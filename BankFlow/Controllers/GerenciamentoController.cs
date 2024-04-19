using BankFlow.Models;
using BankFlow.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace BankFlow.Controllers
{
    public class GerenciamentoController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public GerenciamentoController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public IActionResult Index()
        {
            List<ClienteModel> clientes = _clienteRepositorio.BuscarTodos();
            return View(clientes);
        }
    }
}
