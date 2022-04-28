using Erni.Mobile.MAUI.Helpers;
using Erni.Mobile.MAUI.Services;
using System.Globalization;

namespace Erni.Mobile.MAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        InitializeLanguage();
        DependencyService.Register<MockDataStore>();
        MainPage = new MainPage();
    }

    private static void InitializeLanguage()
    {
        LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("en")).GetAwaiter().GetResult();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        // Workaround for: 'Either set MainPage or override CreateWindow.'??
        if (this.MainPage == null)
        {
            this.MainPage = new MainPage();
        }

        return base.CreateWindow(activationState);
    }
}
