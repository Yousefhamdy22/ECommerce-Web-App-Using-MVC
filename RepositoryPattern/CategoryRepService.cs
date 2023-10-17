using ECommerce_MVC.Areas.AdminPanel.Models;
using ECommerce_MVC.Areas.Identity.Data;

namespace ECommerce_MVC.RepositoryPattern
{
    public class CategoryRepService : EFCoreRepos<Category>
    {
        public CategoryRepService(ApplicationDbContext context) : base(context) { }
    }
}
