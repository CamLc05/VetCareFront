namespace Veterinaria.Models;

public class Paciente
{
    public string Nombre { get; set; }
    public Especies Especie { get; set; }
    public string Raza { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Sexo { get; set; }
    public Propietario Propietario { get; set; }
    public string Padecimientos { get; set; }
    public List<Citas> Citas { get; set; } = new();
    public List<Intervencion> Intervenciones { get; set; } = new();
    public string Imagen { get; set; }
}