using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeFeira.Server.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Createdat = table.Column<DateTime>(name: "Created_at", type: "datetime2", nullable: false),
                    Updatedat = table.Column<DateTime>(name: "Updated_at", type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Feira",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feira", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iban = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbway = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Carrinho_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Stand",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendedorID = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeiraID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stand", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Stand_Feira_FeiraID",
                        column: x => x.FeiraID,
                        principalTable: "Feira",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Stand_Vendedor_VendedorID",
                        column: x => x.VendedorID,
                        principalTable: "Vendedor",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrinhoID = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<float>(type: "real", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Venda_Carrinho_CarrinhoID",
                        column: x => x.CarrinhoID,
                        principalTable: "Carrinho",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Subcategoria",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategoria", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Subcategoria_Stand_StandID",
                        column: x => x.StandID,
                        principalTable: "Stand",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandID = table.Column<int>(type: "int", nullable: true),
                    NomeProduto = table.Column<string>(name: "Nome_Produto", type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    Promocao = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    urlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoriaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produto_Stand_StandID",
                        column: x => x.StandID,
                        principalTable: "Stand",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Produto_Subcategoria_SubCategoriaID",
                        column: x => x.SubCategoriaID,
                        principalTable: "Subcategoria",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CarrinhoProduto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrinhoID = table.Column<int>(type: "int", nullable: true),
                    ProdutoID = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    TaxaBefeira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoProduto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_Carrinho_CarrinhoID",
                        column: x => x.CarrinhoID,
                        principalTable: "Carrinho",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CarrinhoProduto_Produto_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Produto",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Promocao",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoID = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Desconto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promocao", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Promocao_Produto_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Produto",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "VendaProduto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendaID = table.Column<int>(type: "int", nullable: true),
                    ProdutoID = table.Column<int>(type: "int", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    TaxaBefeira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaProduto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VendaProduto_Produto_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Produto",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_VendaProduto_Venda_VendaID",
                        column: x => x.VendaID,
                        principalTable: "Venda",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Administrador",
                columns: new[] { "ID", "Created_at", "Password", "Updated_at", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3070), "1234", new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3121), "Bernas" },
                    { 2, new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3125), "2345", new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3126), "Cebolinha" },
                    { 3, new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3129), "3456", new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3130), "Sergio" },
                    { 4, new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3133), "1134", new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3134), "Anastásia" },
                    { 5, new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3136), "2245", new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3138), "Rodri" },
                    { 6, new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3140), "3453", new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3142), "Jairzinho" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ID", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "a1@uminho.pt", "sporting", "Pedro" },
                    { 2, "a2@uminho.pt", "benfica", "João" },
                    { 3, "a3@uminho.pt", "porto", "Zé" },
                    { 4, "a4@uminho.pt", "sporting11", "Ana" },
                    { 5, "a5@uminho.pt", "benfica11", "Ivo" },
                    { 6, "a6@uminho.pt", "porto11", "Nestor" },
                    { 7, "a7@uminho.pt", "sporting22", "Paulo" },
                    { 8, "a8@uminho.pt", "benfica22", "Bruno" },
                    { 9, "a9@uminho.pt", "porto22", "Rui" },
                    { 10, "a10@uminho.pt", "sporting33", "Francisca" },
                    { 11, "a11@uminho.pt", "benfica33", "Patricia" },
                    { 12, "a12@uminho.pt", "porto33", "Luis" }
                });

            migrationBuilder.InsertData(
                table: "Feira",
                columns: new[] { "ID", "Categoria" },
                values: new object[,]
                {
                    { 1, "Casa e Decoração" },
                    { 2, "Animais" },
                    { 3, "Mercearia e Produtos Frescos" },
                    { 4, "Cultura" },
                    { 5, "Véiculos" },
                    { 6, "Escritório" },
                    { 7, "Moda" },
                    { 8, "Bricolagem" },
                    { 9, "Animais de Estimação" },
                    { 10, "Brinquedos" },
                    { 11, "Gaming" },
                    { 12, "Lazer" },
                    { 13, "Saúde" },
                    { 14, "Beleza" },
                    { 15, "Eletrodomésticos" },
                    { 16, "Imagem" },
                    { 17, "Som" },
                    { 18, "Smartphones e Acessórios" },
                    { 19, "Informática" },
                    { 20, "Desporto" },
                    { 21, "Random" }
                });

            migrationBuilder.InsertData(
                table: "Vendedor",
                columns: new[] { "ID", "Email", "Iban", "Mbway", "Password", "Rating", "Username" },
                values: new object[,]
                {
                    { 1, "a13@uminho.pt", "1113231", "964888999", "0040", 9, "Lucas" },
                    { 2, "a14@uminho.pt", "3453661", "972822895", "0181", 6, "Jonny" },
                    { 3, "a15@uminho.pt", "8142831", "964457999", "2030", 7, "Ema" },
                    { 4, "a16@uminho.pt", "7403061", "932823894", "1161", 8, "Diana" },
                    { 5, "a17@uminho.pt", "1213221", "925679969", "0340", 9, "Jordi Alba" },
                    { 6, "a18@uminho.pt", "5333161", "923852594", "8481", 2, "Marcelo" },
                    { 7, "a19@uminho.pt", "0102831", "964646797", "9039", 5, "Puskas" },
                    { 8, "a20@uminho.pt", "6003261", "937733894", "3131", 10, "Eusébio" }
                });

            migrationBuilder.InsertData(
                table: "Carrinho",
                columns: new[] { "ID", "ClienteID", "Total" },
                values: new object[,]
                {
                    { 1, 1, 0m },
                    { 2, 2, 10m },
                    { 3, 3, 5m }
                });

            migrationBuilder.InsertData(
                table: "Stand",
                columns: new[] { "ID", "FeiraID", "Nome", "VendedorID" },
                values: new object[,]
                {
                    { 1, 1, "ZaraHome", 1 },
                    { 2, 2, "Agriloja", 5 },
                    { 3, 3, "Pingo Doce", 1 },
                    { 4, 4, "Bertrand", 3 },
                    { 5, 5, "BMW", 4 },
                    { 6, 6, "IKEA", 1 },
                    { 7, 7, "Zara", 1 },
                    { 8, 8, "Leroy Merlin", 1 },
                    { 9, 9, "Animais e Companhia", 1 },
                    { 10, 10, "ToysRus", 1 },
                    { 11, 11, "CEX", 5 },
                    { 12, 12, "Worten", 5 },
                    { 13, 13, "WELLS", 2 },
                    { 14, 14, "Perfumes e Companhia", 1 },
                    { 15, 15, "Tien21", 1 },
                    { 16, 16, "Canon", 2 },
                    { 17, 17, "JBL", 6 },
                    { 18, 18, "WortenMobile", 1 },
                    { 19, 19, "PCDiga", 2 },
                    { 20, 20, "SoloPorteros", 6 },
                    { 21, 21, "Pilhas e Companhia", 1 },
                    { 22, 1, "Casa da Cama", 6 },
                    { 23, 2, "Quinta Lagares", 2 },
                    { 24, 3, "Mercado Central", 3 },
                    { 25, 4, "Livraria Santos", 3 },
                    { 26, 5, "Mercedes", 2 },
                    { 27, 6, "Papelaria Tavares", 1 },
                    { 28, 7, "H&M", 1 },
                    { 29, 8, "Ferra&Solda", 2 },
                    { 30, 9, "Pet Store", 1 },
                    { 31, 10, "Toys", 2 },
                    { 32, 11, "Joguinhos", 5 },
                    { 33, 12, "Escuta e Acampa", 1 },
                    { 34, 13, "Farmácia Loures", 6 },
                    { 35, 14, "Perfumaria Bela", 1 },
                    { 36, 15, "EletroTec", 1 },
                    { 37, 16, "Loja de Fotografia", 2 },
                    { 38, 17, "TecSom", 8 },
                    { 39, 18, "Pc Componentes", 7 },
                    { 40, 19, "InfoTec", 2 },
                    { 41, 20, "Decatlon", 7 },
                    { 42, 21, "Brindes", 2 },
                    { 43, 1, "Loja de Jardinagem", 1 },
                    { 44, 2, "Petshoping", 2 },
                    { 45, 3, "Feira Orgânica", 7 },
                    { 46, 4, "Livraria Souza", 6 },
                    { 47, 5, "Fiat", 2 },
                    { 48, 6, "Papelaria artesanal", 1 },
                    { 49, 7, "Pull & Bear", 3 },
                    { 50, 8, "FerraForte", 3 },
                    { 51, 9, "Pet&Comp", 3 },
                    { 52, 10, "Brincadeiras", 2 },
                    { 53, 11, "Loja de jogos digitais", 1 },
                    { 54, 12, "Puzzle Master", 3 },
                    { 55, 13, "Farmácia natural", 2 },
                    { 56, 14, "Perfumaria artesanal", 1 },
                    { 57, 15, "EletroFine", 3 },
                    { 58, 16, "Loja de Fotografia profissional", 2 },
                    { 59, 17, "Loja de Som", 4 },
                    { 60, 18, "TelePersona", 4 },
                    { 61, 19, "InformaTic", 2 },
                    { 62, 20, "Loja de desportos radicais", 8 },
                    { 63, 21, "Loja dos trezentos", 4 }
                });

            migrationBuilder.InsertData(
                table: "Subcategoria",
                columns: new[] { "ID", "Descricao", "StandID" },
                values: new object[,]
                {
                    { 1, "Casa de Banho", 1 },
                    { 2, "Sala", 1 },
                    { 3, "Cozinha", 1 },
                    { 4, "Rações", 2 },
                    { 5, "Frangos", 2 },
                    { 6, "Coelhos", 2 },
                    { 7, "Higiene", 3 },
                    { 8, "Talho", 3 },
                    { 9, "Peixaria", 3 },
                    { 10, "Terror", 4 },
                    { 11, "Comédia", 4 },
                    { 12, "Romance", 4 },
                    { 13, "Elétricos", 5 },
                    { 14, "Gasóleo", 5 },
                    { 15, "Hibrídos", 5 },
                    { 16, "Secretárias", 6 },
                    { 17, "Tapetes", 6 },
                    { 18, "Cadeiras", 6 },
                    { 19, "Vestuário Masculino", 7 },
                    { 20, "Vestuário Feminino", 7 },
                    { 21, "Ferramentas Elétricas", 8 },
                    { 22, "Ferramentas Manuais", 8 },
                    { 23, "Cães", 9 },
                    { 24, "Gatos", 9 },
                    { 25, "Brinquedos para crianças", 10 },
                    { 26, "Jogos de tabuleiro", 10 },
                    { 27, "Consolas", 11 },
                    { 28, "Jogos", 11 },
                    { 29, "Bicicletas", 12 },
                    { 30, "Pesca", 12 },
                    { 31, "Remédios naturais", 13 },
                    { 32, "Produtos de beleza", 14 },
                    { 33, "Máquinas de lavar", 15 },
                    { 34, "Fogões", 15 },
                    { 35, "Câmaras", 16 },
                    { 36, "Lentes", 16 },
                    { 37, "Colunas", 17 },
                    { 38, "Microfones", 17 },
                    { 39, "Smartphones", 18 },
                    { 40, "Acessórios para smartphones", 18 },
                    { 41, "Computadores", 19 },
                    { 42, "Periféricos", 19 },
                    { 43, "Running", 20 },
                    { 44, "Fitness", 20 },
                    { 45, "Cozinha", 21 },
                    { 46, "Decoração interior", 21 },
                    { 47, "Aquecedores", 1 },
                    { 48, "Camas", 1 },
                    { 49, "Utensílios de cozinha", 3 },
                    { 50, "Artigos para animais exóticos", 2 },
                    { 51, "Artigos para equinos", 2 },
                    { 52, "Alimentos congelados", 3 },
                    { 53, "Artigos de papelaria", 4 },
                    { 54, "Artigos de arte", 4 },
                    { 55, "Motos", 5 },
                    { 56, "Carros Usados", 5 },
                    { 57, "Carros Novos", 5 },
                    { 58, "Material Escritório", 6 },
                    { 59, "Material Escolar", 6 },
                    { 60, "Acessórios de Moda", 7 },
                    { 61, "Material de Costura", 7 },
                    { 62, "Pintura e Revestimento", 8 },
                    { 63, "Material Elétrico", 8 },
                    { 64, "Roupas e Acessórios para animais", 9 },
                    { 65, "Recém-nascidos", 10 },
                    { 66, "Realidade virtual", 11 },
                    { 67, "RPG", 11 },
                    { 68, "Camping", 12 },
                    { 69, "Mochilas e equipamentos", 12 },
                    { 70, "Produtos orgânicos", 13 },
                    { 71, "Cosméticos", 14 },
                    { 72, "Eletrodomésticos de cozinha", 15 },
                    { 73, "Eletrodomésticos de limpeza", 15 }
                });

            migrationBuilder.InsertData(
                table: "Venda",
                columns: new[] { "ID", "CarrinhoID", "Date", "Total" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3620), 0f },
                    { 2, 2, new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3623), 0f }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "ID", "Nome_Produto", "Preco", "Promocao", "Rating", "StandID", "Stock", "SubCategoriaID", "urlImage" },
                values: new object[,]
                {
                    { 1, "Maçãs", 2.9f, 0, 4, 1, 3, 1, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 2, "Bonecos", 25.9f, 0, 2, 2, 2, 2, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 3, "Tapetea", 23.9f, 0, 3, 3, 1, 2, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 4, "Celular", 299.9f, 0, 5, 4, 20, 3, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 5, "Livro", 15.99f, 0, 4, 5, 15, 4, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 6, "Caneca", 9.99f, 0, 3, 6, 5, 5, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 7, "Bola de futebol", 29.99f, 0, 4, 7, 10, 6, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 8, "Perfume", 69.99f, 0, 5, 8, 7, 7, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 9, "Mala", 99.99f, 0, 2, 9, 3, 8, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 10, "Sapatos", 89.99f, 0, 4, 10, 5, 9, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 11, "Smartwatch", 199.99f, 0, 5, 11, 8, 10, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 12, "Fritadeira", 49.99f, 0, 3, 12, 4, 11, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 13, "Cadeira gamer", 129.99f, 0, 4, 13, 2, 12, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 14, "Bicicleta", 399.99f, 0, 5, 14, 6, 13, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 15, "Aspirador", 99.99f, 0, 4, 15, 8, 14, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 16, "Toalhas de banho", 12.9f, 0, 5, 1, 7, 1, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 17, "Ração para frangos", 3.9f, 0, 4, 2, 6, 4, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 18, "Carnes de porco", 15.9f, 0, 4, 3, 10, 8, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 19, "Livro de terror", 8.9f, 0, 3, 4, 5, 10, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 20, "BMW elétrico", 65000f, 0, 5, 5, 2, 13, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 21, "Mesa de escritório", 150f, 0, 4, 6, 4, 16, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 22, "Camisola para homem", 25f, 0, 5, 7, 10, 19, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 23, "Serra circular", 150f, 0, 4, 8, 3, 21, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 24, "Ração para cães", 12.9f, 0, 5, 9, 8, 23, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 25, "Toalhas de banho", 15.99f, 0, 4, 1, 10, 1, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 26, "Móveis de jardim", 299.99f, 0, 4, 2, 5, 2, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 27, "Eletrodomésticos de cozinha", 399.99f, 0, 5, 3, 3, 3, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 28, "Ração para cães", 9.99f, 0, 4, 4, 20, 4, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" },
                    { 29, "Frangos orgânicos", 7.99f, 0, 5, 5, 15, 5, "https://www.freepnglogos.com/uploads/box-png/box-png-transparent-google-objects-pinterest-9.png" }
                });

            migrationBuilder.InsertData(
                table: "CarrinhoProduto",
                columns: new[] { "ID", "CarrinhoID", "Preco", "ProdutoID", "Quantidade", "TaxaBefeira" },
                values: new object[,]
                {
                    { 1, 1, 10f, 1, 1, 10 },
                    { 2, 2, 120f, 2, 4, 10 },
                    { 3, 3, 22f, 3, 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "Promocao",
                columns: new[] { "ID", "Date", "Desconto", "ProdutoID" },
                values: new object[] { 1, new DateTime(2023, 1, 14, 23, 50, 1, 738, DateTimeKind.Local).AddTicks(3571), 10, 1 });

            migrationBuilder.InsertData(
                table: "VendaProduto",
                columns: new[] { "ID", "Preco", "ProdutoID", "Quantidade", "TaxaBefeira", "VendaID" },
                values: new object[,]
                {
                    { 1, 10f, 1, 2, 10, 1 },
                    { 2, 20f, 3, 3, 10, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_ClienteID",
                table: "Carrinho",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProduto_CarrinhoID",
                table: "CarrinhoProduto",
                column: "CarrinhoID");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoProduto_ProdutoID",
                table: "CarrinhoProduto",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_StandID",
                table: "Produto",
                column: "StandID");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_SubCategoriaID",
                table: "Produto",
                column: "SubCategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Promocao_ProdutoID",
                table: "Promocao",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Stand_FeiraID",
                table: "Stand",
                column: "FeiraID");

            migrationBuilder.CreateIndex(
                name: "IX_Stand_VendedorID",
                table: "Stand",
                column: "VendedorID");

            migrationBuilder.CreateIndex(
                name: "IX_Subcategoria_StandID",
                table: "Subcategoria",
                column: "StandID");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_CarrinhoID",
                table: "Venda",
                column: "CarrinhoID");

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_ProdutoID",
                table: "VendaProduto",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_VendaProduto_VendaID",
                table: "VendaProduto",
                column: "VendaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "CarrinhoProduto");

            migrationBuilder.DropTable(
                name: "Promocao");

            migrationBuilder.DropTable(
                name: "VendaProduto");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Subcategoria");

            migrationBuilder.DropTable(
                name: "Carrinho");

            migrationBuilder.DropTable(
                name: "Stand");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Feira");

            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
