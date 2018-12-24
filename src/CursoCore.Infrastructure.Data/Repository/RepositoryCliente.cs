using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            return _contexto.Clientes.AsNoTracking().FirstOrDefault(c => c.Apelido == apelido);
        }

        public Cliente ObterPorCpfCnpj(string cpfcnpj)
        {
            return _contexto.Clientes.AsNoTracking().FirstOrDefault(c => c.CpfCnpj.Numero == cpfcnpj);
        }

        public Cliente ObterPorId(int id)
        {
            return _contexto.Clientes.AsNoTracking().FirstOrDefault(c => c.Id == id);
        }
    }
}
