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

        Task DeleteCarrinhoProd(Produto p, int idkart);
    }
}
