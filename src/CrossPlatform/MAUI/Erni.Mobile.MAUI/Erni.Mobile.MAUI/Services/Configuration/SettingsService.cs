﻿using Newtonsoft.Json.Linq;

namespace Erni.Mobile.MAUI.Services.Configuration
{
    public abstract class SettingsService
    {
        private readonly JObject _settings;

        public SettingsService(IConfigurationFileProvider configurationFileProvider)
        {
            //using (var reader = new StreamReader(configurationFileProvider.GetConfigurationStream()))
            //{
            //    var json = reader.ReadToEnd();
            //    _settings = JObject.Parse(json);
            //}
        }

        public T GetSetting<T>(string key)
        {
            var value = _settings.SelectToken(key);
            if (value == null)
            {
                throw new InvalidOperationException($"Key '{key}' does not exist in current settings file.");
            }

            return value.Value<T>();
        }

        public IEnumerable<T> GetSettings<T>(string key)
        {
            var value = _settings.SelectToken(key);
            if (value == null)
            {
                throw new InvalidOperationException($"Key '{key}' does not exist in current settings file.");
            }

            return value.ToList().Select(item => item.Value<T>());
        }
    }
}
