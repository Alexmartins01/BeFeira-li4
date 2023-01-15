namespace BeFeira.Client.Services.VendaProdServices
{
    public interface IVendaProdService
    {
        List<VendaProduto> Vendas { get; set; }
        Task GetVendaProdutos();

        Task<Venda> GetSingleVendaProduto(int idvenda);

        Task AddVendaProduto(Venda venda);
    }
}
