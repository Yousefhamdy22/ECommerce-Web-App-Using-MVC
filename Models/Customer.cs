using ECommerce_MVC.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce_MVC.Models
{
    public class Customer
    {
        [ForeignKey("ApplicationUser")]
        [Required]
        public  string CustmerId  { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }
        //  nav
        public virtual ICollection<ApplicationUser> ApplicatonUsers { get; set; }
        public virtual ICollection<CartItem> Users { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        






    }
}
