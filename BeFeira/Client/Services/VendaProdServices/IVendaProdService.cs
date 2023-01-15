namespace BeFeira.Client.Services.VendaProdServices
{
    public interface IVendaProdService
    {
        List<VendaProduto> Vendas { get; set; }
        Task GetVendaProdutos();

        Task<VendaProduto> GetSingleVendaProduto(int idvenda);

        Task AddVendaProduto(VendaProduto venda);
    }
}
