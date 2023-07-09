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
            var filme = new Filme
            {
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avalicao = 10,
                Valor = 20000
            };

            return RedirectToAction("Privacy", filme);
            //return View();
        }

        public IActionResult Privacy(Filme filme)
        {           
            if (ModelState.IsValid)
            {

            }

            foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
            return View();



            //return View(); **** AQUI ELE ESTÁ RETORNANDO AS INFORMAÇÕES DO PRIVACY QUE ESTÃO CONTIDAS NA PASTA VIEW

            //return Json("{'nome':'Eduardo'}"); AQUI ELE ESTÁ RETORNANDO UM AQUIVO JSON COM AS INFORMAÇÕES DO PARÂMETRO

            /* AQUI ELE TERIA QUE ABRIR UM ARQUIVO EM TEXTO SE O LINK DE ACESSO À PASTA ESTIVESSE CERTO
             var fileBytes = System.IO.File.ReadAllBytes(@"F:\arquivo.txt");
            var fileName = "Ola.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            */
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}