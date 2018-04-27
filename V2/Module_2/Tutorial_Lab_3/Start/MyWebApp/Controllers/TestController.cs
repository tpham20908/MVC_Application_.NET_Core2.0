using Microsoft.AspNetCore.Mvc;
namespace MyWebApp.Controllers {
    public class TestController : Controller {
        public IActionResult Foo() {
            ViewData["Title"] = "Foo";
            ViewData["Header"] = "Header Foo";
            ViewData["Items"] = "AAAA BBBBBB CCCCCCCCCCC".Split(" ");
            return View();
        }

        public IActionResult Bar() {
            ViewBag.Title = "Bar";
            ViewBag.Header = "Header Bar";
            ViewBag.Items = "DFEW DSFAA GWEF DSAF JFWEI".Split(" ");
            return View();
        }
    }
}