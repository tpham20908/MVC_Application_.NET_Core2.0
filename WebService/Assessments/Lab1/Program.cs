using System;
using Newtonsoft.Json;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[] {
                new Product { ID = 2005, Name = "Tilapia", Price = 23.99 },
                new Product { ID = 2006, Name = "Calmar", Price = 35.99 },
                new Product { ID = 2007, Name = "Basa", Price = 18.99 },
                new Product { ID = 2008, Name = "Salmon", Price = 32.99 },
            };

            string productsStr = DoSerialization(products);
            System.Console.WriteLine(productsStr);
            System.Console.WriteLine("==================");
            DoDeserialization(productsStr);
        }

        static string DoSerialization(Product[] products) {
            var productList = JsonConvert.SerializeObject(products);
            return productList;
        }

        static void DoDeserialization(string productList) {
            var products = JsonConvert.DeserializeObject<Product[]>(productList);

            foreach (var product in  products) {
                System.Console.WriteLine($"ID: {product.ID} Name: {product.Name} Price: {product.Price}");
            }
        }
    }
}
