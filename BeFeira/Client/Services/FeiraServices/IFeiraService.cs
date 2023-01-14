namespace BeFeira.Client.Services.FeiraServices
{
    public interface IFeiraService
    {
        List<Feira> FeiraList { get; set; }

        Task GetFeiras();
        Task<Feira> GetSingleFeira(int id);
    }
}
