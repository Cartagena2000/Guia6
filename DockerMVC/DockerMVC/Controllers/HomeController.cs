using Microsoft.AspNetCore.Mvc;

namespace DockerMVC.Controllers
{
    public class HomeController : Controller
    {
        // Acción para la vista principal
        public IActionResult Index()
        {
            return View();
        }

        // Acción para la vista de error
        public IActionResult Error()
        {
            return View();
        }
    }
}
