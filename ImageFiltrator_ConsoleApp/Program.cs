using System.Drawing;
using System;
using ImageFiltrator_ConsoleApp.resources.classes;

namespace ImageFiltrator_ConsoleApp
{
    class Program
    {
        static void Main(string[] argv)
        {
            Bitmap image;
            string outputFileName = "output";
            if (argv.Length > 0)
            {
                try
                {
                    image = new Bitmap(argv[0]);
                    if (argv.Length > 1)
                        outputFileName = argv[1];
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
            FilterUsing.UseImageFilter(image: image, outputFileName: outputFileName);
        }



    }
}
