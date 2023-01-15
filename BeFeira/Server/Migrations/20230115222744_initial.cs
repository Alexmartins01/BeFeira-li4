using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeFeira.Server.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    UrlProfilePic = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Morada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pagamento = table.Column<int>(type: "int", nullable: false)
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
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { 1, new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3608), "1234", new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3652), "Bernas" },
                    { 2, new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3655), "2345", new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3656), "Cebolinha" },
                    { 3, new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3658), "3456", new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3659), "Sergio" },
                    { 4, new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3661), "1134", new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3662), "Anastásia" },
                    { 5, new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3664), "2245", new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3665), "Rodri" },
                    { 6, new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3666), "3453", new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(3667), "Jairzinho" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ID", "Email", "Password", "Total", "UrlProfilePic", "Username" },
                values: new object[,]
                {
                    { 1, "a1@uminho.pt", "sporting", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Pedro" },
                    { 2, "a2@uminho.pt", "benfica", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "João" },
                    { 3, "a3@uminho.pt", "porto", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Zé" },
                    { 4, "a4@uminho.pt", "sporting11", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Ana" },
                    { 5, "a5@uminho.pt", "benfica11", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Ivo" },
                    { 6, "a6@uminho.pt", "porto11", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Nestor" },
                    { 7, "a7@uminho.pt", "sporting22", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Paulo" },
                    { 8, "a8@uminho.pt", "benfica22", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Bruno" },
                    { 9, "a9@uminho.pt", "porto22", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Rui" },
                    { 10, "a10@uminho.pt", "sporting33", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Francisca" },
                    { 11, "a11@uminho.pt", "benfica33", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Patricia" },
                    { 12, "a12@uminho.pt", "porto33", 0f, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Luis" }
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
                columns: new[] { "ID", "Email", "Iban", "Mbway", "Password", "Rating", "UrlImage", "Username" },
                values: new object[,]
                {
                    { 1, "a13@uminho.pt", "1113231", "964888999", "0040", 9, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Lucas" },
                    { 2, "a14@uminho.pt", "3453661", "972822895", "0181", 6, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Jonny" },
                    { 3, "a15@uminho.pt", "8142831", "964457999", "2030", 7, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Ema" },
                    { 4, "a16@uminho.pt", "7403061", "932823894", "1161", 8, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Diana" },
                    { 5, "a17@uminho.pt", "1213221", "925679969", "0340", 9, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Jordi Alba" },
                    { 6, "a18@uminho.pt", "5333161", "923852594", "8481", 2, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Marcelo" },
                    { 7, "a19@uminho.pt", "0102831", "964646797", "9039", 5, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Puskas" },
                    { 8, "a20@uminho.pt", "6003261", "937733894", "3131", 10, "https://cdn-icons-png.flaticon.com/512/5087/5087579.png", "Eusébio" }
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
                    { 44, 2, "Petshopping", 2 },
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
                    { 63, 21, "Loja dos trezentos", 4 },
                    { 64, 1, "Home", 8 },
                    { 65, 7, "Complex", 8 },
                    { 66, 15, "Staples", 8 }
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
                    { 11, "Ação/Aventura", 4 },
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
                    { 50, "Carnes", 2 },
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
                    { 71, "Perfumes", 14 },
                    { 72, "Eletrodomésticos de cozinha", 15 },
                    { 73, "Eletrodomésticos de limpeza", 15 },
                    { 74, "Fruta Fresca", 24 },
                    { 75, "Tablets smartphones e outros", 19 },
                    { 76, "Utensilios cozinha", 19 },
                    { 77, "Basquetebol", 41 },
                    { 78, "Futebol", 41 },
                    { 79, "Nike", 65 },
                    { 80, "Adidas", 65 },
                    { 81, "Secretárias", 66 },
                    { 82, "Cadeiras", 66 },
                    { 83, "Arrumação", 66 },
                    { 84, "Rações", 44 },
                    { 85, "Animais vivos", 44 },
                    { 86, "Moveis exteriores", 43 },
                    { 87, "Mobilidade", 20 },
                    { 88, "Educação", 4 }
                });

            migrationBuilder.InsertData(
                table: "Venda",
                columns: new[] { "ID", "CarrinhoID", "Date", "Morada", "Pagamento", "Total" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(4122), "", 0, 0f },
                    { 2, 2, new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(4124), "", 0, 0f }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "ID", "Nome_Produto", "Preco", "Promocao", "Rating", "StandID", "Stock", "SubCategoriaID", "UrlImage" },
                values: new object[,]
                {
                    { 1, "Maçãs", 0.59f, 0, 4, 24, 12, 74, "https://www.imagensempng.com.br/wp-content/uploads/2021/07/Maca-Png.png" },
                    { 2, "Pêras", 0.79f, 20, 1, 24, 120, 74, "https://lusopera.com/wp-content/uploads/2018/12/img-intro-peras.jpg" },
                    { 3, "Melão", 10f, 5, 4, 24, 25, 74, "https://www.apolonia.com/fotos/produtos/91359_01_12-01-2018_g.jpg" },
                    { 4, "Manga", 5.9f, 0, 4, 24, 5, 74, "https://static.mundoeducacao.uol.com.br/mundoeducacao/2021/05/manga.jpg" },
                    { 5, "Bananas", 0.99f, 35, 4, 24, 150, 74, "https://live.staticflickr.com/65535/50026818621_47244bd8e7_b.jpg" },
                    { 6, "Morangos", 0.99f, 0, 4, 24, 12, 74, "https://i2.wp.com/www.lojaaporta.pt/wp-content/uploads/2021/01/MORANGOS-CAIXA-2KG.png?fit=500%2C500&ssl=1" },
                    { 7, "Bonecos", 25.9f, 0, 2, 10, 2, 25, "https://www.lulu-berlu.com/upload/image/-p-image-334992-grande.jpg" },
                    { 8, "Monopoly", 45.9f, 0, 2, 10, 2, 26, "https://www.toysrus.pt/medias/?context=bWFzdGVyfHByb2R1Y3RfaW1hZ2VzfDQ4OTcxfGltYWdlL2pwZWd8aDkyL2gwOC8xMTI3NDE5NjM4NTgyMnwyZjEwNTk5OGI5NjdkZmZjNmVhMzIyODE0NjE3YWJiMzFhOGM3MjJkNWE0ODc3YWI1NGI2ZTI3NTk1MDMxMWRh" },
                    { 9, "Peluches", 19.9f, 0, 2, 10, 2, 65, "https://www.macao.ubuy.com/productimg/?image=aHR0cHM6Ly9pNS53YWxtYXJ0aW1hZ2VzLmNvbS9hc3IvNGNkNzk5NjYtMDkzMS00OGRkLTljYjQtNmZiODBjNjI1OGQ2XzEuZDU0YTJmMTQ4ODViMmVhNjc1YTY2OGIzZTcwMWNmMGQuanBlZw.jpg" },
                    { 10, "Pop Figure", 15.9f, 0, 2, 10, 2, 25, "https://shop4nerds.pt/cms/produtos_imgs/produto_931/files/849803053055.jpg" },
                    { 11, "Carros de brincar", 25.9f, 0, 2, 10, 2, 25, "https://i.ebayimg.com/thumbs/images/g/7H0AAOSwWFtiBswI/s-l300.jpg" },
                    { 12, "Tapetes", 23.9f, 0, 3, 1, 1, 2, "https://www.casatapetesarraiolos.com/images/A17688-Pombinhas-177-x-122-PL.jpg" },
                    { 13, "Toalhas de mesa", 23.9f, 0, 3, 1, 1, 2, "https://www.lusatextil.pt/755/253.jpg" },
                    { 14, "Vasos interior", 14.9f, 0, 3, 1, 1, 2, "https://urbanjungle.pt/wp-content/uploads/2020/03/IMG_5520-600x750.jpg" },
                    { 15, "Samsung A52", 299.9f, 0, 5, 18, 20, 39, "https://images.samsung.com/is/image/samsung/p6pim/br/galaxy-a52/gallery/br-galaxy-a52-a525-379758-sm-a525mlvgzto-404505598?$650_519_PNG$" },
                    { 16, "Iphone XS", 500f, 0, 5, 18, 20, 39, "https://loja.iservices.pt/5060-large_default/iphone-xs.jpg" },
                    { 17, "Oneplus 8T", 399f, 0, 5, 18, 20, 39, "https://v9y9v6a3.rocketcdn.me/wp-content/uploads/2020/10/kiboTEK_oneplus_8t_014.png" },
                    { 18, "Pixel 7", 700f, 0, 5, 18, 20, 39, "https://s1.kuantokusta.pt/img_upload/produtos_comunicacoes/1315526_3_google-pixel-7-5g-6-3-8gb-128gb-obsidian.jpg" },
                    { 19, "Ipad mini", 499f, 0, 5, 19, 20, 75, "https://store.storeimages.cdn-apple.com/4668/as-images.apple.com/is/ipad-mini-finish-unselect-gallery-1-202207_FMT_WHH?wid=1280&hei=720&fmt=p-jpg&qlt=95&.v=1654903884450" },
                    { 20, "Portátil Asus Zenbook", 1399.9f, 0, 5, 19, 20, 41, "https://dlcdnwebimgs.asus.com/gain/55a72146-0976-465f-b270-8cc1b8c2fbfb/" },
                    { 21, "Earbuds sony", 299.9f, 0, 5, 19, 20, 42, "https://cdn.mos.cms.futurecdn.net/KEAtgEBKMDZemgDfY4hB4Z.jpg" },
                    { 22, "Monitor LG", 299.9f, 0, 5, 19, 20, 42, "https://www.lg.com/pt/images/monitores/MD05851557/gallery/27BK55_Product-image_01_Desk.jpg" },
                    { 23, "Xiaomi Mi6", 509.9f, 0, 5, 19, 20, 75, "https://cdn.weasy.io/users/xiaomi/catalog/xiaomi12_pink_01.png" },
                    { 24, "Livro All your perfects", 15.99f, 0, 4, 4, 15, 12, "https://kbimages1-a.akamaihd.net/284e157b-e503-412b-8adb-ac90a07e69fc/353/569/90/False/all-your-perfects.jpg" },
                    { 25, "Dicionário Português", 15.99f, 0, 4, 4, 15, 88, "https://img.bertrand.pt/images/dicionario-editora-da-lingua-portuguesa/NDV8MTI1Njk0fDIyNjI0ODgwfDE2NDg1NTIzMDgwMDA=/500x" },
                    { 26, "Livro Nicolas Spark", 15.99f, 0, 4, 4, 15, 12, "https://img.wook.pt/images/uma-vida-ao-teu-lado-nicholas-sparks/MXwxNjkzNjcyOXwxMjU1NjY1MnwxNDQ0MzgzMzEyMDAw/500x" },
                    { 27, "Harry potter", 15.99f, 0, 4, 4, 15, 11, "https://cdn.shopify.com/s/files/1/0450/0717/5837/products/image-1_85c1dfac-79f9-431e-b96b-7ab26d9de938_1024x1024.jpg?v=1636630533" },
                    { 28, "Divergente", 15.99f, 0, 4, 4, 15, 11, "https://static.fnac-static.com/multimedia/Images/PT/MC/72/cc/84/8703090/1540-1/tsp20160819200728/Divergente-Uma-Escolha-Pode-Te-Transformar-Trilogia-Divergente-Livro-1.jpg" },
                    { 29, "Caneca", 9.99f, 0, 3, 19, 5, 76, "https://www.ikea.com/my/en/images/products/vardagen-mug-dark-grey__0445777_pe596061_s5.jpg?f=s" },
                    { 30, "Bola de futebol", 29.99f, 0, 4, 41, 10, 78, "https://tm.ibxk.com.br/2014/05/19/19171133437584.jpg?ims=1200x675" },
                    { 31, "Camisola de equipa de futebol", 29.99f, 0, 4, 41, 10, 78, "https://www.dhresource.com/0x0/f2/albu/g17/M01/62/58/rBVa4l--dPmAatjtAAHi4lep_h4122.jpg" },
                    { 32, "NBA Jersey", 29.99f, 0, 4, 41, 10, 77, "https://vafloc02.s3.amazonaws.com/isyn/images/f523/img-3664523-f.jpg" },
                    { 33, "Nike mercurial chuteiras", 29.99f, 0, 4, 41, 10, 78, "https://static.globalnoticias.pt/jn/image.jpg?brand=JN&type=generate&guid=9b616978-12cb-4535-8545-f4f80207d927&w=744&h=495&t=20221029122838" },
                    { 34, "Kobe's 5", 79.99f, 0, 4, 41, 10, 77, "https://www.thenextsole.com/storage/images/CD4991-400.png" },
                    { 35, "Perfume", 69.99f, 0, 5, 14, 7, 71, "http://www.pluricosmetica.com/media/produtos/cache/face_800169_d7dbf-1200_1200.jpg" },
                    { 36, "Mala LV", 999.99f, 0, 2, 7, 3, 60, "http://cdn.shopify.com/s/files/1/0534/4418/2179/products/thumbnail_image7.jpg?v=1645455228" },
                    { 37, "Mala Gucci", 599.99f, 0, 2, 7, 3, 60, "https://cdn1.jolicloset.com/imgr/full/2022/06/554264-1/gucci-marrom-outro-mala-de-viagem.jpg" },
                    { 38, "Mala Guess", 149.99f, 0, 2, 7, 3, 60, "https://www.misscath.com/op/image/?co=946841&h=59204" },
                    { 39, "Jordan's 1 dunk low", 109.99f, 0, 4, 65, 5, 79, "http://cdn.shopify.com/s/files/1/0550/3657/5853/products/Air_Jordan_1_Low_Coconut_Milk-DC0774-121-0.png?v=1658831901" },
                    { 40, "Adidas Forum low", 119.99f, 0, 4, 65, 5, 80, "https://assets.adidas.com/images/w_600,f_auto,q_auto/6ef672a98ba34352b8c2aeb500d60995_9366/Sapatilhas_Forum_Low_Bege_H03475_09_standard.jpg" },
                    { 41, "yezzys", 509.99f, 0, 4, 65, 5, 80, "http://cdn.shopify.com/s/files/1/0550/3657/5853/products/Yeezy_Boost_350_V2_Core_Black_Red-BY9612-0.png?v=1659523925" },
                    { 42, "Jordan's dior", 25000f, 0, 4, 65, 5, 79, "https://cdn-images.farfetch-contents.com/15/65/12/84/15651284_28537785_600.jpg" },
                    { 43, "Adidas x KSI", 109.99f, 0, 4, 65, 5, 80, "https://houseofheat.co/app/uploads/2022/04/ksi-adidas-forum-hi-release-date-1.jpg" },
                    { 44, "Smartwatch garmin", 199.99f, 0, 5, 18, 8, 40, "https://res.garmin.com/en/products/010-02173-02/v/cf-lg-b773b34a-f08b-4dd8-a905-2daf306f2e6f-1.jpg" },
                    { 45, "Fritadeira", 49.99f, 0, 3, 15, 4, 72, "https://www.utensilioscozinha.pt/5155-large_default/fritadeira-eletrica-profissional.jpg" },
                    { 46, "Máquina de café", 69.99f, 0, 3, 15, 4, 72, "https://blog.kuantokusta.pt/wp-content/uploads/2021/11/Maquina-de-Cafe-Delonghi-Nespresso-Inissia-EN80-B.jpg" },
                    { 47, "Chaleira Elétrica", 49.99f, 0, 3, 15, 4, 72, "https://www.homa.pt/on/demandware.static/-/Sites-homa-catalog/default/dwc29ab76c/images/large/447816_chaleira_eletrica_vintage_cuisine_menta_homa_1.jpg" },
                    { 48, "Tostadeira", 29.99f, 0, 3, 15, 4, 72, "https://www.utensilioscozinha.pt/5083-large_default/tostadeira-eletrica-fatias-triangulares.jpg" },
                    { 49, "Cadeira gamer", 129.99f, 0, 4, 66, 2, 82, "https://images.hermanmiller.group/m/29fc4b934cd7d34d/W-200210_HM_Embody_Gaming_Chair_063_F3_V3_transparent.png?trim=auto&trim-sd=1&blend-mode=none&blend=fafafa&bg=transparent&auto=format&w=1000&q=70&h=1000" },
                    { 50, "Cadeira Escritório", 299.99f, 0, 4, 66, 2, 82, "https://spezzo.pt/wp-content/uploads/2020/11/aeron-Mineral_satin-mineral-1.jpg" },
                    { 51, "Secretária Escritório", 129.99f, 0, 4, 66, 2, 81, "https://homycasa.pt/50669-thickbox_default/secretaria-gamer-com-luz-led.jpg" },
                    { 52, "Arrumação Escritório", 229.99f, 0, 4, 66, 2, 83, "https://www.ikea.com/pt/pt/images/products/vihals-modulo-de-arrumacao-branco__1048516_pe843777_s5.jpg?f=s" },
                    { 53, "Bicicleta", 399.99f, 0, 5, 20, 6, 87, "https://resize.sprintercdn.com/o/products/ac52337c-b118-434c-ba97-b33a753ad982/bicicleta-infantil-spider-man-12-pulgadas-3-5-a-os_ac52337c-b118-434c-ba97-b33a753ad982_1_2107067539.jpg" },
                    { 54, "Trotinete", 79.99f, 0, 5, 20, 6, 87, "https://www.auchan.pt/dw/image/v2/BFRC_PRD/on/demandware.static/-/Sites-auchan-pt-master-catalog/default/dw95efa890/images/hi-res/003374633.jpg?sw=500&sh=500&sm=fit&bgcolor=FFFFFF" },
                    { 55, "Aspirador", 99.99f, 0, 4, 15, 8, 73, "https://www.electrofun.pt/27602-large_default/aspirador-robot-mi-vacuum-mop-essential-xiaomi.jpg" },
                    { 56, "Máquina de lavar roupa", 99.99f, 0, 4, 15, 8, 73, "https://s2.glbimg.com/NzitoDQGhjN6--RWdU8z85QMKmw=/e.glbimg.com/og/ed/f/original/2018/12/21/lava__seca_samsung_wd4000_de_10.2kg.jpg" },
                    { 57, "Toalhas de banho", 12.9f, 0, 5, 1, 7, 1, "https://a-static.mlcdn.com.br/800x560/jogo-de-toalhas-de-banho-buddemeyer-100-algodao-delicata-azul-5-pecas/magazineluiza/227741700/42a47093b438f2347721901a8696d5e5.jpg" },
                    { 58, "Ração para frangos", 3.9f, 0, 4, 2, 6, 4, "https://www.sohorta.pt/wp-content/uploads/2018/12/frangosmigalha-1.png" },
                    { 59, "Carnes de porco", 15.9f, 0, 4, 2, 10, 50, "https://delibrave.pt/wp-content/uploads/2020/05/00066.jpg" },
                    { 60, "Livro de terror", 8.9f, 0, 3, 4, 5, 10, "https://lirp.cdn-website.com/174487e2/dms3rep/multi/opt/exorcista-640w.jpeg" },
                    { 61, "BMW i8", 65000f, 0, 5, 5, 2, 13, "https://www.motor24.pt/files/2018/08/IMG_20180630_143131_Easy-Resize.com_-1.jpg" },
                    { 62, "Mesa de escritório", 150f, 0, 4, 66, 4, 81, "https://www.ikea.com/pt/pt/images/products/lagkapten-olov-secretaria-ef-carvalho-c-velatura-branca-branco__0977612_pe813682_s5.jpg?f=s" },
                    { 63, "Camisola para homem", 25f, 0, 5, 7, 10, 19, "https://photos6.spartoo.pt/photos/817/8173562/8173562_500_A.jpg" },
                    { 64, "Serra circular", 150f, 0, 4, 8, 3, 21, "https://depositocristina.com/wp-content/uploads/2022/03/918054a62bad62a09d953c675bda92e6.jpg" },
                    { 65, "Ração para cães", 12.9f, 0, 5, 2, 8, 4, "https://granjadecister.pt/1527-large_default/racao-cao-avenal-mix-20kg.jpg" },
                    { 66, "Toalhas de banho ginásio", 15.99f, 0, 4, 1, 10, 1, "https://static.sscontent.com/thumb/500/500/products/124/v988954_prozis_script-gym-towel-blue_single-size_blue_front.jpg" },
                    { 67, "Móveis de jardim", 299.99f, 0, 4, 43, 5, 86, "https://moveistore.com/wp-content/uploads/2022/04/Cadeira-de-Exterior-Trinity5.jpg" },
                    { 68, "Máquina de lavar loiça", 399.99f, 0, 5, 15, 3, 73, "https://whirlpool-cdn.thron.com/delivery/public/thumbnail/whirlpool/pi-743200f9-e158-441d-9d7e-f31d82618b87/jsind9/std/1000x1000/hfc-3c32-w-x-loi%C3%A7a.jpg?fill=zoom&fillcolor=rgba:255,255,255&scalemode=product" },
                    { 69, "Ração para cães", 9.99f, 0, 4, 44, 20, 84, "https://amoraospets.com/wp-content/uploads/2018/04/royal-canin.png" },
                    { 70, "Frangos caseiros", 7.99f, 0, 5, 44, 15, 85, "https://www.agromogiana.com.br/wp-content/uploads/2022/05/frango.jpg" },
                    { 71, "Bola de Basket", 29.99f, 0, 4, 41, 10, 77, "https://planetabasketstore.com/images/detailed/20/Wilson_Evolution_FPB_Logo_Ball_601.png" },
                    { 72, "Carnes de vaca", 15.9f, 0, 4, 2, 10, 50, "https://static.wikia.nocookie.net/minecraft_gamepedia/images/0/04/Steak_JE4_BE3.png/revision/latest/scale-to-width-down/160?cb=20190504055306" },
                    { 73, "Carnes de frango", 15.9f, 0, 4, 2, 10, 50, "https://static.wikia.nocookie.net/minecraft_gamepedia/images/6/66/Cooked_Chicken_JE3_BE3.png/revision/latest?cb=20200430031305" },
                    { 74, "Carnes de coelho", 15.9f, 0, 4, 2, 10, 50, "https://static.wikia.nocookie.net/minecraft_gamepedia/images/9/9f/Cooked_Rabbit_JE2_BE1.png/revision/latest?cb=20190505050744" },
                    { 75, "Ração para gatos", 12.9f, 0, 5, 2, 8, 4, "https://www.auchan.pt/dw/image/v2/BFRC_PRD/on/demandware.static/-/Sites-auchan-pt-master-catalog/default/dw380f6669/images/hi-res/003036197.jpg?sw=500&sh=500&sm=fit&bgcolor=FFFFFF" },
                    { 76, "SB Dunk low Travis Scott", 1700f, 15, 4, 65, 5, 79, "https://images.stockx.com/images/Nike-SB-Dunk-Low-Travis-Scott-Product.jpg?fit=fill&bg=FFFFFF&w=1200&h=857&fm=webp&auto=compress&dpr=2&trim=color&updated_at=1606325738&q=75" },
                    { 77, "Red October", 75000f, 3, 4, 65, 5, 80, "https://i.ebayimg.com/images/g/BYwAAOxyeZNTTIIg/s-l400.jpg" },
                    { 78, "Nike SB x Ben & Jerry’s Dunk Low Pro", 1000f, 15, 4, 65, 5, 79, "http://cdn.shopify.com/s/files/1/0550/3657/5853/products/SB_Dunk_Low_Ben_Jerry_s_Chunky_Dunky-CU3244-100-0.png?v=1658841197" },
                    { 79, "Abacaxi", 1.49f, 0, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/ab/ac/abacaxi-0-cke.jpg?auto_optimize=low" },
                    { 80, "Abacate", 4.49f, 15, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/ab/ac/abacate-cke.jpg" },
                    { 81, "Amora", 1.5f, 5, 4, 24, 12, 74, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cc/Blackberries_%28Rubus_fruticosus%29.jpg/250px-Blackberries_%28Rubus_fruticosus%29.jpg" },
                    { 82, "Mirtilo", 1.89f, 0, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/ba/ca/bacaba-cke.jpg?auto_optimize=low" },
                    { 83, "Diospiro", 2f, 0, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/ca/qu/caqui-cke.jpg?auto_optimize=low" },
                    { 84, "Cereja", 19.9f, 0, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/ce/re/cereja-cke.jpg?auto_optimize=low" },
                    { 85, "Coco", 39.9f, 20, 4, 24, 12, 74, "https://www.auchan.pt/dw/image/v2/BFRC_PRD/on/demandware.static/-/Sites-auchan-pt-master-catalog/default/dw3a1248f9/images/hi-res/000024110.jpg?sw=500&sh=500&sm=fit&bgcolor=FFFFFF" },
                    { 86, "Figo", 3.5f, 0, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/fr/ut/fruta18-0-cke.jpg?auto_optimize=low" },
                    { 87, "Framboesa", 10f, 50, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/fr/am/framboesa-cke.jpg?auto_optimize=low" },
                    { 88, "Groselha", 30f, 35, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/gr/os/groselha-0-cke.jpg?auto_optimize=low" },
                    { 89, "Kiwi", 3.29f, 0, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/fr/ut/fruta27kiwi-cke.jpg?auto_optimize=low" },
                    { 90, "Romã", 1.25f, 0, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/fr/ut/fruta44roma-cke.jpg?auto_optimize=low" },
                    { 91, "Tangerina", 0.7f, 0, 4, 24, 12, 74, "https://static.todamateria.com.br/upload/ta/ng/tangerina-cke.jpg?auto_optimize=low" }
                });

            migrationBuilder.InsertData(
                table: "Promocao",
                columns: new[] { "ID", "Date", "Desconto", "ProdutoID" },
                values: new object[] { 1, new DateTime(2023, 1, 15, 22, 27, 44, 520, DateTimeKind.Local).AddTicks(4099), 10, 1 });

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
