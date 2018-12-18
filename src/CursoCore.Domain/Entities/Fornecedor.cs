using CursoCore.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Entities
{
    public class Fornecedor : Pessoa
    {
        
        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}
