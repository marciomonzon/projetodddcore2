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
    public interface IRepositoryCliente : IRepository<Cliente>
    {
        Cliente ObterPorCpfCnpj(string cpfcnpj);
        Cliente ObterPorApelido(string apelido);
        Cliente ObterPorId(int id);
    }
}
