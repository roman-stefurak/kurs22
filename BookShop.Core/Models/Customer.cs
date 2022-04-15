using System;
using System.Collections.Generic;

namespace BookShop.Core.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronumic { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Additional { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
