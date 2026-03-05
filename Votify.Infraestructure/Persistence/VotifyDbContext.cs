using Microsoft.EntityFrameworkCore;

namespace Votify.Infrastructure.Persistence
{
    public class VotifyDbContext : DbContext
    {
        public VotifyDbContext(DbContextOptions<VotifyDbContext> options)
            : base(options)
        {
        }

        // DbContext vacío por ahora
        // Añadirás DbSet<> cuando el PO te diga qué entidades crear
    }
}