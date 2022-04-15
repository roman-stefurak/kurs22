using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Core.Other
{
    public class CustomerDto
    {
        public long ID { get; internal set; }
        public string Surname { get; internal set; }
        public string Name { get; internal set; }

        public override string ToString()
        {
            return string.Join(" ", Surname, Name);
        }
    }
}
