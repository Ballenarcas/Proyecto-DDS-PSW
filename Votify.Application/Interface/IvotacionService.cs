using Votify.Application.DTOs;

namespace Votify.Application.Interface
{
    public interface IVotacionService
    {
        Task CrearVotacionAsync(CrearVotacionDto dto);
    }
}