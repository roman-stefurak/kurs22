using BookShop.Core.Models;
using BookShop.Core.Models.Context;

namespace BookShop.Core.Services
{
    public class ProductsService : BaseService<Product>
    {
        public ProductsService(EnterpriseContext context) : base(context)
        {
        }
    }
}
