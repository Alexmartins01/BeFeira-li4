namespace subcat
{

    public class SubCategoria
    {
        int idStand;
        int idsubCategoria;
        string descricao;
        List<prod.Produto> listProdutos;

        public SubCategoria(int idStand, List<prod.Produto> lista, int idsubCategoria, string descicao)
        {
            this.idStand = (int)idStand;
            this.idsubCategoria = idsubCategoria;
            this.listProdutos = lista;
            this.descricao = descricao;
        }


        public int getIdStand()
        {
            return this.idStand;
        }

        public int getIdsubCategoria()
        {
            return this.idsubCategoria;
        }

        public string getDescricao()
        {
            return this.descricao;
        }

        public List<prod.Produto> getListProdutos()
        {
            return this.listProdutos;
        }

        public void setidStand(int idStand)
        {
            this.idStand = idStand;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public void setListProdutos(List<prod.Produto> listProdutos)
        {
            this.listProdutos = listProdutos;
        }

        public void setSUbcategoria(int idsubCategoria)
        {
            this.idsubCategoria = idsubCategoria;
        }


        public void addProduto(prod.Produto p)
        {
            this.listProdutos.Add(p);
        }

        public void removeProduto(prod.Produto p)
        {
            this.listProdutos.Remove(p);
        }

    }
}