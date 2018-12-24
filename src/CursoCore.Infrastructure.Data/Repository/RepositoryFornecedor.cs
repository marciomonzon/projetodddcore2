using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CursoCore.Infrastructure.Data.Repository
{
    /// <summary>
    /// Implementação do IRepositoryFornecedor
    /// </summary>
    public class RepositoryFornecedor : Repository<Fornecedor>, IRepositoryFornecedor
    {
        public RepositoryFornecedor(ContextEFPedidos context) : base(context)
        {

        }

        public Fornecedor ObterPorApelido(string apelido)
        {
            return _contexto.Fornecedores.AsNoTracking().FirstOrDefault(f => f.Apelido == apelido);
        }

        public Fornecedor ObterPorCpfCnpj(string cpfcnpj)
        {
            return _contexto.Fornecedores.AsNoTracking().FirstOrDefault(f => f.CpfCnpj.Numero == cpfcnpj);
        }

        public Fornecedor ObterPorId(int id)
        {
            return _contexto.Fornecedores.AsNoTracking().FirstOrDefault(f => f.Id == id);
        }
    }
}
