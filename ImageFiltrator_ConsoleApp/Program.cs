using ImageFiltrator_ConsoleApp.resources.interfaces;
using ImageFiltrator_ConsoleApp.resources.enums;
using System;

namespace ImageFiltrator_ConsoleApp
{
    class Program
    {
        static void UseImageFilter()
        {
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int keyFlag))
            {
                if (keyFlag <= (int)ImageFilter.Blur && keyFlag >= (int)ImageFilter.Reflect)
                {
                    //imageFilter.ApplyFilter(image, ImageFilter.Reflect); //keyFlag
                }
            }
        }
        static void Main()
        {
            IImageReader imageReader = null; // = new SomeImageReader(...)
            IImage image = null; 
            if (imageReader != null && imageReader.DefineImage().HasFlag(ImageType.BMP))
                return; // image = new SomeImageClass(...) else image = new AnotherImageClass(...);

            IImageFilter imageFilter = null; // = new SomeImageFilterClass(...);
            Console.Write("0 - Reflect\n1 - Sepia\n2 - GrayScale\n3 - Blur\nEnter filter num:");
            UseImageFilter();
        }
    }
}
