using Erni.Mobile.MAUI.ViewModels;

namespace Erni.Mobile.MAUI.Views;

public partial class ChangeLanguagePage : ContentPage
{
	public ChangeLanguagePage(ChangeLanguageViewModel changeLanguageViewModel)
	{
		InitializeComponent();
		BindingContext = changeLanguageViewModel;
	}
}