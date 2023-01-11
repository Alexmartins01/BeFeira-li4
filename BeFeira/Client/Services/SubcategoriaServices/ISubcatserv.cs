namespace BeFeira.Client.Services.SubcategoriaServices
{
    public interface ISubcatserv
    {

        List<Subcategoria> Subcats { get; set; }
        Task GetSubcats();
        //Task<List<Subcategoria>> GetSubcatsByStand(int id);
    }
}
