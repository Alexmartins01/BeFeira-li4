using BeFeira.Client.Pages;
using BeFeira.Client.Services.CarrinhoServices;
using BeFeira.Shared;
using System.Net.Http.Json;

namespace BeFeira.Client.Services.NovaPasta
{
    public class CarrinhoService :ICarrinhoService
    {
        private readonly HttpClient _http;
        public List<Carrinho> carrinhos { get; set; }

        public CarrinhoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Carrinho> getCarrinhobyIdCliente(int id)
        {
            var result = await _http.GetFromJsonAsync<Carrinho>($"api/carrinho/{id}");
            if (result != null)
            {
                return result;
            }
            throw new Exception("Carrinho not found");
        }

        public async Task getCarrinhos()
        {
            var result = await _http.GetFromJsonAsync<List<Carrinho>>("api/carrinho");
            if (result != null)
            {
                carrinhos = result;
            }

        }

        public async Task AddCarrinho(Carrinho carrinho)
        {
            var result = await _http.PostAsJsonAsync("api/carrinho", carrinho);
            var response = await result.Content.ReadFromJsonAsync<List<Carrinho>>();
            carrinhos = response.ToList();
        }

        public async Task UpdateCarrinho(Carrinho carrinho)
        {
            var result = await _http.PutAsJsonAsync($"api/carrinho/{carrinho.ID}", carrinho);
            var response = await result.Content.ReadFromJsonAsync<List<Carrinho>>();
            carrinhos = response.ToList();
        }
        public async Task<int> ExistsCarrinho(int iduser)
        {
            await  getCarrinhos();
            if (carrinhos.Any(h=>h.ClienteID==iduser))
            {
                Carrinho a =  carrinhos.Find(p => p.ClienteID == iduser);
                return a.ID;
            }
            return -1;
        }

        public async Task<Carrinho> GetsingleCarrinho(int idcarrinho)
        {
            if (carrinhos.Any(h => h.ID == idcarrinho))
            {
                Carrinho a = carrinhos.Find(p => p.ID == idcarrinho);
                return a;
            }
            throw new Exception("Non-ExistantKart");
        }
    }
}
