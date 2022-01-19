using Erni.Mobile.Helpers;
using Erni.Mobile.Services;
using System.Globalization;
using Xamarin.Forms;

namespace Erni.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("en")).GetAwaiter().GetResult();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
