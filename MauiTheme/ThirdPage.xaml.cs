using MauiTheme.ViewModel;

namespace MauiTheme;

public partial class ThirdPage : BaseContentPage
{
	public ThirdPage(ThirdViewModel viewModel, IServiceProvider provider) : base(viewModel, provider)
    {
		InitializeComponent();
	}
}