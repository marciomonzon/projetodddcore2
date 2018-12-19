using CursoCore.Domain.Shared.Entities;
using System;
using System.Collections.Generic;

namespace CursoCore.Domain.Entities
{
    public class Fornecedor : Pessoa
    {
        public ICollection<Produto> Produtos { get; set; }

        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}
