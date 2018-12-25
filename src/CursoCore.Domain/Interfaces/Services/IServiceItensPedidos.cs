using CursoCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Interfaces.Services
{
    public interface IServiceItensPedidos : IDisposable
    {
        void AdicionarItensPedidos(ItensPedido item);
        void AtualizarItensPedidos(ItensPedido item);
        void RemoverItensPedidos(ItensPedido item);
        ItensPedido ObterItensPedidosPorId(int id);
        IEnumerable<ItensPedido> ObterItensPedidos(int idPedido);
    }
}
