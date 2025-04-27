namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents a customer in the Baseball Shop system.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the unique identifier for the customer.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the first name of the customer.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the customer.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the customer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the customer.
        /// This property is optional.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the date when the customer record was created.
        /// Defaults to the current date and time.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
