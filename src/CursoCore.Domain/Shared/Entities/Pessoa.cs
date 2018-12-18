using CursoCore.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Shared.Entities
{
    public class Pessoa : EntityBase
    {
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public CpfCnpjVO CpfCnpj { get; set; }
        public EmailVO Email { get; set; }
        public EnderecoVO Endereco { get; set; }

        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}
