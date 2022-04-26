using Microsoft.AppCenter;

namespace Erni.Mobile.MAUI.Services.Configuration
{
    public class ApplicationSettingsService : SettingsService, IApplicationSettingsService
    {
        public ApplicationSettingsService(IConfigurationFileProvider configurationFileProvider) : base(configurationFileProvider)
        {
        }

        public string AppVersion => GetSetting<string>("AppCenter.Version");

        public string ApiBaseUrl => GetSetting<string>(nameof(ApiBaseUrl));

        public string AppCenterKeyForIOS => GetSetting<string>("AppCenter.Keys.iOS");

        public string AppCenterKeyForAndroid => GetSetting<string>("AppCenter.Keys.Android");

        public LogLevel AppCenterLogLevel => GetLogLevel();

        public string IosKeychainSecurityGroups => "com.yourcompany.applicationname";

        public string IosInstallUrl => GetSetting<string>("AppCenter.InstallUrl.iOS");

        public string AndroidInstallUrl => GetSetting<string>("AppCenter.InstallUrl.Android");

        public string UwpInstallUrl => GetSetting<string>("AppCenter.InstallUrl.UWP");

        public string DefaultInstallUrl => GetSetting<string>("AppCenter.InstallUrl.Default");

        private LogLevel GetLogLevel()
        {
            var logLevel = GetSetting<string>("AppCenter.LogLevel");
            switch (logLevel)
            {
                case "Verbose":
                    return LogLevel.Verbose;
                case "Debug":
                    return LogLevel.Debug;
                case "Info":
                    return LogLevel.Info;
                case "Warn":
                    return LogLevel.Warn;
                case "Error":
                    return LogLevel.Error;
                case "Assert":
                    return LogLevel.Assert;
                default:
                    return LogLevel.None;
            }
        }
    }
}
