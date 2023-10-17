using ECommerce_MVC.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce_MVC.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? ProfilePicture { get; set; }

        public virtual List<Address>? Addresses { get; set; }

        [DefaultValue(false)]
        public bool IsBlocked { get; set; } = false;

    }
}
