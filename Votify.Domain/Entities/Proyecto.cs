using System;

public class Proyecto
{
	public string Id { get; set; }
	public string Categoria_Id { get; set; }
	public string Nombre { get; set; }
	public string Descripcion { get; set; }
	public string Equipo_Id { get; set; }

    protected Proyecto(string id, string nombre, string descripcion, string equipo)
	{
		Id = id;
		Nombre = nombre;
		Descripcion = descripcion;
		Equipo_Id = equipo;
    }
}
