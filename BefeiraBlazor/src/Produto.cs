namespace BeFeira.Classes
{
    public class Produto // falta nome produto
    {
        int idProduto;
        String descricao;
        int idStand;
        double preco;
        int promocao;
        int stock;
        int rating;
        int categoria;

       
        public Produto(int idProduto,String descricao,int idStand ,double preco,int promocao,int stock,int rating,int categoria)
        {
            this.idProduto = idProduto;
            this.descricao= descricao;
            this.idStand = idStand;
            this.preco = preco;
            this.promocao = promocao;
            this.stock = stock;
            this.rating = rating;
            this.categoria = categoria;
        }

        public Produto()
        {
            this.idProduto =-1;
            this.idStand =-1;
            this.preco =-1;
            this.promocao = 0;
            this.stock = -1;
            this.rating = -1;
            this.categoria = -1;
            this.descricao = "";
        }

        public Produto (Produto a)
        {
            this.idProduto = a.getIdProduto();
            this.idStand = a.getIdStand();
            this.preco = a.getPreco();
            this.promocao = a.getPromocao();
            this.stock = a.getStock();
            this.rating = a.getRating();
            this.categoria=a.getCategoria();
            this.descricao = a.getDescricao();
        }
        public int getIdProduto()
            {
                return this.idProduto;
            }
        public int getIdStand()
            {
                return this.idStand;    
            }
        public double getPreco() 
            {
                return this.preco;
            }
        public String getDescricao()
        {
            return this.descricao;
        }
        public int getPromocao()
            {
                return this.promocao;
            }
        public int getStock()
            {
                return this.stock;
            }   
        public int getRating()
            {
                return this.rating;
            }
        public int getCategoria()
            {
                return this.categoria;
            }
        public Produto getProduto() {
                return new Produto(this);    
            }
        /*-----------------------*/

        public void setIdProduto(int id)
        {
            this.idProduto=id;
        }
        public void setIdStand(int idStand)
        {
             this.idStand=idStand;
        }
        public void setPreco(int preco)
        {
          this.preco=preco;
        }
        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }
        public void setPromocao(int promocao)
        {
            this.promocao=promocao;
        }
        public void setStock(int stock)
        {
             this.stock=stock;
        }
        public void setRating(int rating)
        {
           this.rating=rating;
        }
        public void setCategoria(int categoria)
        {
            this.categoria=categoria;
        }
