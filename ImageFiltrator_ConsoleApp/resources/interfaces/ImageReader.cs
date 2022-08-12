using ImageFiltrator_ConsoleApp.resources.enums;

namespace ImageFiltrator_ConsoleApp.resources.interfaces
{
    interface IImageReader
    {
        byte[] ReadImage();
        ImageType DefineImage();
    }
}
