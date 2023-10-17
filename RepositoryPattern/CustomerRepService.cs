using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class CustomerRepService : EFCoreRepos<Customer>
    {
        public CustomerRepService(ApplicationDbContext context) : base(context) { }
    }
}
