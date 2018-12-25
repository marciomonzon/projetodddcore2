using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Domain.Services
{
    public class ServicePedidos : IServicePedidos
    {
        private readonly IRepositoryPedidos _repoPedidos;

        public ServicePedidos(IRepositoryPedidos repoPedidos)
        {
            _repoPedidos = repoPedidos;
        }

        public void Adicionar(Pedido obj)
        {
            _repoPedidos.Adicionar(obj);
        }

        public void Atualizar(Pedido obj)
        {
            _repoPedidos.Atualizar(obj);
        }

        public IEnumerable<Pedido> Buscar(Expression<Func<Pedido, bool>> predicado)
        {
            return _repoPedidos.Buscar(predicado);
        }

        public void Remover(Pedido obj)
        {
            _repoPedidos.Remover(obj);
        }

        public Pedido ObterPorId(int id)
        {
            return _repoPedidos.ObterPorId(id);
        }

        public IEnumerable<Pedido> ObterTodos()
        {
            return _repoPedidos.ObterTodos();
        }

        public void Dispose()
        {
            _repoPedidos.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
