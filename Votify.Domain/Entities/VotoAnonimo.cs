namespace Votify.Domain.Entities
{
    public class VotoAnonimo : Voto
    {
        public VotoAnonimo(string proyectoId, int valor)
            : base(proyectoId, valor, null) { }

        public override string Tipo() => "ANONIMO";
    }
}