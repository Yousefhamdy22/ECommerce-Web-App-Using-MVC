using ECommerce_MVC.Areas.AdminPanel.Models;
using ECommerce_MVC.Areas.Identity.Data;

namespace ECommerce_MVC.RepositoryPattern
{
    public class AdminRepService : EFCoreRepos<Admin>
    {
        public AdminRepService(ApplicationDbContext context) : base(context) { }
    }
}
