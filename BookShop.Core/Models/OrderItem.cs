using System;
using System.Collections.Generic;

namespace BookShop.Core.Models
{
    public partial class OrderItem
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual ProductPriceHistory Product { get; set; }
    }
}
