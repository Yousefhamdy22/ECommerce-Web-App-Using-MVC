using ECommerce_MVC.Areas.SellerPanel.Models;
using ECommerce_MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_MVC.Areas.CustomerPanel.ViewModels
{
    public class CustomerOrderItemVM
    {
        public int Id { get; set; }

        public OrderStatus Status { get; set; }

        public int SellerProductId { get; set; }

        public int Count { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        //
        [Required]
        public Seller Seller { get; set; }
        [Required]
        public Product Product { get; set; }


    }
}
