using Microsoft.AspNetCore.Mvc;
namespace MyWebApp.Controllers {
    public class TestController : Controller {
        public IActionResult Foo() {
            ViewData["Title"] = "Foo";
            ViewData["Header"] = "Header Foo";
            ViewData["Items"] = "AAAA BBBBBB CCCCCCCCCCC".Split(" ");
            return View();
        }
    }
}