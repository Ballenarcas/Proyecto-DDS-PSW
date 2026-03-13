namespace Votify.Domain.Interfaces
{
    public interface IProyectoRepository
    {
        Task GuardarAsync(Proyecto proyecto);

        Task<List<Proyecto>> ObtenerTodasAsync();
        Task<Proyecto?> ObtenerAsync(String proyectoId);
    }
}