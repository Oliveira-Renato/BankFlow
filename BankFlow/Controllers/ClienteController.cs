using BankFlow.Models;
using BankFlow.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace BankFlow.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio) 
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ClienteModel cliente)
        {
            _clienteRepositorio.Adicionar(cliente);

            return RedirectToAction("Index");
        }
    }
}
