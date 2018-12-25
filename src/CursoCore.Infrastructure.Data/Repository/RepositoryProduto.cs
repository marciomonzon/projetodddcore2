using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Infrastructure.Data.Context;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public override IEnumerable<Produto> ObterTodos()
        {
            StringBuilder query = new StringBuilder();
            query.Append(@"select * from produto p inner join fornecedor f 
                        on p.fornecedor_id = p.id 
                        order by p.id desc");
            var produtos = _contexto.Database.GetDbConnection().Query<Produto, Fornecedor, Produto>(query.ToString(), 
                (P, F) => 
                {
                    P.Fornecedor = F;
                    return P;
                });
            return produtos;
        }

    }
}
