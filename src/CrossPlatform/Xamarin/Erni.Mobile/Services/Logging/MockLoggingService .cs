using Newtonsoft.Json;
using System;

namespace Erni.Mobile.Services.Logging
{
    public class MockLoggingService : ILoggingService
    {
        public void TrackEvent<T>(string eventName, T message)
        {
            var jsonMessage = JsonConvert.SerializeObject(message);
            Debug(eventName);
            Debug("Message");
            Debug(jsonMessage);
        }

        public void TrackEvent(string eventName, string message)
        {
            Debug(eventName);
            Debug(message);
        }

        public void TrackEvent(string eventName)
        {
            Debug(eventName);
        }

        public void Debug(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }

        public void Warning(string message)
        {
            Debug($"# {nameof(Warning)}");
            Debug(message);
        }

        public void Error(Exception exception)
        {
            Debug($"# {nameof(Error)}");
            Debug(exception.ToString());
        }
    }
}
