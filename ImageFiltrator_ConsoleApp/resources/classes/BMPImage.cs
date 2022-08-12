using ImageFiltrator_ConsoleApp.resources.interfaces;

namespace ImageFiltrator_ConsoleApp.resources.classes
{
    class BMPImage : IImageSignature
    {
        public BMPImage() { }

        public byte[] ImageHeader { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public byte[] ImageData { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public byte[] ImageTail { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public byte[] Image => throw new System.NotImplementedException();
    }
}
