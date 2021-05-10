using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using TanaraLiv.Model;
using Dapper;


namespace TanaraLiv.Repository
{
    public class ProdutoRepository
    {
        public string ConString = "Data Source = LAPTOP-M85EBA97\\SQLEXPRESS; Initial Catalog = TANARA LIV; Integrated Security = True";
        public List<Produto> Listar()
        {
            string query = @"SELECT
                           Id
                          ,Codigo
                          ,Nome
                           Editora
                      FROM Produto";

            var con = new SqlConnection(ConString);
            con.Open();
            return con.Query<Produto>(query).ToList();
        }

        public Produto Obter(int Id)
        {
            string query = @"SELECT
                           Id
                          ,Codigo
                          ,Nome
                           Editora
                      FROM Produto
                        WHERE Id = @Id";

            var con = new SqlConnection(ConString);//variavél de conexão
            con.Open(); //abre o banco de dados, conectar 
            return con.QueryFirstOrDefault<Produto>(query, new { Id }); 


        }

        public void Inserir(Produto produto)
        {
            string query = @"INSERT INTO Produto
                                Id
                               ,Codigo
                               ,Nome
                               ,Editora
                         VALUES";

            var con = new SqlConnection(ConString);//variavél de conexão
            con.Open();
            con.Execute(query, produto); // inserindo os dados dentro do SQL 


        }
        public void Atualizar(Produto produto)
        {
            string query = @"UPDATE Produto
                           SET Id
                              ,Codigo
                              ,Nome
                              ,Editora
                         WHERE Id = @Id";

            var con = new SqlConnection(ConString);
            con.Open();
            con.Execute(query, produto); // atualizando os dados dentro do SQL 


        }
        public void Deletar (int Id)
        {
            string query = @"DELETE FROM Produto
                            WHERE Id = @Id";

            var con = new SqlConnection(ConString);
            con.Open();
            con.Execute(query, new { Id }); // Deletou registro no SQL. 


        }


    }
}
