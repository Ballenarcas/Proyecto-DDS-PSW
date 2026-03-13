using System;

public class Proyecto
{
	public string Id { get; set; }
	public string? Categoria_Id { get; set; }
	public string Nombre { get; set; }
	public string Descripcion { get; set; }
	public string? Equipo_Id { get; set; }

    public Proyecto(string? categoriaId, string nombre, string descripcion, string? equipo, string? id = null)
	{
		Id = id ?? string.Empty;
        Categoria_Id = categoriaId;
		Nombre = nombre;
		Descripcion = descripcion;
		Equipo_Id = equipo;
    }
}
