using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Infrastructure.Data.Repository
{
    /// <summary>
    /// Implementação do IRepository do Domain
    /// </summary>
    public class Repository<TEntidade> : IRepository<TEntidade> where TEntidade : class
    {
        protected ContextEFPedidos _contexto;
        protected DbSet<TEntidade> _dbSet;

        public Repository(ContextEFPedidos context)
        {
            _contexto = context;
            _dbSet = _contexto.Set<TEntidade>();
        }

        public void Adicionar(TEntidade obj)
        {
            _dbSet.Add(obj);
        }

        public void Atualizar(TEntidade obj)
        {
            _dbSet.Update(obj);
        }

        public void Remover(TEntidade obj)
        {
            _dbSet.Remove(obj);
        }

        public IEnumerable<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicado)
        {
            return _dbSet.AsNoTracking().Where(predicado);
        }

        // posso dar override
        public virtual IEnumerable<TEntidade> ObterTodos()
        {
            return _dbSet.ToList();
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
