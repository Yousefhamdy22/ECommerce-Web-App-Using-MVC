using ECommerce_MVC.Areas.SellerPanel.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce_MVC.Models
{
    public enum OrderStatus
    {
        Pending,
        Processing,
        OutForDelivery,
        Delivered,
        Cancelled
    }
    public class Orderitem
    {
        [Key]
        public  int Id  { get; set; }


        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }


        [DefaultValue(OrderStatus.Pending)]
        [EnumDataType(enumType: typeof(OrderStatus))]
        public OrderStatus StutesofOrder { get; set; } = OrderStatus.Pending;

        [Required]
        [Range(0,10)]
        public  int  Count { get; set; }


        // navigate
        [ForeignKey("Order")]
        public  int  Orderid { get; set; }
        public virtual Order? Orders { get; set; }


        [Required]
        [ForeignKey("SellerProductes")]
        public int SellerProductId { get; set; }
        public  virtual SellerProductes? SellerProductes  { get; set; }





    }
}
