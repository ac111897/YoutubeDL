using Microsoft.Extensions.DependencyInjection;
using DotNetTools.SharpGrabber.YouTube;
using DotNetTools.SharpGrabber;

namespace YoutubeDL;
#nullable disable
internal static class Program
{
    public static readonly string ImagePath = $"{AppDomain.CurrentDomain.BaseDirectory}/images/";
    public static IServiceProvider ServiceProvider { get; set; }
    private static void ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddSingleton<IGrabber>(x => GrabberBuilder.New().UseDefaultServices().AddYouTube().Build());

        ServiceProvider = services.BuildServiceProvider();
    }
    public static T GetService<T>(this IServiceProvider provider)
    {
        return (T)provider.GetService(typeof(T));
    }
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        if (Directory.Exists(ImagePath))
        {
            try
            {
                Directory.Delete(ImagePath, true);
            }
            catch
            {

            }
        }
       
        ConfigureServices();
        Application.Run(new YoutubeDLForm());
    }
}
