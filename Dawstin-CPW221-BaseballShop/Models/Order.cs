namespace Dawstin_CPW221_BaseballShop.Models
{
    public class Order
    {
        public int OrderID { get; set; } // Unique identifier
        public int CustomerID { get; set; } // Foreign key to Customer
        public DateTime OrderDate { get; set; } = DateTime.Now; // Date of the order
        public decimal TotalAmount { get; set; } // Total order cost
        public string Status { get; set; } // Status (e.g., "Pending", "Completed")

        // Navigation property
        public Customer Customer { get; set; }
    }
}
