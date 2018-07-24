using System.Linq;
using Microsoft.AspNetCore.Mvc;
[Route("api/[controller]")]
public class ProductsController : Controller {
    [HttpGet]
    public Product[] Get() {
        return FakeData.Products.Values.ToArray();
    }
}