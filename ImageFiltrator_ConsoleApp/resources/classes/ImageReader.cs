using ImageFiltrator_ConsoleApp.resources.interfaces;
using System.Threading.Tasks;

namespace ImageFiltrator_ConsoleApp.resources.classes
{
    abstract class ImageReader : IImageReader
    {
        public ImageReader(string sourceName)
        {
            SourceName = sourceName;
        }

        public virtual string SourceName { get; set; }
        public abstract byte[] Image { get; }

        public abstract Task<byte[]> ReadImage();
    }
}
