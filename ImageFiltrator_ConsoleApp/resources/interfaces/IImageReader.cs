using System.Threading.Tasks;

namespace ImageFiltrator_ConsoleApp.resources.interfaces
{
    interface IImageReader : IImage
    {
        Task<byte[]> ReadImage();
    }
}
