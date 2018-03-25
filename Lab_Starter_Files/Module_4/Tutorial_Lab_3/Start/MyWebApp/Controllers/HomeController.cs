using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers {
    public class HomeController : Controller {
        public IActionResult Home() => View();
        public IActionResult Page1() => View();
        public IActionResult Page2() => View();
    }
}