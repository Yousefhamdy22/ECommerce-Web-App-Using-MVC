using ECommerce_MVC.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace ECommerce_MVC.Areas.AdminPanel.Models
{
    public class ManagrmentRoleVM
    {
        public List<ApplicationUser>? Users { get; set; }
        public List<IdentityRole>? Roles { get; set; }
        public string? SelectedUserId { get; set; }
        public string? SelectedRoleId { get; set; }
    }
}
