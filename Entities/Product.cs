using API.Entities.Enumerations;

namespace API.Entities
{
    public class Product
    {
        public string ProductName { get; set; }
        public Categories Category { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}