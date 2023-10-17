using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Areas.SellerPanel.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class SellerRepService : EFCoreRepos<Seller>
    {
        public SellerRepService(ApplicationDbContext context) : base(context) { }
    }
}
