using MauiTheme.ViewModel;

namespace MauiTheme;

public partial class OptionsHome : BaseContentPage
{
    public OptionsHome(OptionsViewModel viewModel, IServiceProvider provider) : base(viewModel, provider)
    {
        InitializeComponent();
    }
}