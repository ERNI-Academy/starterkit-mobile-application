using Erni.Mobile.MAUI.ViewModels;

namespace Erni.Mobile.MAUI.Views;

public partial class ItemDetailPage : ContentPage
{
	public ItemDetailPage(ItemDetailViewModel itemDetailViewModel)
	{
		InitializeComponent();
		BindingContext = itemDetailViewModel;
	}
}