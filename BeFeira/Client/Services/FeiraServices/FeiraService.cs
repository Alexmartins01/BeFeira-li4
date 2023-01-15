using System.Net.Http.Json;

namespace BeFeira.Client.Services.FeiraServices
{
	public class FeiraService : IFeiraService
	{
		private readonly HttpClient _http;

		public FeiraService(HttpClient http)
		{
			_http = http;
		}
		public List<Feira> Feiras { get; set; } = new List<Feira>();

        public async Task GetFeiras()
		{
			var result = await _http.GetFromJsonAsync<List<Feira>>("api/feira");
			if (result != null) { Feiras = result; }
		}

		public async  Task<Feira> GetSingleFeira(int id)
		{
			var result = await _http.GetFromJsonAsync<Feira>($"api/feira/{id}");
			if (result != null)
			{

				return result;
			}
			throw new Exception("Product not found");
		}

        public async Task<int> ExistsFeiraByUname(string uname)
        {
			if (Feiras.Any(h => h.Categoria == uname))
			{
				Feira aux = Feiras.Find(h => h.Categoria == uname);
				return aux.ID;
			}
			return -1;
        }
    }
}
