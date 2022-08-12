using ImageFiltrator_ConsoleApp.resources.enums;

namespace ImageFiltrator_ConsoleApp.resources.interfaces
{
    interface IImageFilter
    {
        void ApplyFilter(IImageSignature imageSignature, ImageFilter imageFilter);
    }
}
