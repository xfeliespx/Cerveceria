using Microsoft.AspNetCore.Mvc;
using GestionAgilDeProyectos.Models;
using System.Diagnostics;

namespace GestionAgilDeProyectos.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

		}
		public IActionResult Index()
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
