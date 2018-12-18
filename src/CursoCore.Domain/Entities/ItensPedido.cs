using CursoCore.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Domain.Entities
{
    public class ItensPedido : EntityBase
    {
        public int Qtd { get; set; }

        // fk
        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }

        public string Apelido { get; set; }
        public string Nome { get; set; }

        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}
