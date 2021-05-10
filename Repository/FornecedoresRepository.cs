using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TanaraLiv.Model;
using Dapper;
using System.Linq;

namespace TanaraLiv.Repository
{
    public class FornecedoresRepository
    {
        public string ConString = "Data Source = LAPTOP-M85EBA97\\SQLEXPRESS; Initial Catalog = TANARA LIV; Integrated Security = True";
        public List<Fornecedores> Listar()
        {
            string query = @"SELECT
                           Id
                          ,Fornecedor
                          ,Cnpj
                          ,Contato
                          ,Telefone
                      FROM Fornecedores";

            var con = new SqlConnection(ConString);
            con.Open();
            return con.Query<Fornecedores>(query).ToList();
        }
        public  Fornecedores Obter(int Id)
        {
            string query = @"SELECT
                           Id
                          ,Fornecedor
                          ,Cnpj
                          ,Contato
                          ,Telefone
                      FROM Fornecedores
                        WHERE Id = @Id";

            var con = new SqlConnection(ConString);
            con.Open();  
            return con.QueryFirstOrDefault<Fornecedores>(query, new { Id });

        }

        public void Inserir(Fornecedores fornecedores)
        {
            string query = @"INSERT INTO Fornecedores
                           Id
                          ,Fornecedor
                          ,Cnpj
                          ,Contato
                          ,Telefone  
                         VALUES";

            var con = new SqlConnection(ConString);
            con.Open();
            con.Execute(query, fornecedores); 
        }
        public void Atualizar(Fornecedores fornecedores)
        {
            string query = @"UPDATE Fornecedores
                           SET Id
                          ,Fornecedor
                          ,Cnpj
                          ,Contato
                          ,Telefone  
                         WHERE Id = @Id";

            var con = new SqlConnection(ConString);
            con.Open();
            con.Execute(query, fornecedores); 
        }
        public void Deletar(int Id)
        {
            string query = @"DELETE FROM Forncedores
                            WHERE Id = @Id";

            var con = new SqlConnection(ConString);
            con.Open();
            con.Execute(query, new { Id }); 
        }
    }
}
