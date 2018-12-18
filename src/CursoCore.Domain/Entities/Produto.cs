using CursoCore.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Entities
{
    public class Produto : EntityBase
    {
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Unidade { get; set; }

        //fk
        public int FornecedorId { get; set; }

        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}
