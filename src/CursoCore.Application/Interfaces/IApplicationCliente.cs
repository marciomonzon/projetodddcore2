using CursoCore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Application.Interfaces
{
    /// <summary>
    /// igual ao IServiceCliente no Domain
    /// Porém com o ViewModel
    /// </summary>
    public interface IApplicationCliente : IDisposable
    {
        ClienteViewModel Adicionar(ClienteViewModel obj);
        ClienteViewModel Atualizar(ClienteViewModel obj);
        ClienteViewModel Remover(ClienteViewModel obj);
        IEnumerable<ClienteViewModel> ObterTodos();
        IEnumerable<ClienteViewModel> Buscar(Expression<Func<ClienteViewModel, bool>> predicado);
        ClienteViewModel ObterPorCpfCnpj(string cpfcnpj);
        ClienteViewModel ObterPorApelido(string apelido);
        ClienteViewModel ObterPorId(int id);
    }
}
