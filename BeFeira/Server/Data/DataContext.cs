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
                new Stand { ID = 44, Nome = "Petshopping", VendedorID = 2, FeiraID = 2 },
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
                new Stand { ID = 63, Nome = "Loja dos trezentos", VendedorID = 4, FeiraID = 21 },
                new Stand { ID = 64, Nome = "Home", VendedorID = 8, FeiraID = 1 },
                new Stand { ID = 65, Nome = "Complex", VendedorID = 8, FeiraID = 7 },
                new Stand { ID = 66, Nome = "Staples", VendedorID = 8, FeiraID = 15 }

            );

            modelBuilder.Entity<Carrinho>().HasData(
                new Carrinho { ID = 1, ClienteID = 1, Total = 0 },
                new Carrinho { ID = 2, ClienteID = 2, Total = 10 },
                new Carrinho { ID = 3, ClienteID = 3, Total = 5 }
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
                new Subcategoria { ID = 11, Descricao = "Ação/Aventura", StandID = 4 },
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
                new Subcategoria { ID = 50, Descricao = "Carnes", StandID = 2 },
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
                new Subcategoria { ID = 71, Descricao = "Perfumes", StandID = 14 },
                new Subcategoria { ID = 72, Descricao = "Eletrodomésticos de cozinha", StandID = 15 },
                new Subcategoria { ID = 73, Descricao = "Eletrodomésticos de limpeza", StandID = 15 },
                new Subcategoria { ID = 74, Descricao = "Fruta Fresca", StandID = 24 },
                new Subcategoria { ID = 75, Descricao = "Tablets smartphones e outros", StandID = 19 },
                new Subcategoria { ID = 76, Descricao = "Utensilios cozinha", StandID = 19 },
                new Subcategoria { ID = 77, Descricao = "Basquetebol", StandID = 41 },
                new Subcategoria { ID = 78, Descricao = "Futebol", StandID = 41 },
                new Subcategoria { ID = 79, Descricao = "Nike", StandID = 65 },
                new Subcategoria { ID = 80, Descricao = "Adidas", StandID = 65 },
                new Subcategoria { ID = 81, Descricao = "Secretárias", StandID = 66 },
                new Subcategoria { ID = 82, Descricao = "Cadeiras", StandID = 66 },
                new Subcategoria { ID = 83, Descricao = "Arrumação", StandID = 66 },
                new Subcategoria { ID = 84, Descricao = "Rações", StandID = 44 },
                new Subcategoria { ID = 85, Descricao = "Animais vivos", StandID = 44 },
                new Subcategoria { ID = 86, Descricao = "Moveis exteriores", StandID = 43 },
                new Subcategoria { ID = 87, Descricao = "Mobilidade", StandID = 20 },
                new Subcategoria { ID = 88, Descricao = "Educação", StandID = 4 }
            );

            modelBuilder.Entity<Produto>().HasData(
                // mercado central
                new Produto { ID = 1, StandID = 24, Nome_Produto = "Maçãs", Preco = 0.59F, Promocao = 0, Stock = 12, Rating = 4, SubCategoriaID = 74 , UrlImage = "https://www.imagensempng.com.br/wp-content/uploads/2021/07/Maca-Png.png" },
                new Produto { ID = 2, StandID = 24, Nome_Produto = "Pêras", Preco = 0.79F, Promocao = 20, Stock = 120, Rating = 1, SubCategoriaID = 74 , UrlImage = "https://lusopera.com/wp-content/uploads/2018/12/img-intro-peras.jpg" },
                new Produto { ID = 3, StandID = 24, Nome_Produto = "Melão", Preco = 10F, Promocao = 5, Stock = 25, Rating = 4, SubCategoriaID = 74 , UrlImage = "https://www.apolonia.com/fotos/produtos/91359_01_12-01-2018_g.jpg" },
                new Produto { ID = 4, StandID = 24, Nome_Produto = "Manga", Preco = 5.9F, Promocao = 0, Stock = 5, Rating = 4, SubCategoriaID = 74 , UrlImage = "https://static.mundoeducacao.uol.com.br/mundoeducacao/2021/05/manga.jpg" },
                new Produto { ID = 5, StandID = 24, Nome_Produto = "Bananas", Preco = 0.99F, Promocao = 35, Stock = 150, Rating = 4, SubCategoriaID = 74 , UrlImage = "https://live.staticflickr.com/65535/50026818621_47244bd8e7_b.jpg" },
                new Produto { ID = 6, StandID = 24, Nome_Produto = "Morangos", Preco = 0.99F, Promocao = 0, Stock = 12, Rating = 4, SubCategoriaID = 74 , UrlImage = "https://i2.wp.com/www.lojaaporta.pt/wp-content/uploads/2021/01/MORANGOS-CAIXA-2KG.png?fit=500%2C500&ssl=1" },
                new Produto { ID = 79, StandID = 24, Nome_Produto = "Abacaxi", Preco = 1.49F, Promocao = 0, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/ab/ac/abacaxi-0-cke.jpg?auto_optimize=low" },
                new Produto { ID = 80, StandID = 24, Nome_Produto = "Abacate", Preco = 4.49F, Promocao = 15, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/ab/ac/abacate-cke.jpg" },
                new Produto { ID = 81, StandID = 24, Nome_Produto = "Amora", Preco = 1.50F, Promocao = 5, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Blackberries_%28Rubus_fruticosus%29.jpg/250px-Blackberries_%28Rubus_fruticosus%29.jpg" },
                new Produto { ID = 82, StandID = 24, Nome_Produto = "Mirtilo", Preco = 1.89F, Promocao = 0, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/ba/ca/bacaba-cke.jpg?auto_optimize=low" },
                new Produto { ID = 83, StandID = 24, Nome_Produto = "Diospiro", Preco = 2.00F, Promocao = 0, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/ca/qu/caqui-cke.jpg?auto_optimize=low" },
                new Produto { ID = 84, StandID = 24, Nome_Produto = "Cereja", Preco = 19.90F, Promocao = 0, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/ce/re/cereja-cke.jpg?auto_optimize=low" },
                new Produto { ID = 85, StandID = 24, Nome_Produto = "Coco", Preco = 39.90F, Promocao = 20, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://www.auchan.pt/dw/image/v2/BFRC_PRD/on/demandware.static/-/Sites-auchan-pt-master-catalog/default/dw3a1248f9/images/hi-res/000024110.jpg?sw=500&sh=500&sm=fit&bgcolor=FFFFFF" },
                new Produto { ID = 86, StandID = 24, Nome_Produto = "Figo", Preco = 3.50F, Promocao = 0, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/fr/ut/fruta18-0-cke.jpg?auto_optimize=low" },
                new Produto { ID = 87, StandID = 24, Nome_Produto = "Framboesa", Preco = 10.00F, Promocao = 50, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/fr/am/framboesa-cke.jpg?auto_optimize=low" },
                new Produto { ID = 88, StandID = 24, Nome_Produto = "Groselha", Preco = 30.00F, Promocao = 35, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/gr/os/groselha-0-cke.jpg?auto_optimize=low" },
                new Produto { ID = 89, StandID = 24, Nome_Produto = "Kiwi", Preco = 3.29F, Promocao = 0, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/fr/ut/fruta27kiwi-cke.jpg?auto_optimize=low" },
                new Produto { ID = 90, StandID = 24, Nome_Produto = "Romã", Preco = 1.25F, Promocao = 0, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/fr/ut/fruta44roma-cke.jpg?auto_optimize=low" },
                new Produto { ID = 91, StandID = 24, Nome_Produto = "Tangerina", Preco = 0.70F, Promocao = 0, Stock = 12, Rating = 4, SubCategoriaID = 74, UrlImage = "https://static.todamateria.com.br/upload/ta/ng/tangerina-cke.jpg?auto_optimize=low" },
                //toysrus
                new Produto { ID = 7, StandID = 10, Nome_Produto = "Bonecos", Preco = 25.9F, Promocao = 0, Stock = 2, Rating = 2, SubCategoriaID = 25, UrlImage = "https://www.lulu-berlu.com/upload/image/-p-image-334992-grande.jpg" },
                new Produto { ID = 8, StandID = 10, Nome_Produto = "Monopoly", Preco = 45.9F, Promocao = 0, Stock = 2, Rating = 2, SubCategoriaID = 26, UrlImage = "https://www.toysrus.pt/medias/?context=bWFzdGVyfHByb2R1Y3RfaW1hZ2VzfDQ4OTcxfGltYWdlL2pwZWd8aDkyL2gwOC8xMTI3NDE5NjM4NTgyMnwyZjEwNTk5OGI5NjdkZmZjNmVhMzIyODE0NjE3YWJiMzFhOGM3MjJkNWE0ODc3YWI1NGI2ZTI3NTk1MDMxMWRh" },
                new Produto { ID = 9, StandID = 10, Nome_Produto = "Peluches", Preco = 19.9F, Promocao = 0, Stock = 2, Rating = 2, SubCategoriaID = 65, UrlImage = "https://www.macao.ubuy.com/productimg/?image=aHR0cHM6Ly9pNS53YWxtYXJ0aW1hZ2VzLmNvbS9hc3IvNGNkNzk5NjYtMDkzMS00OGRkLTljYjQtNmZiODBjNjI1OGQ2XzEuZDU0YTJmMTQ4ODViMmVhNjc1YTY2OGIzZTcwMWNmMGQuanBlZw.jpg" },
                new Produto { ID = 10, StandID = 10, Nome_Produto = "Pop Figure", Preco = 15.9F, Promocao = 0, Stock = 2, Rating = 2, SubCategoriaID = 25, UrlImage = "https://shop4nerds.pt/cms/produtos_imgs/produto_931/files/849803053055.jpg" },
                new Produto { ID = 11, StandID = 10, Nome_Produto = "Carros de brincar", Preco = 25.9F, Promocao = 0, Stock = 2, Rating = 2, SubCategoriaID = 25, UrlImage = "https://i.ebayimg.com/thumbs/images/g/7H0AAOSwWFtiBswI/s-l300.jpg" },
                //zara home
                new Produto { ID = 12, StandID = 1, Nome_Produto = "Tapetes", Preco = 23.9F, Promocao = 0, Stock = 1, Rating = 3, SubCategoriaID = 2, UrlImage = "https://www.casatapetesarraiolos.com/images/A17688-Pombinhas-177-x-122-PL.jpg" },
                new Produto { ID = 13, StandID = 1, Nome_Produto = "Toalhas de mesa", Preco = 23.9F, Promocao = 0, Stock = 1, Rating = 3, SubCategoriaID = 2, UrlImage = "https://www.lusatextil.pt/755/253.jpg" },
                new Produto { ID = 14, StandID = 1, Nome_Produto = "Vasos interior", Preco = 14.9F, Promocao = 0, Stock = 1, Rating = 3, SubCategoriaID = 2, UrlImage = "https://urbanjungle.pt/wp-content/uploads/2020/03/IMG_5520-600x750.jpg" },
                new Produto { ID = 57, StandID = 1, Nome_Produto = "Toalhas de banho", Preco = 12.9F, Promocao = 0, Stock = 7, Rating = 5, SubCategoriaID = 1, UrlImage = "https://a-static.mlcdn.com.br/800x560/jogo-de-toalhas-de-banho-buddemeyer-100-algodao-delicata-azul-5-pecas/magazineluiza/227741700/42a47093b438f2347721901a8696d5e5.jpg" },
                new Produto { ID = 66, StandID = 1, Nome_Produto = "Toalhas de banho ginásio", Preco = 15.99F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 1, UrlImage = "https://static.sscontent.com/thumb/500/500/products/124/v988954_prozis_script-gym-towel-blue_single-size_blue_front.jpg" },
                // worten mobile
                new Produto { ID = 15, StandID = 18, Nome_Produto = "Samsung A52", Preco = 299.9F, Promocao = 0, Stock = 20, Rating = 5, SubCategoriaID = 39, UrlImage = "https://images.samsung.com/is/image/samsung/p6pim/br/galaxy-a52/gallery/br-galaxy-a52-a525-379758-sm-a525mlvgzto-404505598?$650_519_PNG$" },
                new Produto { ID = 16, StandID = 18, Nome_Produto = "Iphone XS", Preco = 500F, Promocao = 0, Stock = 20, Rating = 5, SubCategoriaID = 39, UrlImage = "https://loja.iservices.pt/5060-large_default/iphone-xs.jpg" },
                new Produto { ID = 17, StandID = 18, Nome_Produto = "Oneplus 8T", Preco = 399F, Promocao = 0, Stock = 20, Rating = 5, SubCategoriaID = 39, UrlImage = "https://v9y9v6a3.rocketcdn.me/wp-content/uploads/2020/10/kiboTEK_oneplus_8t_014.png" },
                new Produto { ID = 18, StandID = 18, Nome_Produto = "Pixel 7", Preco = 700F, Promocao = 0, Stock = 20, Rating = 5, SubCategoriaID = 39, UrlImage = "https://s1.kuantokusta.pt/img_upload/produtos_comunicacoes/1315526_3_google-pixel-7-5g-6-3-8gb-128gb-obsidian.jpg" },
                new Produto { ID = 44, StandID = 18, Nome_Produto = "Smartwatch garmin", Preco = 199.99F, Promocao = 0, Stock = 8, Rating = 5, SubCategoriaID = 40, UrlImage = "https://res.garmin.com/en/products/010-02173-02/v/cf-lg-b773b34a-f08b-4dd8-a905-2daf306f2e6f-1.jpg" },
                // pc diga
                new Produto { ID = 19, StandID = 19, Nome_Produto = "Ipad mini", Preco = 499F, Promocao = 0, Stock = 20, Rating = 5, SubCategoriaID = 75, UrlImage = "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/ipad-mini-finish-unselect-gallery-1-202207_FMT_WHH?wid=1280&hei=720&fmt=p-jpg&qlt=95&.v=1654903884450" },
                new Produto { ID = 20, StandID = 19, Nome_Produto = "Portátil Asus Zenbook", Preco = 1399.9F, Promocao = 0, Stock = 20, Rating = 5, SubCategoriaID = 41, UrlImage = "https://dlcdnwebimgs.asus.com/gain/55a72146-0976-465f-b270-8cc1b8c2fbfb/" },
                new Produto { ID = 21, StandID = 19, Nome_Produto = "Earbuds sony", Preco = 299.9F, Promocao = 0, Stock = 20, Rating = 5, SubCategoriaID = 42, UrlImage = "https://cdn.mos.cms.futurecdn.net/KEAtgEBKMDZemgDfY4hB4Z.jpg" },
                new Produto { ID = 22, StandID = 19, Nome_Produto = "Monitor LG", Preco = 299.9F, Promocao = 0, Stock = 20, Rating = 5, SubCategoriaID = 42, UrlImage = "https://www.lg.com/pt/images/monitores/MD05851557/gallery/27BK55_Product-image_01_Desk.jpg" },
                new Produto { ID = 23, StandID = 19, Nome_Produto = "Xiaomi Mi6", Preco = 509.9F, Promocao = 0, Stock = 20, Rating = 5, SubCategoriaID = 75, UrlImage = "https://cdn.weasy.io/users/xiaomi/catalog/xiaomi12_pink_01.png" },
                // bertrand
                new Produto { ID = 24, StandID = 4, Nome_Produto = "Livro All your perfects", Preco = 15.99F, Promocao = 0, Stock = 15, Rating = 4, SubCategoriaID = 12, UrlImage = "https://kbimages1-a.akamaihd.net/284e157b-e503-412b-8adb-ac90a07e69fc/353/569/90/False/all-your-perfects.jpg" },
                new Produto { ID = 25, StandID = 4, Nome_Produto = "Dicionário Português", Preco = 15.99F, Promocao = 0, Stock = 15, Rating = 4, SubCategoriaID = 88, UrlImage = "https://img.bertrand.pt/images/dicionario-editora-da-lingua-portuguesa/NDV8MTI1Njk0fDIyNjI0ODgwfDE2NDg1NTIzMDgwMDA=/500x" },
                new Produto { ID = 26, StandID = 4, Nome_Produto = "Livro Nicolas Spark", Preco = 15.99F, Promocao = 0, Stock = 15, Rating = 4, SubCategoriaID = 12, UrlImage = "https://img.wook.pt/images/uma-vida-ao-teu-lado-nicholas-sparks/MXwxNjkzNjcyOXwxMjU1NjY1MnwxNDQ0MzgzMzEyMDAw/500x" },
                new Produto { ID = 27, StandID = 4, Nome_Produto = "Harry potter", Preco = 15.99F, Promocao = 0, Stock = 15, Rating = 4, SubCategoriaID = 11, UrlImage = "https://cdn.shopify.com/s/files/1/0450/0717/5837/products/image-1_85c1dfac-79f9-431e-b96b-7ab26d9de938_1024x1024.jpg?v=1636630533" },
                new Produto { ID = 28, StandID = 4, Nome_Produto = "Divergente", Preco = 15.99F, Promocao = 0, Stock = 15, Rating = 4, SubCategoriaID = 11, UrlImage = "https://static.fnac-static.com/multimedia/Images/PT/MC/72/cc/84/8703090/1540-1/tsp20160819200728/Divergente-Uma-Escolha-Pode-Te-Transformar-Trilogia-Divergente-Livro-1.jpg" },
                new Produto { ID = 60, StandID = 4, Nome_Produto = "Livro de terror", Preco = 8.9F, Promocao = 0, Stock = 5, Rating = 3, SubCategoriaID = 10, UrlImage = "https://lirp.cdn-website.com/174487e2/dms3rep/multi/opt/exorcista-640w.jpeg" },
                // home
                new Produto { ID = 29, StandID = 19, Nome_Produto = "Caneca", Preco = 9.99F, Promocao = 0, Stock = 5, Rating = 3, SubCategoriaID = 76, UrlImage = "https://www.ikea.com/my/en/images/products/vardagen-mug-dark-grey__0445777_pe596061_s5.jpg?f=s" },
                // Decatlon
                new Produto { ID = 30, StandID = 41, Nome_Produto = "Bola de futebol", Preco = 29.99F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 78, UrlImage = "https://tm.ibxk.com.br/2014/05/19/19171133437584.jpg?ims=1200x675" },
                new Produto { ID = 31, StandID = 41, Nome_Produto = "Camisola de equipa de futebol", Preco = 29.99F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 78, UrlImage = "https://www.dhresource.com/0x0/f2/albu/g17/M01/62/58/rBVa4l--dPmAatjtAAHi4lep_h4122.jpg" },
                new Produto { ID = 32, StandID = 41, Nome_Produto = "NBA Jersey", Preco = 29.99F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 77, UrlImage = "https://vafloc02.s3.amazonaws.com/isyn/images/f523/img-3664523-f.jpg" },
                new Produto { ID = 71, StandID = 41, Nome_Produto = "Bola de Basket", Preco = 29.99F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 77, UrlImage = "https://planetabasketstore.com/images/detailed/20/Wilson_Evolution_FPB_Logo_Ball_601.png" },
                new Produto { ID = 33, StandID = 41, Nome_Produto = "Nike mercurial chuteiras", Preco = 29.99F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 78, UrlImage = "https://static.globalnoticias.pt/jn/image.jpg?brand=JN&type=generate&guid=9b616978-12cb-4535-8545-f4f80207d927&w=744&h=495&t=20221029122838" },
                new Produto { ID = 34, StandID = 41, Nome_Produto = "Kobe's 5", Preco = 79.99F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 77, UrlImage = "https://www.thenextsole.com/storage/images/CD4991-400.png" },
                //Perfumes e Companhia
                new Produto { ID = 35, StandID = 14, Nome_Produto = "Perfume", Preco = 69.99F, Promocao = 0, Stock = 7, Rating = 5, SubCategoriaID = 71, UrlImage = "http://www.pluricosmetica.com/media/produtos/cache/face_800169_d7dbf-1200_1200.jpg" },
                //Zara
                new Produto { ID = 36, StandID = 7, Nome_Produto = "Mala LV", Preco = 999.99F, Promocao = 0, Stock = 3, Rating = 2, SubCategoriaID = 60, UrlImage = "http://cdn.shopify.com/s/files/1/0534/4418/2179/products/thumbnail_image7.jpg?v=1645455228" },
                new Produto { ID = 37, StandID = 7, Nome_Produto = "Mala Gucci", Preco = 599.99F, Promocao = 0, Stock = 3, Rating = 2, SubCategoriaID = 60, UrlImage = "https://cdn1.jolicloset.com/imgr/full/2022/06/554264-1/gucci-marrom-outro-mala-de-viagem.jpg" },
                new Produto { ID = 38, StandID = 7, Nome_Produto = "Mala Guess", Preco = 149.99F, Promocao = 0, Stock = 3, Rating = 2, SubCategoriaID = 60, UrlImage = "https://www.misscath.com/op/image/?co=946841&h=59204" },
                new Produto { ID = 63, StandID = 7, Nome_Produto = "Camisola para homem", Preco = 25.00F, Promocao = 0, Stock = 10, Rating = 5, SubCategoriaID = 19, UrlImage = "https://photos6.spartoo.pt/photos/817/8173562/8173562_500_A.jpg" },
                // Complex
                new Produto { ID = 39, StandID = 65, Nome_Produto = "Jordan's 1 dunk low", Preco = 109.99F, Promocao = 0, Stock = 5, Rating = 4, SubCategoriaID = 79, UrlImage = "http://cdn.shopify.com/s/files/1/0550/3657/5853/products/Air_Jordan_1_Low_Coconut_Milk-DC0774-121-0.png?v=1658831901" },
                new Produto { ID = 40, StandID = 65, Nome_Produto = "Adidas Forum low", Preco = 119.99F, Promocao = 0, Stock = 5, Rating = 4, SubCategoriaID = 80, UrlImage = "https://assets.adidas.com/images/w_600,f_auto,q_auto/6ef672a98ba34352b8c2aeb500d60995_9366/Sapatilhas_Forum_Low_Bege_H03475_09_standard.jpg" },
                new Produto { ID = 41, StandID = 65, Nome_Produto = "yezzys", Preco = 509.99F, Promocao = 0, Stock = 5, Rating = 4, SubCategoriaID = 80, UrlImage = "http://cdn.shopify.com/s/files/1/0550/3657/5853/products/Yeezy_Boost_350_V2_Core_Black_Red-BY9612-0.png?v=1659523925" },
                new Produto { ID = 42, StandID = 65, Nome_Produto = "Jordan's dior", Preco = 25000F, Promocao = 0, Stock = 5, Rating = 4, SubCategoriaID = 79, UrlImage = "https://cdn-images.farfetch-contents.com/15/65/12/84/15651284_28537785_600.jpg" },
                new Produto { ID = 43, StandID = 65, Nome_Produto = "Adidas x KSI", Preco = 109.99F, Promocao = 0, Stock = 5, Rating = 4, SubCategoriaID = 80, UrlImage = "https://houseofheat.co/app/uploads/2022/04/ksi-adidas-forum-hi-release-date-1.jpg" },
                new Produto { ID = 76, StandID = 65, Nome_Produto = "SB Dunk low Travis Scott", Preco = 1700F, Promocao = 15, Stock = 5, Rating = 4, SubCategoriaID = 79, UrlImage = "https://images.stockx.com/images/Nike-SB-Dunk-Low-Travis-Scott-Product.jpg?fit=fill&bg=FFFFFF&w=1200&h=857&fm=webp&auto=compress&dpr=2&trim=color&updated_at=1606325738&q=75" },
                new Produto { ID = 77, StandID = 65, Nome_Produto = "Red October", Preco = 75000F, Promocao = 3, Stock = 5, Rating = 4, SubCategoriaID = 80, UrlImage = "https://i.ebayimg.com/images/g/BYwAAOxyeZNTTIIg/s-l400.jpg" },
                new Produto { ID = 78, StandID = 65, Nome_Produto = "Nike SB x Ben & Jerry’s Dunk Low Pro", Preco = 1000F, Promocao = 15, Stock = 5, Rating = 4, SubCategoriaID = 79, UrlImage = "http://cdn.shopify.com/s/files/1/0550/3657/5853/products/SB_Dunk_Low_Ben_Jerry_s_Chunky_Dunky-CU3244-100-0.png?v=1658841197" },

                //Tien21
                new Produto { ID = 45, StandID = 15, Nome_Produto = "Fritadeira", Preco = 49.99F, Promocao = 0, Stock = 4, Rating = 3, SubCategoriaID = 72, UrlImage = "https://www.utensilioscozinha.pt/5155-large_default/fritadeira-eletrica-profissional.jpg" },
                new Produto { ID = 46, StandID = 15, Nome_Produto = "Máquina de café", Preco = 69.99F, Promocao = 0, Stock = 4, Rating = 3, SubCategoriaID = 72, UrlImage = "https://blog.kuantokusta.pt/wp-content/uploads/2021/11/Maquina-de-Cafe-Delonghi-Nespresso-Inissia-EN80-B.jpg" },
                new Produto { ID = 47, StandID = 15, Nome_Produto = "Chaleira Elétrica", Preco = 49.99F, Promocao = 0, Stock = 4, Rating = 3, SubCategoriaID = 72, UrlImage = "https://www.homa.pt/on/demandware.static/-/Sites-homa-catalog/default/dwc29ab76c/images/large/447816_chaleira_eletrica_vintage_cuisine_menta_homa_1.jpg" },
                new Produto { ID = 48, StandID = 15, Nome_Produto = "Tostadeira", Preco = 29.99F, Promocao = 0, Stock = 4, Rating = 3, SubCategoriaID = 72, UrlImage = "https://www.utensilioscozinha.pt/5083-large_default/tostadeira-eletrica-fatias-triangulares.jpg" },
                new Produto { ID = 55, StandID = 15, Nome_Produto = "Aspirador", Preco = 99.99F, Promocao = 0, Stock = 8, Rating = 4, SubCategoriaID = 73, UrlImage = "https://www.electrofun.pt/27602-large_default/aspirador-robot-mi-vacuum-mop-essential-xiaomi.jpg" },
                new Produto { ID = 56, StandID = 15, Nome_Produto = "Máquina de lavar roupa", Preco = 99.99F, Promocao = 0, Stock = 8, Rating = 4, SubCategoriaID = 73, UrlImage = "https://s2.glbimg.com/NzitoDQGhjN6--RWdU8z85QMKmw=/e.glbimg.com/og/ed/f/original/2018/12/21/lava__seca_samsung_wd4000_de_10.2kg.jpg" },
                new Produto { ID = 68, StandID = 15, Nome_Produto = "Máquina de lavar loiça", Preco = 399.99F, Promocao = 0, Stock = 3, Rating = 5, SubCategoriaID = 73, UrlImage = "https://whirlpool-cdn.thron.com/delivery/public/thumbnail/whirlpool/pi-743200f9-e158-441d-9d7e-f31d82618b87/jsind9/std/1000x1000/hfc-3c32-w-x-loi%C3%A7a.jpg?fill=zoom&fillcolor=rgba:255,255,255&scalemode=product" },
                //Staples
                new Produto { ID = 49, StandID = 66, Nome_Produto = "Cadeira gamer", Preco = 129.99F, Promocao = 0, Stock = 2, Rating = 4, SubCategoriaID = 82, UrlImage = "https://images.hermanmiller.group/m/29fc4b934cd7d34d/W-200210_HM_Embody_Gaming_Chair_063_F3_V3_transparent.png?trim=auto&trim-sd=1&blend-mode=none&blend=fafafa&bg=transparent&auto=format&w=1000&q=70&h=1000" },
                new Produto { ID = 50, StandID = 66, Nome_Produto = "Cadeira Escritório", Preco = 299.99F, Promocao = 0, Stock = 2, Rating = 4, SubCategoriaID = 82, UrlImage = "https://spezzo.pt/wp-content/uploads/2020/11/aeron-Mineral_satin-mineral-1.jpg" },
                new Produto { ID = 51, StandID = 66, Nome_Produto = "Secretária Escritório", Preco = 129.99F, Promocao = 0, Stock = 2, Rating = 4, SubCategoriaID = 81, UrlImage = "https://homycasa.pt/50669-thickbox_default/secretaria-gamer-com-luz-led.jpg" },
                new Produto { ID = 52, StandID = 66, Nome_Produto = "Arrumação Escritório", Preco = 229.99F, Promocao = 0, Stock = 2, Rating = 4, SubCategoriaID = 83, UrlImage = "https://www.ikea.com/pt/pt/images/products/vihals-modulo-de-arrumacao-branco__1048516_pe843777_s5.jpg?f=s" },
                new Produto { ID = 62, StandID = 66, Nome_Produto = "Mesa de escritório", Preco = 150.00F, Promocao = 0, Stock = 4, Rating = 4, SubCategoriaID = 81, UrlImage = "https://www.ikea.com/pt/pt/images/products/lagkapten-olov-secretaria-ef-carvalho-c-velatura-branca-branco__0977612_pe813682_s5.jpg?f=s" },
                //SoloPorteros
                new Produto { ID = 53, StandID = 20, Nome_Produto = "Bicicleta", Preco = 399.99F, Promocao = 0, Stock = 6, Rating = 5, SubCategoriaID = 87, UrlImage = "https://resize.sprintercdn.com/o/products/ac52337c-b118-434c-ba97-b33a753ad982/bicicleta-infantil-spider-man-12-pulgadas-3-5-a-os_ac52337c-b118-434c-ba97-b33a753ad982_1_2107067539.jpg" },
                new Produto { ID = 54, StandID = 20, Nome_Produto = "Trotinete", Preco = 79.99F, Promocao = 0, Stock = 6, Rating = 5, SubCategoriaID = 87, UrlImage = "https://www.auchan.pt/dw/image/v2/BFRC_PRD/on/demandware.static/-/Sites-auchan-pt-master-catalog/default/dw95efa890/images/hi-res/003374633.jpg?sw=500&sh=500&sm=fit&bgcolor=FFFFFF" },               
                // Agriloja
                new Produto { ID = 58, StandID = 2, Nome_Produto = "Ração para frangos", Preco = 3.9F, Promocao = 0, Stock = 6, Rating = 4, SubCategoriaID = 4, UrlImage = "https://www.sohorta.pt/wp-content/uploads/2018/12/frangosmigalha-1.png" },
                new Produto { ID = 59, StandID = 2, Nome_Produto = "Carnes de porco", Preco = 15.9F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 50, UrlImage = "https://delibrave.pt/wp-content/uploads/2020/05/00066.jpg" },
                new Produto { ID = 72, StandID = 2, Nome_Produto = "Carnes de vaca", Preco = 15.9F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 50, UrlImage = "https://static.wikia.nocookie.net/minecraft_gamepedia/images/0/04/Steak_JE4_BE3.png/revision/latest/scale-to-width-down/160?cb=20190504055306" },
                new Produto { ID = 73, StandID = 2, Nome_Produto = "Carnes de frango", Preco = 15.9F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 50, UrlImage = "https://static.wikia.nocookie.net/minecraft_gamepedia/images/6/66/Cooked_Chicken_JE3_BE3.png/revision/latest?cb=20200430031305" },
                new Produto { ID = 74, StandID = 2, Nome_Produto = "Carnes de coelho", Preco = 15.9F, Promocao = 0, Stock = 10, Rating = 4, SubCategoriaID = 50, UrlImage = "https://static.wikia.nocookie.net/minecraft_gamepedia/images/9/9f/Cooked_Rabbit_JE2_BE1.png/revision/latest?cb=20190505050744" },
                new Produto { ID = 65, StandID = 2, Nome_Produto = "Ração para cães", Preco = 12.9F, Promocao = 0, Stock = 8, Rating = 5, SubCategoriaID = 4, UrlImage = "https://granjadecister.pt/1527-large_default/racao-cao-avenal-mix-20kg.jpg" },
                new Produto { ID = 75, StandID = 2, Nome_Produto = "Ração para gatos", Preco = 12.9F, Promocao = 0, Stock = 8, Rating = 5, SubCategoriaID = 4, UrlImage = "https://www.auchan.pt/dw/image/v2/BFRC_PRD/on/demandware.static/-/Sites-auchan-pt-master-catalog/default/dw380f6669/images/hi-res/003036197.jpg?sw=500&sh=500&sm=fit&bgcolor=FFFFFF" },
                // bmw
                new Produto { ID = 61, StandID = 5, Nome_Produto = "BMW i8", Preco = 65000.00F, Promocao = 0, Stock = 2, Rating = 5, SubCategoriaID = 13, UrlImage = "https://www.motor24.pt/files/2018/08/IMG_20180630_143131_Easy-Resize.com_-1.jpg" },
                //Leroy
                new Produto { ID = 64, StandID = 8, Nome_Produto = "Serra circular", Preco = 150.00F, Promocao = 0, Stock = 3, Rating = 4, SubCategoriaID = 21, UrlImage = "https://depositocristina.com/wp-content/uploads/2022/03/918054a62bad62a09d953c675bda92e6.jpg" },
                // Loja de jardinagem
                new Produto { ID = 67, StandID = 43, Nome_Produto = "Móveis de jardim", Preco = 299.99F, Promocao = 0, Stock = 5, Rating = 4, SubCategoriaID = 86, UrlImage = "https://moveistore.com/wp-content/uploads/2022/04/Cadeira-de-Exterior-Trinity5.jpg" },
                //Petshopping
                new Produto { ID = 69, StandID = 44, Nome_Produto = "Ração para cães", Preco = 9.99F, Promocao = 0, Stock = 20, Rating = 4, SubCategoriaID = 84, UrlImage = "https://amoraospets.com/wp-content/uploads/2018/04/royal-canin.png" },
                new Produto { ID = 70, StandID = 44, Nome_Produto = "Frangos caseiros", Preco = 7.99F, Promocao = 0, Stock = 15, Rating = 5, SubCategoriaID = 85, UrlImage = "https://www.agromogiana.com.br/wp-content/uploads/2022/05/frango.jpg" }
            );

            modelBuilder.Entity<Promocao>().HasData(
                 new Promocao { ID = 1, ProdutoID = 1, Desconto = 10 }
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