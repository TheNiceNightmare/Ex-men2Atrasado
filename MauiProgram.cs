using Exámen2.Views;
using Exámen2.ViewModels;
using Microsoft.Extensions.Logging;

namespace Exámen2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<Calcular>();
            builder.Services.AddSingleton<CalcularViewModels>();
            return builder.Build();
        }
    }
}