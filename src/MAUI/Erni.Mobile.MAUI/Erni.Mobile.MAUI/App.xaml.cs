using Erni.Mobile.MAUI.Helpers;
using Erni.Mobile.MAUI.Services;
using System.Globalization;

namespace Erni.Mobile.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("en")).GetAwaiter().GetResult();
		DependencyService.Register<MockDataStore>();
		MainPage = new MainPage();
	}
}
