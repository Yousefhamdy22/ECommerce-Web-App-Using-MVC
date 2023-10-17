using ECommerce_MVC.Areas.SellerPanel.Models;

namespace ECommerce_MVC.ViewModeles
{
    public class FrontPageVM
    {
        public List<Product> FeaturedProducts { get; set; }
        public List<Product> BestSelllerProducts { get; set; }
    }
}
