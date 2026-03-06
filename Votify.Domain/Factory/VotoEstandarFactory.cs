using Votify.Domain.Entities;

namespace Votify.Domain.Factory
{
    public class VotoEstandarFactory : VotoFactory
    {
        public override Voto Crear(string proyectoId, int valor, string? votanteId = null)
        {
            return new VotoEstandar(proyectoId, valor, votanteId!);
        }
    }
}