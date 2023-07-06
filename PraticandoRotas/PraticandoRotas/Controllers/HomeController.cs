using Microsoft.AspNetCore.Mvc;
using MinhaDemo.Models;
using System.Diagnostics;

namespace MinhaDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id, string categoria)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}