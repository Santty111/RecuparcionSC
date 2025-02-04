using RecuperacionSC.Models;
using Microsoft.Maui.Controls;

namespace RecuperacionSC.Views
{
    public partial class DetallePersonajePage : ContentPage
    {
        public DetallePersonajePage(PersonajesSC personaje)
        {
            InitializeComponent();
            BindingContext = personaje;
        }
    }
}
