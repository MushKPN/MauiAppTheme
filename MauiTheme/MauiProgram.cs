using CommunityToolkit.Maui.Core;
using MauiTheme.Navigation;
using MauiTheme.ViewModel;
using Microsoft.Extensions.Logging;
using Telerik.Maui.Controls.Compatibility;

namespace MauiTheme;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseTelerik()
            .UseMauiCommunityToolkitCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        //Partie navigation
        builder.Services.AddSingleton<INavigationService, NavigationService>();

        //Inject VM
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddTransient<OptionsViewModel>();
        builder.Services.AddSingleton<ThirdViewModel>();

        //Inject Views
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<OptionsHome>();
        builder.Services.AddSingleton<ThirdPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
