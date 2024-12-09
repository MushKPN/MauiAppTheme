using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiTheme.ViewModel;

public partial class MainPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private bool isDarkTheme;

    public MainPageViewModel(IServiceProvider provider) : base(provider)
    {
        IsDarkTheme = Application.Current!.RequestedTheme == AppTheme.Dark;
    }

    [RelayCommand]
    private async Task ChangeAppTheme()
    {
        try
        {
            IsLoading = true;
            Application.Current!.UserAppTheme = IsDarkTheme ? AppTheme.Light : AppTheme.Dark;
            IsDarkTheme = !IsDarkTheme;

            await Task.Delay(2000); //Simulate long running task
        }
        catch (Exception)
        {
            //log error
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    private async Task OpenOptions()
    {
        await navigationService.NavigateToAsync(nameof(OptionsHome));
    }

    [RelayCommand]
    private void ExitApp()
    {
        navigationService.CloseApplication();
    }
}
