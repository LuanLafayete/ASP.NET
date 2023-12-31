﻿using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class CadastroController : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("busca")]
        public IActionResult Busca()
        {
            return View();
        }
    }
}
