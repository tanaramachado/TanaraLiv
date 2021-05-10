using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TanaraLiv.Model;
using Dapper;
using System.Linq;



namespace TanaraLiv.Repository
{
    public class PedidoRepository
    {
        public string ConString = "Data Source = LAPTOP-M85EBA97\\SQLEXPRESS; Initial Catalog = TANARA LIV; Integrated Security = True";
        public List<Pedido> Listar()
        {
            string query = @"SELECT
                            Id  
                           ,NumeroPedido
                           ,Valor
                           ,Desconto
                           ,Valorliquido
                          FROM Pedido";

            var con = new SqlConnection(ConString);
            con.Open();
            return con.Query<Pedido>(query).ToList();
        }

        public Pedido Obter(int Id)
        {

            string query = @"SELECT
                            Id
                           ,NumeroPedido
                           ,Valor
                           ,Desconto
                           ,Valorliquido
                          
                      FROM Pedido
                        WHERE Id = @Id";

            var con = new SqlConnection(ConString);//variavél de conexão
            con.Open(); //abre o banco de dados, conectar 
            return con.QueryFirstOrDefault<Pedido>(query, new { Id });
        }


        public void Inserir(Pedido pedido)
        {
            string query = @"INSERT INTO Pedido
                            Id
                           ,NumeroPedido
                           ,Valor
                           ,Desconto
                           ,Valorliquido
                         VALUES";

            var con = new SqlConnection(ConString);//variavél de conexão
            con.Open();
            con.Execute(query, pedido); // inserindo os dados dentro do SQL 

        }
        public void Atualizar(Pedido pedido)
        {
            string query = @"UPDATE Pedido
                           SET Id
                           ,NumeroPedido
                           ,Valor
                           ,Desconto
                           ,Valorliquido
                         WHERE Id = @Id";

            var con = new SqlConnection(ConString);
            con.Open();
            con.Execute(query, pedido); // atualizando os dados dentro do SQL 
        }

        public void Deletar(int Id)
        {
            string query = @"DELETE FROM Pedido
                            WHERE Id = @Id";

            var con = new SqlConnection(ConString);
            con.Open();
            con.Execute(query, new { Id }); // Deletou registro no SQL.
        }
    }
}









           