namespace BeFeira.Client.Services.CarrinhoProdServices
{
    public interface ICarrinhoProdService
    {
        List<CarrinhoProduto> carrinhoprodutos { get; set; }
        Task getCarrinhosProd();

        Task<List<CarrinhoProduto>> getCarrinhosProdbyIdKart(int idkart);

        Task AddCarrinhoProduto(CarrinhoProduto carrinho);

        Task UpdateCarrinhoProduto(CarrinhoProduto carrinho);

        Task<List<Produto>> getProdutosinCarrinho(int  idcarrinho);

        Task DeleteCarrinhoProd(int id);

        Task<int> getCarrinhoprodbykartandprod(Produto prod, int idkart);
        Task<float> getPrecoKart(int idkart);

        Task deleteprodutoskart(int idkart);

    }
}
