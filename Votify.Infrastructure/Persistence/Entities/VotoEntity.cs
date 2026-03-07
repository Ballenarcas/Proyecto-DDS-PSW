namespace Votify.Infrastructure.Persistence.Entities
{
    public class VotoEntity
    {
        public int Id { get; set; }
        public string ProyectoId { get; set; } = default!;
        public int Valor { get; set; }
        public string? VotanteId { get; set; }
        public string Tipo { get; set; } = default!; // ESTANDAR | ANONIMO
    }
}