namespace Votify.Domain.Entities
{
    public class VotacionEstandar : Votacion
    {
        public VotacionEstandar( string nombre, DateTime inicio, DateTime fin, int limite, bool permiteComentarios)
            : base(nombre, inicio, fin, limite, permiteComentarios) { }

        public override string Tipo() => "ESTANDAR";
    }
}