using Votify.Domain.Entities;

namespace Votify.Domain.Interfaces
{
    public interface IVotacionRepository
    {
        Task GuardarAsync(Votacion votacion);
        Task<Votacion?> ObtenerAsync(string id);
        Task<List<Votacion>> ObtenerTodasAsync();
    }   
}
