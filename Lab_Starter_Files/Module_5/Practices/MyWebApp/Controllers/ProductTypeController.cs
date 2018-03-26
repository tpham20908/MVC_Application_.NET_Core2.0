using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;

namespace ProductManager.Controllers {
    public class ProductTypeController : Controller {
        public IActionResult Index() {
            var types = DataSource.GetProductTypes();
            return View(types);
        }

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductType productType) {
            if (ModelState.IsValid) {
                DataSource.AddProductType(productType);
            }

            return RedirectToAction("Index");
        }
    }
}