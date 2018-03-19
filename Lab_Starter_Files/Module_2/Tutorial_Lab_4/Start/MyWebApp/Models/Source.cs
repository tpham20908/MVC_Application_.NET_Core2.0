using System;
using System.Collections.Generic;

namespace MyWebApp.Models {
    public class Film {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre[] Genres { get; set; }
        public bool IsInStore { get; set; }
    }

    /*
    public class CreateOrUpdateDTO {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public Genre[] Genres { get; set; }
        public bool IsInStore { get; set; }
        
        // public Operation Operation { get; set; }
    }
    */

    public enum Genre {
        Action,
        Adventure,
        Comedy,
        Drama,
        War
    }

    /*
    public enum Operation {
        Create,
        Update,
        Delete
    }
    */

    public class Product 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Discount 
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public double Rate{ get; set; }
    }

    public class ProductListVM
    {
        public Discount Discount { get; set; }
        public IList<Product> Products { get; set; }
    }
}