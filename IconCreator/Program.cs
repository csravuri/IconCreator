using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IconCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter main image full path");
            var mainImage = Console.ReadLine();
            //var mainImage = @"D:\GoFileClient.png";

            Console.WriteLine("Enter folder to save resized images");

            var basePath = $@"{Console.ReadLine()}\icons\resizeImages";
            //var basePath = @"D:\WhoKnows\Courses\Applications\GoFileClient\GoFile\icons\resizeImages";

            var logo = Image.FromFile(mainImage);

            saveResizeImage(logo, new Size(72, 72), $@"{basePath}\mipmap-hdpi", "icon.png");
            saveResizeImage(logo, new Size(48, 48), $@"{basePath}\mipmap-mdpi", "icon.png");
            saveResizeImage(logo, new Size(96, 96), $@"{basePath}\mipmap-xhdpi", "icon.png");
            saveResizeImage(logo, new Size(144, 144), $@"{basePath}\mipmap-xxhdpi", "icon.png");
            saveResizeImage(logo, new Size(192, 192), $@"{basePath}\mipmap-xxxhdpi", "icon.png");

            var foreground = Image.FromFile(mainImage);

            saveResizeImage(foreground, new Size(162, 162), $@"{basePath}\mipmap-hdpi", "launcher_foreground.png");
            saveResizeImage(foreground, new Size(108, 108), $@"{basePath}\mipmap-mdpi", "launcher_foreground.png");
            saveResizeImage(foreground, new Size(216, 216), $@"{basePath}\mipmap-xhdpi", "launcher_foreground.png");
            saveResizeImage(foreground, new Size(324, 324), $@"{basePath}\mipmap-xxhdpi", "launcher_foreground.png");
            saveResizeImage(foreground, new Size(432, 432), $@"{basePath}\mipmap-xxxhdpi", "launcher_foreground.png");

            Console.WriteLine("Conversion complete. Click and key");
            Console.ReadKey();

        }

        public static void saveResizeImage(Image imgToResize, Size size, string folderPath, string imageName)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            Image newImage = (Image)(new Bitmap(imgToResize, size));
            newImage.Save(Path.Combine(folderPath, imageName));
        }
    }
}
