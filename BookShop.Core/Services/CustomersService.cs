using BookShop.Core.Mappers;
using BookShop.Core.Models;
using BookShop.Core.Models.Context;
using BookShop.Core.Other;
using System.Linq;

namespace BookShop.Core.Services
{
    public class CustomersService : BaseService<Customer>
    {
        public CustomersService(EnterpriseContext context) : base(context)
        {
        }

        public CustomerDto[] GetCustomers()
        {
            return GetAll().Select(x => x.CustomerToDto()).ToArray();
        }
    }
}
