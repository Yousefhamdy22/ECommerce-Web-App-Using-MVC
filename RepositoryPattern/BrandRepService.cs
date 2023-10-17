using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class BrandRepService : EFCoreRepos<Brand>
    {
        public BrandRepService(ApplicationDbContext context) : base(context) { }
    }
}
