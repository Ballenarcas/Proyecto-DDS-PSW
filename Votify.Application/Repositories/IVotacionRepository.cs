using Votify.Domain.Entities;

namespace Votify.Application.Repositories
{
    public interface IVotacionRepository
    {
        Task GuardarAsync(Votacion votacion);
        Task<Votacion?> ObtenerAsync(string id);
    }
}