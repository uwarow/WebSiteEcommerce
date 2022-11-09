using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaWeb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbNail, IsProdutosPreferidos, EmEstoque, CategoriaId) VALUES ('Accelo', 'Accelo é a tecnologia que nasceu da força e chegou para trazer inovação', 'Accelo é a tecnologia que nasceu da força e chegou para trazer inovação e muito mais robustez para as operações mais pesadas, na mineração e na construção civil', '300000.000', '/images/ImagensProdutos/Acello.jpg', '/images/ImagensProdutos/Acello.jpg',  'true', 'true', 1)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbNail, IsProdutosPreferidos, EmEstoque, CategoriaId) VALUES ('Arocs', 'Arocs é a tecnologia que nasceu da força e chegou para trazer inovação', 'Arocs é a tecnologia que nasceu da força e chegou para trazer inovação e muito mais robustez para as operações mais pesadas, na mineração e na construção civil', '500000.000', '/images/ImagensProdutos/Arocs.jpg', '/images/ImagensProdutos/Arocs.jpg',  'true', 'true', 1)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbNail, IsProdutosPreferidos, EmEstoque, CategoriaId) VALUES ('Atego', 'Atego é a tecnologia que nasceu da força e chegou para trazer inovação', 'Atego é a tecnologia que nasceu da força e chegou para trazer inovação e muito mais robustez para as operações mais pesadas, na mineração e na construção civil', '400000.000', '/images/ImagensProdutos/Atego.jpg', '/images/ImagensProdutos/Atego.jpg',  'true', 'true', 1)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbNail, IsProdutosPreferidos, EmEstoque, CategoriaId) VALUES ('Atron', 'Atron é a tecnologia que nasceu da força e chegou para trazer inovação', 'Atron é a tecnologia que nasceu da força e chegou para trazer inovação e muito mais robustez para as operações mais pesadas, na mineração e na construção civil', '450000.000', '/images/ImagensProdutos/Atron.png', '/images/ImagensProdutos/Atron.png',  'true', 'true', 1)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbNail, IsProdutosPreferidos, EmEstoque, CategoriaId) VALUES ('Axor', 'Axor é a tecnologia que nasceu da força e chegou para trazer inovação', 'Axor é a tecnologia que nasceu da força e chegou para trazer inovação e muito mais robustez para as operações mais pesadas, na mineração e na construção civil', '500000.000', '/images/ImagensProdutos/Axor.jpg', '/images/ImagensProdutos/Axor.jpg',  'true', 'true', 1)");
            

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Produtos");
            
        }
    }
}
