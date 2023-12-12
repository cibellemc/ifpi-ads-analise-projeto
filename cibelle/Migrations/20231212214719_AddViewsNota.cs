using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cibelle.Migrations
{
    public partial class AddViewsNota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "NotasDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTipoPagamento",
                table: "NotasDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdTransportadora",
                table: "NotasDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVendedor",
                table: "NotasDeVenda",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "NotasDeVenda");

            migrationBuilder.DropColumn(
                name: "IdTipoPagamento",
                table: "NotasDeVenda");

            migrationBuilder.DropColumn(
                name: "IdTransportadora",
                table: "NotasDeVenda");

            migrationBuilder.DropColumn(
                name: "IdVendedor",
                table: "NotasDeVenda");
        }
    }
}
