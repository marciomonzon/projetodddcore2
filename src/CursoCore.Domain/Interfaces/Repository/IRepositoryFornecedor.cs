using CursoCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface Especializada
    /// Com métodos específicos
    /// </summary>
    public interface IRepositoryFornecedor : IRepository<Fornecedor>
    {
        Fornecedor ObterPorCpfCnpj(string cpfcnpj);
        Fornecedor ObterPorApelido(string apelido);
        Fornecedor ObterPorId(int id);
    }
}
