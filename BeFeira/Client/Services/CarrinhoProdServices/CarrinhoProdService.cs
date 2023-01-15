using BeFeira.Shared;
using System.Net.Http.Json;

namespace BeFeira.Client.Services.CarrinhoProdServices
{
    public class CarrinhoProdService : ICarrinhoProdService
    {
       public  List<CarrinhoProduto> carrinhoprodutos { get; set;}


        private readonly HttpClient _http;
 

        public CarrinhoProdService(HttpClient http)
        {
            _http = http;
        }
        public async  Task AddCarrinhoProduto(CarrinhoProduto carrinho)
        {
            var result = await _http.PostAsJsonAsync("api/carrinhoprod", carrinho);
            var response = await result.Content.ReadFromJsonAsync<List<CarrinhoProduto>>();
            carrinhoprodutos = response;
        }

        public async  Task getCarrinhosProd()
        {

            var result = await _http.GetFromJsonAsync<List<CarrinhoProduto>>("api/CarrinhoProd");
            if (result != null) { carrinhoprodutos = result; }
        }

       public async  Task<List<CarrinhoProduto>> getCarrinhosProdbyIdKart(int idkart)
        {
            List<CarrinhoProduto> aux = new List<CarrinhoProduto>();
            await getCarrinhosProd();       
            
            foreach(var item in carrinhoprodutos)
            {
                if (item.CarrinhoID == idkart)
                {
                    aux.Add(item);
                }
            }
            return aux;
                
            
        }

        public async Task<float> getPrecoKart(int idkart)
        {
            float aux = 0;
            await getCarrinhosProd();

            foreach (var item in carrinhoprodutos)
            {
                if (item.CarrinhoID == idkart)
                {
                    aux += item.Preco   ;
                }
            }
            return aux;


        }


        public async Task UpdateCarrinhoProduto(CarrinhoProduto carrinho)
        {
            throw new NotImplementedException();
        }

       public async  Task<List<Produto>> getProdutosinCarrinho(int idcarrinho)
        {
            List<Produto> aux = new List<Produto>();
            await getCarrinhosProd();

            foreach (var item in carrinhoprodutos)
            {
                if (item.CarrinhoID == idcarrinho)
                {
                    aux.Add(item.Produto);
                }
            }
            return aux;
        }

        public async Task<int > getCarrinhoprodbykartandprod(Produto prod, int idkart)
        {
			CarrinhoProduto p = carrinhoprodutos.Find(car => car.CarrinhoID == idkart && car.ProdutoID == prod.ID);
            return p.ID;
		}

        public async Task DeleteCarrinhoProd(int id)
        {
    
            var result = await _http.DeleteAsync($"api/CarrinhoProd/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<CarrinhoProduto>>();
            carrinhoprodutos = response;
        }

        public async Task deleteprodutoskart(int idkart)
        {
            foreach(var item in carrinhoprodutos)
            {
                if (item.CarrinhoID == idkart)
                {
                    await DeleteCarrinhoProd(item.ID);
                }
            }

        }
    }
}
