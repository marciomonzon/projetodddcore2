using CursoCore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Application.Interfaces
{
    /// <summary>
    /// igual ao IServicePedidos no Domain
    /// Porém com o ViewModel
    /// </summary>
    public interface IApplicationPedidos : IDisposable
    {
        void Adicionar(PedidosViewModel obj);
        void Atualizar(PedidosViewModel obj);
        void Remover(PedidosViewModel obj);
        IEnumerable<PedidosViewModel> ObterTodos();
        IEnumerable<PedidosViewModel> Buscar(Expression<Func<PedidosViewModel, bool>> predicado);
        PedidosViewModel ObterPorId(int id);
    }
}
