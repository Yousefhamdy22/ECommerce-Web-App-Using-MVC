using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class ReportRepService : EFCoreRepos<Report>
    {
        public ReportRepService(ApplicationDbContext context) : base(context) { }
    }
}
