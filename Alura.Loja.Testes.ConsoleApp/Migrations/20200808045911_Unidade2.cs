using Microsoft.EntityFrameworkCore.Migrations;

namespace Alura.Loja.Testes.ConsoleApp.Migrations
{
    public partial class Unidade2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoUnitario",
                table: "Produtos");

            migrationBuilder.AddColumn<double>(
                name: "PrecoUnidade",
                table: "Produtos",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoUnidade",
                table: "Produtos");

            migrationBuilder.AddColumn<double>(
                name: "PrecoUnitario",
                table: "Produtos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
