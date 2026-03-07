namespace Votify.Infrastructure.Persistence.Entities
{
    public class VotacionEntity
    {
        public string Id { get; set; } = default!;
        public string Nombre { get; set; } = default!;
        public string Tipo { get; set; } = default!;
        public string Categoria { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int LimiteProyectos { get; set; }
        public bool PermiteComentarios { get; set; }
    }
}