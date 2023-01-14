namespace BeFeira.Client.Services.SubcategoriaServices
{
    public interface ISubcatserv
    {

        List<Subcategoria> subcats { get; set; }
        Task GetSubcats();

        Task<List<Subcategoria>> GetSubcatsByStand(int id);

        Task<Subcategoria> GetSingleSubCat(int id);
    }
}
