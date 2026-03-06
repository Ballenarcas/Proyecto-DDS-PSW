using Microsoft.EntityFrameworkCore;
using Votify.Application.Repositories;
using Votify.Domain.Entities;
using Votify.Domain.Factory;
using Votify.Infrastructure.Persistence;
using Votify.Infrastructure.Persistence.Entities;

namespace Votify.Infrastructure.Repositories
{
    public class VotoRepository : IVotoRepository
    {
        private readonly VotifyDbContext _db;

        public VotoRepository(VotifyDbContext db)
        {
            _db = db;
        }

        public async Task GuardarAsync(Voto voto)
        {
            var entity = new VotoEntity
            {
                ProyectoId = voto.ProyectoId,
                Valor = voto.Valor,
                VotanteId = voto.VotanteId,
                Tipo = voto.Tipo()
            };

            _db.Votos.Add(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Voto>> ObtenerPorProyectoAsync(string proyectoId)
        {
            var entities = await _db.Votos
                .Where(v => v.ProyectoId == proyectoId)
                .ToListAsync();

            return entities.Select(e =>
            {
                VotoFactory factory = e.Tipo switch
                {
                    "ESTANDAR" => new VotoEstandarFactory(),
                    "ANONIMO" => new VotoAnonimoFactory(),
                    _ => throw new Exception("Tipo desconocido")
                };

                return factory.Crear(e.ProyectoId, e.Valor, e.VotanteId);
            }).ToList();
        }
    }
}