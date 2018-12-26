using CursoCore.Domain.Entities;
using CursoCore.Domain.Interfaces.Repository;
using CursoCore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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

        #region Adicionar Cliente - Regras de Negócio

        public void Adicionar(Cliente cliente)
        {
            cliente = AptoParaAdicionarCliente(cliente);

            if (!cliente.ListaErros.Any()); // se a lista de erros estiver vazia
                _repoCliente.Adicionar(cliente);
        }

        private Cliente VerificarSeApelidoExisteNoBanco(Cliente cliente)
        {
            if (ObterPorId(cliente.Id) != null) 
                cliente.ListaErros.Add("O apelido" + cliente.Apelido + "Já existe em outro cliente!");
            return cliente;
        }

        private Cliente VerificarSeCpfCnpjExisteNoBanco(Cliente cliente)
        {
            if (ObterPorCpfCnpj(cliente.CpfCnpj.Numero) != null)
                cliente.ListaErros.Add("O CPF/CNPJ informado já existe!");
            return cliente;
        }

        private Cliente AptoParaAdicionarCliente(Cliente cliente)
        {
            if (!cliente.EstaConsistente())
                return cliente;

            cliente = VerificarSeApelidoExisteNoBanco(cliente);
            cliente = VerificarSeCpfCnpjExisteNoBanco(cliente);

            return cliente;
        }

        #endregion

        #region Alterar Cliente - Regras de Negócio
        public void Atualizar(Cliente obj)
        {
            _repoCliente.Atualizar(obj);
        }

        private Cliente VerificarSeCpfCnpjExisteNoBancoEmAlteracao(Cliente cliente)
        {
            if (ObterPorCpfCnpj(cliente.CpfCnpj.Numero) != null)
                cliente.ListaErros.Add("O CPF/CNPJ informado já existe!");
            return cliente;
        }


        #endregion

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
