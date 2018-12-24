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
    public interface IRepositoryProduto : IRepository<Produto>
    {
        Produto ObterPorNome(string nome);
        Produto ObterPorApelido(string apelido);
        Produto ObterPorId(int id);
    }
}
