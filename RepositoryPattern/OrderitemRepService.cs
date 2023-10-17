using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class OrderitemRepService : EFCoreRepos<Orderitem>
    {
        public OrderitemRepService(ApplicationDbContext context) : base(context) { }
    }
}
