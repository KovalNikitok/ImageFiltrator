
using System.Drawing;

namespace ImageFiltrator_ConsoleApp.resources.classes
{
    static class Color_Base
    {
        public static int ColorConvert(this ref Color color, float input_color)
        {
            int hex_color;
            if (input_color > 255.0f)
            {
                hex_color = 255;

            }
            else if (input_color < 0.0f)
            {
                hex_color = 0;

            }
            else if (input_color - 0.5f > (int)input_color)
            {
                hex_color = (int)input_color + 1;

            }
            else
                hex_color = (int)input_color;
            return hex_color;
        }
    }
}
