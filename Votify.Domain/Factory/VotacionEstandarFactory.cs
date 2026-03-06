using Votify.Domain.Entities;

namespace Votify.Domain.Factory
{
    public class VotacionEstandarFactory : VotacionFactory
    {
        public override Votacion Crear(string id, string nombre, DateTime inicio, DateTime fin, int limite, bool permiteComentarios)
        {
            return new VotacionEstandar(id, nombre, inicio, fin, limite, permiteComentarios);
        }
    }
}
