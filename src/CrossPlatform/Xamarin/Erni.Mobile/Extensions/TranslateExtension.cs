﻿using System;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using Erni.Mobile.Helpers;

namespace Erni.Mobile.Extensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension<BindingBase>
    {
        public string Text { get; set; }
        public string StringFormat { get; set; }
        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }

        public BindingBase ProvideValue(IServiceProvider serviceProvider)
        {
            var binding = new Binding
            {
                Mode = BindingMode.OneWay,
                Path = $"[{Text}]",
                Source = LocalizationResourceManager.Instance,
                StringFormat = StringFormat

            };
            return binding;
        }
    }
}
