using System.Net.Http.Json;
using BeFeira.Shared;

namespace BeFeira.Client.Services.VendaProdServices
{
    public class VendaProdService : IVendaProdService
    {
        private readonly HttpClient _http;

        public VendaProdService(HttpClient http)
        {
            _http = http;
        }

        public List<VendaProduto> Vendas { get; set; }


        public async Task GetVendaProdutos()
        {
            var result = await _http.GetFromJsonAsync<List<VendaProduto>>("api/vendaproduto");
            if (result != null) { Vendas = result; }
        }

        public async Task<VendaProduto> GetSingleVendaProduto(int idvenda)
        {
            var result = await _http.GetFromJsonAsync<VendaProduto>($"api/vendaproduto/{idvenda}");
            if (result != null)
            {
                return result;
            }
            throw new Exception("VendaProduto not found");
        }

        public async Task AddVendaProduto(VendaProduto venda)
        {
            var result = await _http.PostAsJsonAsync("api/vendaproduto", venda);
            var response = await result.Content.ReadFromJsonAsync<List<VendaProduto>>();
            Vendas = response;
        }

    }
}
