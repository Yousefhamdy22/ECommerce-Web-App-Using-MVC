using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_MVC.Models
{
    public class Order
    {
        [Key]
        public  int OrderId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public  decimal TotalPrice { get; set; }

        public  DateTime OrderDate { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public  string Customerid { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual Collection<Orderitem> Orderitems { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }

        public virtual Address? Address { get; set; }

    }
}
