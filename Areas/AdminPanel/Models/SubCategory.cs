using ECommerce_MVC.Areas.SellerPanel.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_MVC.Areas.AdminPanel.Models
{
    public class SubCategory
    {

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public  string Name { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
