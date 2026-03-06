using System.ComponentModel.DataAnnotations;

namespace Votify.Application.DTOs;

public class CrearVotacionDto
{
    public string? Id { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Tipo { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int LimiteProyectos { get; set; }

    public bool PermiteComentarios { get; set; }
}