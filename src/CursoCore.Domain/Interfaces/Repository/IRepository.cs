using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Domain.Interfaces.Repository
{
    public interface IRepository<TEntidade> : IDisposable where TEntidade : class
    {
        void Adicionar(TEntidade obj);
        void Atualizar(TEntidade obj);
        void Remover(TEntidade obj);
        IEnumerable<TEntidade> ObterTodos();
        IEnumerable<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicado);
    }
}
