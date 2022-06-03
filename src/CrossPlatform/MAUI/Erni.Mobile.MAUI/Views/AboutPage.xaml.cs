using Erni.Mobile.MAUI.ViewModels;

namespace Erni.Mobile.MAUI.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage(AboutViewModel aboutViewModel)
	{
		InitializeComponent();
		BindingContext = aboutViewModel;
	}
}