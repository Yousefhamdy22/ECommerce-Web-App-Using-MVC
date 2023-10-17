using ECommerce_MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_MVC.Areas.CustomerPanel.ViewModels
{
    public class CustomerOrderVM
    {

        public int OrderId { get; set; }

        public string CustomerId { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }

        public  List<CustomerOrderItemVM> OrderItems { get; set; }

        public Address Address { get; set; }
    }
}
