namespace Votify.Domain.Entities
{
    public abstract class Votacion
    {
        public string Nombre { get; }
        public DateTime FechaInicio { get; }
        public DateTime FechaFin { get; }
        public int LimiteProyectos { get; }
        public bool PermiteComentarios { get; }

        protected Votacion(string nombre, DateTime inicio, DateTime fin, int limite, bool permiteComentarios)
        {
            Nombre = nombre;
            FechaInicio = inicio;
            FechaFin = fin;
            LimiteProyectos = limite;
            PermiteComentarios = permiteComentarios;
        }

        public abstract string Tipo();
    }
}