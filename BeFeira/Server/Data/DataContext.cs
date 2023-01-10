using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Data
{
    public class DataContext:DbContext
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                    new Produto { ID = 2, StandID = 1, Nome_Produto = "Maçãs", Preco = 2.9F, Promocao = 0, Stock = 3, Rating = 4, SubCategoriaID = 1 },
            new Produto { ID = 3, StandID = 2, Nome_Produto = "Bonecos", Preco = 25.9F, Promocao = 0, Stock = 2, Rating = 2, SubCategoriaID = 4 },
            new Produto { ID = 4, StandID = 3, Nome_Produto = "Tapetea", Preco = 23.9F, Promocao = 0, Stock = 1, Rating = 3, SubCategoriaID = 3 }
                );

            modelBuilder.Entity<Feira>().HasData(
                   new Feira { ID = 1, Categoria = "lOUCOS" }

               );
            modelBuilder.Entity<Subcategoria>().HasData(
                 new Subcategoria { ID = 1, Descricao = "Terror", StandID = 1 },
            new Subcategoria { ID = 2, Descricao = "Aventura", StandID = 1 }

            );

    }
    public DbSet<Produto> Produtos { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Feira> Feiras { get; set; }
        public DbSet<Stand> Stands { get; set; }

        public DbSet<Carrinho> Carrinhos { get; set; }

        public DbSet<CarrinhoProduto> CarrinhoProdutos { get; set; }
        public DbSet<Cliente> Clientes { get; set;}
        
        public DbSet<Promocao> Promocoes { get; set; }

        public DbSet<Subcategoria> Subcategorias { get; set;}
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaProduto> VendaProdutos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }


    }
}
