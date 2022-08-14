using System.Drawing;

namespace ImageFiltrator_ConsoleApp.resources.classes
{
    partial class BitmapImageFilter
    {
        private void GrayScaleFilter()
        {
            float average = 0.0f;
            Color color;
            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Width; x++)
                {
                    color = Image.GetPixel(x, y);
                    average += color.B;
                    average += color.G;
                    average += color.R;
                    average /= 3.0f;
                    int transform_average = (int)average;
                    if (average - 0.5f > transform_average)
                    {
                        transform_average++;
                    }

                    Image.SetPixel(x, y, Color.FromArgb(color.A, transform_average, transform_average, transform_average));
                    average = 0.0f;
                }
            }
        }
        // Could be used by many variations, just multipling sepiaRed/sepiaGreen/sepiaBlue floats by some value for Pink/Olivia/Purple filters
        private void SepiaFilter()
        {
            Color color = new Color();
            float sepiaRed, sepiaGreen, sepiaBlue;
            for (int y = 0; y < Image.Height; y++)
            {
                for (int x = 0; x < Image.Width; x++)
                {
                    color = Image.GetPixel(x, y);
                    // Constant by standart sepia algorithm
                    sepiaRed = 0.393f * color.R + 0.769f * color.G + 0.189f * color.B;
                    sepiaGreen = 0.349f * color.R + 0.686f * color.G + 0.168f * color.B;
                    sepiaBlue = 0.272f * color.R + 0.534f * color.G + 0.131f * color.B;

                    Image.SetPixel(x, y, Color.FromArgb(color.A,
                        Color_Base.ColorConvert(ref color, sepiaRed),
                        Color_Base.ColorConvert(ref color, sepiaGreen),
                        Color_Base.ColorConvert(ref color, sepiaBlue)));
                }
            }
        }
    }
}
