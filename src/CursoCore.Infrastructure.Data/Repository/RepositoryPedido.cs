using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCore.Infrastructure.Data.Repository
{
    public class RepositoryPedido : Repository<Pedido>, IRepositoryPedidos
    {
        public RepositoryPedido(ContextEFPedidos context) : base(context)
        {

        }

        public void AdicionarItensPedidos(ItensPedido item)
        {
            _contexto.itensPedidos.Add(item);
        }

        public void AtualizarItensPedidos(ItensPedido item)
        {
            _contexto.itensPedidos.Update(item);
        }

        public void RemoverItensPedidos(ItensPedido item)
        {
            _contexto.itensPedidos.Remove(item);
        }

        public IEnumerable<ItensPedido> ObterItensPedidos(int idPedido)
        {
            return _contexto.itensPedidos.Where(i => i.PedidoId == idPedido);
        }

        public ItensPedido ObterItensPedidosPorId(int id)
        {
            return _contexto.itensPedidos.AsNoTracking().FirstOrDefault(i => i.Id == id);
        }

        public Pedido ObterPorId(int id)
        {
            return _contexto.Pedidos.FirstOrDefault(p => p.Id == id);
        }

       
    }
}
