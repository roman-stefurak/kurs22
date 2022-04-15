using System;

namespace BookShop.Core.Other
{
    public class User
    {
        public long ID { get; set; }
        public string Surname { get; internal set; }
        public string Name { get; internal set; }
        public string Patronymic { get; internal set; }
        public string Phone { get; internal set; }
        public string Email { get; internal set; }
        public byte[] Photo { get; internal set; }
        public DateTime Birthday { get; internal set; }
        public UserType UserType { get; set; }
    }
}
