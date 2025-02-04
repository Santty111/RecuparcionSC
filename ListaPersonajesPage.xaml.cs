using RecuperacionSC.ViewModel;
using RecuperacionSC.Models; // Asegúrate de tener el modelo adecuado
using Microsoft.Maui.Controls;

namespace RecuperacionSC.Views
{
    public partial class ListaPersonajesPage : ContentPage
    {
        public ListaPersonajesPage()
        {
            InitializeComponent();
            BindingContext = new CharacterViewModel();
        }

        // Método para manejar la selección de un personaje en la lista
        private async void OnCharacterSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                var selectedCharacter = e.CurrentSelection[0] as PersonajesSC; 

                // Navegar a la página de detalle del personaje
                if (selectedCharacter != null)
                {
                    await Navigation.PushAsync(new DetallePersonajePage(selectedCharacter));
                }

                // Deseleccionar el ítem después de la navegación
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}
