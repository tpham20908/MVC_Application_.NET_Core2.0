using Microsoft.AspNetCore.Mvc;

namespace MyWebApp {
    public class HomeController : Controller {
        public IActionResult Index() {
            
            ViewData["country"] = "United States";
            ViewData["state"] = "Washington";
            ViewData["county"] = "King";
            ViewData["city"] = "Redmond";
            
            ViewData["columnNames"] = new string[] { "ID", "Name", "Price" };
            ViewData["content"] = new string[,]{
                {"101", "Apple", "1.01"},
                {"202", "Back", "2.02"},
                {"303", "Cup", "3.03"},
                {"404", "Donut", "3.03"}
            };
            return View();
        }
    }
}