using ECommerce_MVC.Areas.AdminPanel.Models;
using ECommerce_MVC.Areas.Identity.Data;

namespace ECommerce_MVC.RepositoryPattern
{
    public class SubCategoryRepService : EFCoreRepos<SubCategory>
    {
        public SubCategoryRepService(ApplicationDbContext context) : base(context) { }
    }
}
