namespace BeFeira.Client.Services.VendaService
{
    public interface IVendaService
    {
        List<Venda> vendas { get; set; }
        Task GetVendas();

        Task<Venda> GetSingleVenda(int idvenda);

        Task AddVenda(Venda venda);


    }
}
