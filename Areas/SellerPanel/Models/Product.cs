using System.ComponentModel.DataAnnotations;

namespace ECommerce_MVC.Areas.SellerPanel.Models
{
    public class Product
    {

        public  int  id { get; set; }

        public  int Serialnum { get; set; }

        [Required]
        [StringLength(100)]
        public  string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public  string Productimage { get; set; }




    }
}
