namespace MauiTheme;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        //Add navigation reoutes
        Routing.RegisterRoute(nameof(OptionsHome), typeof(OptionsHome));
        Routing.RegisterRoute(nameof(ThirdPage), typeof(ThirdPage));
    }
}
