using Votify.Domain.Entities;
using Votify.Infrastructure.Persistence;
using Votify.Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Votify.Infrastructure.Repositories
{
    public class VotacionRepository
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
                Tipo = votacion.Tipo(),
                FechaInicio = votacion.FechaInicio,
                FechaFin = votacion.FechaFin,
                LimiteProyectos = votacion.LimiteProyectos,
                PermiteComentarios = votacion.PermiteComentarios
            };

            _db.Votaciones.Add(entity);
            await _db.SaveChangesAsync();
        }
    }
}