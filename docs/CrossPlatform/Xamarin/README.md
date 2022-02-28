# About starterkit-mobile-application Xamarin instructions

ERNI Academy mobile boilerplate to start a xamarin forms mobile application.

## Getting Started

This boilerplate uses the well-known [MVVM pattern](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/enterprise-application-patterns/mvvm) and is based on a [Xamarin Forms Shell](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/shell/) application.

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

Then you can use in a laber like this:

``` xml
<Label FontFamily="FAS" Text="{x:Static FontAwesome:FontAwesomeIcons.AddressCard}" />
```

## Project Structure

### The project contains the following projects

* **Erni.Mobile**: this project contains all the shared non platform specific code.
* **Erni.Mobile.Andorid**: this project contains all necessary platform specific code to build an Android app.
* **Erni.Mobile.iOS**: this project contains all necessary platform specific code to build an iOS app.
* **Erni.Mobile.UWP**: this project contains all necessary platform specific code to build an Universal Windows Platform app.

### The folder structure

. \
├── **Erni.Mobile** \
│&emsp;&emsp;├── 📁 Controls: Contains all custom controls \
│&emsp;&emsp;├── 📁 Converters: Contains all custom converters \
│&emsp;&emsp;├── 📂 Extensions: Contains all custom Helpers \
│&emsp;&emsp;│&emsp;&emsp;└── 📄 TranslateExtension.cs: Class that manages the localization culture of the application. \
│&emsp;&emsp;├── 📂 Helpers: Contains all custom Helpers \
│&emsp;&emsp;│&emsp;&emsp;├── 📄 ApplicationMode.cs: Contains all helpers need to determine if application is in debug mode, UI Testing mode or release mode. \
│&emsp;&emsp;│&emsp;&emsp;├── 📄 FontAwesomeIcons.cs: Contains all code for FornAwesome. \
│&emsp;&emsp;│&emsp;&emsp;└── 📄 LocalizationResourceManager.cs: Class that manages the localization culture of the application. \
│&emsp;&emsp;├── 📂 Models: Contains all Busines Models that the application uses \
│&emsp;&emsp;│&emsp;&emsp;└── 📄 Language.cs: Model class that represents the language object for LanguageResourceManager. \
│&emsp;&emsp;├── 📁 Resource: Contains all application resources as resx files, fonts, ... \
│&emsp;&emsp;├── 📂 Services: Contains all services to connect to any API, DB, Queue,... \
│&emsp;&emsp;│&emsp;&emsp;├── 📂 Configuration: Contains all services to load/read application configuration file. \
│&emsp;&emsp;│&emsp;&emsp;│&emsp;&emsp;├── 📄 ApplicationSettingsService.cs: Class to read all the configuration file. \
│&emsp;&emsp;│&emsp;&emsp;│&emsp;&emsp;├── 📄 IApplicationSettingsService.cs: Interface to read all the configuration file. \
│&emsp;&emsp;│&emsp;&emsp;│&emsp;&emsp;├── 📄 IConfigurationFileProvider.cs: Interface service that will be implemented on each platform to read the json configuration file. \
│&emsp;&emsp;│&emsp;&emsp;│&emsp;&emsp;└── 📄 SettingsService.cs: Base Class to interact with the configuration json object. \
│&emsp;&emsp;│&emsp;&emsp;└── 📂 Logging: Contains all needed classes to interact with the AppCenter to log traces, events and crashes. \
│&emsp;&emsp;│&emsp;&emsp;&nbsp;&emsp;&emsp;├── 📄 AppCenterLoggingService.cs: Class to intract with AppCenter to log traces, events and crashes. \
│&emsp;&emsp;│&emsp;&emsp;&nbsp;&emsp;&emsp;├── 📄 Events.cs: Class that contains all the application events that will be reported to AppCenter. \
│&emsp;&emsp;│&emsp;&emsp;&nbsp;&emsp;&emsp;├── 📄 ILoggingService.cs: Interface to intract with AppCenter to log traces, events and crashes. \
│&emsp;&emsp;│&emsp;&emsp;&nbsp;&emsp;&emsp;└── 📄 MockLoggingService.cs: Class to mock the interact with the AppCenter. \
│&emsp;&emsp;├── 📁 Style: Contains all styles used in the application \
│&emsp;&emsp;│&emsp;&emsp;├── 📄 Colors.xaml: Contains all the colors the application needs. \
│&emsp;&emsp;│&emsp;&emsp;├── 📄 FontSizes.xaml: Contains all the font sizes the application needs. \
│&emsp;&emsp;│&emsp;&emsp;├── 📄 Spaces.xaml: Contains all the space sizes the application needs. \
│&emsp;&emsp;│&emsp;&emsp;├── 📄 Styles.xaml: Unifies all the previous resources into one big dictionary with all. \
│&emsp;&emsp;│&emsp;&emsp;└── ... Add personalized styles for buttons, labels, tabs, etc. in separate files and then reference them in the Style.xaml \
│&emsp;&emsp;├── 📁 ViewModels: Contans all the ViewModels used in the Views \
│&emsp;&emsp;│&emsp;&emsp;└── 📄 BaseViewModel.cs: All ViewModel classes must inherit from this one that implements the INotifyPropertyChanged \
│&emsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; and encapsulate the methods to work with it. \
│&emsp;&emsp;└── 📁 Views: Contains all the Views in the application. \
├── **Erni.Mobile.Android** \
│&emsp;&emsp;├── 📁 Assets: Any raw assets you want to be deployed with your application can be placed in this directory\
│&emsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;(and child directories) and given a Build Action of "AndroidAsset". \
│&emsp;&emsp;├── 📁 CustomRenders: custom control renders for Android \
│&emsp;&emsp;├── 📁 Resources: Images, layout descriptions, binary blobs and string dictionaries \
│&emsp;&emsp;└── 📁 Services: Dependency Service implementation for android. See docs: [Dependency Service](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/dependency-service/introduction) \
│&emsp;&emsp;&nbsp;&emsp;&emsp;└── 📂 Configuration: Contains all services to load/read application configuration file. \
│&emsp;&emsp;&nbsp;&emsp;&emsp;&emsp;&emsp;└── 📄 ConfigurationFileProvider.cs: Class to read application settings json file. \
├── **Erni.Mobile.Resources** (Add them as a linked file into the projects.)\
│&emsp;&emsp;├── 📁 Fonts: All fonts need by the application.\
│&emsp;&emsp;├── 📁 Icons: All icons need by the application.\
│&emsp;&emsp;└── 📁 Images: All Images need by the application.\
├── **Erni.Mobile.iOS** \
│&emsp;&emsp;├── 📁 CustomRenders: custom control renders for iOS \
│&emsp;&emsp;└── 📁 Services: Dependency Service implementation for iOS. See docs: [Dependency Service](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/dependency-service/introduction) \
│&emsp;&emsp;&emsp;&emsp;└── 📂 Configuration: Contains all services to load/read application configuration file. \
│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;└── 📄 ConfigurationFileProvider.cs: Class to read application settings json file. \
└── **Erni.Mobile.UWP** \
&nbsp;&emsp;&emsp;├── 📁 CustomRenders: custom control renders for UWP \
&nbsp;&emsp;&emsp;└── 📁 Services: Dependency Service implementation for UWP. See docs: [Dependency Service](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/dependency-service/introduction) \
&nbsp;&emsp;&emsp;&emsp;&emsp;└── 📂 Configuration: Contains all services to load/read application configuration file. \
&nbsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;└── 📄 ConfigurationFileProvider.cs: Class to read application settings json file. \


## Azure DevOps CI/CD
### Prerequisits

### Scripts