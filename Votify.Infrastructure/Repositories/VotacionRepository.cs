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
                Nombre = votacion.Nombre,
                Tipo = votacion.Tipo(),
                FechaInicio = votacion.FechaInicio.ToUniversalTime(),
                FechaFin = votacion.FechaFin.ToUniversalTime(),
                LimiteProyectos = votacion.LimiteProyectos,
                PermiteComentarios = votacion.PermiteComentarios
            };
            Console.WriteLine("Añadiendo votacion...");

            await _db.Votaciones.AddAsync(entity);
            Console.WriteLine("Guardando en DB...");
            await _db.SaveChangesAsync();
            Console.WriteLine("Guardado!");
        }   
        public async Task<List<VotacionEntity>> ObtenerTodasAsync()
        {
            return await _db.Votaciones.ToListAsync();
        }
    }
}