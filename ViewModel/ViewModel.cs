using System.Collections.ObjectModel;
using System.Threading.Tasks;
using RecuperacionSC.Models;
using RecuperacionSC.Services;
using Microsoft.Maui.Controls;

namespace RecuperacionSC.ViewModel
{
    public class CharacterViewModel : BindableObject
    {
        private readonly PersonajeServiceSC _personajeService;
        public ObservableCollection<PersonajesSC> Characters { get; set; } = new();

        private string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                _searchText = value;
                OnPropertyChanged();
                BuscarPersonajes();
            }
        }

        public CharacterViewModel()
        {
            _personajeService = new PersonajeServiceSC();
            CargarPersonajes();
        }

        private async void CargarPersonajes()
        {
            var personajes = await _personajeService.ObtenerPersonajesAsync();
            Characters.Clear();
            foreach (var personaje in personajes)
            {
                Characters.Add(personaje);
            }
        }

        private void BuscarPersonajes()
        {
            if (string.IsNullOrWhiteSpace(SearchText))
            {
                CargarPersonajes();
                return;
            }

            var filtered = Characters.Where(p => p.Name.ToLower().Contains(SearchText.ToLower())).ToList();
            Characters.Clear();
            foreach (var personaje in filtered)
            {
                Characters.Add(personaje);
            }
        }
    }
}
