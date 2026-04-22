using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var modelo = LoadData();
            //var modelo = new List<Proyector>();
            return View(modelo);
            //Uso del modelo de modelos de la vista
            //Proyector proyector = new()
            //var proyector = new Proyector()
            //{
            //    Id = 1,
            //    Marca = "Epson",
            //    Modelo = "PowerLite X49",
            //NumeroDeSerie = "981130",
            //Situacion = SituacionProyector.Bueno,
            //FechaDeAlta = DateTime.Now
            //};

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

            //return View(proyector);
        }

        private IEnumerable<Proyector> LoadData()
        {
            var proyectores = new List<Proyector>();
            {
                proyectores.Add(new Proyector()
                {
                    Id = 1,
                    Marca = "Epson",
                    Modelo = "PowerLite X49",
                    NumeroDeSerie = "981130",
                    Situacion = SituacionProyector.Bueno,
                    FechaDeAlta = DateTime.Now
                });
                proyectores.Add(new Proyector()
                {
                    Id = 2,
                    Marca = "Samsung",
                    Modelo = "SM X49",
                    NumeroDeSerie = "189267",
                    Situacion = SituacionProyector.Regular,
                    FechaDeAlta = DateTime.Now
                });
                proyectores.Add(new Proyector()
                {
                    Id = 3,
                    Marca = "Epson",
                    Modelo = "Smart x50",
                    NumeroDeSerie = "165289",
                    Situacion = SituacionProyector.Bueno,
                    FechaDeAlta = DateTime.Now
                });
                proyectores.Add(new Proyector()
                {
                    Id = 4,
                    Marca = "LG",
                    Modelo = "LiGa RX",
                    NumeroDeSerie = "764190",
                    Situacion = SituacionProyector.Malo,
                    FechaDeAlta = DateTime.Now
                });
                proyectores.Add(new Proyector()
                {
                    Id = 5,
                    Marca = "Epson",
                    Modelo = "Light 34",
                    NumeroDeSerie = "172693",
                    Situacion = SituacionProyector.Regular,
                    FechaDeAlta = DateTime.Now
                });
            }
            return proyectores;

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
