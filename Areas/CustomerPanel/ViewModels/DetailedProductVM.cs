using ECommerce_MVC.Areas.SellerPanel.Models;
using ECommerce_MVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_MVC.Areas.CustomerPanel.ViewModels
{
    public class DetailedProductVM
    {

        public int ProductId { get; set; }
        public string? ProductName { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal ProductPrice { get; set; }
        public string? ProductDescription { get; set; }
        public byte[]? ProductImage { get; set; }
        public string? SellerName { get; set; } // SellerName
        // public decimal LowestPrice { get; set; }

        public string? SellerId { get; set; } // note that : SellerID is a `String`

        public string? SubCategory { get; set; }
        public string? Brand { get; set; }

        public int Count { get; set; }

        public SellerProductes? CurrentSellerProduct { get; set; } // Seller record

        // public IEnumerable<SelectListItem>? SellersList;
        public List<SellerProductes>? SellersList;

        public List<Review>? ReviewsList;
    }
}
