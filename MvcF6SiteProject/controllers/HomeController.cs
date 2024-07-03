using Microsoft.AspNetCore.Mvc;

namespace MvcF6SiteProject.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
