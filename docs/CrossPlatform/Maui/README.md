# About starterkit-mobile-application MAUI instructions

ERNI Academy mobile boilerplate to start a MAUI forms mobile application.

## Getting Started

This boilerplate uses the well-known [MVVM pattern](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/enterprise-application-patterns/mvvm) and is based on a [MAUI Forms Shell](https://docs.microsoft.com/en-us/dotnet/maui/fundamentals/shell/) application.

The application is multilanguage so just add a new file AppResources.(TWO ISO LANGUAGE LETTER).resx with the language and then
add the following code in the header of the XAML

``` xml
<ContentPage
...
 xmlns:extensions="clr-namespace:Erni.Mobile.Extensions"
 />
```

Then you can use in a label like this:

``` xml
<Label FontSize="{StaticResource HeadLine}" Text="{extensions:Translate About_Title}" />
```

Also has FontAwesome icons ready to use, add the following code in the header of the XAML:

``` xml
<ContentPage
...
 xmlns:FontAwesome="clr-namespace:Erni.Mobile.Helpers.Fonts"
 />
```

Then you can use in a label like this:

``` xml
<Label FontFamily="FAS" Text="{x:Static FontAwesome:FontAwesomeIcons.AddressCard}" />
```

## Project Structure

### The project contains the following projects

* **Erni.Mobile.MAUI**: this project contains all the needed functionalities to run in any platform.

### The folder structure

. \
├── **Erni.Mobile.MAUI** \
 &nbsp;&emsp;├── 📁 Properties: Contains all custom controls \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 launchSettings.json: Stores configuration information. \ 
 &nbsp;&emsp;├── 📂 Extensions: Contains all custom extension \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 TranslateExtension.cs: Class that manages the localization culture of the application. \
 &nbsp;&emsp;├── 📂 Helpers: Contains all custom Helpers \
 &nbsp;&emsp;│&emsp;&emsp;├── 📄 ApplicationMode.cs: Contains all helpers need to determine if application is in debug mode, UI Testing mode or release mode. \
 &nbsp;&emsp;│&emsp;&emsp;├── 📄 FontAwesomeIcons.cs: Contains all code for FontAwesome. \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 LocalizationResourceManager.cs: Class that manages the localization culture of the application. \
 &nbsp;&emsp;├── 📂 Models: Contains all Busines Models that the application uses \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 Item.cs: Model class that represents a dummy object for the application. \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 Language.cs: Model class that represents the language object for LanguageResourceManager. \
 &nbsp;&emsp;├── 📁 Platforms: Contains all application resources as resx files, fonts, ... \
 &nbsp;&emsp;│&emsp;&emsp;└──  📁 Android: Contains all functionalities and implementations specific for Android. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;├── 📁 Resources: Android specific Resources. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;└──  📁 values \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;└── 📄 colors.xml: Specific color definition for Android. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;└── 📁 Services: Android specific implementation for the different Services. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;├──  📁 Configuration \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;└── 📄 ConfigurationFileProvider.cs: Specific implementation for the IConfigurationFileProvider. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;├──  📄 AndroidManifest.xml: Describes essential information for the Android application. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;├──  📄 MainActivity.cs: Class pushed to screen. First activity of the application. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;└──  📄 MainApplication.cs: Main application class. Entry point of the application for Android platform. \
 &nbsp;&emsp;│&emsp;&emsp;└──  📁 iOS: Contains all functionalities and implementations specific for iOS. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;└── 📁 Services: iOS specific implementation for the different Services. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;├──  📁 Configuration \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;└── 📄 ConfigurationFileProvider.cs: Specific implementation for the IConfigurationFileProvider. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;├──  📄 AppDelegate.cs: Calls the CreateMAUIApp functionality. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;├──  📄 Info.plist: File of list of properties. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;└──  📄 Program.cs: Entry point of the application for iOS platform. \
 &nbsp;&emsp;│&emsp;&emsp;└──  📁 MacCatalyst: Contains all functionalities and implementations specific for Mac. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;└── 📁 Services: Mac specific implementation for the different Services. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;├──  📁 Configuration \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;└── 📄 ConfigurationFileProvider.cs: Specific implementation for the IConfigurationFileProvider. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;├──  📄 AppDelegate.cs: Calls the CreateMAUIApp functionality. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;├──  📄 Info.plist: File of list of properties. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;└──  📄 Program.cs: Entry point of the application for Mac platform. \
 &nbsp;&emsp;│&emsp;&emsp;└──  📁 Windows: Contains all functionalities and implementations specific for Windows. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;└── 📁 Services: Windows specific implementation for the different Services. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;├──  📁 Configuration \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;└── 📄 ConfigurationFileProvider.cs: Specific implementation for the IConfigurationFileProvider. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;├──  📄 app.manifest: Describes essential information for the Windows application. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;├──  📄 App.xaml: Entry point of the application for Windows platform. \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;└──  📄 Package.appxmanifest: XML file used for packaging Windows apps. \
 &nbsp;&emsp;├── 📁 Resources: Contains all application resources as resx files, fonts, ... \
 &nbsp;&emsp;│&emsp;&emsp;└──  📁 Fonts: Contains all fonts available for the application \
 &nbsp;&emsp;│&emsp;&emsp;└──  📁 Images: Contains all images available for the application \
 &nbsp;&emsp;│&emsp;&emsp;└──  📁 Raw: Contains all maui assets available for the application \
 &nbsp;&emsp;│&emsp;&emsp;&nbsp;&emsp;&emsp;├── 📄 AboutAssets.txt: Explain how to use Assets in MAUI. \
 &nbsp;&emsp;│&emsp;&emsp;&nbsp;&emsp;&emsp;├── 📄 appsettings.json: Dummy app settings file. \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 appicon.svg: Icon image for the application. \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 appiconfg.svg: Splash screen image. \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 AppResource.resx: Base resources file for translations. \
 &nbsp;&emsp;├── 📂 Services: Contains all services to connect to any API, DB, Queue,... \
 &nbsp;&emsp;│&emsp;&emsp;├── 📂 Configuration: Contains all services to load/read application configuration file. \
 &nbsp;&emsp;│&emsp;&emsp;│&emsp;&emsp;├── 📄 ApplicationSettingsService.cs: Class to read all the configuration file. \
 &nbsp;&emsp;│&emsp;&emsp;│&emsp;&emsp;├── 📄 IApplicationSettingsService.cs: Interface to read all the configuration file. \
 &nbsp;&emsp;│&emsp;&emsp;│&emsp;&emsp;├── 📄 IConfigurationFileProvider.cs: Interface service that will be implemented on each platform to read the json configuration file. \
 &nbsp;&emsp;│&emsp;&emsp;│&emsp;&emsp;└── 📄 SettingsService.cs: Base Class to interact with the configuration json object. \
 &nbsp;&emsp;│&emsp;&emsp;└── 📂 Logging: Contains all needed classes to interact with the AppCenter to log traces, events and crashes. \
 &nbsp;&emsp;│&emsp;&emsp;&nbsp;&emsp;&emsp;├── 📄 AppCenterLoggingService.cs: Class to intract with AppCenter to log traces, events and crashes. \
 &nbsp;&emsp;│&emsp;&emsp;&nbsp;&emsp;&emsp;├── 📄 Events.cs: Class that contains all the application events that will be reported to AppCenter. \
 &nbsp;&emsp;│&emsp;&emsp;&nbsp;&emsp;&emsp;├── 📄 ILoggingService.cs: Interface to intract with AppCenter to log traces, events and crashes. \
 &nbsp;&emsp;│&emsp;&emsp;&nbsp;&emsp;&emsp;└── 📄 MockLoggingService.cs: Class to mock the interact with the AppCenter. \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 IDataStore.cs: Interface to implement the data storage functionality. \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 MockDataStore.cs: Fake data store functionality. \
 &nbsp;&emsp;├── 📁 Style: Contains all styles used in the application \
 &nbsp;&emsp;│&emsp;&emsp;├── 📄 Colors.xaml: Contains all the colors the application needs. \
 &nbsp;&emsp;│&emsp;&emsp;├── 📄 FontSizes.xaml: Contains all the font sizes the application needs. \
 &nbsp;&emsp;│&emsp;&emsp;├── 📄 Spaces.xaml: Contains all the space sizes the application needs. \
 &nbsp;&emsp;│&emsp;&emsp;├── 📄 Styles.xaml: Unifies all the previous resources into one big dictionary with all. \
 &nbsp;&emsp;│&emsp;&emsp;└── ... Add personalized styles for buttons, labels, tabs, etc. in separate files and then reference them in the Style.xaml \
 &nbsp;&emsp;├── 📁 ViewModels: Contains all the ViewModels used in the Views \
 &nbsp;&emsp;│&emsp;&emsp;└── 📄 BaseViewModel.cs: All ViewModel classes must inherit from this one that implements the INotifyPropertyChanged \
 &nbsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; and encapsulate the methods to work with it. \
 &nbsp;&emsp;├── 📁 Views: Contains all the Views in the application. \
 &nbsp;&emsp;├── 📄 App.xaml: Application main view. Entrance View for the current application. \
 &nbsp;&emsp;├── 📄 MainPage.xaml: Shell view defining visual hierarchy and navigation. \
 &nbsp;&emsp;└── 📄 MauiProgram.cs: Starting point to register dependencies, fonts, services, ... 