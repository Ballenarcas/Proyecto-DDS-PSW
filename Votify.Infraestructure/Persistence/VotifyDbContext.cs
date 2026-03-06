using Microsoft.EntityFrameworkCore;
using Votify.Infrastructure.Persistence.Entities;

namespace Votify.Infrastructure.Persistence
{
    public class VotifyDbContext : DbContext
    {
        public VotifyDbContext(DbContextOptions<VotifyDbContext> options)
            : base(options) { }

        public DbSet<VotacionEntity> Votaciones => Set<VotacionEntity>();
        public DbSet<VotoEntity> Votos => Set<VotoEntity>();
        public DbSet<ComentarioEntity> Comentarios => Set<ComentarioEntity>();
    }
}