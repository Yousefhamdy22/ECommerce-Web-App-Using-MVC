using ECommerce_MVC.Areas.Identity.Data;
using ECommerce_MVC.Models;

namespace ECommerce_MVC.RepositoryPattern
{
    public class AddressRepService : EFCoreRepos<Address>
    {
        public AddressRepService(ApplicationDbContext context) : base(context) { }


    }
}
