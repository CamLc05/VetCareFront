namespace Veterinaria.Models;

public class Propietario
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }

    public override string ToString() => Nombre;
}