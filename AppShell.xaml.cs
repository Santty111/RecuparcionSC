using RecuperacionSC.Views;

namespace RecuperacionSC
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrar las rutas para la navegación
            Routing.RegisterRoute("detallePersonaje", typeof(DetallePersonajePage)); 
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
