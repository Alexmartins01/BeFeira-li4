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
                new Cliente { ID = 1, Username = "Pedro", Password = "sporting", Email = "a1@uminho.pt" },
                new Cliente { ID = 2, Username = "João", Password = "benfica", Email = "a2@uminho.pt" },
                new Cliente { ID = 3, Username = "Zé", Password = "porto", Email = "a3@uminho.pt" },
                new Cliente { ID = 4, Username = "Ana", Password = "sporting11", Email = "a4@uminho.pt" },
                new Cliente { ID = 5, Username = "Ivo", Password = "benfica11", Email = "a5@uminho.pt" },
                new Cliente { ID = 6, Username = "Nestor", Password = "porto11", Email = "a6@uminho.pt" },
                new Cliente { ID = 7, Username = "Paulo", Password = "sporting22", Email = "a7@uminho.pt" },
                new Cliente { ID = 8, Username = "Bruno", Password = "benfica22", Email = "a8@uminho.pt" },
                new Cliente { ID = 9, Username = "Rui", Password = "porto22", Email = "a9@uminho.pt" },
                new Cliente { ID = 10, Username = "Francisca", Password = "sporting33", Email = "a10@uminho.pt" },
                new Cliente { ID = 11, Username = "Patricia", Password = "benfica33", Email = "a11@uminho.pt" },
                new Cliente { ID = 12, Username = "Luis", Password = "porto33", Email = "a12@uminho.pt" }
            );

            modelBuilder.Entity<Administrador>().HasData(
                new Administrador { ID = 1, Password = "1234", Username = "Bernas" },
                new Administrador { ID = 2, Password = "2345", Username = "Cebolinha" },
                new Administrador { ID = 3, Password = "3456", Username = "Sergio" },
                new Administrador { ID = 4, Password = "1134", Username = "Anastásia" },
                new Administrador { ID = 5, Password = "2245", Username = "Rodri" },
                new Administrador { ID = 6, Password = "3453", Username = "Jairzinho" }
            );

            modelBuilder.Entity<Vendedor>().HasData(
                new Vendedor { ID = 1, Iban = "1113231", Mbway = "964888999", Username = "Lucas", Password = "0040", Rating = 9, Email = "a13@uminho.pt" },
                new Vendedor { ID = 2, Iban = "3453661", Mbway = "972822895", Username = "Jonny", Password = "0181", Rating = 6, Email = "a14@uminho.pt" },
                new Vendedor { ID = 3, Iban = "8142831", Mbway = "964457999", Username = "Ema", Password = "2030", Rating = 7, Email = "a15@uminho.pt" },
                new Vendedor { ID = 4, Iban = "7403061", Mbway = "932823894", Username = "Diana", Password = "1161", Rating = 8, Email = "a16@uminho.pt" },
                new Vendedor { ID = 5, Iban = "1213221", Mbway = "925679969", Username = "Jordi Alba", Password = "0340", Rating = 9, Email = "a17@uminho.pt" },
                new Vendedor { ID = 6, Iban = "5333161", Mbway = "923852594", Username = "Marcelo", Password = "8481", Rating = 2, Email = "a18@uminho.pt" },
                new Vendedor { ID = 7, Iban = "0102831", Mbway = "964646797", Username = "Puskas", Password = "9039", Rating = 5, Email = "a19@uminho.pt" },
                new Vendedor { ID = 8, Iban = "6003261", Mbway = "937733894", Username = "Eusébio", Password = "3131", Rating = 10, Email = "a20@uminho.pt" }
            );

            modelBuilder.Entity<Stand>().HasData(
                new Stand { ID = 1, Nome = "ZaraHome", VendedorID = 1, FeiraID = 1 },
                new Stand { ID = 2, Nome = "Agriloja", VendedorID = 5, FeiraID = 2 },
                new Stand { ID = 3, Nome = "Pingo Doce", VendedorID = 1, FeiraID = 3 },
                new Stand { ID = 4, Nome = "Bertrand", VendedorID = 3, FeiraID = 4 },
                new Stand { ID = 5, Nome = "BMW", VendedorID = 4, FeiraID = 5 },
                new Stand { ID = 6, Nome = "IKEA", VendedorID = 1, FeiraID = 6 },
                new Stand { ID = 7, Nome = "Zara", VendedorID = 1, FeiraID = 7 },
                new Stand { ID = 8, Nome = "Leroy Merlin", VendedorID = 1, FeiraID = 8 },
                new Stand { ID = 9, Nome = "Animais e Companhia", VendedorID = 1, FeiraID = 9 },
                new Stand { ID = 10, Nome = "ToysRus", VendedorID = 1, FeiraID = 10 },
                new Stand { ID = 11, Nome = "CEX", VendedorID = 5, FeiraID = 11 },
                new Stand { ID = 12, Nome = "Worten", VendedorID = 5, FeiraID = 12 },
                new Stand { ID = 13, Nome = "WELLS", VendedorID = 2, FeiraID = 13 },
                new Stand { ID = 14, Nome = "Perfumes e Companhia", VendedorID = 1, FeiraID = 14 },
                new Stand { ID = 15, Nome = "Tien21", VendedorID = 1, FeiraID = 15 },
                new Stand { ID = 16, Nome = "Canon", VendedorID = 2, FeiraID = 16 },
                new Stand { ID = 17, Nome = "JBL", VendedorID = 6, FeiraID = 17 },
                new Stand { ID = 18, Nome = "WortenMobile", VendedorID = 1, FeiraID = 18 },
                new Stand { ID = 19, Nome = "PCDiga", VendedorID = 2, FeiraID = 19 },
                new Stand { ID = 20, Nome = "SoloPorteros", VendedorID = 6, FeiraID = 20 },
                new Stand { ID = 21, Nome = "Pilhas e Companhia", VendedorID = 1, FeiraID = 21 },
                new Stand { ID = 22, Nome = "Casa da Cama", VendedorID = 6, FeiraID = 1 },
                new Stand { ID = 23, Nome = "Quinta Lagares", VendedorID = 2, FeiraID = 2 },
                new Stand { ID = 24, Nome = "Mercado Central", VendedorID = 3, FeiraID = 3 },
                new Stand { ID = 25, Nome = "Livraria Santos", VendedorID = 3, FeiraID = 4 },
                new Stand { ID = 26, Nome = "Mercedes", VendedorID = 2, FeiraID = 5 },
                new Stand { ID = 27, Nome = "Papelaria Tavares", VendedorID = 1, FeiraID = 6 },
                new Stand { ID = 28, Nome = "H&M", VendedorID = 1, FeiraID = 7 },
                new Stand { ID = 29, Nome = "Ferra&Solda", VendedorID = 2, FeiraID = 8 },
                new Stand { ID = 30, Nome = "Pet Store", VendedorID = 1, FeiraID = 9 },
                new Stand { ID = 31, Nome = "Toys", VendedorID = 2, FeiraID = 10 },
                new Stand { ID = 32, Nome = "Joguinhos", VendedorID = 5, FeiraID = 11 },
                new Stand { ID = 33, Nome = "Escuta e Acampa", VendedorID = 1, FeiraID = 12 },
                new Stand { ID = 34, Nome = "Farmácia Loures", VendedorID = 6, FeiraID = 13 },
                new Stand { ID = 35, Nome = "Perfumaria Bela", VendedorID = 1, FeiraID = 14 },
                new Stand { ID = 36, Nome = "EletroTec", VendedorID = 1, FeiraID = 15 },
                new Stand { ID = 37, Nome = "Loja de Fotografia", VendedorID = 2, FeiraID = 16 },
                new Stand { ID = 38, Nome = "TecSom", VendedorID = 8, FeiraID = 17 },
                new Stand { ID = 39, Nome = "Pc Componentes", VendedorID = 7, FeiraID = 18 },
                new Stand { ID = 40, Nome = "InfoTec", VendedorID = 2, FeiraID = 19 },
                new Stand { ID = 41, Nome = "Decatlon", VendedorID = 7, FeiraID = 20 },
                new Stand { ID = 42, Nome = "Brindes", VendedorID = 2, FeiraID = 21 },
                new Stand { ID = 43, Nome = "Loja de Jardinagem", VendedorID = 1, FeiraID = 1 },
                new Stand { ID = 44, Nome = "Petshoping", VendedorID = 2, FeiraID = 2 },
                new Stand { ID = 45, Nome = "Feira Orgânica", VendedorID = 7, FeiraID = 3 },
                new Stand { ID = 46, Nome = "Livraria Souza", VendedorID = 6, FeiraID = 4 },
                new Stand { ID = 47, Nome = "Fiat", VendedorID = 2, FeiraID = 5 },
                new Stand { ID = 48, Nome = "Papelaria artesanal", VendedorID = 1, FeiraID = 6 },
                new Stand { ID = 49, Nome = "Pull & Bear", VendedorID = 3, FeiraID = 7 },
                new Stand { ID = 50, Nome = "FerraForte", VendedorID = 3, FeiraID = 8 },
                new Stand { ID = 51, Nome = "Pet&Comp", VendedorID = 3, FeiraID = 9 },
                new Stand { ID = 52, Nome = "Brincadeiras", VendedorID = 2, FeiraID = 10 },
                new Stand { ID = 53, Nome = "Loja de jogos digitais", VendedorID = 1, FeiraID = 11 },
                new Stand { ID = 54, Nome = "Puzzle Master", VendedorID = 3, FeiraID = 12 },
                new Stand { ID = 55, Nome = "Farmácia natural", VendedorID = 2, FeiraID = 13 },
                new Stand { ID = 56, Nome = "Perfumaria artesanal", VendedorID = 1, FeiraID = 14 },
                new Stand { ID = 57, Nome = "EletroFine", VendedorID = 3, FeiraID = 15 },
                new Stand { ID = 58, Nome = "Loja de Fotografia profissional", VendedorID = 2, FeiraID = 16 },
                new Stand { ID = 59, Nome = "Loja de Som", VendedorID = 4, FeiraID = 17 },
                new Stand { ID = 60, Nome = "TelePersona", VendedorID = 4, FeiraID = 18 },
                new Stand { ID = 61, Nome = "InformaTic", VendedorID = 2, FeiraID = 19 },
                new Stand { ID = 62, Nome = "Loja de desportos radicais", VendedorID = 8, FeiraID = 20 },
                new Stand { ID = 63, Nome = "Loja dos trezentos", VendedorID = 4, FeiraID = 21 }



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
                new Subcategoria { ID = 7, Descricao = "Higiene", StandID = 3 },
                new Subcategoria { ID = 8, Descricao = "Talho", StandID = 3 },
                new Subcategoria { ID = 9, Descricao = "Peixaria", StandID = 3 },
                new Subcategoria { ID = 10, Descricao = "Terror", StandID = 4 },
                new Subcategoria { ID = 11, Descricao = "Comédia", StandID = 4 },
                new Subcategoria { ID = 12, Descricao = "Romance", StandID = 4 },
                new Subcategoria { ID = 13, Descricao = "Elétricos", StandID = 5 },
                new Subcategoria { ID = 14, Descricao = "Gasóleo", StandID = 5 },
                new Subcategoria { ID = 15, Descricao = "Hibrídos", StandID = 5 },
                new Subcategoria { ID = 16, Descricao = "Secretárias", StandID = 6 },
                new Subcategoria { ID = 17, Descricao = "Tapetes", StandID = 6 },
                new Subcategoria { ID = 18, Descricao = "Cadeiras", StandID = 6 },
                new Subcategoria { ID = 19, Descricao = "Vestuário Masculino", StandID = 7 },
                new Subcategoria { ID = 20, Descricao = "Vestuário Feminino", StandID = 7 },
                new Subcategoria { ID = 21, Descricao = "Ferramentas Elétricas", StandID = 8 },
                new Subcategoria { ID = 22, Descricao = "Ferramentas Manuais", StandID = 8 },
                new Subcategoria { ID = 23, Descricao = "Cães", StandID = 9 },
                new Subcategoria { ID = 24, Descricao = "Gatos", StandID = 9 },
                new Subcategoria { ID = 25, Descricao = "Brinquedos para crianças", StandID = 10 },
                new Subcategoria { ID = 26, Descricao = "Jogos de tabuleiro", StandID = 10 },
                new Subcategoria { ID = 27, Descricao = "Consolas", StandID = 11 },
                new Subcategoria { ID = 28, Descricao = "Jogos", StandID = 11 },
                new Subcategoria { ID = 29, Descricao = "Bicicletas", StandID = 12 },
                new Subcategoria { ID = 30, Descricao = "Pesca", StandID = 12 },
                new Subcategoria { ID = 31, Descricao = "Remédios naturais", StandID = 13 },
                new Subcategoria { ID = 32, Descricao = "Produtos de beleza", StandID = 14 },
                new Subcategoria { ID = 33, Descricao = "Máquinas de lavar", StandID = 15 },
                new Subcategoria { ID = 34, Descricao = "Fogões", StandID = 15 },
                new Subcategoria { ID = 35, Descricao = "Câmaras", StandID = 16 },
                new Subcategoria { ID = 36, Descricao = "Lentes", StandID = 16 },
                new Subcategoria { ID = 37, Descricao = "Colunas", StandID = 17 },
                new Subcategoria { ID = 38, Descricao = "Microfones", StandID = 17 },
                new Subcategoria { ID = 39, Descricao = "Smartphones", StandID = 18 },
                new Subcategoria { ID = 40, Descricao = "Acessórios para smartphones", StandID = 18 },
                new Subcategoria { ID = 41, Descricao = "Computadores", StandID = 19 },
                new Subcategoria { ID = 42, Descricao = "Periféricos", StandID = 19 },
                new Subcategoria { ID = 43, Descricao = "Running", StandID = 20 },
                new Subcategoria { ID = 44, Descricao = "Fitness", StandID = 20 },
                new Subcategoria { ID = 45, Descricao = "Cozinha", StandID = 21 },
                new Subcategoria { ID = 46, Descricao = "Decoração interior", StandID = 21 },
                new Subcategoria { ID = 47, Descricao = "Aquecedores", StandID = 1 },
                new Subcategoria { ID = 48, Descricao = "Camas", StandID = 1 },
                new Subcategoria { ID = 49, Descricao = "Utensílios de cozinha", StandID = 3 },
                new Subcategoria { ID = 50, Descricao = "Artigos para animais exóticos", StandID = 2 },
                new Subcategoria { ID = 51, Descricao = "Artigos para equinos", StandID = 2 },
                new Subcategoria { ID = 52, Descricao = "Alimentos congelados", StandID = 3 },
                new Subcategoria { ID = 53, Descricao = "Artigos de papelaria", StandID = 4 },
                new Subcategoria { ID = 54, Descricao = "Artigos de arte", StandID = 4 },
                new Subcategoria { ID = 55, Descricao = "Motos", StandID = 5 },
                new Subcategoria { ID = 56, Descricao = "Carros Usados", StandID = 5 },
                new Subcategoria { ID = 57, Descricao = "Carros Novos", StandID = 5 },
                new Subcategoria { ID = 58, Descricao = "Material Escritório", StandID = 6 },
                new Subcategoria { ID = 59, Descricao = "Material Escolar", StandID = 6 },
                new Subcategoria { ID = 60, Descricao = "Acessórios de Moda", StandID = 7 },
                new Subcategoria { ID = 61, Descricao = "Material de Costura", StandID = 7 },
                new Subcategoria { ID = 62, Descricao = "Pintura e Revestimento", StandID = 8 },
                new Subcategoria { ID = 63, Descricao = "Material Elétrico", StandID = 8 },
                new Subcategoria { ID = 64, Descricao = "Roupas e Acessórios para animais", StandID = 9 },
                new Subcategoria { ID = 65, Descricao = "Recém-nascidos", StandID = 10 },
                new Subcategoria { ID = 66, Descricao = "Realidade virtual", StandID = 11 },
                new Subcategoria { ID = 67, Descricao = "RPG", StandID = 11 },
                new Subcategoria { ID = 68, Descricao = "Camping", StandID = 12 },
                new Subcategoria { ID = 69, Descricao = "Mochilas e equipamentos", StandID = 12 },
                new Subcategoria { ID = 70, Descricao = "Produtos orgânicos", StandID = 13 },
                new Subcategoria { ID = 71, Descricao = "Cosméticos", StandID = 14 },
                new Subcategoria { ID = 72, Descricao = "Eletrodomésticos de cozinha", StandID = 15 },
                new Subcategoria { ID = 73, Descricao = "Eletrodomésticos de limpeza", StandID = 15 }
            );

            modelBuilder.Entity<Produto>().HasData(
                new Produto { ID = 1, StandID = 1, Nome_Produto = "Maçãs", Preco = 2.9F, Promocao = 0, Stock = 3, Rating = 4, SubCategoriaID = 1 },
                new Produto { ID = 2, StandID = 2, Nome_Produto = "Bonecos", Preco = 25.9F, Promocao = 0, Stock = 2, Rating = 2, SubCategoriaID = 2 },
                new Produto { ID = 3, StandID = 3, Nome_Produto = "Tapetea", Preco = 23.9F, Promocao = 0, Stock = 1, Rating = 3, SubCategoriaID = 2 },
                new Produto { ID = 4, StandID = 4, Nome_Produto = "Celular", Preco = 299.9F, Promocao = 0, Stock = 20, Rating = 5, SubCategoriaID = 3 },
                new Produto { ID = 5, StandID = 5, Nome_Produto = "Livro", Preco = 15.99F, Promocao = 0, Stock = 15, Rating = 4, SubCategoriaID = 4 },
                new Produto { ID = 6, StandID = 6, Nome_Produto = "Caneca", Preco = 9.99F, Promocao = 0, Stock = 5, Rating = 3, SubCategoriaID = 5 },
                new Produto { ID = 7, StandID = 7, Nome_Produto = "Bola de futebol", Preco = 29.99F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 6 },
                new Produto { ID = 8, StandID = 8, Nome_Produto = "Perfume", Preco = 69.99F, Promocao = 0, Stock = 7, Rating = 5, SubCategoriaID = 7 },
                new Produto { ID = 9, StandID = 9, Nome_Produto = "Mala", Preco = 99.99F, Promocao = 0, Stock = 3, Rating = 2, SubCategoriaID = 8 },
                new Produto { ID = 10, StandID = 10, Nome_Produto = "Sapatos", Preco = 89.99F, Promocao = 0, Stock = 5, Rating = 4, SubCategoriaID = 9 },
                new Produto { ID = 11, StandID = 11, Nome_Produto = "Smartwatch", Preco = 199.99F, Promocao = 0, Stock = 8, Rating = 5, SubCategoriaID = 10 },
                new Produto { ID = 12, StandID = 12, Nome_Produto = "Fritadeira", Preco = 49.99F, Promocao = 0, Stock = 4, Rating = 3, SubCategoriaID = 11 },
                new Produto { ID = 13, StandID = 13, Nome_Produto = "Cadeira gamer", Preco = 129.99F, Promocao = 0, Stock = 2, Rating = 4, SubCategoriaID = 12 },
                new Produto { ID = 14, StandID = 14, Nome_Produto = "Bicicleta", Preco = 399.99F, Promocao = 0, Stock = 6, Rating = 5, SubCategoriaID = 13 },
                new Produto { ID = 15, StandID = 15, Nome_Produto = "Aspirador", Preco = 99.99F, Promocao = 0, Stock = 8, Rating = 4, SubCategoriaID = 14 },
                new Produto { ID = 16, StandID = 1, Nome_Produto = "Toalhas de banho", Preco = 12.9F, Promocao = 0, Stock = 7, Rating = 5, SubCategoriaID = 1 },
                new Produto { ID = 17, StandID = 2, Nome_Produto = "Ração para frangos", Preco = 3.9F, Promocao = 0, Stock = 6, Rating = 4, SubCategoriaID = 4 },
                new Produto { ID = 18, StandID = 3, Nome_Produto = "Carnes de porco", Preco = 15.9F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 8 },
                new Produto { ID = 19, StandID = 4, Nome_Produto = "Livro de terror", Preco = 8.9F, Promocao = 0, Stock = 5, Rating = 3, SubCategoriaID = 10 },
                new Produto { ID = 20, StandID = 5, Nome_Produto = "BMW elétrico", Preco = 65000.00F, Promocao = 0, Stock = 2, Rating = 5, SubCategoriaID = 13 },
                new Produto { ID = 21, StandID = 6, Nome_Produto = "Mesa de escritório", Preco = 150.00F, Promocao = 0, Stock = 4, Rating = 4, SubCategoriaID = 16 },
                new Produto { ID = 22, StandID = 7, Nome_Produto = "Camisola para homem", Preco = 25.00F, Promocao = 0, Stock = 10, Rating = 5, SubCategoriaID = 19 },
                new Produto { ID = 23, StandID = 8, Nome_Produto = "Serra circular", Preco = 150.00F, Promocao = 0, Stock = 3, Rating = 4, SubCategoriaID = 21 },
                new Produto { ID = 24, StandID = 9, Nome_Produto = "Ração para cães", Preco = 12.9F, Promocao = 0, Stock = 8, Rating = 5, SubCategoriaID = 23 },
                new Produto { ID = 25, StandID = 1, Nome_Produto = "Toalhas de banho", Preco = 15.99F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 1 },
                new Produto { ID = 26, StandID = 2, Nome_Produto = "Móveis de jardim", Preco = 299.99F, Promocao = 0, Stock = 5, Rating = 4, SubCategoriaID = 2 },
                new Produto { ID = 27, StandID = 3, Nome_Produto = "Eletrodomésticos de cozinha", Preco = 399.99F, Promocao = 0, Stock = 3, Rating = 5, SubCategoriaID = 3 },
                new Produto { ID = 28, StandID = 4, Nome_Produto = "Ração para cães", Preco = 9.99F, Promocao = 0, Stock = 20, Rating = 4, SubCategoriaID = 4 },
                new Produto { ID = 29, StandID = 5, Nome_Produto = "Frangos orgânicos", Preco = 7.99F, Promocao = 0, Stock = 15, Rating = 5, SubCategoriaID = 5 }
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