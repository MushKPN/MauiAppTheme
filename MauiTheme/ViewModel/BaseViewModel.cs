using CommunityToolkit.Mvvm.ComponentModel;
using MauiTheme.Navigation;

namespace MauiTheme.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    #region Private variables
    protected readonly IServiceProvider provider;

    protected readonly INavigationService navigationService;

    [ObservableProperty]
    private bool isLoading;
    #endregion

    #region Constructor
    public BaseViewModel(IServiceProvider provider)
    {
        this.provider = provider;
        navigationService = provider.GetRequiredService<INavigationService>();
    }
    #endregion

    #region Methods
#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
    public virtual async Task InitViewAsync()
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
    {
        //Méthode virtuelle dédiée au chargement asynchrone des écrans (overridée de manière spécifique sur chaque enfant)
    }
    #endregion
}