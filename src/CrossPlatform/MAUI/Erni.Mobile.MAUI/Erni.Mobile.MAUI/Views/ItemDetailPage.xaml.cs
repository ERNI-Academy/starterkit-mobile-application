using Erni.Mobile.MAUI.Services.Configuration;
using Erni.Mobile.MAUI.Services.Logging;
using Erni.Mobile.MAUI.ViewModels;

namespace Erni.Mobile.MAUI.Views;

public partial class ItemDetailPage : ContentPage
{
	public ItemDetailPage(ILoggingService loggingService, IApplicationSettingsService applicationSettingsService)
	{
		InitializeComponent();
		BindingContext = new ItemDetailViewModel(loggingService, applicationSettingsService);
	}
}