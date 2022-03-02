using Erni.Mobile.MAUI.Helpers;
using System.Globalization;

namespace Erni.Mobile.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("en")).GetAwaiter().GetResult();
		MainPage = new MainPage();
	}
}
