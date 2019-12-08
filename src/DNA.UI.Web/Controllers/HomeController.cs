using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DNA.UI.Web.Models;

namespace DNA.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sobre()
        {
            return View();
        }
        public IActionResult Produto()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Contato()
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
