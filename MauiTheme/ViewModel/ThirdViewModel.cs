using CommunityToolkit.Mvvm.ComponentModel;
using MauiTheme.Helpers;
using System.Collections.ObjectModel;

namespace MauiTheme.ViewModel;

public partial class ThirdViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<TestDto> myItems = [];

    public ThirdViewModel(IServiceProvider provider) : base(provider)
    {
        MyItems.Add(new TestDto() { Id = 1, Name = "Test 1" });
        MyItems.Add(new TestDto() { Id = 2, Name = "Test 2" });
        MyItems.Add(new TestDto() { Id = 3, Name = "Test 3" });
    }

    public override async Task InitViewAsync()
    {
        await base.InitViewAsync();
        //await Task.Delay(2000); //Simulate long running task
    }
}
