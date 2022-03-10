using Erni.Mobile.MAUI.Services;
using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using Erni.Mobile.MAUI.ViewModels;

namespace Erni.Mobile.MAUI.Views;

public partial class ChangeLanguagePage : ContentPage
{
	public ChangeLanguagePage(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
	{
		InitializeComponent();
		BindingContext = new ChangeLanguageViewModel(loggingService, applicationSettingsService);
	}
}