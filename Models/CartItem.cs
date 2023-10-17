using ECommerce_MVC.Areas.SellerPanel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce_MVC.Models
{
    public class CartItem
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Customer))]
        public  string CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        [ForeignKey("SellerProduct")]
        public int SellerProductId { get; set; }

        public virtual SellerProductes? SellerProduct { get; set; }

        [Required]
        public int Count { get; set; }
    }
}
