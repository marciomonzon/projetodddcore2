using CursoCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Domain.Interfaces.Services
{
    /// <summary>
    /// Junção do repositorio e especializada
    /// </summary>
    public interface IServiceProduto : IDisposable
    {
        void Adicionar(Produto obj);
        void Atualizar(Produto obj);
        void Remover(Produto obj);
        IEnumerable<Produto> ObterTodos();
        IEnumerable<Produto> Buscar(Expression<Func<Produto, bool>> predicado);
        Produto ObterPorNome(string nome);
        Produto ObterPorApelido(string apelido);
        Produto ObterPorId(int id);
    }
}
