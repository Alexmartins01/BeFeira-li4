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
        Task<List<Produto>> GetProdutosBySubcat(int idsubcat);
        Task<List<Produto>> GetProdutosBySubcat4(int idsubcat);
		Task<List<Produto>> GetProdutosBySeller(int idsubcat);
        Task<List<Produto>> GetProdutosBySearch(string searchProdName,int idfeira);

	}
}
