using System;

namespace Carrinho
{
    public class CarrinhoProduto
    {
        int idCarrinho;
        int idProduto;
        int quantidade;
        float preco;
        float taxa;

        public CarrinhoProduto(int idCarrinho, int idProduto, int quantidade, float preco, float taxa)
        {
            this.idCarrinho = idCarrinho;
            this.idProduto = idProduto;
            this.quantidade= quantidade;
            this.preco = preco;
            this.taxa = taxa;
        }

        public int getIdCarrinho()
        {
            return idCarrinho;
        }

        public int getIdProduto()
        {
            return idProduto;
        }

        public int getQuantidade()
        {
            return quantidade;
        }

        public float getPreco()
        {
            return preco;
        }

        public float getTaxa()
        {
            return taxa;
        }
    }
}
