using Votify.Domain.Entities;

namespace Votify.Domain.Interfaces
{
    public interface IVotoRepository
    {
        Task GuardarAsync(Voto voto);
        Task<List<Voto>> ObtenerPorProyectoAsync(string proyectoId);
    }
}
