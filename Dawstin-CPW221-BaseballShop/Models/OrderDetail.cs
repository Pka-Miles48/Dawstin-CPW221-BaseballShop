namespace Dawstin_CPW221_BaseballShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; } // Unique identifier
        public int OrderID { get; set; } // Foreign key to Order
        public int ProductID { get; set; } // Foreign key to Product
        public int Quantity { get; set; } // Number of items purchased
        public decimal Subtotal { get; set; } // Subtotal (Price * Quantity)

        // Navigation properties
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
