namespace Erni.Mobile.MAUI.Helpers
{
    public static class ApplicationMode
    {
        public const bool RandomFails = false;

        public const bool UseFakeAPIs = UITestMode;

        public const bool UseFakeAuthentication = UITestMode;

        public const bool ForceAutomaticLogin = !UITestMode && DebugMode;

        public const bool BreakNetworkRandomly = !UITestMode && DebugMode;

        public const bool AndroidDebuggable = DebugMode;

        public const bool UseDebugLogging = UITestMode || DebugMode;

        public const bool EnableARDiagnostics = DebugMode;

        public const bool DebugMode =
#if DEBUG 
            true;
#else
            false;
#endif

        public const bool UITestMode =
#if IS_UI_TEST || DEBUG
            true;
#else
            false;
#endif
    }
}
