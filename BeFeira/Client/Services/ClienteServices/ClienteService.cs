using BeFeira.Shared;
using System.Net.Http.Json;

namespace BeFeira.Client.Services.ClienteServices
{
    public class ClienteService : IClienteService
    {
        private readonly HttpClient _http;
        public  List<Cliente> clientes { get ; set ; }

        public ClienteService(HttpClient http)
        {
            _http = http;
        }

        public async  Task GetClientes()
        {
            
                var result = await _http.GetFromJsonAsync<List<Cliente>>("api/cliente");
                if (result != null) { clientes = result; }

        }

        public async Task<Cliente> GetSingleCliente(int id)
        {
            var result = await _http.GetFromJsonAsync<Cliente>($"api/cliente/{id}");
            if (result != null) {
                return result;
            }
            else throw new Exception("NonExistantClient");
        }

        public async Task<bool> ValidClient(string username, string pass)
        {
            if(clientes.Any(h=> h.Username==username && h.Password==pass)) {
                return true;
            }
            return false;
        }
    }
}
