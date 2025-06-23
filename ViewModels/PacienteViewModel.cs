using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Veterinaria.Models;
using Veterinaria.Services;


namespace Veterinaria.ViewModels;

public class PacienteViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Paciente> Pacientes { get; set; }

    public PacienteViewModel()
    {
        var lista = FakeDatabase.ObtenerPacientes();
        Pacientes = new ObservableCollection<Paciente>(lista);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propiedad = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propiedad));
    }
}