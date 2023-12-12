using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cibelle.Migrations
{
    public partial class AddRelacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVenda_Itens_ItemId",
                table: "NotasDeVenda");

            migrationBuilder.DropIndex(
                name: "IX_NotasDeVenda_ItemId",
                table: "NotasDeVenda");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "NotasDeVenda");

            migrationBuilder.AddColumn<int>(
                name: "IdNotaDeVenda",
                table: "Pagamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdNotaDeVenda",
                table: "Itens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProduto",
                table: "Itens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Itens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Itens_NotaDeVendaId",
                table: "Itens",
                column: "NotaDeVendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_NotasDeVenda_NotaDeVendaId",
                table: "Itens",
                column: "NotaDeVendaId",
                principalTable: "NotasDeVenda",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_NotasDeVenda_NotaDeVendaId",
                table: "Itens");

            migrationBuilder.DropIndex(
                name: "IX_Itens_NotaDeVendaId",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "IdNotaDeVenda",
                table: "Pagamentos");

            migrationBuilder.DropColumn(
                name: "IdNotaDeVenda",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "IdProduto",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Itens");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "NotasDeVenda",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotasDeVenda_ItemId",
                table: "NotasDeVenda",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVenda_Itens_ItemId",
                table: "NotasDeVenda",
                column: "ItemId",
                principalTable: "Itens",
                principalColumn: "Id");
        }
    }
}
