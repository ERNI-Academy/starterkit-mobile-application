using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using Erni.Mobile.MAUI.ViewModels;

namespace Erni.Mobile.MAUI.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
	{
		InitializeComponent();
		BindingContext = new AboutViewModel(loggingService,applicationSettingsService);
	}
}