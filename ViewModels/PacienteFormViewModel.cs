namespace Veterinaria.ViewModels;

    public class PatientFormViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Owner> Propietarios { get; set; }
        public ObservableCollection<Appointment> Citas { get; set; }
        public ObservableCollection<Intervention> Intervenciones { get; set; }

        private Patient _paciente;
        public Patient Paciente
        {
            get => _paciente;
            set { _paciente = value; OnPropertyChanged(nameof(Paciente)); }
        }

        private string _filtroPropietario;
        public string FiltroPropietario
        {
            get => _filtroPropietario;
            set
            {
                _filtroPropietario = value;
                FiltrarPropietarios();
                OnPropertyChanged(nameof(FiltroPropietario));
            }
        }

        public PatientFormViewModel()
        {
            // Simulación de carga desde base de datos
            Propietarios = new ObservableCollection<Owner>(BaseDatos.ObtenerPropietarios());
            Citas = new ObservableCollection<Appointment>();
            Intervenciones = new ObservableCollection<Intervention>();
            Paciente = new Patient(); // nuevo o cargado
        }

        private void FiltrarPropietarios()
        {
            var lista = BaseDatos.ObtenerPropietarios()
                .Where(p => p.Nombre.Contains(FiltroPropietario, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Propietarios.Clear();
            foreach (var p in lista)
                Propietarios.Add(p);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string prop)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }

