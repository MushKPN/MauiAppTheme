namespace MauiTheme.ViewModel;

public partial class ThirdViewModel : BaseViewModel
{
    public ThirdViewModel(IServiceProvider provider) : base(provider)
    {
    }

    public override async Task InitViewAsync()
    {
        await base.InitViewAsync();
        await Task.Delay(2000); //Simulate long running task
    }
}
