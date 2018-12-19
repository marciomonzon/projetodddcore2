using CursoCore.Domain.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCore.Domain.Entities
{
    public class Pedido : EntityBase
    {
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public int Status { get; set; }

        // FK
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<ItensPedido> ItensPedidos { get; set; }

        public override bool EstaConsistente()
        {
            DataPedidoDeveSerPreenchida();
            DataPedidoDeveSerSuperiorOuIgualADataDoDia();
            DataEntregaDeveSerSuperiorOuIgualDataPedido();
            ClienteDeveSerPreenchido();
            return !ListaErros.Any();
        }

        private void DataPedidoDeveSerPreenchida()
        {
            if (DataPedido == null) ListaErros.Add("Preencha data do pedido!");
        }

        private void DataPedidoDeveSerSuperiorOuIgualADataDoDia()
        {
            if (DataPedido < DateTime.Today) ListaErros.Add("Data do pedido não pode ser superior a data de hoje!");
        }

        private void DataEntregaDeveSerSuperiorOuIgualDataPedido()
        {
            if (DataEntrega != null && DataEntrega < DataPedido) ListaErros.Add("Data da entrega deve ser superior a data do pedido");
        }

        private void ClienteDeveSerPreenchido()
        {
            if (ClienteId == 0) ListaErros.Add("Cliente deve ser informado!");
        }
    }
}
