namespace BeFeira.Client.Services.FeiraServices
{
    public interface IFeiraService
    {
        List<Feira> Feiras { get; set; }

        Task GetFeiras();
        Task<Feira> GetSingleFeira(int id);

        Task<int> ExistsFeiraByUname(string uname);
    }
}
