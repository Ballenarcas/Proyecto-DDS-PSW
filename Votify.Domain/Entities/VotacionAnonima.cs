namespace Votify.Domain.Entities
{
    public class VotacionAnonima : Votacion
    {
        public VotacionAnonima(string id, string nombre, DateTime inicio, DateTime fin, int limite, bool permiteComentarios)
            : base(id, nombre, inicio, fin, limite, permiteComentarios) { }

        public override string Tipo() => "ANONIMA";
    }
}