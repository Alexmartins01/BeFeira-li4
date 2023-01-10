namespace BeFeira.Client.Services.ProdutoServices
{
    public interface IProdutoService
    {
        List<Produto> produtos { get; set; }

        Task GetProdutos();
        Task<List<Produto>> GetByIdStand(int id);
        Task<Produto> GetSingleProd(int id);

        Task CreateProduto(Produto p);
        Task UpdateProduto(Produto p);
        Task DeleteProduto( int id);

    }
}
