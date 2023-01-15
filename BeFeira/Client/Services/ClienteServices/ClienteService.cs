using BeFeira.Shared;
using System.ComponentModel;
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

        public async Task<int> getmyid()
        {
            return clientes.Count+1;
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

        public async Task<int> ValidClient(string username, string pass)
        {
            Cliente c;
            if(clientes.Any(h=> h.Username==username && h.Password==pass)) 
            {
                c = clientes.Find(h => h.Username == username && h.Password == pass);
                return c.ID;
            }
            return -1;
        }


        public async Task AddCliente(Cliente client)
        {
            var result = await _http.PostAsJsonAsync("api/cliente", client);
            var response = await result.Content.ReadFromJsonAsync<List<Cliente>>();
            clientes = response;
        }


        public async Task UpdateCliente(Cliente cli)
        {

            var result = await _http.PutAsJsonAsync($"api/cliente/{cli.ID}", cli);
            var response = await result.Content.ReadFromJsonAsync<List<Cliente>>();
            clientes = response.ToList();
        }
    }
}
