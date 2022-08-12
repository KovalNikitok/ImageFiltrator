using System.IO;
using System.Threading.Tasks;

namespace ImageFiltrator_ConsoleApp.resources.classes
{
    class FileImageReader : ImageReader
    {
        public FileImageReader(string fileName): base(fileName) 
        {
            image = ReadImage().Result;
        }
        private byte[] image;
        public override byte[] Image 
        { 
            get => image; 
        }
        public override async Task<byte[]> ReadImage()
        {
            byte[] buffer;
            using (var streamReader = new FileStream(path: SourceName, mode: FileMode.Open))
            {
                buffer = new byte[streamReader.Length];
                if(streamReader.CanRead)
                {
                    await streamReader.ReadAsync(buffer: buffer, offset: 0, count: buffer.Length);
                    return buffer;
                }
            }
            return null;
        }
    }
}
