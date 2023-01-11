using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Data
{
    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
/*
            modelBuilder.Entity<Feira>().HasData(
                new Feira { ID = 1, Categoria = "lOUCOS" }
            );

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { ID = -1, Username = "pedro", Password = "sporting", Email = "a@uminho.pt" },
                new Cliente { ID = -2, Username = "joao", Password = "benfica", Email = "a@uminho.pt" },
                new Cliente { ID = -3, Username = "ze", Password = "porto", Email = "a@uminho.pt" }
            );

            modelBuilder.Entity<Administrador>().HasData(
                new Administrador { ID = -1, Password = "1234", Username = "Bernas" },
                new Administrador { ID = -2, Password = "2345", Username = "Cebolinha" },
                new Administrador { ID = -3, Password = "3456", Username = "Sergio" }
            );

            modelBuilder.Entity<Vendedor>().HasData(
                new Vendedor { ID = -1, Iban = "1113231", Mbway = "964888999", Username = "Lucas", Password = "0000", Rating = 9, Email = "a@uminho.pt" },
                new Vendedor { ID = -2, Iban = "3453661", Mbway = "96282289", Username = "Jonny", Password = "0101", Rating = 6, Email = "a@uminho.pt" }
            );

            modelBuilder.Entity<Stand>().HasData(
                new Stand { ID = -1, VendedorID = 1, FeiraID = 1 },
                new Stand { ID = -2, VendedorID = 1, FeiraID = 1 },
                new Stand { ID = -3, VendedorID = 1, FeiraID = 1 }
            );

            modelBuilder.Entity<Carrinho>().HasData(
                new Carrinho { ID = -1, ClienteID = 1, StandID = 1, Total = 0 },
                new Carrinho { ID = -2, ClienteID = 2, StandID = 2, Total = 10 },
                new Carrinho { ID = -3, ClienteID = 3, StandID = 3, Total = 5 }
            );

            modelBuilder.Entity<Subcategoria>().HasData(
                new Subcategoria { ID = -1, Descricao = "Terror", StandID = 1 },
                new Subcategoria { ID = -2, Descricao = "Aventura", StandID = 1 }
            );

            modelBuilder.Entity<Produto>().HasData(
                new Produto { ID = -1, StandID = 1, Nome_Produto = "Maçãs", Preco = 2.9F, Promocao = 0, Stock = 3, Rating = 4, SubCategoriaID = 1 },
                new Produto { ID = -2, StandID = 2, Nome_Produto = "Bonecos", Preco = 25.9F, Promocao = 0, Stock = 2, Rating = 2, SubCategoriaID = 4 },
                new Produto { ID = -3, StandID = 3, Nome_Produto = "Tapetea", Preco = 23.9F, Promocao = 0, Stock = 1, Rating = 3, SubCategoriaID = 3 }
            );

            modelBuilder.Entity<Promocao>().HasData(
                 new Promocao { ID = -1, ProdutoID = 1, Desconto = 10 }
            );

            modelBuilder.Entity<CarrinhoProduto>().HasData(
                new CarrinhoProduto { ID = -1, CarrinhoID = 1, ProdutoID = 1, Quantidade = 1, Preco = 10, TaxaBefeira = 10 },
                new CarrinhoProduto { ID = -2, CarrinhoID = 2, ProdutoID = 2, Quantidade = 4, Preco = 120, TaxaBefeira = 10 },
                new CarrinhoProduto { ID = -3, CarrinhoID = 3, ProdutoID = 3, Quantidade = 2, Preco = 22, TaxaBefeira = 10 }
            );

            modelBuilder.Entity<Venda>().HasData(
                new Venda { ID = -1, CarrinhoID = 1 },
                new Venda { ID = -2, CarrinhoID = 2 }
            );

            modelBuilder.Entity<VendaProduto>().HasData(
                new VendaProduto { ID = -1, VendaID = 1, ProdutoID = 1, Quantidade = 2, Preco = 10, TaxaBefeira = 10 },
                new VendaProduto { ID = -2, VendaID = 2, ProdutoID = 3, Quantidade = 3, Preco = 20, TaxaBefeira = 10 }
            );
*/

        }
        public DbSet<Feira> Feiras { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Stand> Stands { get; set; }
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<Subcategoria> Subcategorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<CarrinhoProduto> CarrinhoProdutos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaProduto> VendaProdutos { get; set; }

    }
}