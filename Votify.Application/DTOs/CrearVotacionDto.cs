namespace Votify.Application.DTOs;

public class CrearVotacionDto
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public int CategoriaId { get; set; }
}