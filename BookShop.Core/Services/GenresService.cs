using BookShop.Core.Models;
using BookShop.Core.Models.Context;

namespace BookShop.Core.Services
{
    public class GenresService : BaseService<Genre>
    {
        public GenresService(EnterpriseContext context) : base(context)
        {
        }
    }
}
