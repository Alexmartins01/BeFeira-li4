using System.Net.Http.Json;

namespace BeFeira.Services.StandServices
{
	public class StandService : IStandService
	{
		private readonly HttpClient _http;

		public StandService(HttpClient http)
		{
			_http = http;
		}
		public List<Stand> Stands { get; set; } = new List<Stand>();
		public List<Feira> Feiras { get; set; } = new List<Feira>();

		public Task<Stand> GetStand(int id)
		{
			throw new NotImplementedException();
		}

		public async Task GetStands()
		{
			var result = await _http.GetFromJsonAsync<List<Stand>>("api/stand");
			if (result != null) { Stands = result; }
		}

		public Task GetFeiras()
		{
			throw new NotImplementedException();

		}
	}
}
