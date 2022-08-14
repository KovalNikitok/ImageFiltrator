using System;
using System.Diagnostics;
using System.Drawing;
using ImageFiltrator_ConsoleApp.resources.enums;
using ImageFiltrator_ConsoleApp.resources.interfaces;

namespace ImageFiltrator_ConsoleApp.resources.classes
{
    static class FilterUsing
    {
        public static void UseImageFilter(Bitmap image, IImageFilter imageFilter = null, string outputFileName = null)
        {
            if (image == null)
                return;

            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out int keyFlag))
            {
                if (keyFlag < (int)ImageFilter.NONE && keyFlag >= (int)ImageFilter.HorizontalReflect)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    if (imageFilter == null)
                        imageFilter = new BitmapImageFilter(image, (ImageFilter)keyFlag, outputFileName);
                    imageFilter.ApplyFilter();
                    stopwatch.Stop();
                    Console.WriteLine($"\nConverting by: {stopwatch.ElapsedMilliseconds} ms");
                }
            }
        }
    }
}
