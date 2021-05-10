using System;
using System.Collections.Generic;
using System.Text;
using TanaraLiv.Model;
using TanaraLiv.Repository;

namespace TanaraLiv.Service
{
    public class PedidoService
    {
        public List<Pedido> Listar()
        {
           PedidoRepository repository = new PedidoRepository();
           return repository.Listar();
        }
        public Pedido Obter(int Id)
        {
            PedidoRepository repository = new PedidoRepository();
            return repository.Obter(Id);
        }
        public void Inserir(Pedido pedido)
        {
            PedidoRepository repository = new PedidoRepository();
            repository.Inserir(pedido); // não tem retorno, Só faz a chamada do comando para inserir os dados dentro do SQL
        }
        public void Atualizar(Pedido pedido)
        {
            PedidoRepository repository = new PedidoRepository();
            repository.Atualizar(pedido);
        }
        public void Deletar(int Id)
        {
            PedidoRepository repository = new PedidoRepository();
            repository.Deletar(Id);
        }
        


    }
    

    
}
