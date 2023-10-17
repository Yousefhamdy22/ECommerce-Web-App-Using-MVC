using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ECommerce_MVC.Areas.SellerPanel.Models;

namespace ECommerce_MVC.Models
{
    public class Review
    {
        public int Id { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
        [Required]
        public  string Name { get; set; }
        [Required]
        public  string Description { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [ReadOnly(true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        //nav

        [ForeignKey(nameof(Customer))]
        public string CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }

        [ForeignKey(nameof(Seller))]
        public string SellerId { get; set; }
        public virtual Seller? Seller { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }

        public virtual ICollection<Report>? Reports { get; set; }


    }
}
