﻿using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net.Http.Json;

namespace BeFeira.Client.Services.ProdutoServices
{
    public class ProdutoService : IProdutoService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager navigationManager;

        public ProdutoService(HttpClient http,NavigationManager navigation) { 
            _http=http;
            this.navigationManager = navigation;

        }
        public  List<Produto> produtos { get ; set ; }=new List<Produto>();
        

        public async void SetProdutos(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<Produto>>();
            this.produtos= response;
            navigationManager.NavigateTo("produto");
        }
        public async Task<List<Produto>> GetByIdStand(int id)
        {
            throw new NotImplementedException();
        }

        public  async Task GetProdutos()
        {
            var result = await _http.GetFromJsonAsync<List<Produto>>("api/Produto");
            if (result != null)
            {
                produtos = result;
            }
        }

        public async Task<Produto> GetSingleProd(int id)
        {
            var result = await _http.GetFromJsonAsync<Produto>($"api/Produto/{id}");
            if (result != null)
            {
                return result;
            }
            throw new Exception("Hero not found");
        }

        public async Task CreateProduto(Produto p)
        {
            var result = await _http.PostAsJsonAsync("api/Produto", p);
            var response = await result.Content.ReadFromJsonAsync<List<Produto>>();
            SetProdutos(result);
        }

        public async Task DeleteProduto( int id)
        {

            var result = await _http.DeleteAsync($"api/Produto/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Produto>>();
            SetProdutos(result);
        }

        public async Task UpdateProduto(Produto p)
        {
            var result = await _http.PutAsJsonAsync($"api/Produto/{p.ProdutoId}", p);
            var response = await result.Content.ReadFromJsonAsync<List<Produto>>();
            SetProdutos(result);
        }
    }
}