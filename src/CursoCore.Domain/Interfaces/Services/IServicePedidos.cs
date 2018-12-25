using CursoCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Domain.Interfaces.Services
{
    public interface IServicePedidos : IDisposable
    {
        void Adicionar(Pedido obj);
        void Atualizar(Pedido obj);
        void Remover(Pedido obj);
        IEnumerable<Pedido> ObterTodos();
        IEnumerable<Pedido> Buscar(Expression<Func<Pedido, bool>> predicado);
        Pedido ObterPorId(int id);
    }
}
