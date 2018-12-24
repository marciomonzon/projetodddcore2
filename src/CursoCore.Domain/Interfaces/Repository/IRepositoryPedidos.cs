using CursoCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Interfaces.Repository
{
    /// <summary>
    /// ItenspPedido é agregado, então é assim mesmo
    /// </summary>
    public interface IRepositoryPedidos : IRepository<Pedido>
    {
        void AdicionarItensPedidos(ItensPedido item);
        void AtualizarItensPedidos(ItensPedido item);
        void RemoverItensPedidos(ItensPedido item);
        ItensPedido ObterItensPedidosPorId(int id);
        IEnumerable<ItensPedido> ObterItensPedidos(int idPedido);
        Pedido ObterPorId(int id);
    }
}
