using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using CommunityToolkit.Maui; // 👈 Asegúrate de tener esta línea

namespace Veterinaria;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit() // 👈 ¡IMPORTANTE! Asegúrate de incluir esto
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Quicksand-Light.ttf", "QuicksandLight");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .ConfigureMauiHandlers(handlers =>
            {
#if ANDROID
                handlers.AddHandler(typeof(Entry), typeof(Veterinaria.CustomEntryHandler));
#elif IOS
                handlers.AddHandler(typeof(Entry), typeof(Veterinaria.CustomEntryHandler));
#elif WINDOWS
                handlers.AddHandler(typeof(Entry), typeof(Veterinaria.CustomEntryHandler));
#endif
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
