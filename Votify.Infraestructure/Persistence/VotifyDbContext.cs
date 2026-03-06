using Microsoft.EntityFrameworkCore;
using Votify.Domain.Entities;

namespace Votify.Infrastructure.Persistence
{
    public class VotifyDbContext : DbContext
    {
        public VotifyDbContext(DbContextOptions<VotifyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Votacion> Votaciones { get; set; }
        public DbSet<Voto> Votos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}