using BeFeira.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BeFeira.Services.StandServices
{
	public class StandService : IStandService
	{
		private readonly HttpClient _http;
        private readonly NavigationManager navigationManager;
        public List<Stand> Stands { get; set; } = new List<Stand>();
        public List<Subcategoria> subcats { get; set; } = new List<Subcategoria>();
        public StandService(HttpClient http,NavigationManager navigation)
		{
			_http = http;
			navigationManager = navigation;
		}
		

		public async Task<Stand>GetSingleStand(int id)
		{
            var result = await _http.GetFromJsonAsync<Stand>($"api/stand/{id}");
            if (result != null) 
			{
				return result; 
			}
            throw new Exception("Stand not found");
        }

		public async Task GetStands()
		{
			var result = await _http.GetFromJsonAsync<List<Stand>>("api/stand");
			if (result != null) { Stands = result; }
            
        }

        public async Task GetSubcategorias()
        {
            var result = await _http.GetFromJsonAsync<List<Subcategoria>>("api/subcategoria");
            if (result != null) { subcats = result; }

        }

        public async Task<List<Subcategoria>> GetSubcategoriasbyStand(int id)
        {
            var result = await _http.GetFromJsonAsync<List<Subcategoria>>($"api/subcategoria");
            if (result != null) { return result; }
            throw new Exception("invalid");
        }

		public async Task<List<Stand>> GetStandsByFeira(int id)
		{
			List<Stand> std=new List<Stand>() { };
			foreach (var p in Stands)
			{
				if (p.FeiraID == id)
				{
					std.Add(p);
				}

			}
			return std; 
		}

		public async Task<List<Stand>> GetStandsByVendedor(int idVend)
		{
			List<Stand> std = new List<Stand>() { };
			foreach (var p in Stands)
			{
				if (p.VendedorID == idVend)
				{
					std.Add(p);
				}

			}
			return std;
		}

		public async Task AddStand(Stand stand)
		{
			var result = await _http.PostAsJsonAsync("api/stand", stand);
			var response = await result.Content.ReadFromJsonAsync<List<Stand>>();
			Stands = response.ToList();
		}

		public async Task UpdateStand(Stand stand)
		{
			var result = await _http.PutAsJsonAsync($"api/stand/{stand.ID}", stand);
			var response = await result.Content.ReadFromJsonAsync<List<Stand>>();
			Stands = response.ToList();
		}

        public async Task<int> GetIdStand(String name ,int iduser)
        {
			GetStands();
			Stand aux = Stands.Find(h => h.Nome == name && h.VendedorID == iduser);			
			if (aux != null)
			{
				Console.WriteLine(aux.Nome);
                return aux.ID;
            }
			return -1;
			
        }

       



    }
}
