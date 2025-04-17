namespace Dawstin_CPW221_BaseballShop.Models
{
    public class Product
    {
        public int ProductID { get; set; } // Unique identifier
        public string Name { get; set; } // Product name
        public string Description { get; set; } // Product description
        public decimal Price { get; set; } // Product price
        public int Stock { get; set; } // Available quantity
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Record creation date
    }
}
