using Microsoft.Extensions.Logging;
using IFridge.MVVM.Models;
using IFridge.Repositories;
using CommunityToolkit.Maui;
using ZXing.Net.Maui.Controls;

namespace IFridge
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
                builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseBarcodeReader();
            builder.Services.AddSingleton<BaseRepository<Drink>>();
            builder.Services.AddSingleton<BaseRepository<Fridge>>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}