using System.ComponentModel.DataAnnotations;

namespace ECommerce_MVC.Areas.AdminPanel.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Navigation property for Products
        public virtual ICollection<SubCategory>? SubCategories { get; set; }

    }
}
