using Erni.Mobile.Helpers;
using Erni.Mobile.Services;
using Erni.Mobile.Services.Configuration;
using Erni.Mobile.Services.Logging;
using System.Globalization;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Erni.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            RegisterServicesAndProviders();
            VersionTracking.Track();
            InitializeLanguage();

            MainPage = new AppShell();
        }

        private static void InitializeLanguage()
        {
            LocalizationResourceManager.Instance.SetCulture(CultureInfo.GetCultureInfo("en")).GetAwaiter().GetResult();
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

        private void RegisterServicesAndProviders()
        {
            if (ApplicationMode.UseDebugLogging)
            {
                DependencyService.Register<MockDataStore>();
                DependencyService.Register<ApplicationSettingsService>();
                DependencyService.Register<MockLoggingService>();
            }
            else
            {
                DependencyService.Register<ApplicationSettingsService>();
                DependencyService.Register<AppCenterLoggingService>();
            }
        }
    }
}
