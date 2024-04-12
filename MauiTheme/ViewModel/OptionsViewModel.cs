using CommunityToolkit.Mvvm.Input;

namespace MauiTheme.ViewModel;

public partial class OptionsViewModel : BaseViewModel
{
    public OptionsViewModel(IServiceProvider provider) : base(provider)
    {

    }

    [RelayCommand]
    public async Task GotoThirdPage()
    {
        await navigationService.NavigateToAsync(nameof(ThirdPage));
    }
}
