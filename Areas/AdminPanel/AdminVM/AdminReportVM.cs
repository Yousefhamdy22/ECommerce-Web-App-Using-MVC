namespace ECommerce_MVC.Areas.AdminPanel.AdminVM
{
    public class Reporting
    {

        public int ReportId { get; set; }

        public bool IsReviewDeleted { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsSolved { get; set; }

        public DateTime? SolveDate { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int ReviewId { get; set; }

        public  string ReviewName { get; set; }

        public  string ReviewDescription { get; set; }

        public  string SellerId { get; set; }

        public string SellerName { get; set; }

        public  string CustomerId { get; set; }

        public  string CustomerName { get; set; }

        public  string ApplicationUserId { get; set; }

        public  string ApplicationUserName { get; set; }
    }
}
