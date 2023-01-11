using BeFeira.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BeFeira.Client.Services.SubcategoriaServices
{
    public class SubCatService : ISubcatserv
    {
        private readonly HttpClient _http;
        private readonly NavigationManager navigationManager;

        public List<Subcategoria> subcats { get; set; } = new List<Subcategoria>();
        public SubCatService(HttpClient http,NavigationManager nac) {
            _http = http;
            navigationManager = nac;
        }




        List<Subcategoria> ISubcatserv.Subcats { get; set; }

       public  async Task GetSubcats()
        {
            var result = await _http.GetFromJsonAsync<List<Subcategoria>>("api/subcategoria");
            if (result != null) { subcats = result; }
        }

        /*
       public async  Task<List<Subcategoria>> GetSubcatsByStand(int id)
        {
            var result = await _http.GetFromJsonAsync<List<Subcategoria>>($"api/subcategoria/{id}");
            if (result != null) { subcats = result; }
           throw new Exception("Subcats not found");
        }*/
    }
}
