using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimeiroProjeto.Repositorio.Migrations
{
    public partial class NovaColunaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeArquivo",
                table: "Produtos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeArquivo",
                table: "Produtos");
        }
    }
}
