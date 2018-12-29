using CursoCore.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Application.Interfaces
{
    /// <summary>
    /// igual ao IServiceProduto no Domain
    /// Porém com o ViewModel
    /// </summary>
    public interface IApplicationProduto : IDisposable
    {
        void Adicionar(ProdutosViewModel obj);
        void Atualizar(ProdutosViewModel obj);
        void Remover(ProdutosViewModel obj);
        IEnumerable<ProdutosViewModel> ObterTodos();
        IEnumerable<ProdutosViewModel> Buscar(Expression<Func<ProdutosViewModel, bool>> predicado);
        ProdutosViewModel ObterPorNome(string nome);
        ProdutosViewModel ObterPorApelido(string apelido);
        ProdutosViewModel ObterPorId(int id);
    }
}
