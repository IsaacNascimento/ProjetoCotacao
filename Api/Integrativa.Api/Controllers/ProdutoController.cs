using Microsoft.AspNetCore.Mvc;

namespace Integrativa.Api.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
