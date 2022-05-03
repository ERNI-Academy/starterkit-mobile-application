using Microsoft.AppCenter;

namespace Erni.Mobile.MAUI.Services.Configuration
{
    public interface IApplicationSettingsService
    {
        string AppVersion { get; }

        string ApiBaseUrl { get; }

        string AppCenterKeyForIOS { get; }

        string AppCenterKeyForAndroid { get; }
        string AppCenterKeyForUWP { get; }

        string IosKeychainSecurityGroups { get; }

        LogLevel AppCenterLogLevel { get; }

        string IosInstallUrl { get; }

        string AndroidInstallUrl { get; }

        string DefaultInstallUrl { get; }
    }
}
