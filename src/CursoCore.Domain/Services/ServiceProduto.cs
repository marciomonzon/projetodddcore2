using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Domain.Services
{
    public class ServiceProduto : IServiceProduto
    {
        private readonly IRepositoryProduto _repoProduto;

        public ServiceProduto(IRepositoryProduto repoProduto)
        {
            _repoProduto = repoProduto;
        }

        public void Adicionar(Produto obj)
        {
            _repoProduto.Adicionar(obj);
        }

        public void Atualizar(Produto obj)
        {
            _repoProduto.Atualizar(obj);
        }

        public IEnumerable<Produto> Buscar(Expression<Func<Produto, bool>> predicado)
        {
            return _repoProduto.Buscar(predicado);
        }

        public void Remover(Produto obj)
        {
            _repoProduto.Remover(obj);
        }

        public Produto ObterPorApelido(string apelido)
        {
            return _repoProduto.ObterPorApelido(apelido);
        }

        public Produto ObterPorId(int id)
        {
            return _repoProduto.ObterPorId(id);
        }

        public Produto ObterPorNome(string nome)
        {
            return _repoProduto.ObterPorNome(nome);
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _repoProduto.ObterTodos();
        }

        public void Dispose()
        {
            _repoProduto.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
