using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Domain.Services
{
    public class ServiceFornecedor : IServiceFornecedor
    {
        private readonly IRepositoryFornecedor _repoFornecedor;

        public ServiceFornecedor(IRepositoryFornecedor repoFornecedor)
        {
            _repoFornecedor = repoFornecedor;
        }

        public void Adicionar(Fornecedor obj)
        {
            _repoFornecedor.Adicionar(obj);
        }

        public void Atualizar(Fornecedor obj)
        {
            _repoFornecedor.Atualizar(obj);
        }

        public void Remover(Fornecedor obj)
        {
            _repoFornecedor.Remover(obj);
        }

        public IEnumerable<Fornecedor> Buscar(Expression<Func<Fornecedor, bool>> predicado)
        {
            return _repoFornecedor.Buscar(predicado);
        }

        public Fornecedor ObterPorApelido(string apelido)
        {
            return _repoFornecedor.ObterPorApelido(apelido);
        }

        public Fornecedor ObterPorCpfCnpj(string cpfcnpj)
        {
            return _repoFornecedor.ObterPorCpfCnpj(cpfcnpj);
        }

        public Fornecedor ObterPorId(int id)
        {
            return _repoFornecedor.ObterPorId(id);
        }

        public IEnumerable<Fornecedor> ObterTodos()
        {
            return _repoFornecedor.ObterTodos();
        }

        public void Dispose()
        {
            _repoFornecedor.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
