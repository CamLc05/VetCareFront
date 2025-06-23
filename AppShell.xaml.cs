using Veterinaria.Views;

namespace Veterinaria
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("pacienteForm", typeof(PacienteFormPage)); 


        }
    }
}
