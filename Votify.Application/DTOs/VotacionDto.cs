namespace Votify.Application.DTOs;

public class VotacionDto
{
    public string? Id { get; set; }
    public string? Nombre { get; set; }
    public string? Tipo { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int LimiteProyectos { get; set; }

    public bool PermiteComentarios { get; set; }
}