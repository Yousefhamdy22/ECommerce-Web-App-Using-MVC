using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Areas.SellerPanel.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class SellerProductRepService : EFCoreRepos<SellerProductes>
    {
        public SellerProductRepService(ApplicationDbContext context) : base(context) { }
    }
}
