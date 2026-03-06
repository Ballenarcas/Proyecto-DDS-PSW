namespace Votify.Application.DTOs;

public class VotacionDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public int CategoriaId { get; set; }
}
