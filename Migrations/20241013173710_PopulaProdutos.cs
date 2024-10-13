using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 1', 'Descrição do Produto 1', 29.90, 'https://www.dreamstime.com/product1-image123456', 100, NOW(), 1)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 2', 'Descrição do Produto 2', 49.90, 'https://www.dreamstime.com/product2-image123457', 50, NOW(), 2)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 3', 'Descrição do Produto 3', 19.90, 'https://www.dreamstime.com/product3-image123458', 150, NOW(), 3)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 4', 'Descrição do Produto 4', 99.90, 'https://www.dreamstime.com/product4-image123459', 75, NOW(), 4)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 5', 'Descrição do Produto 5', 79.90, 'https://www.dreamstime.com/product5-image123460', 200, NOW(), 5)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 6', 'Descrição do Produto 6', 59.90, 'https://www.dreamstime.com/product6-image123461', 90, NOW(), 1)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 7', 'Descrição do Produto 7', 39.90, 'https://www.dreamstime.com/product7-image123462', 110, NOW(), 2)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 8', 'Descrição do Produto 8', 69.90, 'https://www.dreamstime.com/product8-image123463', 85, NOW(), 3)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 9', 'Descrição do Produto 9', 89.90, 'https://www.dreamstime.com/product9-image123464', 120, NOW(), 4)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 10', 'Descrição do Produto 10', 109.90, 'https://www.dreamstime.com/product10-image123465', 60, NOW(), 5)");
            migrationBuilder.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                "VALUES ('Produto 11', 'Descrição do Produto 11', 89.90, 'https://www.dreamstime.com/product11-image123466', 100, NOW(), 1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
