using Microsoft.EntityFrameworkCore;
using Votify.Application.Repositories;
using Votify.Domain.Entities;
using Votify.Domain.Factory;
using Votify.Infrastructure.Persistence;
using Votify.Infrastructure.Persistence.Entities;

namespace Votify.Infrastructure.Repositories
{
    public class VotacionRepository : IVotacionRepository
    {
        private readonly VotifyDbContext _db;

        public VotacionRepository(VotifyDbContext db)
        {
            _db = db;
        }

        public async Task GuardarAsync(Votacion votacion)
        {
            var entity = new VotacionEntity
            {
                Id = votacion.Id,
                Nombre = votacion.Nombre,
                FechaInicio = votacion.FechaInicio,
                FechaFin = votacion.FechaFin,
                LimiteProyectos = votacion.LimiteProyectos,
                PermiteComentarios = votacion.PermiteComentarios,
                Tipo = votacion.Tipo()
            };

            _db.Votaciones.Add(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<Votacion?> ObtenerAsync(string id)
        {
            var entity = await _db.Votaciones.FirstOrDefaultAsync(v => v.Id == id);
            if (entity == null) return null;

            // reconstrucción usando Factory Method
            VotacionFactory factory = entity.Tipo switch
            {
                "ESTANDAR" => new VotacionEstandarFactory(),
                "ANONIMA" => new VotacionAnonimaFactory(),
                _ => throw new Exception("Tipo desconocido")
            };

            return factory.Crear(
                entity.Id,
                entity.Nombre,
                entity.FechaInicio,
                entity.FechaFin,
                entity.LimiteProyectos,
                entity.PermiteComentarios
            );
        }
    }
}