﻿namespace ECommerce_MVC.Services
{
    public class FileServices
    {
        IWebHostEnvironment environment;
        public FileServices(IWebHostEnvironment env) => environment = env;
        Tuple<int, string> SaveImage(IFormFile imagefile)
        {
            try
            {
                var wwwPath = environment.WebRootPath;
                var path = Path.Combine(wwwPath, "Uploads");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                // Check the allowed extenstions
                var ext = Path.GetExtension(imagefile.FileName);
                var allowedExtensions = new string[] { ".jpg", ".png", ".jpeg" };

                if (!allowedExtensions.Contains(ext))
                {
                    var msg = string.Format("Only {0} extensions are allowed", string.Join(",", allowedExtensions));
                    return new Tuple<int, string>(0, msg);
                }

                var uniqueString = Guid.NewGuid().ToString();
                var newFileName = uniqueString + ext;
                var fileWithPath = Path.Combine(path, newFileName);
                var stream = new FileStream(fileWithPath, FileMode.Create);
                imagefile.CopyTo(stream);
                stream.Close();
                return new Tuple<int, string>(1, newFileName);



            }
            catch
            {
                return new Tuple<int, string>(0, "Error has occured");
            }
        }
            public bool DeleteImage(string imageFileName)
            {
                try
                {
                    var wwwPath = environment.WebRootPath;
                    var path = Path.Combine(wwwPath, "Uploads\\", imageFileName);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                        return true;
                    }

                    return false;
                }
                catch
                {
                    return false;
                }
            }

    }
}
