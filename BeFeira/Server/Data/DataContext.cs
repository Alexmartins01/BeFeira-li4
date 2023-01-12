using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Data
{
    public class DataContext : DbContext
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feira>().HasData(
                             new Feira { ID = 1, Categoria = "Casa e Decoração" },
                             new Feira { ID = 2, Categoria = "Animais" },
                             new Feira { ID = 3, Categoria = "Mercearia e Produtos Frescos" },
                             new Feira { ID = 4, Categoria = "Cultura" },
                             new Feira { ID = 5, Categoria = "Véiculos" },
                             new Feira { ID = 6, Categoria = "Escritório" },
                             new Feira { ID = 7, Categoria = "Moda" },
                             new Feira { ID = 8, Categoria = "Bricolagem" },
                             new Feira { ID = 9, Categoria = "Animais de Estimação" },
                             new Feira { ID = 10, Categoria = "Brinquedos" },
                             new Feira { ID = 11, Categoria = "Gaming" },
                             new Feira { ID = 12, Categoria = "Lazer" },
                             new Feira { ID = 13, Categoria = "Saúde" },
                             new Feira { ID = 14, Categoria = "Beleza" },
                             new Feira { ID = 15, Categoria = "Eletrodomésticos" },
                             new Feira { ID = 16, Categoria = "Imagem" },
                             new Feira { ID = 17, Categoria = "Som" },
                             new Feira { ID = 18, Categoria = "Smartphones e Acessórios" },
                             new Feira { ID = 19, Categoria = "Informática" },
                             new Feira { ID = 20, Categoria = "Desporto" },
                             new Feira { ID = 21, Categoria = "Random" }




                       );

            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { ID = 1, Username = "pedro", Password = "sporting", Email = "a@uminho.pt" },
                new Cliente { ID = 2, Username = "joao", Password = "benfica", Email = "a@uminho.pt" },
                new Cliente { ID = 3, Username = "ze", Password = "porto", Email = "a@uminho.pt" }
            );

            modelBuilder.Entity<Administrador>().HasData(
                new Administrador { ID = 1, Password = "1234", Username = "Bernas" },
                new Administrador { ID = 2, Password = "2345", Username = "Cebolinha" },
                new Administrador { ID = 3, Password = "3456", Username = "Sergio" }
            );

            modelBuilder.Entity<Vendedor>().HasData(
                new Vendedor { ID = 1, Iban = "1113231", Mbway = "964888999", Username = "Lucas", Password = "0000", Rating = 9, Email = "a@uminho.pt" },
                new Vendedor { ID = 2, Iban = "3453661", Mbway = "96282289", Username = "Jonny", Password = "0101", Rating = 6, Email = "a@uminho.pt" }
            );

            modelBuilder.Entity<Stand>().HasData(
                new Stand { ID = 1,Nome= "ZaraHome", VendedorID = 1, FeiraID = 1 },
                new Stand { ID = 2, Nome = "Agriloja", VendedorID = 1, FeiraID = 2 },
                new Stand { ID = 3, Nome = "Pingo Doce", VendedorID = 1, FeiraID = 3 },
				new Stand { ID = 4, Nome = "Bertrand", VendedorID = 1, FeiraID = 4 },
				new Stand { ID = 5, Nome = "BMW", VendedorID = 1, FeiraID = 5 },
				new Stand { ID = 6, Nome = "IKEA", VendedorID = 1, FeiraID = 6 },
				new Stand { ID = 7, Nome = "Zara", VendedorID = 1, FeiraID = 7 },
				new Stand { ID = 8, Nome = "Leroy Merlin", VendedorID = 1, FeiraID = 8 },
				new Stand { ID = 9, Nome = "Animais e Companhia", VendedorID = 1, FeiraID = 9 },
				new Stand { ID = 10, Nome = "ToysRus", VendedorID = 1, FeiraID = 10 },
				new Stand { ID = 11, Nome = "CEX", VendedorID = 2, FeiraID = 11 },
				new Stand { ID = 12, Nome = "Worten", VendedorID = 1, FeiraID = 12 },
				new Stand { ID = 13, Nome = "WELLS", VendedorID = 2, FeiraID = 13 },
				new Stand { ID = 14, Nome = "Perfumes e Companhia", VendedorID = 1, FeiraID = 14},
				new Stand { ID = 15, Nome = "Tien21", VendedorID = 1, FeiraID = 15},
				new Stand { ID = 16, Nome = "Canon", VendedorID = 2, FeiraID = 16 },
				new Stand { ID = 17, Nome = "JBL", VendedorID = 1, FeiraID = 17 },
				new Stand { ID = 18, Nome = "WortenMobile", VendedorID = 1, FeiraID = 18 },
				new Stand { ID = 19, Nome = "PCDiga", VendedorID = 2, FeiraID =  19},
				new Stand { ID = 20, Nome = "SoloPorteros", VendedorID = 1, FeiraID = 20 },
				new Stand { ID = 21, Nome = "Pilhas e Companhia", VendedorID = 1, FeiraID = 21 }

			);

            modelBuilder.Entity<Carrinho>().HasData(
                new Carrinho { ID = 1, ClienteID = 1, StandID = 1, Total = 0 },
                new Carrinho { ID = 2, ClienteID = 2, StandID = 2, Total = 10 },
                new Carrinho { ID = 3, ClienteID = 3, StandID = 3, Total = 5 }
            );

            modelBuilder.Entity<Subcategoria>().HasData(
                new Subcategoria { ID = 1, Descricao = "Casa de Banho", StandID = 1 },
                new Subcategoria { ID = 2, Descricao = "Sala", StandID = 1 },
			    new Subcategoria { ID = 3, Descricao = "Cozinha", StandID = 1 },
				new Subcategoria { ID = 4, Descricao = "Rações", StandID = 2 },
				new Subcategoria { ID = 5, Descricao = "Frangos", StandID = 2 },
				new Subcategoria { ID = 6, Descricao = "Coelhos", StandID = 2 },
				new Subcategoria { ID = 7, Descricao = "Higiene", StandID = 3},
				new Subcategoria { ID = 8, Descricao = "Talho", StandID = 3 },
				new Subcategoria { ID = 9, Descricao = "Peixaria", StandID = 3 },
				new Subcategoria { ID = 10, Descricao = "Terror", StandID = 4 },
				new Subcategoria { ID = 11, Descricao = "Comédia", StandID = 4 },
				new Subcategoria { ID = 12, Descricao = "Romance", StandID = 4 },
				new Subcategoria { ID = 13, Descricao = "Elétricos", StandID =5 },
				new Subcategoria { ID = 14, Descricao = "Gasóleo", StandID = 5 },
				new Subcategoria { ID = 15, Descricao = "Hibrídos", StandID = 5 },
				new Subcategoria { ID = 16, Descricao = "Secretárias", StandID = 6 },
				new Subcategoria { ID = 17, Descricao = "Tapetes", StandID = 6},
				new Subcategoria { ID = 18, Descricao = "Cadeiras", StandID= 6 }

			);

            modelBuilder.Entity<Produto>().HasData(
                new Produto { ID = 1, StandID = 1, Nome_Produto = "Maçãs", Preco = 2.9F, Promocao = 0, Stock = 3, Rating = 4, SubCategoriaID = 1 },
                new Produto { ID = 2, StandID = 2, Nome_Produto = "Bonecos", Preco = 25.9F, Promocao = 0, Stock = 2, Rating = 2, SubCategoriaID = 2 },
                new Produto { ID = 3, StandID = 3, Nome_Produto = "Tapetea", Preco = 23.9F, Promocao = 0, Stock = 1, Rating = 3, SubCategoriaID = 2 }
            );

            modelBuilder.Entity<Promocao>().HasData(
                 new Promocao { ID = 1, ProdutoID = 1, Desconto = 10 }
            );

            modelBuilder.Entity<CarrinhoProduto>().HasData(
                new CarrinhoProduto { ID = 1, CarrinhoID = 1, ProdutoID = 1, Quantidade = 1, Preco = 10, TaxaBefeira = 10 },
                new CarrinhoProduto { ID = 2, CarrinhoID = 2, ProdutoID = 2, Quantidade = 4, Preco = 120, TaxaBefeira = 10 },
                new CarrinhoProduto { ID = 3, CarrinhoID = 3, ProdutoID = 3, Quantidade = 2, Preco = 22, TaxaBefeira = 10 }
            );

            modelBuilder.Entity<Venda>().HasData(
                new Venda { ID = 1, CarrinhoID = 1 },
                new Venda { ID = 2, CarrinhoID = 2 }
            );

            modelBuilder.Entity<VendaProduto>().HasData(
                new VendaProduto { ID = 1, VendaID = 1, ProdutoID = 1, Quantidade = 2, Preco = 10, TaxaBefeira = 10 },
                new VendaProduto { ID = 2, VendaID = 2, ProdutoID = 3, Quantidade = 3, Preco = 20, TaxaBefeira = 10 }
            );


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