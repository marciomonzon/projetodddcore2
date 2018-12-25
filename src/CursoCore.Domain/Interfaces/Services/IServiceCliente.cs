using CursoCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Domain.Interfaces.Services
{
    /// <summary>
    /// Junção do repository com o repositoryCliente
    /// </summary>
    public interface IServiceCliente : IDisposable
    {
        void Adicionar(Cliente obj);
        void Atualizar(Cliente obj);
        void Remover(Cliente obj);
        IEnumerable<Cliente> ObterTodos();
        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado);
        Cliente ObterPorCpfCnpj(string cpfcnpj);
        Cliente ObterPorApelido(string apelido);
        Cliente ObterPorId(int id);
    }
}
