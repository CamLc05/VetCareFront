namespace Veterinaria.Models;

public class Usario
{
    public int Id { get; set; }
    public string Nombre_usuario { get; set; }
    public string Contrasena { get; set; }
    public RolUsuario Rol { get; set; }
    public DateTime Fecha_creacion { get; set; }

}