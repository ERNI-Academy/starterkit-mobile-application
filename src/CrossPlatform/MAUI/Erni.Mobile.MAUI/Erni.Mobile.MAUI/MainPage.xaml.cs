using Erni.Mobile.MAUI.Services;
using Erni.Mobile.MAUI.Views;

namespace Erni.Mobile.MAUI;

public partial class MainPage : Shell
{
	public MainPage()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
		Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
	}
}

