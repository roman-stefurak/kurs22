using System;
using System.Collections.Generic;

namespace BookShop.Core.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductGenre = new HashSet<ProductGenre>();
            ProductPriceHistory = new HashSet<ProductPriceHistory>();
        }
        
        public long Id { get; set; }
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string ProductDateCreated { get; set; }
        public string DateCreated { get; set; }

        public virtual ICollection<ProductGenre> ProductGenre { get; set; }
        public virtual ICollection<ProductPriceHistory> ProductPriceHistory { get; set; }
    }
}
