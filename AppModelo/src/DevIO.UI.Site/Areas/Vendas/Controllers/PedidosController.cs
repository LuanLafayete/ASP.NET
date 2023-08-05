using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Areas.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("vendas")]
    public class PedidosController : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
