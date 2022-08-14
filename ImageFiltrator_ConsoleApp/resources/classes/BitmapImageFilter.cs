﻿using ImageFiltrator_ConsoleApp.resources.enums;
using ImageFiltrator_ConsoleApp.resources.interfaces;
using System.Drawing;
using System.IO;

namespace ImageFiltrator_ConsoleApp.resources.classes
{
    partial class BitmapImageFilter : IImageFilter
    {
        public ImageFilter ImageFilter { get; set; }
        public Bitmap Image { get; set; }
        public string NameFileToSave { get; set; }
        public BitmapImageFilter(Bitmap image)
        {
            Image = image;
        }
        public BitmapImageFilter(Bitmap image, ImageFilter imageFilter) : this(image)
        {
            ImageFilter = imageFilter;
        }
        public BitmapImageFilter(Bitmap image, ImageFilter imageFilter, string newFileName) : this(image, imageFilter)
        {
            NameFileToSave = newFileName;
        }
        public void ApplyFilter()
        {
            if (Image == null)
                return;
            switch (ImageFilter)
            {
                case ImageFilter.HorizontalReflect:
                    HorizontalReflectFilter();
                    break;
                case ImageFilter.VerticalReflect:
                    VerticalReflectFilter();
                    break;
                case ImageFilter.Sepia:
                    SepiaFilter();
                    break;
                case ImageFilter.GrayScale:
                    GrayScaleFilter();
                    break;
                case ImageFilter.Blur:
                    BlurFilter();
                    break;
                default:
                    System.Console.WriteLine("Undefined image filter!");
                    return;
            }
            SaveImage(NameFileToSave);
        }

        private void SaveImage(string fileName = null)
        {
            if (fileName == null)
                fileName = $"output";

            using (FileStream fileStream = new FileStream(
                string.Concat(fileName, ".", Image.RawFormat.ToString().ToLower()),
                FileMode.Create))
            {
                Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Png);
                Image.Dispose();
            }
        }
    }
}
