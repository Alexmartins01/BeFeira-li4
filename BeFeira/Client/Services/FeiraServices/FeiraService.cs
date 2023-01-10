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
		public HttpClient Http { get; }

		public async Task GetFeiras()
		{
			var result = await _http.GetFromJsonAsync<List<Feira>>("api/feira");
			if (result != null) { Feiras = result; }
		}

		public Task<Feira> GetSingleFeira(int id)
		{
			throw new NotImplementedException();
		}
	}
}
