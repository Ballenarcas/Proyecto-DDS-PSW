using System.ComponentModel.DataAnnotations;

namespace Votify.Application.DTOs;

public class CrearVotacionDto
{
    
    public required string Nombre { get; set; }

    public required string Tipo { get; set; }

    public required DateTime FechaInicio { get; set; }

    public required DateTime FechaFin { get; set; }

    public required int LimiteProyectos { get; set; }

    public bool PermiteComentarios { get; set; }
}