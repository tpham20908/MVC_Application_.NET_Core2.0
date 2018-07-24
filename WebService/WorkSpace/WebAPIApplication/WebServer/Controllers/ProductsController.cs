using System.Linq;
using Microsoft.AspNetCore.Mvc;
[Route("api/[controller]")]
public class ProductsController : Controller {
    [HttpGet]
    public Product[] Get() {
        return FakeData.Products.Values.ToArray();
    }

    [HttpGet("{id}")]
    public Product Get(int id) {
        if (FakeData.Products.ContainsKey(id))
            return FakeData.Products[id];
        else
            return null;
    }
}