﻿using Erni.Mobile.MAUI.Views;

namespace Erni.Mobile.MAUI;

public partial class MainPage : Shell
{
	public MainPage()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ChangeLanguagePage), typeof(ChangeLanguagePage));
	}
}

