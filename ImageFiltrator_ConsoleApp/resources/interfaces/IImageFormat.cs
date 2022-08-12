using ImageFiltrator_ConsoleApp.resources.enums;

namespace ImageFiltrator_ConsoleApp.resources.interfaces
{
    interface IImageFormat
    {
        ImageType DefineImage(IImageReader imageReader);
    }
}
