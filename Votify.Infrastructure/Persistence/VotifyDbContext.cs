using Microsoft.EntityFrameworkCore;
using Votify.Infrastructure.Persistence.Entities;

namespace Votify.Infrastructure.Persistence
{

public class VotifyDbContext : DbContext
{
    public VotifyDbContext(DbContextOptions<VotifyDbContext> options) : base(options) { }

    public DbSet<VotacionEntity> Votaciones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VotacionEntity>(entity =>
        {
            entity.ToTable("votacion"); // tabla exacta en Supabase

            entity.Property(e => e.Id).HasColumnName("id").ValueGeneratedOnAdd();
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaFin).HasColumnName("fecha_fin");
            entity.Property(e => e.LimiteProyectos).HasColumnName("limite_proy");
            entity.Property(e => e.PermiteComentarios).HasColumnName("comentarios");
        });
    }
}
}