﻿using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;
using Microsoft.AppCenter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Erni.Mobile.Services.Configuration;

namespace Erni.Mobile.Services.Logging
{
    public class AppCenterLoggingService : ILoggingService
    {
        public AppCenterLoggingService()
        {
            var applicationSettingsService = DependencyService.Get<IApplicationSettingsService>();
            AppCenter.LogLevel = applicationSettingsService.AppCenterLogLevel;
            AppCenter.Start(
                $"ios={applicationSettingsService.AppCenterKeyForIOS}​;android={applicationSettingsService.AppCenterKeyForAndroid}",
                typeof(Analytics),
                typeof(Crashes),
                typeof(Distribute));
        }

        public void TrackEvent<T>(string eventName, T message)
        {
            var jsonMessage = JsonConvert.SerializeObject(message);
            Analytics.TrackEvent(eventName, new Dictionary<string, string> { { "EventMessage", jsonMessage } });
        }

        public void TrackEvent(string eventName, string message)
        {
            Analytics.TrackEvent(eventName, new Dictionary<string, string> { { nameof(message), message } });
        }

        public void TrackEvent(string eventName)
        {
            Analytics.TrackEvent(eventName);
        }

        public void Debug(string message)
        {
            Analytics.TrackEvent(nameof(Debug), new Dictionary<string, string> { { nameof(message), message } });
        }

        public void Warning(string message)
        {
            Analytics.TrackEvent(nameof(Warning), new Dictionary<string, string> { { nameof(message), message } });
        }

        public void Error(Exception exception)
        {
            Crashes.TrackError(exception);
        }
    }
}
