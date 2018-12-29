using CursoCore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CursoCore.Site.Areas.Cadastros.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IApplicationCliente _appCliente;

        public ClientesController(IApplicationCliente appCliente)
        {
            _appCliente = appCliente;
        }

        public IActionResult Index()
        {
            var model = _appCliente.ObterTodos();
            return View(model);
        }
    }
}