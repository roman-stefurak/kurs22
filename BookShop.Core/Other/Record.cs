using BookShop.Core.Models;
using System.Collections.Generic;

namespace BookShop.Core.Other
{
    public enum RecordState
    {
        New,
        Editing,
        Closed
    }

    public class Record
    {
        public long ID { get; internal set; }
        public string EmployeeFullName { get; set; }
        public string CustomerFullName { get; set; }
        public string DateCreated { get; set; }
        public string DateClosed { get; set; }
        public RecordState State { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();

        public long CustomerID { get; set; }
        public long EmployeeID { get; set; }
    }
}
