using Dawstin_CPW221_BaseballShop.Baseball_Data;

namespace Dawstin_CPW221_BaseballShop.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CategoryID { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public Category Category { get; set; }
    }
}
