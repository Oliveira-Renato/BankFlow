using Microsoft.AspNetCore.Mvc;

namespace BankFlow.Controllers
{
    public class GerenciamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
