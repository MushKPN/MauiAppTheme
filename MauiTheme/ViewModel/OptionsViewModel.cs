using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiTheme.ViewModel;

public partial class OptionsViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<string> myItems = [];

    public OptionsViewModel(IServiceProvider provider) : base(provider)
    {
        MyItems.Add("A");
        MyItems.Add("B");
        MyItems.Add("C");
    }

    [RelayCommand]
    public async Task GotoThirdPage()
    {
        await navigationService.NavigateToAsync(nameof(ThirdPage));
    }
}
