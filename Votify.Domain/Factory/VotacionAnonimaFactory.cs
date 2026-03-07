using Votify.Domain.Entities;

namespace Votify.Domain.Factory
{
    public class VotacionAnonimaFactory : VotacionFactory
    {
        public override Votacion Crear( string nombre, DateTime inicio, DateTime fin, int limite, bool permiteComentarios)
        {
            return new VotacionAnonima( nombre, inicio, fin, limite, permiteComentarios);
        }
    }
}
