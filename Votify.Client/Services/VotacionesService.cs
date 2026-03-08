using System.Net.Http.Json;
using Votify.Client.DTOs;

namespace Votify.Client.Services
{
    public class VotacionesService
    {
        private readonly HttpClient _http;

        public VotacionesService(HttpClient http)
        {
            _http = http;
        }

        public async Task CrearVotacion(CrearVotacionRequest request)
        {
            var response = await _http.PostAsJsonAsync("api/votaciones", request);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al crear la votación: {error}");
            }
        }
        public async Task<List<CrearVotacionResponse>> ObtenerVotaciones()
        {
            return await _http.GetFromJsonAsync<List<CrearVotacionResponse>>("api/votaciones") 
                ?? new List<CrearVotacionResponse>();
        }
    }
}