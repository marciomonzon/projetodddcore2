using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Services
{
    public class ServiceItensPedidos : IServiceItensPedidos
    {
        private readonly IRepositoryPedidos _repoPedidos;

        public ServiceItensPedidos(IRepositoryPedidos repoPedidos)
        {
            _repoPedidos = repoPedidos;
        }

        public void AdicionarItensPedidos(ItensPedido item)
        {
            _repoPedidos.AdicionarItensPedidos(item);
        }

        public void AtualizarItensPedidos(ItensPedido item)
        {
            _repoPedidos.AtualizarItensPedidos(item);
        }

        public IEnumerable<ItensPedido> ObterItensPedidos(int idPedido)
        {
            return _repoPedidos.ObterItensPedidos(idPedido);
        }

        public ItensPedido ObterItensPedidosPorId(int id)
        {
            return _repoPedidos.ObterItensPedidosPorId(id);
        }

        public void RemoverItensPedidos(ItensPedido item)
        {
            _repoPedidos.RemoverItensPedidos(item);
        }

        public void Dispose()
        {
            _repoPedidos.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
