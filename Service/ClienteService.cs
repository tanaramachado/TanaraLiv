using System;
using System.Collections.Generic;
using System.Text;
using TanaraLiv.Model;
using TanaraLiv.Repository;

namespace TanaraLiv.Service
{
    public class ClienteService
    {
        public List<Cliente> Listar()
        {
            ClienteRepository repository = new ClienteRepository();
            return repository.Listar();
        }
        public Cliente Obter(int Id)
        {
            ClienteRepository repository = new ClienteRepository();
            return repository.Obter(Id);
        }
        public void Inserir(Cliente cliente)
        {
            ClienteRepository repository = new ClienteRepository();
            repository.Inserir(cliente); 
        }
        public void Atualizar(Cliente cliente)
        {
            ClienteRepository repository = new ClienteRepository();
            repository.Atualizar(cliente);
        }
        public void Deletar(int Id)
        {
            ClienteRepository repository = new ClienteRepository();
            repository.Deletar(Id);
        }
    }
}
