using ImageFiltrator_ConsoleApp.resources.classes;
using ImageFiltrator_ConsoleApp.resources.interfaces;
using ImageFiltrator_ConsoleApp.resources.enums;
using System.Drawing;
using System;
using System.IO;

namespace ImageFiltrator_ConsoleApp
{
    class Program
    {
        static void Main(string[] argv)
        {
            Bitmap image;
            if (argv.Length > 0)
            {
                try
                {
                    image = new Bitmap(argv[1]);
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException || ex is NullReferenceException)
                    {
                        Console.WriteLine("Write source path to image like: \n" +
                                                    "./program_name c:\\img\\myimage.png\nor\n" +
                                                    "program_name.exe c:\\img\\myimage.png");
                        return;
                    }
                    throw;
                }
            }
            else
                image = new Bitmap("3.png");
            Console.Write("0 - Horizontal Reflect\n1 - Vertical Reflect\n2 - Sepia\n3 - GrayScale\n4 - Blur\nEnter filter num:");
            //IImageFilter imageFilter = new BitmapImageFilter();
            UseImageFilter(image);
        }

        static void UseImageFilter(Bitmap image, IImageFilter imageFilter = null)
        {
            if (image == null)
                return;

            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int keyFlag))
            {
                if (keyFlag < (int)ImageFilter.NONE && keyFlag >= (int)ImageFilter.HorizontalReflect)
                {
                    if (imageFilter == null)
                        imageFilter = new BitmapImageFilter(image, (ImageFilter)keyFlag);
                    imageFilter.ApplyFilter();
                }
            }
        }

    }
}
