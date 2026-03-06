using Votify.Domain.Entities;

namespace Votify.Domain.Factory
{
    public class VotacionAnonimaFactory : VotacionFactory
    {
        public override Votacion Crear(string id, string nombre, DateTime inicio, DateTime fin, int limite, bool permiteComentarios)
        {
            return new VotacionAnonima(id, nombre, inicio, fin, limite, permiteComentarios);
        }
    }
}
