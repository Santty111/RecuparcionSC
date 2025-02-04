using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RecuperacionSC.Models;

namespace RecuperacionSC.Services
{
    public class PersonajeServiceSC
    {
        private readonly HttpClient _httpClient;

        public PersonajeServiceSC()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<PersonajesSC>> ObtenerPersonajesAsync()
        {
            string url = "https://dragonball-api.com/api/characters";
            var response = await _httpClient.GetStringAsync(url);

            // Deserializa la respuesta JSON a una lista de objetos PersonajesSC
            return JsonConvert.DeserializeObject<List<PersonajesSC>>(response);
        }
    }
}
