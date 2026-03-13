using Votify.Client.DTOs;
using System.Net.Http.Json;

namespace Votify.Client.Services
{
    public class ProyectosService
    {
        private readonly HttpClient _httpClient;

        public ProyectosService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProyectoDto>> ObtenerProyectosAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ProyectoDto>>("api/proyectos");
            return response ?? new List<ProyectoDto>();
        }
    }
}