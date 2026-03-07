using Votify.Application.DTOs;

namespace Votify.Application.Interface
{
    public interface IVotacionService
    {
        void CrearVotacion(CrearVotacionDto dto);
    }
}