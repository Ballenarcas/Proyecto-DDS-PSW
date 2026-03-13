namespace Votify.Domain.Entities
{
    public abstract class Voto
    {
        public string ProyectoId { get; }
        public string? VotanteId { get; }

        protected Voto(string proyectoId, string? votanteId)
        {
            ProyectoId = proyectoId;
            VotanteId = votanteId;
        }

        public abstract string Tipo();
    }
}