namespace Dawstin_CPW221_BaseballShop.Models
{
    /// <summary>
    /// Represents a product category in the Baseball Shop.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the unique identifier for the category.
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the collection of items associated with this category.
        /// </summary>
        public ICollection<Item> Items { get; set; }

        /// <summary>
        /// Gets or sets the collection of products belonging to this category.
        /// </summary>
        public ICollection<Product> Products { get; set; }
    }
}