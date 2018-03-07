using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers {
    public class ProductController : Controller {
        public IActionResult ShowAll() {
            ViewData["Heading"] = "All Products";
            var products = new List<Product>();
            products.Add(new Product { ID = 101, Name = "Apple", Price = 1.1 });
            products.Add(new Product { ID = 202, Name = "Bike", Price = 2.2 });
            products.Add(new Product { ID = 303, Name = "Calculator", Price = 3.3 });
            return View(products);
        }
    }
}