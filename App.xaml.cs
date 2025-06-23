namespace Veterinaria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var loginPage = new LoginPage(); // o LoginPage, según tu flujo
            var navPage = new NavigationPage(loginPage);
            return new Window(navPage);
        }
    }
}

