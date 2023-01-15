namespace BeFeira.Client.Services.CarrinhoServices
{
    public interface ICarrinhoService
    {

        List<Carrinho> carrinhos { get; set; }
        Task<Carrinho> getCarrinhobyIdCliente(int id);

        Task getCarrinhos();

        Task AddCarrinho(Carrinho carrinho);

        Task UpdateCarrinho(Carrinho carrinho);

        Task<int> ExistsCarrinho(int iduser);
        Task<Carrinho> GetsingleCarrinho(int idcarrinho);
    }
}
