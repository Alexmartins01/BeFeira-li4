﻿using Microsoft.AspNetCore.Components;
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
    }
}
