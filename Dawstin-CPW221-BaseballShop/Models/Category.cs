namespace Dawstin_CPW221_BaseballShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
