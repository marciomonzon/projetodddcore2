using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Domain.Services
{
    public class ServiceCliente : IServiceCliente
    {
        // injeção de dependencia
        private readonly IRepositoryCliente _repoCliente;

        public ServiceCliente(IRepositoryCliente repoCliente)
        {
            _repoCliente = repoCliente;
        }

        public void Adicionar(Cliente obj)
        {
            _repoCliente.Adicionar(obj);
        }

        public void Atualizar(Cliente obj)
        {
            _repoCliente.Atualizar(obj);
        }

        public void Remover(Cliente obj)
        {
            _repoCliente.Remover(obj);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            return _repoCliente.Buscar(predicado);
        }

        public Cliente ObterPorApelido(string apelido)
        {
            return _repoCliente.ObterPorApelido(apelido);
        }

        public Cliente ObterPorCpfCnpj(string cpfcnpj)
        {
            return _repoCliente.ObterPorCpfCnpj(cpfcnpj);
        }

        public Cliente ObterPorId(int id)
        {
            return _repoCliente.ObterPorId(id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _repoCliente.ObterTodos();
        }

        public void Dispose()
        {
            _repoCliente.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
