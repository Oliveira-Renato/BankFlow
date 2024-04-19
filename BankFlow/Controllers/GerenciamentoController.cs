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
        public IActionResult ObterSaldo(int clienteId)
        {
            // Chama o método BuscarSaldoPorClienteId para obter o saldo do cliente
            //decimal saldo = _clienteRepositorio.BuscarSaldoPorClienteId(clienteId);

            // ViewBag.Saldo = saldo;

            return View("Index"); // Retorna a visualização apropriada
        }
        public IActionResult LancamentoCredito(int clienteId, decimal valor)
        {
            // Validações (por exemplo, se o cliente existe, se o valor é positivo, etc.)

            // Crie uma nova transação de crédito
            var transacao = new TransacaoModel
            {
                Tipo = "Crédito",
                Valor = valor,
                ClienteId = clienteId
            };

            // Atualize o saldo do cliente no banco de dados (pode ser uma operação assíncrona)
            // ...

            // Informe ao usuário que o lançamento foi bem-sucedido
            TempData["Mensagem"] = "Lançamento de crédito realizado com sucesso.";

            return RedirectToAction("Index", "Gerenciamento"); // Redirecione para a página de clientes
        }

        public IActionResult Transferencia(int clienteOrigemId, int clienteDestinoId, decimal valor)
        {
            // Validações (por exemplo, se os clientes existem, se o valor é positivo, etc.)

            // Verifique se o saldo do cliente de origem é suficiente
            // ...

            // Atualize os saldos dos clientes no banco de dados (pode ser uma operação assíncrona)
            // ...

            // Informe ao usuário que a transferência foi bem-sucedida
            TempData["Mensagem"] = "Transferência realizada com sucesso.";

            return RedirectToAction("Index", "Cliente"); // Redirecione para a página de clientes
        }
    }
}
