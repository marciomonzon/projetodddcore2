using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CursoCore.Infrastructure.Data.Repository
{
    public class RepositoryProduto : Repository<Produto>, IRepositoryProduto
    {
        public RepositoryProduto(ContextEFPedidos context) : base(context)
        {

        }

        public Produto ObterPorApelido(string apelido)
        {
            return _contexto.Produtos.AsNoTracking().FirstOrDefault(p => p.Apelido == apelido);
        }

        public Produto ObterPorId(int id)
        {
            return _contexto.Produtos.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        public Produto ObterPorNome(string nome)
        {
            return _contexto.Produtos.AsNoTracking().FirstOrDefault(p => p.Nome == nome);
        }
    }
}
