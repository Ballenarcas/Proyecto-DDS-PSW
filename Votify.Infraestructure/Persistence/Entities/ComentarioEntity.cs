namespace Votify.Infrastructure.Persistence.Entities
{
    public class ComentarioEntity
    {
        public int Id { get; set; }
        public string ProyectoId { get; set; } = default!;
        public string Texto { get; set; } = default!;
    }
}