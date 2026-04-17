using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //uso de viewdata
            ViewData["Id"] = "1";
            ViewData["Marca"] = "Epson";
            ViewData["Modelo"] = "PowerLite X49";
            ViewData["Número de serie"] = "981130";
            ViewData["Situación"] = "Bueno";
            ViewData["FechaDeAlta"] = DateTime.Now.ToString("d"); ;
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
