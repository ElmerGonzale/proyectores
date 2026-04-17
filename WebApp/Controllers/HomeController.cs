using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Uso del modelo de modelos de la vista
            Proyector proyector = new()
            //var proyector = new Proyector()
            {
                Id = 1,
                Marca = "Epson",
                Modelo = "PowerLite X49",
                NumeroDeSerie = "981130",
                Situacion = SituacionProyector.Bueno,
                FechaDeAlta = DateTime.Now
            };

            /*Uso de View Bag
            ViewBag.Id = "1";
            ViewBag.Marca = "Epson";
            ViewBag.Modelo = "PowerLite X49";
            ViewBag.Numero_serie= "981130";
            ViewBag.Situacion = "Bueno";
            ViewBag.FechaDeAlta = DateTime.Now.ToString("d");*/

            /*uso de viewdata
            ViewData["Id"] = "1";
            ViewData["Marca"] = "Epson";
            ViewData["Modelo"] = "PowerLite X49";
            ViewData["Número de serie"] = "981130";
            ViewData["Situación"] = "Bueno";
            ViewData["FechaDeAlta"] = DateTime.Now.ToString("d"); */

            return View(proyector);
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
