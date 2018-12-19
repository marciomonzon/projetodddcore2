using CursoCore.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            QuantidadeDeveSerSuperiorAZero();
            ItemDePedidoDeveSerAssociadoAUmPedido();
            ProdudoDeveSerPreenchido();
            return !ListaErros.Any();
        }

        private void QuantidadeDeveSerSuperiorAZero()
        {
            if (Qtd <= 0) ListaErros.Add("Quantidade deverá ser informada!");
        }

        private void ItemDePedidoDeveSerAssociadoAUmPedido()
        {
            if (PedidoId <= 0) ListaErros.Add("Numero do pedido inválido!");
        }

        private void ProdudoDeveSerPreenchido()
        {
            if (ProdutoId <= 0) ListaErros.Add("Produto deve ser informado!");
        }
    }
}
