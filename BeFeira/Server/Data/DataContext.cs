﻿using Microsoft.EntityFrameworkCore;

namespace BeFeira.Server.Data
{
    public class DataContext:DbContext
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(
                    new Produto { ProdutoId = 2, StandId = 1, Nome_Produto = "Maçãs", Preco = 2.9F, Promocao = 0, Stock = 3, Rating = 4, SubCategoria = 1 },
            new Produto { ProdutoId = 3, StandId = 2, Nome_Produto = "Bonecos", Preco = 25.9F, Promocao = 0, Stock = 2, Rating = 2, SubCategoria = 4 },
            new Produto { ProdutoId = 4, StandId = 3, Nome_Produto = "Tapetea", Preco = 23.9F, Promocao = 0, Stock = 1, Rating = 3, SubCategoria = 3 }
                );

            modelBuilder.Entity<Feira>().HasData(
                   new Feira { FeiraId=1,Categoria="lOUCOS" }

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
