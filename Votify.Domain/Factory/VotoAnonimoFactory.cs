using Votify.Domain.Entities;

namespace Votify.Domain.Factory
{
    public class VotoAnonimoFactory : VotoFactory
    {
        public override Voto Crear(string proyectoId, string? votanteId = null)
        {
            return new VotoAnonimo(proyectoId);
        }
    }
}