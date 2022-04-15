using System;
using System.Collections.Generic;

namespace BookShop.Core.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Order = new HashSet<Order>();
        }

        public long Id { get; set; }
        public string Login { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }
        public string Birthday { get; set; }
        public long UserType { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
