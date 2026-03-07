using Microsoft.EntityFrameworkCore;
using Votify.Infrastructure.Persistence.Entities;

namespace Votify.Infrastructure.Persistence
{
    public class VotifyDbContext : DbContext
    {
        public VotifyDbContext(DbContextOptions<VotifyDbContext> options)
        : base(options)
        {
        }


        public DbSet<VotacionEntity> Votaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VotacionEntity>(entity =>
            {
                entity.ToTable("Votaciones");

                entity.HasKey(v => v.Id);

                entity.Property(v => v.Nombre).IsRequired();
                entity.Property(v => v.Tipo).IsRequired();
                entity.Property(v => v.FechaInicio)
                        .HasColumnType("timestamp without time zone");
                entity.Property(v => v.FechaFin)
                        .HasColumnType("timestamp without time zone");
                entity.Property(v => v.LimiteProyectos).IsRequired();
                entity.Property(v => v.PermiteComentarios).IsRequired();
            });
        }
    }
}