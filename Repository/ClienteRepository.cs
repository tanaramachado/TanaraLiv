using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TanaraLiv.Model;
using Dapper;
using System.Linq;




namespace TanaraLiv.Repository
{
    public class ClienteRepository
    {
        public string ConString = "Data Source = LAPTOP-M85EBA97\\SQLEXPRESS; Initial Catalog = TANARA LIV; Integrated Security = True";

        public List<Cliente> Listar()
        {
            string query = @"SELECT
                            Id  
                           ,Nome
                           ,Cpf
                           ,Email
                           ,Cidade
                           ,Estado
                          FROM Cliente";
            var con = new SqlConnection(ConString);
            con.Open();
            return con.Query<Cliente>(query).ToList();

        }

        public Cliente Obter(int Id)
        {
            string query = @"SELECT
                            Id  
                           ,Nome
                           ,Cpf
                           ,Email
                           ,Cidade
                           ,Estado
                          FROM Cliente
                          WHERE Id = @Id";

            var con = new SqlConnection(ConString);
            con.Open(); 
            return con.QueryFirstOrDefault<Cliente>(query, new { Id });
        }

        public void Inserir(Cliente cliente)
        {
            string query = @"INSERT INTO Cliente
                                Id
                               ,Nome
                               ,Cpf
                               ,Email
                               ,Cidade
                               ,Estado
                         VALUES
                                (@Id
                                ,@Nome  
                                ,@Cpf
                                ,@Email
                                ,@Cidade
                                ,@Estado)";

            var con = new SqlConnection(ConString);//variavél de conexão
            con.Open();
            con.Execute(query, cliente); // inserindo os dados dentro do SQL 

        }
        public void Atualizar(Cliente cliente)
        {
            string query = @"UPDATE Produto
                           SET Id
                               ,Nome
                               ,Cpf
                               ,Email
                               ,Cidade
                               ,Estado
                         WHERE Id = @Id";

            var con = new SqlConnection(ConString);
            con.Open();
            con.Execute(query, cliente); // atualizando os dados dentro do SQL 
        }
        public void Deletar(int Id)
        {
            string query = @"DELETE FROM Cliente
                            WHERE Id = @Id";

            var con = new SqlConnection(ConString);
            con.Open();
            con.Execute(query, new { Id }); // Deletou registro no SQL.
        }
    }




}
