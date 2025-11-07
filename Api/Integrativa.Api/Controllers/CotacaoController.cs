using Microsoft.AspNetCore.Mvc;

namespace Integrativa.Api.Controllers
{
    public class CotacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
