
namespace ImageFiltrator_ConsoleApp.resources.interfaces
{
    interface IImage
    {
        byte[] Image { get; set; }
        byte[] ImageHeader { get; set; }
        byte[] ImageBody { get; set; }
        byte[] ImageTail { get; set; }
        
    }
}
