using Microsoft.Extensions.Logging;

namespace ElMUNDO
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
                    fonts.AddFont("Coffee Soda.ttf", "CoffeSoda");
                    fonts.AddFont("Avocade Free.ttf", "AvocadeF");
                    fonts.AddFont("Rubica PERSONAL USE ONLY!.ttf", "RUpeUO");
                    fonts.AddFont("Loches.ttf", "Loches");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
