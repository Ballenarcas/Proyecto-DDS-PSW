using System.Net.Http.Json;
using Votify.Application.DTOs;

namespace Votify.Client.Services
{
    public class VotacionesService
    {
        private readonly HttpClient _httpClient;

        public VotacionesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CrearVotacion(CrearVotacionDto dto)
        {
            try
            {
                // var response = await _httpClient.PostAsJsonAsync("api/votaciones", dto);
                // response.EnsureSuccessStatusCode();
                Console.WriteLine("Votación creada (temporalmente sin API)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task<List<VotacionDto>> ObtenerVotaciones()
        {
            try
            {
                // var response = await _httpClient.GetAsync("api/votaciones");
                // return await response.Content.ReadAsAsync<List<VotacionDto>>();
                return new List<VotacionDto>();  // Retorna una lista vacía temporalmente
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<VotacionDto>();
            }
        }
    }
}