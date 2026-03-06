namespace Votify.Domain.Entities
{
    public class VotoEstandar : Voto
    {
        public VotoEstandar(string proyectoId, int valor, string votanteId)
            : base(proyectoId, valor, votanteId) { }

        public override string Tipo() => "ESTANDAR";
    }
}