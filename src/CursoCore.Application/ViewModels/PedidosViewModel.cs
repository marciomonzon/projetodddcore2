using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCore.Application.ViewModels
{
    public class PedidosViewModel
    {
        public PedidosViewModel()
        {
            ListaErros = new List<string>();
        }

        public int Id { get; set; }
        public List<string> ListaErros { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public string DataPedido { get; set; }
        public string DataEntrega { get; set; }
        public int Status { get; set; }
        
        // FK
        public int ClienteId { get; set; }
    }
}
