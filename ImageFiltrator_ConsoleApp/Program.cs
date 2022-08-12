using ImageFiltrator_ConsoleApp.resources.classes;
using ImageFiltrator_ConsoleApp.resources.interfaces;
using ImageFiltrator_ConsoleApp.resources.enums;
using System;

namespace ImageFiltrator_ConsoleApp
{
    class Program
    {
        static void UseImageFilter(IImageSignature imageSignature)
        {
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int keyFlag))
            {
                if (keyFlag <= (int)ImageFilter.Blur && keyFlag >= (int)ImageFilter.Reflect)
                {
                    IImageFilter imageFilter = null;// = new SomeImageFilterClass(...);
                    imageFilter.ApplyFilter(imageSignature, ImageFilter.Reflect); //keyFlag
                }
            }
        }
        static void Main()
        {
            // IImageReader interface realization accept source string of data source what you need(todo)
            // and tried to transform it's content to bytes array
            IImageReader imageReader = new FileImageReader("1.bmp");

            // IImageFormat interface has some method for define image format by it's signature
            IImageFormat imageFormat = new ImageFormat();

            //  imageFormat.DefineImage(imageReader) defines what's format of file
            //  by files headers (from documentation of image files signature)
            ImageType imageType = imageFormat.DefineImage(imageReader);

            if (imageReader != null && imageType != ImageType.NONE)
            {
                IImageSignature imageSignature = null;
                switch (imageType)
                {
                    // IImageSignature interface transform bytes array of image to it's content by image format signature
                    case ImageType.BMP:
                        imageSignature = new BMPImage();
                        break;
                    case ImageType.PNG:
                        break;
                    case ImageType.JPG:
                        break;
                    case ImageType.JPEG:
                        break;
                    default:
                        Console.WriteLine("Undefined image type!");
                        break;
                }
                // IImageFilter interface realization gives some filters for changing images
                Console.Write("0 - Reflect\n1 - Sepia\n2 - GrayScale\n3 - Blur\nEnter filter num:");
                UseImageFilter(imageSignature);
            }
        }
    }
}
