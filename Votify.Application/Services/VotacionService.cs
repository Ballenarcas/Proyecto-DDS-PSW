using Votify.Application.DTOs;
using Votify.Application.Interfaces;
using Votify.Domain.Factory;
using Votify.Domain.Interfaces;

namespace Votify.Application.Services
{
    public class VotacionService : IVotacionService
    {
        private readonly IVotacionRepository _repo;

        public VotacionService(IVotacionRepository repo)
        {
            _repo = repo;
        }

        public async Task CrearVotacionAsync(CrearVotacionDto dto)
        {
            VotacionFactory factory = dto.Tipo.ToUpper() switch
            {
                "ESTANDAR" => new VotacionEstandarFactory(),
                "ANONIMA" => new VotacionAnonimaFactory(),
                _ => throw new ArgumentException("Tipo de votación no válido.")
            };

            var votacion = factory.Crear(
                dto.Nombre,
                dto.FechaInicio,
                dto.FechaFin,
                dto.LimiteProyectos,
                dto.PermiteComentarios
            );
            
            await _repo.GuardarAsync(votacion);
        }
        public async Task<List<CrearVotacionResponse>> ObtenerTodasAsync()
        {
            var entidades = await _repo.ObtenerTodasAsync();

            return entidades.Select(e => new CrearVotacionResponse
            {
                Id = e.Id.ToString(), 
                Nombre = e.Nombre,
                Tipo = e.Tipo(),
                FechaInicio = e.FechaInicio,
                FechaFin = e.FechaFin,
                LimiteProyectos = e.LimiteProyectos,
                PermiteComentarios = e.PermiteComentarios
            }).ToList();
        }
    }
}
