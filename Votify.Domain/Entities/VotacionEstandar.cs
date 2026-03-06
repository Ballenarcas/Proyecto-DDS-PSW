namespace Votify.Domain.Entities
{
    public class VotacionEstandar : Votacion
    {
        public VotacionEstandar(string id, string nombre, DateTime inicio, DateTime fin, int limite, bool permiteComentarios)
            : base(id, nombre, inicio, fin, limite, permiteComentarios) { }

        public override string Tipo() => "ESTANDAR";
    }
}