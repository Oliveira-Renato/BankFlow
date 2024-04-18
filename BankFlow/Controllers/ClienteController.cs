using Microsoft.AspNetCore.Mvc;

namespace BankFlow.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
