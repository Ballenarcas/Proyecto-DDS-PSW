using Votify.Application.DTOs;

namespace Votify.Application.Interfaces
{
    public interface IVotacionService
    {
        Task CrearVotacionAsync(CrearVotacionDto dto);
        Task<List<CrearVotacionResponse>> ObtenerTodasAsync();
    }
}
