namespace Votify.Domain.Interfaces
{
    public interface IComentarioRepository
    {
        Task GuardarAsync(string proyectoId, string texto);
        Task<List<string>> ObtenerAsync(string proyectoId);
    }
}
