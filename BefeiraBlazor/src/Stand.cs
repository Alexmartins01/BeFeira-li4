namespace stand
{

public class Stand
{
    


    int idStand;
    string nameStand;
    int idVendedor;
    int idFeira;
    List<subcat.SubCategoria> subcategorias ;



    public Stand(int idStand, string nameStand, List<subcat.SubCategoria> lista)
	{
		this.idStand = idStand;
		this.nameStand = (String)nameStand.Clone();
		this.subcategorias = lista;
    }

    public int getIdStand ()
    {
        return this.idStand;
    }

     public  int getIdVendedor ()
    {
        return this.idVendedor;
    }

   public  int getIdFeira ()
    {
        return this.idFeira;
    }


   public  string getnameStand ()
    {
        return this.nameStand;
    }

   public  List<subcat.SubCategoria> getSubCats ()
    {
        return this.subcategorias;
    }



     public void setIdStand(int idStand)
    {
        this.idStand=idStand;
    }

    public void setIdVendedor(int idVendedor)
    {
        this.idVendedor=idVendedor;
    }

    public void setIdFeira(int idFeira)
    {
        this.idFeira=idFeira;
    }


    public void setNameStand(string nameStand)
    {
        this.nameStand=nameStand;
    }


    public void setSubCats(List<subcat.SubCategoria> subcategorias)
    {
        this.subcategorias=subcategorias;
    }


    public void addSubCat(subcat.SubCategoria sc)
    {
        this.subcategorias.Add(sc);
    }

    public void removeSubCat(subcat.SubCategoria sc)
    {
        this.subcategorias.Remove(sc);
    }

    
}
}