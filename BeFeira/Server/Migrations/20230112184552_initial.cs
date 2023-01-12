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
                name: "Carrinho",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: true),
                    StandID = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Carrinho_Stand_StandID",
                        column: x => x.StandID,
                        principalTable: "Stand",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    { 1, new DateTime(2023, 1, 12, 18, 45, 51, 956, DateTimeKind.Local).AddTicks(2889), "1234", new DateTime(2023, 1, 12, 18, 45, 51, 956, DateTimeKind.Local).AddTicks(2932), "Bernas" },
                    { 2, new DateTime(2023, 1, 12, 18, 45, 51, 956, DateTimeKind.Local).AddTicks(2936), "2345", new DateTime(2023, 1, 12, 18, 45, 51, 956, DateTimeKind.Local).AddTicks(2937), "Cebolinha" },
                    { 3, new DateTime(2023, 1, 12, 18, 45, 51, 956, DateTimeKind.Local).AddTicks(2939), "3456", new DateTime(2023, 1, 12, 18, 45, 51, 956, DateTimeKind.Local).AddTicks(2940), "Sergio" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ID", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "a@uminho.pt", "sporting", "pedro" },
                    { 2, "a@uminho.pt", "benfica", "joao" },
                    { 3, "a@uminho.pt", "porto", "ze" }
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
                    { 1, "a@uminho.pt", "1113231", "964888999", "0000", 9, "Lucas" },
                    { 2, "a@uminho.pt", "3453661", "96282289", "0101", 6, "Jonny" }
                });

            migrationBuilder.InsertData(
                table: "Stand",
                columns: new[] { "ID", "FeiraID", "Nome", "VendedorID" },
                values: new object[,]
                {
                    { 1, 1, "ZaraHome", 1 },
                    { 2, 2, "Agriloja", 1 },
                    { 3, 3, "Pingo Doce", 1 },
                    { 4, 4, "Bertrand", 1 },
                    { 5, 5, "BMW", 1 },
                    { 6, 6, "IKEA", 1 },
                    { 7, 7, "Zara", 1 },
                    { 8, 8, "Leroy Merlin", 1 },
                    { 9, 9, "Animais e Companhia", 1 },
                    { 10, 10, "ToysRus", 1 },
                    { 11, 11, "CEX", 2 },
                    { 12, 12, "Worten", 1 },
                    { 13, 13, "WELLS", 2 },
                    { 14, 14, "Perfumes e Companhia", 1 },
                    { 15, 15, "Tien21", 1 },
                    { 16, 16, "Canon", 2 },
                    { 17, 17, "JBL", 1 },
                    { 18, 18, "WortenMobile", 1 },
                    { 19, 19, "PCDiga", 2 },
                    { 20, 20, "SoloPorteros", 1 },
                    { 21, 21, "Pilhas e Companhia", 1 }
                });

            migrationBuilder.InsertData(
                table: "Carrinho",
                columns: new[] { "ID", "ClienteID", "StandID", "Total" },
                values: new object[,]
                {
                    { 1, 1, 1, 0m },
                    { 2, 2, 2, 10m },
                    { 3, 3, 3, 5m }
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
                    { 18, "Cadeiras", 6 }
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "ID", "Nome_Produto", "Preco", "Promocao", "Rating", "StandID", "Stock", "SubCategoriaID" },
                values: new object[,]
                {
                    { 1, "Maçãs", 2.9f, 0, 4, 1, 3, 1 },
                    { 2, "Bonecos", 25.9f, 0, 2, 2, 2, 2 },
                    { 3, "Tapetea", 23.9f, 0, 3, 3, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Venda",
                columns: new[] { "ID", "CarrinhoID", "Date", "Total" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 12, 18, 45, 51, 956, DateTimeKind.Local).AddTicks(3160), 0f },
                    { 2, 2, new DateTime(2023, 1, 12, 18, 45, 51, 956, DateTimeKind.Local).AddTicks(3163), 0f }
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
                values: new object[] { 1, new DateTime(2023, 1, 12, 18, 45, 51, 956, DateTimeKind.Local).AddTicks(3121), 10, 1 });

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
                name: "IX_Carrinho_StandID",
                table: "Carrinho",
                column: "StandID");

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
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Stand");

            migrationBuilder.DropTable(
                name: "Feira");

            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
