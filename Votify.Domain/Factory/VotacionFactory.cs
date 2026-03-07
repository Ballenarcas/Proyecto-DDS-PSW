using Votify.Domain.Entities;

namespace Votify.Domain.Factory
{
    public abstract class VotacionFactory
    {
        public abstract Votacion Crear(
            string nombre,
            DateTime inicio,
            DateTime fin,
            int limiteProyectos,
            bool permiteComentarios
        );
    }
}
