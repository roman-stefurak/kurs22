using System;
using System.Collections.Generic;

namespace BookShop.Core.Models
{
    public partial class Admin
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
    }
}
