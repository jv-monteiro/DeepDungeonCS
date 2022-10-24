using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeepDungeon.Migrations
{
    public partial class PopularTabelas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName)" +
                "VALUES ('Pocoes')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName)" +
                "VALUES ('Espadas')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName)" +
                "VALUES ('Machados')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName)" +
                "VALUES ('LivrosArcanos')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
