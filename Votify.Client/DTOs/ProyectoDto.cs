namespace Votify.Client.DTOs
{
    public class ProyectoDto
    {
        public string Id { get; set; } = default!;
        public string? Categoria_Id { get; set; }
        public string Nombre { get; set; } = default!;
        public string Descripcion { get; set; } = default!;
        public string? Equipo_Id { get; set; }
    }
}