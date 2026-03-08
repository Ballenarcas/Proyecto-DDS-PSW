using Votify.Application.DTOs;
using Votify.Application.Interface;
using Votify.Domain.Factory;
using Votify.Infrastructure.Repositories;

namespace Votify.Application.Services
{
    public class VotacionService : IVotacionService
    {
        private readonly VotacionRepository _repo;

        public VotacionService(VotacionRepository repo)
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

            // Mapeamos de la base de datos al DTO que verá el cliente
            return entidades.Select(e => new CrearVotacionResponse
            {
                Id = e.Id.ToString(), 
                Nombre = e.Nombre,
                Tipo = e.Tipo,
                FechaInicio = e.FechaInicio,
                FechaFin = e.FechaFin
            }).ToList();
        }
    }
}