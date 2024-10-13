using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Eletrônicos', 'https://www.dreamstime.com/electronics-image12564845')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Livros', 'https://www.dreamstime.com/books-image27285999')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Roupas', 'https://www.dreamstime.com/clothes-image108255')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Alimentos', 'https://www.dreamstime.com/food-image8236209')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Brinquedos', 'https://www.dreamstime.com/toys-image9489532')");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Moveis', 'https://www.dreamstime.com/furniture-image159105')");
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
