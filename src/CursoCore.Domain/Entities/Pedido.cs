using CursoCore.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Entities
{
    public class Pedido : EntityBase
    {
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataEntrega { get; set; }
        public int Status { get; set; }

        // FK
        public int ClienteId { get; set; }

        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}
