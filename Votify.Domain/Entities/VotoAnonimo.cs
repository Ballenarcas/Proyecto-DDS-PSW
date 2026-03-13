namespace Votify.Domain.Entities
{
    public class VotoAnonimo : Voto
    {
        public VotoAnonimo(string proyectoId)
            : base(proyectoId, null) { }

        public override string Tipo() => "ANONIMO";
    }
}