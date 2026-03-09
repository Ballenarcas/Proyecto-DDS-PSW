namespace Votify.Domain.Entities
{
    public abstract class Votacion
    {
        public Guid Id { get; set; }
        public string Nombre { get; }
        public DateTime FechaInicio { get; }
        public DateTime FechaFin { get; }
        public int LimiteProyectos { get; }
        public bool PermiteComentarios { get; }

        protected Votacion(string nombre, DateTime inicio, DateTime fin, int limite, bool permiteComentarios)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            FechaInicio = inicio;
            FechaFin = fin;
            LimiteProyectos = limite;
            PermiteComentarios = permiteComentarios;
        }

        public abstract string Tipo();
    }
}
