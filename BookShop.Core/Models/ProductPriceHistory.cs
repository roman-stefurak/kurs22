using System;
using System.Collections.Generic;

namespace BookShop.Core.Models
{
    public partial class ProductPriceHistory
    {
        public ProductPriceHistory()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public long Id { get; set; }
        public long ProductId { get; set; }
        public string DateCreated { get; set; }
        public double Price { get; set; }
        public long IsDeleted { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
