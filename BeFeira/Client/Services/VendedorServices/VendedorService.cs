using BeFeira.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BeFeira.Client.Services.VendedorServices
{
    public class VendedorService : IVendedorService
    {
        private readonly HttpClient _http;
        public  List<Vendedor> vendedores { get; set; }

		public VendedorService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Vendedor> GetSingleVendedor(int id)
        {
            var result = await _http.GetFromJsonAsync<Vendedor>($"api/vendedor/{id}");
            if (result != null)
            {
                return result;
            }
            throw new Exception("Stand not found");
        }

        public async Task GetVendedores()
        {
            var result = await _http.GetFromJsonAsync<List<Vendedor>>("api/vendedor");
            if (result != null) { vendedores = result; }

        }

        public async Task<int> ValidVendedor(string username, string pass)
        {
            Vendedor vend ;
            if (vendedores.Any(h => h.Username == username && h.Password == pass))
            {
               vend = vendedores.Find(h=> h.Username == username && h.Password == pass);
               return vend.ID;
            }
            return (-1);
        }

        public async Task AddVendedor(Vendedor vendedor)
        {
            var result = await _http.PostAsJsonAsync("api/vendedor", vendedor);
            var response=await result.Content.ReadFromJsonAsync<List<Vendedor>>();
            vendedores=response;
        }

        public async Task UpdateVendedor(Vendedor vendedor)
        {
            var result = await _http.PutAsJsonAsync($"api/vendedor/{vendedor.ID}", vendedor);
            var response = await result.Content.ReadFromJsonAsync<List<Vendedor>>();
            vendedores = response.ToList();
        }
    }
}
