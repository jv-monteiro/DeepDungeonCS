using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepDungeon.Migrations
{
    public partial class PopularProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(ProdutoName,ProdutoDescription,ProdutoPrice,ProdutoImage,IsFav,EmEstoque,CategoriaId)" +
                "VALUES ('Machado Congelante', 'Congele seus inimigos por um pequeno preço!', 200.00, '~/images/produtos/ice_axe.png',0,1,3)");
            migrationBuilder.Sql("INSERT INTO Produtos(ProdutoName,ProdutoDescription,ProdutoPrice,ProdutoImage,IsFav,EmEstoque,CategoriaId)" +
                "VALUES ('Poção de cura', 'Cure suas feridas para continuar se aventurando!', 10.00, '~/images/produtos/health_potion.png',0,1,1)");
            migrationBuilder.Sql("INSERT INTO Produtos(ProdutoName,ProdutoDescription,ProdutoPrice,ProdutoImage,IsFav,EmEstoque,CategoriaId)" +
                "VALUES ('Livro da floresta', 'Use os poderes arcanos da selva!', 300.00, '~/images/produtos/wood_book.png',0,1,4)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
