using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiCatalogo.Migrations
{
    public partial class Populadb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            //Insere categorias
            mb.Sql("INSERT INTO Categorias(Nome,Imagemurl) VALUES('Bebidas','http://www.macoratti.net/Imagens/1.jpg')");
            mb.Sql("INSERT INTO Categorias(Nome,Imagemurl) VALUES('Lanches','http://www.macoratti.net/Imagens/2.jpg')");
            mb.Sql("INSERT INTO Categorias(Nome,Imagemurl) VALUES('Sobremesas','http://www.macoratti.net/Imagens/3.jpg')");

            //Insere produtos
            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                " VALUES('Coca-Cola Diet','Refrigerante de Cola',5.45,'http://www.macoratti.net/Imagens/coca.jpg',50,GETDATE(),(SELECT CategoriaId FROM Categorias WHERE Nome LIKE 'Bebidas'))");

            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                " VALUES('Lanche de Atum','Lanche de Atum com maionese',8.50,'http://www.macoratti.net/Imagens/atum.jpg',10,GETDATE(),(SELECT CategoriaId FROM Categorias WHERE Nome LIKE 'Lanches'))");

            mb.Sql("INSERT INTO Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId)" +
                " VALUES('Pudim 100g','Pudim de leite condensado 100g',6.75,'http://www.macoratti.net/Imagens/pudim.jpg',50,GETDATE(),(SELECT CategoriaId FROM Categorias WHERE Nome LIKE 'Sobremesas'))");

        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Categorias");
            mb.Sql("DELETE FROM Produtos");
        }
    }
}
