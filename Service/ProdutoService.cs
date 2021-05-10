using System;
using System.Collections.Generic;
using System.Text;
using TanaraLiv.Model;
using TanaraLiv.Repository;


namespace TanaraLiv.Service
{
   public class ProdutoService
    {

        public List<Produto> Listar()
        {
            ProdutoRepository repository = new ProdutoRepository(); // criando um objeto "prouto repository" e chamando ela de repository. 
                                                                    //TIPOobjeto      NOMEobjeto = NOVO MOLDEdoobjeto
                                                                    //classe            variavél =  NOVO PRODUTO REPOSITORY 

            //                 int idade = 24;

            return repository.Listar();
            //retornando  ---  chamando o metodo "listar" da repository.
        }

        public Produto Obter(int Id)
        {
            ProdutoRepository repository = new ProdutoRepository();
            return repository.Obter(Id);

        }

        public void Inserir(Produto produto)
        {
            ProdutoRepository repository = new ProdutoRepository();
            repository.Inserir(produto); // não tem retorno, Só faz a chamada do comando para inserir os dados dentro do SQL. 

        }


        public void Atualizar(Produto produto)
        {
            ProdutoRepository repository = new ProdutoRepository();
            repository.Atualizar(produto);

                 
        }

        public void Deletar(int Id)
        {
            ProdutoRepository repository = new ProdutoRepository();
            repository.Deletar(Id);
        }

         



    }





}
