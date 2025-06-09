using Dawstin_CPW221_BaseballShop.Baseball_Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents an item available for purchase in the Baseball Shop.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the unique identifier for the item.
        /// </summary>
        public int ItemID { get; set; }

        /// <summary>
        /// Gets or sets the name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the category ID associated with the item.
        /// This represents a foreign key to the Category table.
        /// </summary>
        public int? CategoryID { get; set; }

        /// <summary>
        /// Gets or sets the price of the item.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the date when the item record was created.
        /// Defaults to the current date and time.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the category of the item.
        /// This property is ignored by Entity Framework since it is marked with the [NotMapped] attribute.
        /// Consider changing 'object' to 'Category' for proper relationship mapping.
        /// </summary>
        [NotMapped]
        public object Category { get; set; }

        /// <summary>
        /// Gets or sets the category associated with the item.
        /// </summary>
        public Category ItemCategory { get; set; }
    }
}
