using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Shared.ValueObjects
{
    public class EnderecoVO
    {
        public EnderecoVO()
        {
            UF = new UfVO();
        }

        public string Lograoudo { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public UfVO UF { get; set; }
        public string CEP { get; set; }
    }
}
