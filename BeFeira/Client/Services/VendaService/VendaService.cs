using BeFeira.Shared;
using System.Net.Http.Json;

namespace BeFeira.Client.Services.VendaService
{
    public class VendaService : IVendaService
    {

        private readonly HttpClient _http;
        public List<Venda> vendas { get; set; }

        public VendaService(HttpClient http)
        {
            _http = http;
        }

        public async Task AddVenda(Venda venda)
        {
            var result = await _http.PostAsJsonAsync("api/venda", venda);
            var response = await result.Content.ReadFromJsonAsync<List<Venda>>();
            vendas = response;
        }

        public async Task<Venda> GetSingleVenda(int idvenda)
        {
            var result = await _http.GetFromJsonAsync<Venda>($"api/venda/{idvenda}");
            if (result != null)
            {
                return result;
            }
            throw new Exception("Venda not found");
        }

       public async  Task GetVendas()
        {
            var result = await _http.GetFromJsonAsync<List<Venda>>("api/venda");
            if (result != null) { vendas = result; }
        }
    }
}
