using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Infrastructure.Data.Context;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CursoCore.Infrastructure.Data.Repository
{
    public class RepositoryCliente : Repository<Cliente>, IRepositoryCliente
    {

        public RepositoryCliente(ContextEFPedidos context) : base(context)
        {

        }

        public Cliente ObterPorApelido(string apelido)
        {
            //return _contexto.Clientes.AsNoTracking().FirstOrDefault(c => c.Apelido == apelido);
            StringBuilder query = new StringBuilder();
            query.Append(@"select * from cliente where apelido = @pApelido");
            var retorno = _contexto.Database.
                GetDbConnection().Query<Cliente>(query.ToString(), new { pApelido = apelido }).FirstOrDefault();

            return retorno;
        }

        public Cliente ObterPorCpfCnpj(string cpfcnpj)
        {
            return _contexto.Clientes.AsNoTracking().FirstOrDefault(c => c.CpfCnpj.Numero == cpfcnpj);
        }

        public Cliente ObterPorId(int id)
        {
            return _contexto.Clientes.AsNoTracking().FirstOrDefault(c => c.Id == id);
        }

        public override IEnumerable<Cliente> ObterTodos()
        {
            StringBuilder query = new StringBuilder();
            query.Append(@"select * from cliente order by id desc");
            return _contexto.Database.GetDbConnection().Query<Cliente>(query.ToString());
        }
    }
}
