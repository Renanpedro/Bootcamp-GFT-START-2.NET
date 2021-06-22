using Microsoft.EntityFrameworkCore.Migrations;

namespace CursoMVC.Migrations
{
    public partial class addmigrtionTabelaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrição",
                table: "Produtos");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produtos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "Descrição",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
