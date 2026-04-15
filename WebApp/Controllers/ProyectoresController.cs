using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace WebApp.Controllers
{
    public class ProyectoresController : Controller
    {
        public IActionResult Index()
        {
            return Content(
                "<p>Aqu&iacute se mostrar&aacute la lista de proyectores registrados</p>",
                "text/html"
                );
        }
        public IActionResult Details(int id)
        {
            string cadena = "<h1> Nuevo proyector </h1>";
            cadena += $"<p> Aqu&iacute se mostrar&aacute la informaci&oacuten del proyector espec&iacutefico: {id} </p>";
            return Content(cadena, "text/html");
        }

        public IActionResult Delete(int id)
        {
            string cadena = $"<h1> Dar de baja </h1>" +
                $"<p> Aqui se dara de baja el proyector: {id} </p>";
            return Content(cadena, "text/html");
        }

        public IActionResult Edit(int id)
        {
            string cadena = $"<h1> Editar proyector </h1>" +
                $"<p> Aqui se modificara el proyector: {id} </p>";
            return Content(cadena, "text/html");
        }

        
    }
}
