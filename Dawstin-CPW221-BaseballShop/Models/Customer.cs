namespace Dawstin_CPW221_BaseballShop.Models
{
    public class Customer
    {
        public int CustomerID { get; set; } // Unique identifier
        public string FirstName { get; set; } // First name
        public string LastName { get; set; } // Last name
        public string Email { get; set; } // Email address
        public string Phone { get; set; } // Phone number (optional)
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Record creation date
    }
}
