using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class CartitemRepService : EFCoreRepos<CartItem>
    {
        public CartitemRepService(ApplicationDbContext context) : base(context) { }
    }
}
