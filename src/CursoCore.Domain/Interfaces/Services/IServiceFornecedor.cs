using CursoCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CursoCore.Domain.Interfaces.Services
{
    public interface IServiceFornecedor : IDisposable
    {
        void Adicionar(Fornecedor obj);
        void Atualizar(Fornecedor obj);
        void Remover(Fornecedor obj);
        IEnumerable<Fornecedor> ObterTodos();
        IEnumerable<Fornecedor> Buscar(Expression<Func<Fornecedor, bool>> predicado);
        Fornecedor ObterPorCpfCnpj(string cpfcnpj);
        Fornecedor ObterPorApelido(string apelido);
        Fornecedor ObterPorId(int id);
    }
}
