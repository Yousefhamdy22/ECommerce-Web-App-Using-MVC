using ECommerce_MVC.Areas.SellerPanel.Models;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_MVC.Models
{
    public class Brand
    {
        public  int Id { get; set; }

       
        [StringLength(20)]
        public string  Name { get; set; }

        // navigate
        
        public Address? Address { get; set; }

        

        public virtual ICollection<Product>? Products { get; set; }

    }
}
