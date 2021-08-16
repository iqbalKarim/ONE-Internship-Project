using System;

namespace API.Entities
{
    public class Product
    {
        public Product(string ProductName, string Category, double Price){
            this.ProductName = ProductName;
            this.Category = Category;
            this.Price = Price;
        }
        public Product(string ProductName, string Category){
            this.ProductName = ProductName;
            this.Category = Category;
            this.Price = 0.00;
        }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        // public string Image { get; set; }
        // public string Description { get; set; }
    }
}