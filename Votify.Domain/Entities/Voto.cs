namespace Votify.Domain.Entities
{
    public abstract class Voto
    {
        public string ProyectoId { get; }
        public string? VotanteId { get; }
        public int Valor { get; }

        protected Voto(string proyectoId, int valor, string? votanteId)
        {
            ProyectoId = proyectoId;
            Valor = valor;
            VotanteId = votanteId;
        }

        public abstract string Tipo();
    }
}