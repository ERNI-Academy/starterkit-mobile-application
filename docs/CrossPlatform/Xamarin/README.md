# About starterkit-mobile-application Xamarin instructions

ERNI Academy mobile boilerplate to start a xamarin forms mobile application.

## Getting Started

This boilerplate uses the well-known [MVVM pattern](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/enterprise-application-patterns/mvvm) and is based on a [Xamarin Forms Shell](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/shell/) application.

The application is multilanguage so just add a new file AppResources.(TWO ISO LANGUAGE LETTER).resx with the language and then
add the following code in the header of the XAML

``` xml
<ContentPage
...
 xmlns:helpers="clr-namespace:Erni.Mobile.Helpers"
 />
```

Then you can use in a label like this:

``` xml
<Label FontSize="{StaticResource HeadLine}" Text="{helpers:Translate About_Title}" />
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
│&emsp;&emsp;├── :file_folder: Controls: Contains all custom controls \
│&emsp;&emsp;├── :file_folder: Converters: Contains all custom converters \
│&emsp;&emsp;├── :file_folder: Helpers: Contains all custom Helpers \
│&emsp;&emsp;├── :file_folder: Models: Contains all Busines Models that the application uses \
│&emsp;&emsp;├── :file_folder: Resource: Contains all application resources as resx files, fonts, ... \
│&emsp;&emsp;├── :file_folder: Services: Contains all services to connect to any API, DB, Queue,... \
│&emsp;&emsp;├── :file_folder: Style: Contains all styles used in the application \
│&emsp;&emsp;│&emsp;&emsp;├── :page_facing_up: Colors.xaml: Contains all the colors the application needs. \
│&emsp;&emsp;│&emsp;&emsp;├── :page_facing_up: FontSizes.xaml: Contains all the font sizes the application needs. \
│&emsp;&emsp;│&emsp;&emsp;├── :page_facing_up: Spaces.xaml: Contains all the space sizes the application needs. \
│&emsp;&emsp;│&emsp;&emsp;├── :page_facing_up: Styles.xaml: Unifies all the previous resources into one big dictionary with all. \
│&emsp;&emsp;│&emsp;&emsp;└── ... Add personalized styles for buttons, labels, tabs, etc. in separate files and then reference them in the Style.xaml \
│&emsp;&emsp;├── :file_folder: ViewModels: Contans all the ViewModels used in the Views \
│&emsp;&emsp;│&emsp;&emsp;└── :page_facing_up: BaseViewModel.cs: All ViewModel classes must inherit from this one that implements the INotifyPropertyChanged \
│&emsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp; and encapsulate the methods to work with it. \
│&emsp;&emsp;└── :file_folder: Views: Contains all the Views in the application. \
├── **Erni.Mobile.Android** \
│&emsp;&emsp;├── :file_folder: Assets: Any raw assets you want to be deployed with your application can be placed in this directory\
│&emsp;&emsp;│&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;(and child directories) and given a Build Action of "AndroidAsset". \
│&emsp;&emsp;├── :file_folder: CustomRenders: custom control renders for Android \
│&emsp;&emsp;├── :file_folder: Resources: Images, layout descriptions, binary blobs and string dictionaries \
│&emsp;&emsp;└── :file_folder: Services: Dependency Service implementation for android. See docs: [Dependency Service](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/dependency-service/introduction) \
├── **Erni.Mobile.Resources** (Add them as a linked file into the projects.)\
│&emsp;&emsp;├── :file_folder: Fonts: All fonts need by the application.\
│&emsp;&emsp;├── :file_folder: Icons: All icons need by the application.\
│&emsp;&emsp;└── :file_folder: Images: All Images need by the application.\
├── **Erni.Mobile.iOS** \
│&emsp;&emsp;├── :file_folder: CustomRenders: custom control renders for iOS \
│&emsp;&emsp;└── :file_folder: Services: Dependency Service implementation for iOS. See docs: [Dependency Service](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/dependency-service/introduction) \
└── **Erni.Mobile.UWP** \
&nbsp;&emsp;&emsp;├── :file_folder: CustomRenders: custom control renders for UWP \
&nbsp;&emsp;&emsp;└── :file_folder: Services: Dependency Service implementation for UWP. See docs: [Dependency Service](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/dependency-service/introduction)
