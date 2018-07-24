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

    [HttpPost]
    public Product Post([FromBody]Product product) {
        product.ID = FakeData.Products.Keys.Max() + 1;
        FakeData.Products.Add(product.ID, product);
        return product;
    }
}