using ECommerce_MVC.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce_MVC.Areas.AdminPanel.Models
{
    public class Admin
    {
        [ForeignKey("ApplicationUser")]
        public  string id { get; set; }

        public  virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
