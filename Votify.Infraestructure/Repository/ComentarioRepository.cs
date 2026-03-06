using Microsoft.EntityFrameworkCore;
using Votify.Application.Repositories;
using Votify.Infrastructure.Persistence;
using Votify.Infrastructure.Persistence.Entities;

namespace Votify.Infrastructure.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly VotifyDbContext _db;

        public ComentarioRepository(VotifyDbContext db)
        {
            _db = db;
        }

        public async Task GuardarAsync(string proyectoId, string texto)
        {
            _db.Comentarios.Add(new ComentarioEntity
            {
                ProyectoId = proyectoId,
                Texto = texto
            });

            await _db.SaveChangesAsync();
        }

        public async Task<List<string>> ObtenerAsync(string proyectoId)
        {
            return await _db.Comentarios
                .Where(c => c.ProyectoId == proyectoId)
                .Select(c => c.Texto)
                .ToListAsync();
        }
    }
}