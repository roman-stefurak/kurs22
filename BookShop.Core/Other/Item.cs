using BookShop.Core.Models;

namespace BookShop.Core.Other
{
    public class Item
    {
        public long ID { get; internal set; }
        public string Name { get; internal set; }
        public double Price { get; internal set; }

        public long ProductID { get; set; }
    }
}
