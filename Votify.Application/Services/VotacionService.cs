using Votify.Application.DTOs;
using Votify.Application.Interface;
using Votify.Domain.Factory;

namespace Votify.Application.Services
{
    public class VotacionService : IVotacionService
    {

        public void CrearVotacion(CrearVotacionDto dto)
        {
            VotacionFactory factory = dto.Tipo.ToUpper() switch
            {
                "ESTANDAR" => new VotacionEstandarFactory(),
                "ANONIMA" => new VotacionAnonimaFactory(),
                _ => throw new ArgumentException("Tipo de votación no válido.")
            };

            var votacion = factory.Crear(
                dto.Id,
                dto.Nombre,
                dto.FechaInicio,
                dto.FechaFin,
                dto.LimiteProyectos,
                dto.PermiteComentarios
            );
            _ = votacion;
        }
    }
}