using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cibelle.Migrations
{
    public partial class AddIdMarcaEmProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMarca",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdMarca",
                table: "Produtos");
        }
    }
}
