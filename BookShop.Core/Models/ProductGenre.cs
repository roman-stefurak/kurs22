using System;
using System.Collections.Generic;

namespace BookShop.Core.Models
{
    public partial class ProductGenre
    {
        public long ProductId { get; set; }
        public long GenreId { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Product Product { get; set; }
    }
}
