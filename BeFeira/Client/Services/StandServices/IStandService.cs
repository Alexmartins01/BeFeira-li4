namespace BeFeira.Services.StandServices
{
	public interface IStandService
	{
        List<Subcategoria> subcats { get; set; }
        List<Stand> Stands { get; set; } 
		Task GetStands();
		Task<Stand> GetSingleStand(int id);
		Task GetSubcategorias();
		Task<List<Subcategoria>> GetSubcategoriasbyStand(int id);
		Task<List<Stand>> GetStandsByFeira(int id);
		Task<List<Stand>> GetStandsByVendedor(int idVend);

		Task AddStand(Stand stand);

		Task UpdateStand(Stand stand);

		Task<int> GetIdStand(String name, int iduser);


    }
}
