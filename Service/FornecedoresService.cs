using System;
using System.Collections.Generic;
using System.Text;
using TanaraLiv.Model;
using TanaraLiv.Repository;

namespace TanaraLiv.Service
{
    public class FornecedoresService
    {
        public List<Fornecedores> Listar()
        {
            FornecedoresRepository repository = new FornecedoresRepository();
            return repository.Listar();
        }
        public Fornecedores Obter(int Id)
        {
            FornecedoresRepository repository = new FornecedoresRepository();
            return repository.Obter(Id);
        }
        public void Inserir(Fornecedores fornecedores)
        {
            FornecedoresRepository repository = new FornecedoresRepository();
            repository.Inserir(fornecedores);
        }
        public void Atualizar(Fornecedores fornecedores)
        {
            FornecedoresRepository repository = new FornecedoresRepository();
            repository.Atualizar(fornecedores);
        }
        public void Deletar(int Id)
        {
            FornecedoresRepository repository = new FornecedoresRepository();
            repository.Deletar(Id);
        }
    }
}
