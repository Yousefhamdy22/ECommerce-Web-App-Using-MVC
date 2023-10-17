using System.ComponentModel.DataAnnotations;

namespace ECommerce_MVC.ViewModeles
{
    public class EditReviewVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
    }
}
