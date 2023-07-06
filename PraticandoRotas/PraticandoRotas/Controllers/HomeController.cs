using Microsoft.AspNetCore.Mvc;
using PraticandoRotas.Models;
using System.Diagnostics;

namespace PraticandoRotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //return View(); **** AQUI ELE ESTÁ RETORNANDO AS INFORMAÇÕES DO PRIVACY QUE ESTÃO CONTIDAS NA PASTA VIEW

            //return Json("{'nome':'Eduardo'}"); AQUI ELE ESTÁ RETORNANDO UM AQUIVO JSON COM AS INFORMAÇÕES DO PARÂMETRO

            /* AQUI ELE TERIA QUE ABRIR UM ARQUIVO EM TEXTO
             var fileBytes = System.IO.File.ReadAllBytes(@"F:\arquivo.txt");
            var fileName = "Ola.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            */

            return Content ("Qualquer coisa");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}