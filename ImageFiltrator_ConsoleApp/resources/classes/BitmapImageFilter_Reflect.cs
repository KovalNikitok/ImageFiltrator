using System.Drawing;

namespace ImageFiltrator_ConsoleApp.resources.classes
{
    partial class BitmapImageFilter
    {
        private void HorizontalReflectFilter()
        {
            if (Image == null)
                return;

            Color tempPixel;
            for (int i = 0, length = Image.Width / 2; i < length; i++)
            {
                for (int j = 0; j < Image.Height; j++)
                {
                    tempPixel = Image.GetPixel(i, j);
                    Image.SetPixel(i, j, Image.GetPixel(Image.Width - i - 1, j));
                    Image.SetPixel(Image.Width - i - 1, j, tempPixel);
                }
            }

        }
        private void VerticalReflectFilter()
        {
            if (Image == null)
                return;

            Color tempPixel;
            for (int i = 0, length = Image.Width; i < length; i++)
            {
                for (int j = 0; j < Image.Height / 2; j++)
                {
                    tempPixel = Image.GetPixel(i, j);
                    Image.SetPixel(i, j, Image.GetPixel(i, Image.Height - j - 1));
                    Image.SetPixel(i, Image.Height - j - 1, tempPixel);
                }
            }

        }
    }
}
