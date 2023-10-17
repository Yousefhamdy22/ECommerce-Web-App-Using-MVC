using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Areas.SellerPanel.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class ProductRepService : EFCoreRepos<Product>
    {
        public ProductRepService(ApplicationDbContext context) : base(context) { }
    }
}
