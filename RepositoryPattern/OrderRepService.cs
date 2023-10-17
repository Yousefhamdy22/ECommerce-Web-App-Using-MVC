using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class OrderRepService : EFCoreRepos<Order>
    {
        public OrderRepService(ApplicationDbContext context) : base(context) { }
    }
}
