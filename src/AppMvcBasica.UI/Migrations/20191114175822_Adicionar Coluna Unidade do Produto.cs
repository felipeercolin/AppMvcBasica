using Microsoft.EntityFrameworkCore.Migrations;

namespace AppMvcBasica.UI.Migrations
{
    public partial class AdicionarColunaUnidadedoProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unidade",
                table: "Produtos",
                maxLength: 3,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unidade",
                table: "Produtos");
        }
    }
}
