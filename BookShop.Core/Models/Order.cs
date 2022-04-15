using System;
using System.Collections.Generic;

namespace BookShop.Core.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public long Id { get; set; }
        public long CustomerId { get; set; }
        public long EmployeeId { get; set; }
        public string DateCreated { get; set; }
        public string DateClosed { get; set; }
        public long OrderState { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
