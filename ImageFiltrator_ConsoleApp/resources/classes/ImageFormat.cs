using ImageFiltrator_ConsoleApp.resources.enums;
using ImageFiltrator_ConsoleApp.resources.interfaces;

namespace ImageFiltrator_ConsoleApp.resources.classes
{
    class ImageFormat : IImageFormat
    {
        public ImageType DefineImage(IImageReader imageReader)
        {
            byte[] checkByFormat = new byte[2];
            if(imageReader.Image != null)
            {
                for(int i = 0; i < 2; i++)
                {
                    checkByFormat[i] = imageReader.Image[i];
                }
                if(checkByFormat[0] == 0x42 && checkByFormat[1] == 0x4d)
                    return ImageType.BMP;
            }

            return ImageType.NONE;
        }
    }
}
