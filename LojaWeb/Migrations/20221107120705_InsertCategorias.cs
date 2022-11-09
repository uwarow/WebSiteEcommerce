using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaWeb.Migrations
{
    public partial class InsertCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT EcommerceOficial. dbo. Categorias OFF");
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaName, Descricao) VALUES ('Caminhoes', 'Caminhoes')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From Categorias");
        }
    }
}
