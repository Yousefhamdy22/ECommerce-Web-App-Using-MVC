namespace ECommerce_MVC.Services
{
    public interface IFileServices
    {

        Tuple<int, string> SaveImage(IFormFile imageFile);
        public bool DeleteImage(string imageFileName);
    }
}
