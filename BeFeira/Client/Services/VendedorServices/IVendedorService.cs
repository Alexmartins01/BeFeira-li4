namespace BeFeira.Client.Services.VendedorServices
{
    public interface IVendedorService
    {
        List<Vendedor> vendedores { get; set; }
        Task GetVendedores();

        Task<Vendedor> GetSingleVendedor(int id);
        Task<int> ValidVendedor(string username,string pass);

        Task AddVendedor(Vendedor vendedor);

        Task UpdateVendedor(Vendedor vendedor );
    }
}
