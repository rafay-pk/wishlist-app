using wishlist_app.forms;
namespace wishlist_app;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new viewer());
    }
}