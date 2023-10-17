using ECommerce_MVC.Areas.CustomerPanel.ViewModels;
using ECommerce_MVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce_MVC.Areas.SellerPanel.Models
{
    public class SellerProductes
    {
        public int Id { get; set; }

        public int Count { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Price { get; set; }

        [ForeignKey(nameof(Seller))]
        public string SellerId { get; set; }
        public virtual Seller? Seller { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }

        public virtual ICollection<Orderitem>? OrderItems { get; set; }
        public virtual ICollection<CartItem>? CartItems { get; set; }

        [NotMapped]
        public string DataTextFieldLabel
        {
            get
            {
                return $"{Seller?.ApplicationUser?.FirstName} | ${Math.Round(Price, 2)}";
            }
        }




    }
}
