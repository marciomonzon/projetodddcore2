using CursoCore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Application.Interfaces
{
    /// <summary>
    /// igual ao IServiceFornecedores no Domain
    /// Porém com o ViewModel
    /// </summary>
    public interface IApplicationFornecedor : IDisposable
    {
        void Adicionar(FornecedoresViewModel obj);
        void Atualizar(FornecedoresViewModel obj);
        void Remover(FornecedoresViewModel obj);
        IEnumerable<FornecedoresViewModel> ObterTodos();
        IEnumerable<FornecedoresViewModel> Buscar(Expression<Func<FornecedoresViewModel, bool>> predicado);
        FornecedoresViewModel ObterPorCpfCnpj(string cpfcnpj);
        FornecedoresViewModel ObterPorApelido(string apelido);
        FornecedoresViewModel ObterPorId(int id);
    }
}
