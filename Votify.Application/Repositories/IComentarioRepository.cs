namespace Votify.Application.Repositories
{
    public interface IComentarioRepository
    {
        Task GuardarAsync(string proyectoId, string texto);
        Task<List<string>> ObtenerAsync(string proyectoId);
    }
}