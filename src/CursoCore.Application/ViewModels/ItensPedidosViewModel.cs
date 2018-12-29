using System.Collections.Generic;

namespace CursoCore.Application.ViewModels
{
    public class ItensPedidosViewModel
    {
        public ItensPedidosViewModel()
        {
            ListaErros = new List<string>();
        }

        public int Id { get; set; }
        public List<string> ListaErros { get; set; }

        public int ProdutoId { get; set; }
        public int PedidoId { get; set; }

        public int Qtd { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        
    }
}
