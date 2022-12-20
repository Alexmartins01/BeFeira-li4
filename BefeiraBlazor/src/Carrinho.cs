using System;

namespace Carrinho
{
    public class Carrinho
    {
        int idCarrinho;
        int idCliente;
        int idStand;
        double total;

        public Carrinho(int idCarrinho, int idCliente, int idStand, int total)
        {
            this.idCarrinho= idCarrinho;
            this.idCliente= idCliente;
            this.idStand= idStand;
            this.total= total;
        }

        public int getIdCarrinho()
        {
            return idCarrinho;
        }

        public int getIdCliente()
        {
            return idCliente;
        }

        public double getTotal() 
        { 
            return total;
        }
    }
}
