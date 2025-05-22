using System.ComponentModel.DataAnnotations.Schema;

namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents a product available for sale in the Baseball Shop.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the unique identifier for the product.
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the available quantity in stock.
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Gets or sets the date when the product record was created.
        /// Defaults to the current date and time.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the category of the product.
        /// </summary>
        /// <remarks>
        /// Avoid using 'object' type for category; use 'Category' instead.
        /// </remarks>
        [NotMapped]
        public object Category { get; set; }

        /// <summary>
        /// Gets or sets the foreign key for the category this product belongs to.
        /// </summary>
        public int CategoryID { get; set; }
    }
}
