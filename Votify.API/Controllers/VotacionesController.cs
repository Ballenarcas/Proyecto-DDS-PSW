using Microsoft.AspNetCore.Mvc;
using Votify.API.DTOs;
using Votify.Application.DTOs;
using Votify.Application.Interface;

namespace Votify.API.Controllers
{
    [ApiController]
    [Route("api/votaciones")]
    public class VotacionesController : ControllerBase
    {
        private readonly IVotacionService _service;

        public VotacionesController(IVotacionService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult CrearVotacion([FromBody] CrearVotacionRequest request)
        {
            var dto = new CrearVotacionDto
            {
                Id = request.Id,
                Nombre = request.Nombre,
                Tipo = request.Tipo,
                FechaInicio = request.FechaInicio,
                FechaFin = request.FechaFin,
                LimiteProyectos = request.LimiteProyectos,
                PermiteComentarios = request.PermiteComentarios
            };

            _service.CrearVotacionAsync(dto);

            return Ok(new
            {
                dto.Id,
                dto.Nombre,
                dto.Tipo,
                dto.FechaInicio,
                dto.FechaFin,
                dto.LimiteProyectos,
                dto.PermiteComentarios
            });
        }
    }
}