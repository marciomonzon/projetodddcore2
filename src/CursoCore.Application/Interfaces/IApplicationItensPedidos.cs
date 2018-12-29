using CursoCore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Application.Interfaces
{
    /// <summary>
    /// igual ao IServiceItensPedidos no Domain
    /// Porém com o ViewModel
    /// </summary>
    public interface IApplicationItensPedidos : IDisposable
    {
        void AdicionarItensPedidos(ItensPedidosViewModel item);
        void AtualizarItensPedidos(ItensPedidosViewModel item);
        void RemoverItensPedidos(ItensPedidosViewModel item);
        ItensPedidosViewModel ObterItensPedidosPorId(int id);
        IEnumerable<ItensPedidosViewModel> ObterItensPedidos(int idPedido);
    }
}
