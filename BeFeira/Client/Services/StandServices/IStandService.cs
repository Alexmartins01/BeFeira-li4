namespace BeFeira.Services.StandServices
{
	public interface IStandService
	{

         List<Stand> Stands { get; set; } 
         List<Feira> Feiras { get; set; } 
		Task GetStands();
		Task<Stand> GetStand(int id);

	}
}
