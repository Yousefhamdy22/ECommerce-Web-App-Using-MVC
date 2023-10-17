using ECommerce_MVC.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
namespace ECommerce_MVC.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public  string StreerName { get; set; }
        [Required]
        public string BulidingNum { get; set; }
        [Required]
        public  string City { get; set; }
        [Required]
        public  string  Region { get; set; }


        // nav 

        public  int Userid { get; set; }

        public virtual ApplicationUser? ApplicationUser { get; set; }







    }
}
