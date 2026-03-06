using Votify.Domain.Entities;

namespace Votify.Application.Repositories
{
    public interface IVotoRepository
    {
        Task GuardarAsync(Voto voto);
        Task<List<Voto>> ObtenerPorProyectoAsync(string proyectoId);
    }
}