using ECommerce_MVC.Areas.Identity.Data;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce_MVC.Areas.SellerPanel.Models
{
    public class Seller
    {
        
        [ForeignKey("ApplicationUser")]
        public string Sellerid  { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Balance { get; set; } = 0;

        public  int  TaxNumber { get; set; }

        // navigation
        public ApplicationUser? ApplicationUser { get; set; }



    }
}
