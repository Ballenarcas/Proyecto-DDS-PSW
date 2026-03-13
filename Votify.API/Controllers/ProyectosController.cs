using Microsoft.AspNetCore.Mvc;
using Votify.API.DTOs;
using Votify.Application.DTOs;
using Votify.Application.Interfaces;

namespace Votify.API.Controllers
{
    [ApiController]
    [Route("api/proyectos")]
    public class ProyectosController : ControllerBase
    {
        private readonly IProyectoService _proyectoService;

        public ProyectosController(IProyectoService proyectoService)
        {
            _proyectoService = proyectoService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> CrearProyecto([FromBody] ProyectoDto dto)
        {
            var id = await _proyectoService.CrearProyectoAsync(dto);
            return Ok(id);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProyectoDto>> ObtenerProyecto(string id)
        {
            var proyecto = await _proyectoService.ObtenerProyectoAsync(id);
            if (proyecto == null)
            {
                return NotFound();
            }
            return Ok(new ProyectoDto
            {
                Id = proyecto.Id,
                Categoria_Id = proyecto.Categoria_Id,
                Nombre = proyecto.Nombre,
                Descripcion = proyecto.Descripcion,
                Equipo_Id = proyecto.Equipo_Id
            });
        }
        [HttpGet]
        public async Task<ActionResult<List<ProyectoDto>>> ObtenerProyectos()
        {
            var proyectos = await _proyectoService.ObtenerProyectosAsync();
            return Ok(proyectos);
        }
    }
}