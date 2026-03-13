namespace Votify.Domain.Entities
{
    public class VotoEstandar : Voto
    {
        public VotoEstandar(string proyectoId, string votanteId)
            : base(proyectoId, votanteId) { }

        public override string Tipo() => "ESTANDAR";
    }
}