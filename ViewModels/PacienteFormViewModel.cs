using System.Collections.ObjectModel;
using System.Windows.Input;
using Veterinaria.Models;
using Veterinaria.Services;
using Microsoft.Maui.Controls;

namespace Veterinaria.ViewModels;

public class PacienteFormViewModel : BindableObject
{
    public bool SoloLectura { get; set; } = false;

    private Paciente _paciente;
    public Paciente Paciente
    {
        get => _paciente;
        set
        {
            _paciente = value;
            OnPropertyChanged(nameof(Paciente));
            OnPropertyChanged(nameof(Titulo));
        }
    }

    public string Titulo => Paciente?.Nombre ?? "Nuevo paciente";

    public ObservableCollection<string> Especies { get; set; } =
        new ObservableCollection<string> { "Perro", "Gato", "Hamster", "Ave" };

    public ObservableCollection<Propietario> Propietarios { get; set; }

    public ICommand GuardarCommand { get; }
    public ICommand AgregarPropietarioCommand { get; }

    public PacienteFormViewModel()
    {
        Propietarios = new ObservableCollection<Propietario>(FakeDatabase.ObtenerPropietarios());

        GuardarCommand = new Command(() =>
        {
            Application.Current.MainPage.DisplayAlert("Guardado", "Paciente actualizado", "OK");
        });
        
        AgregarPropietarioCommand = new Command(async () =>
        {
            // Simulación de formulario
            string nombre = await Application.Current.MainPage.DisplayPromptAsync("Nuevo propietario", "Nombre del propietario:");
            if (!string.IsNullOrEmpty(nombre))
            {
                var nuevo = new Propietario { Nombre = nombre };
                Propietarios.Add(nuevo);
                Paciente.Propietario = nuevo;
            }
        });
    }
}