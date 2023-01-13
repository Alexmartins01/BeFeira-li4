using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeFeira.Server.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(8957), new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9026), new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9029), new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9033), new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9036), new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9039), new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 1,
                column: "Nome_Produto",
                value: "Maçãs");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 2,
                column: "Nome_Produto",
                value: "Bonecos");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 3,
                column: "Nome_Produto",
                value: "Tapetea");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 4,
                column: "Nome_Produto",
                value: "Celular");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 5,
                column: "Nome_Produto",
                value: "Livro");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 6,
                column: "Nome_Produto",
                value: "Caneca");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 7,
                column: "Nome_Produto",
                value: "Bola de futebol");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 8,
                column: "Nome_Produto",
                value: "Perfume");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 9,
                column: "Nome_Produto",
                value: "Mala");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 10,
                column: "Nome_Produto",
                value: "Sapatos");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 11,
                column: "Nome_Produto",
                value: "Smartwatch");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 12,
                column: "Nome_Produto",
                value: "Fritadeira");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 13,
                column: "Nome_Produto",
                value: "Cadeira gamer");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 14,
                column: "Nome_Produto",
                value: "Bicicleta");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 15,
                column: "Nome_Produto",
                value: "Aspirador");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 16,
                column: "Nome_Produto",
                value: "Toalhas de banho");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 17,
                column: "Nome_Produto",
                value: "Ração para frangos");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 18,
                column: "Nome_Produto",
                value: "Carnes de porco");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 19,
                column: "Nome_Produto",
                value: "Livro de terror");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 20,
                column: "Nome_Produto",
                value: "BMW elétrico");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 21,
                column: "Nome_Produto",
                value: "Mesa de escritório");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 22,
                column: "Nome_Produto",
                value: "Camisola para homem");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 23,
                column: "Nome_Produto",
                value: "Serra circular");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 24,
                column: "Nome_Produto",
                value: "Ração para cães");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 25,
                column: "Nome_Produto",
                value: "Toalhas de banho");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 26,
                column: "Nome_Produto",
                value: "Móveis de jardim");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 27,
                column: "Nome_Produto",
                value: "Eletrodomésticos de cozinha");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 28,
                column: "Nome_Produto",
                value: "Ração para cães");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 29,
                column: "Nome_Produto",
                value: "Frangos orgânicos");

            migrationBuilder.UpdateData(
                table: "Promocao",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Subcategoria",
                keyColumn: "ID",
                keyValue: 47,
                column: "Descricao",
                value: "Aquecedores");

            migrationBuilder.UpdateData(
                table: "Venda",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Venda",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 1, 13, 14, 22, 53, 960, DateTimeKind.Local).AddTicks(9515));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Administrador",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Created_at", "Updated_at" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 1,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 2,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 3,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 4,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 5,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 6,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 7,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 8,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 9,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 10,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 11,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 12,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 13,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 14,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 15,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 16,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 17,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 18,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 19,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 20,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 21,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 22,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 23,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 24,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 25,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 26,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 27,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 28,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ID",
                keyValue: 29,
                column: "Nome_Produto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Promocao",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 13, 0, 15, 37, 171, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Subcategoria",
                keyColumn: "ID",
                keyValue: 47,
                column: "Descricao",
                value: "Toalhas de banho");

            migrationBuilder.UpdateData(
                table: "Venda",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 13, 0, 15, 37, 171, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Venda",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 1, 13, 0, 15, 37, 171, DateTimeKind.Local).AddTicks(2705));
        }
    }
}
