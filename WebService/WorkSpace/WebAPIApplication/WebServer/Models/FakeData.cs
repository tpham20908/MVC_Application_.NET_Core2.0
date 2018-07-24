using System.Collections.Generic;

public class FakeData {
    public static IDictionary<int, Product> Products;

    static FakeData() {
        Products = new Dictionary<int, Product>();
        Products.Add(0, new Product { ID = 0, Name = "Apple", Price = 5.99});
        Products.Add(1, new Product { ID = 1, Name = "Bike", Price = 6.99});
        Products.Add(2, new Product { ID = 2, Name = "Coffee", Price = 7.99});
    }
}