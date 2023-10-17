using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class ReviewRepService : EFCoreRepos<Review>
    {
        public ReviewRepService(ApplicationDbContext context) : base(context) { }
    }
}
