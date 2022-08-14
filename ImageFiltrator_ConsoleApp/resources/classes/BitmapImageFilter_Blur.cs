using System.Drawing;

namespace ImageFiltrator_ConsoleApp.resources.classes
{
    partial class BitmapImageFilter
    {
        public void BlurFilter()
        {
            // Copy original image to apply filter by defined Blur algorithm
            Bitmap imageCopy = Image.Clone(new Rectangle(0, 0, Image.Width, Image.Height), Image.PixelFormat);

            float averageRed = 0.0f, averageGreen = 0.0f, averageBlue = 0.0f;
            Color color = new Color();
            // Transformation by Blur algorithm for image copy
            for (int y = 0, height = Image.Height; y < height; y++)
            {
                for (int x = 0, width = Image.Width, count = 0; x < width; x++)
                {
                    if (y - 1 >= 0)
                    {
                        if (x - 1 >= 0)
                        {
                            color = Image.GetPixel(x - 1, y - 1);
                            averageRed += color.R;
                            averageGreen += color.G;
                            averageBlue += color.B;
                            count++;
                        }
                        if (x + 1 < width)
                        {
                            color = Image.GetPixel(x + 1, y - 1);
                            averageRed += color.R;
                            averageGreen += color.G;
                            averageBlue += color.B;
                            count++;
                        }
                        color = Image.GetPixel(x, y - 1);
                        averageRed += color.R;
                        averageGreen += color.G;
                        averageBlue += color.B;
                        count++;
                    }
                    if (y + 1 < height)
                    {
                        if (x - 1 >= 0)
                        {
                            color = Image.GetPixel(x - 1, y + 1);
                            averageRed += color.R;
                            averageGreen += color.G;
                            averageBlue += color.B;
                            count++;
                        }
                        if (x + 1 < width)
                        {
                            color = Image.GetPixel(x + 1, y + 1);
                            averageRed += color.R;
                            averageGreen += color.G;
                            averageBlue += color.B;
                            count++;
                        }
                        color = Image.GetPixel(x, y + 1);
                        averageRed += color.R;
                        averageGreen += color.G;
                        averageBlue += color.B;
                        count++;
                    }
                    if (x - 1 >= 0)
                    {
                        color = Image.GetPixel(x - 1, y);
                        averageRed += color.R;
                        averageGreen += color.G;
                        averageBlue += color.B;
                        count++;
                    }
                    if (x + 1 < width)
                    {
                        color = Image.GetPixel(x + 1, y);
                        averageRed += color.R;
                        averageGreen += color.G;
                        averageBlue += color.B;
                        count++;
                    }

                    averageRed /= count;
                    averageGreen /= count;
                    averageBlue /= count;

                    imageCopy.SetPixel(x, y, Color.FromArgb(Image.GetPixel(x, y).A,
                        Color_Base.ColorConvert(ref color, averageRed),
                        Color_Base.ColorConvert(ref color, averageGreen),
                        Color_Base.ColorConvert(ref color, averageBlue)));

                    count = 0;
                    averageRed = 0.0f;
                    averageGreen = 0.0f;
                    averageBlue = 0.0f;
                }
            }

            // Append filtrated copy of image to original
            for (int y = 0; y < Image.Height - 1; y++)
            {
                for (int x = 0; x < Image.Width; x++)
                {
                    Image.SetPixel(x, y, imageCopy.GetPixel(x, y));
                }
            }
        }
    }
}
