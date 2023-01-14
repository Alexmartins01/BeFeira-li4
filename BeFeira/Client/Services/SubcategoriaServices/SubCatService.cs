using BeFeira.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BeFeira.Client.Services.SubcategoriaServices
{
    public class SubCatService : ISubcatserv
    {
        private readonly HttpClient _http;
 

        public List<Subcategoria> subcats { get; set; } = new List<Subcategoria>();
        public SubCatService(HttpClient http) {
            _http = http;
        }

       public  async Task GetSubcats()
        {
            var result = await _http.GetFromJsonAsync<List<Subcategoria>>("api/Subcategoria");
            if (result != null) { subcats = result; }
        }

        public async Task<List<Subcategoria>> GetSubcatsByStand(int id)
        {
            List<Subcategoria> AUX= new List<Subcategoria>();
            foreach(var subc in subcats)
            {

                if (subc.StandID == id) { AUX.Add(subc);}
            }
            return AUX;
        }

        public async Task<Subcategoria> GetSingleSubCat(int id)
        {
            var result = await _http.GetFromJsonAsync<Subcategoria>($"api/subcategoria/{id}");
            if (result != null)
            {
                return result;
            }
            throw new Exception("Subcat not found");
        }


    }
}
