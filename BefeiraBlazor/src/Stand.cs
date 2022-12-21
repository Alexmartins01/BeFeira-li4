namespace stand
{

public class Stand
{
    public class SubCategoria
    {
        int idStand;
        int idsubCategoria;
        string descricao;
        static List<Produto> listProdutos = new List<Produto>();

        public SubCategoria(int idStand, List<Produto>)
	    {
		    this.subCatName = (int)idStand.Clone();
		    this.listProdutos = List<Produto>.Clone();
        }


        int getIdStand ()
        {
            return this.idStand;
        }

        int getIdsubCategoria ()
        {
            return this.idsubCategoria;
        }

        string getDescricao()
        {
            return this.descricao;
        }

        string getListProdutos()
        {
            return this.listProdutos;
        }

        void setidStand(int idStand)
        {
            this.idStand=idStand;
        }

        void setDescricao(string descricao)
        {
            this.descricao=descricao;
        }

        void setListProdutos(List<Produto> listProdutos)
        {
            this.listProdutos=listProdutos;
        }

        void setSUbcategoria(int idsubCategoria)
        {
            this.idsubCategoria = idsubCategoria;
        }


        void addProduto(Produto p)
        {
            this.listProdutos.Add(p);
        }

        void removeProduto(Produto p)
        {
            this.listProdutos.Remove(p);
        }

    }


    int idStand;
    string nameStand;
    int idVendedor;
    int idFeira;
    static List<SubCategoria> subcategorias = new List<SubCategoria>();



    public Stand(int idStand, string nameStand, List<SubCategoria>)
	{
		this.idStand = idStand.Clone();
		this.nameStand = (String)nameStand.Clone();
		this.subcategorias = List<SubCategoria>.Clone();
    }



    int getIdStand ()
    {
        return this.idStand;
    }

    int getIdVendedor ()
    {
        return this.idVendedor;
    }

    int getIdFeira ()
    {
        return this.idFeira;
    }


    string getnameStand ()
    {
        return this.nameStand;
    }

    List<SubCategoria> getSubCats ()
    {
        return this.subcategorias;
    }



    void setIdStand(string idStand)
    {
        this.idStand=idStand;
    }

    void setIdVendedor(int idVendedor)
    {
        this.idVendedor=idVendedor;
    }

    void setIdFeira(int idFeira)
    {
        this.idFeira=idFeira;
    }


    void setNameStand(string nameStand)
    {
        this.nameStand=nameStand;
    }


    void setSubCats(List<SubCategoria> subcategorias)
    {
        this.subcategorias=subcategorias;
    }


    void addSubCat(SubCategoria sc)
    {
        this.subcategorias.Add(sc);
    }

    void removeSubCat(SubCategoria sc)
    {
        this.subcategorias.Remove(sc);
    }

    
}
}