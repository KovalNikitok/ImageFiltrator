namespace ImageFiltrator_ConsoleApp.resources.interfaces
{
    interface IImageSignature : IImage
    {
        byte[] ImageHeader { get; set; }
        byte[] ImageData { get; set; }
        byte[] ImageTail { get; set; }
        
    }
}
