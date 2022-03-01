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

### **Prerequisits**

* I've used Visual Studio 2022 for developing the sample solution, with the Mobile Development for .NET workload installed, which covers Xamarin requirements, but you could also use Visual Studio for Mac
* You will need access to a MacBook or similar MacOS X device for building and signing the iOS project, and a paid Apple Developer account that can be used for generating certificates and provisioning profiles - get started at <https://developer.apple.com>
* You will need an Azure DevOps account for creating the build and release pipelines used in this series. Source code is hosted in a git repository in Azure Repos, but you could use any other source control provider such as GitHub or BitBucket if you wish - go to <https://dev.azure.com> to get started
* You will need a Visual Studio App Center account in order to create the platform-specific projects we will need for deploying and testing our app packages - go to <https://appcenter.ms/> to get started

### **Creating a continuous integration pipeline for a Xamarin Forms mobile app**

Unlike standard .NET Core apps, building a Xamarin Forms app for continuous integration in Azure DevOps is much more involved, due to the combination of different platforms and frameworks that we need to use. The pipeline in  the folder Scripts\CrossPlatform\Xamarin [azure-pipelines.yml](https://github.com/ERNI-Academy/starterkit-mobile-application/tree/main/scripts/CrossPlatform/Xamarin/azure-pipelines.yml) is a good starting point for building on Android, iOS and Windows platforms, and is based on the newer YAML format used in Azure Pipelines. YAML-based pipelines are part of the source for the application, so that they can follow the same development lifecycle as any other code would.

**The YAML file**

The YAML contains a variables section. The variables section is used to pull in a variable group from **Pipelines > Library** called **CI-Build**. Variable groups are sets of parameters that you can define directly in Azure DevOps and pull into your pipeline definitions, so that their values can be controlled outside of source control. Also, we define a new variable called IsMainBranch as well, which is set to a boolean value of True when the current branch we are building is the master branch, or False for any other branch. This variable will be used later on to decide whether to conditionally execute specific steps or not.

To create the variable group CI-Build, open the Azure DevOps project you are using in a browser, and open the Pipelines > Library link from the left-hand navigation bar then click + Variable Group:

![AzureDevOps_Create_Var_Group](./Images/AzureDevOps_Create_Var_Group.png "AzureDevOps_Create_Var_Group")

Then enter the details as per the screenshot below. You can use a different name for the group if you wish, just remember to update the YAML to reference the new name you use:

![AzureDevOps_Create_Var_Group_CI_Build](./Images/AzureDevOps_Create_Var_Group_CI_Build.png "AzureDevOps_Create_Var_Group_CI_Build")

There is a block in the YAML where updates the version number for Android, iOS and UWP. This task comes from an extension which is developed and maintained by James Montemagno, a well-known Xamarin rep for Microsoft - to use it, you will need to install this extension in your Azure DevOps organisation using the Visual Studio Marketplace:

1) In Azure DevOps, open the Browse Marketplace link which is in the top-right navigation bar:
![Browse_Marketplace](./Images/Browse_Marketplace.png "Browse_Marketplace")

2) Search for Mobile App Tasks for iOS and Android, the extension should look like the below:
![Mobile Apps extensions](./Images/Mobile_Apps_extensions.png "Mobile Apps extensions")

3) Click the Get it free link, then select the appropriate organisation in Azure DevOps where you want to install the extension. An administrator will likely need to approve your request, unless you already have the appropriate permissions yourself.

If you can't install the extension or don't want to use it, you can just remove this task from the YAML file, as it's not required to continue with this example, however, I strongly recommend that you use it if possible as it provides a unique version number for each package produced by this build, and becomes important when we release the packages to App Center later on from a release pipeline.

In order to build an iOS project, we have to provide a certificate in *.p12 format that will act as a signing identity. This certificate must be available for download to the build agent when it runs the job, so we will use the Secure Files feature of the Library in Azure DevOps to store this certificate to meet this requirement.

First, we need to create a certificate that we can upload and use for signing and distributing iOS builds produced and deployed in our pipelines.

You will need to have a paid Apple Developer account in order to continue, as well as access to a macOS device that has Xcode 11+ installed. I recommend creating a single Apple Distribution certificate which can be used for Ad Hoc distribution and/or App Store deployment as well. If you already have an Apple Distribution certificate for your team or organisation that you can use, then you can skip the following steps.

Here are the steps to follow to create this certificate and upload to Azure DevOps. First, you will need to generate a Certificate Signing Request (CSR) from your macOS device:

1) Open the Keychain Access utility - I find it easiest to use CMD + SPACE to open Spotlight then type Keychain and hit enter on Keychain Access:
![Apple_KeyChain_Access](./Images/Apple_KeyChain_Access.png "Apple_KeyChain_Access")

2) In the Keychain Access menu, select Certificate Assistant > Request a Certificate from a Certificate Authority..., this will open a new dialog:
![Apple_KeyChain_Access_Request_Cert](./Images/Apple_KeyChain_Access_Request_Cert.png "Apple_KeyChain_Access_Request_Cert")

3) Enter an email address and common name (eg 'Mobile DevOps AdHoc') to identify your certificate. Select the Saved to disk option, then click Continue:
![Apple_KeyChain_Access_Request_Cert_2](./Images/Apple_KeyChain_Access_Request_Cert_2.png "Apple_KeyChain_Access_Request_Cert_2")

4) Choose where to save the CSR file - I just use the default name, CertificateSigningRequest.certSigningRequest, saved to Desktop.

Next, we will create the certificate from this CSR file.

1) On your macOS device, open Safari and sign in to your Apple Developer account

2) From your Developer Account home page, click the Certificates, Identifiers and Profiles link:
![Apple_Certificate_Setup_1](./Images/Apple_Certificate_Setup_1.png "Apple_Certificate_Setup_1")

3) Open the Certificates page from the link in the left-hand navigation, if this is not the default page already selected. Click the + icon next to the Certificates header to create a new certificate:
![Apple_Certificate_Setup_2](./Images/Apple_Certificate_Setup_2.png "Apple_Certificate_Setup_2")

4) Select the Apple Distribution certificate option and click Continue:
![Apple_Certificate_Setup_3](./Images/Apple_Certificate_Setup_3.png "Apple_Certificate_Setup_3")

5) You should see a page like this that asks you to upload a CSR file, go ahead and choose the file that you created earlier using the Keychain Access utility, then click Continue to upload:
![Apple_Certificate_Setup_4](./Images/Apple_Certificate_Setup_4.png "Apple_Certificate_Setup_4")

6) You should now see a page that provides certificate details and a Download link. Click this link to download the distribution.cer file for the certificate.

We're nearly there - the final set of steps involves installing the certificate file onto your macOS device, then exporting into *.p12 format with password protection:

1) Find the distribution.cer file you just downloaded (goes to Downloads by default), and double-click it, this will launch the Add Certificates dialog:
![Apple_Add_Certificate](./Images/Apple_Add_Certificate.png "Apple_Add_Certificate")

2) Make sure the login keychain is selected, so that you can export it correctly, then click Add.
3) Ensure Keychain Access is open, and that you have the login keychain currently open. It's also useful to filter to the My Certificates category. You should be able to see the certificate you just imported, including the private key - the expiry date will be 12 months from the certificate creation date, and the name of the private key should match the common name that you specified in your original CSR file. Select BOTH the certificate and private key lines together, then click File > Export Items...:
![Apple_KeyChain_Export_Cert_1](./Images/Apple_KeyChain_Export_Cert_1.png "Apple_KeyChain_Export_Cert_1")

4) This will bring up a dialog where you can specify the p12 certificate file name and folder location to export to. Ensure that File Format is Personal Information Exchange (.p12), then click Save:
![Apple_KeyChain_Export_Cert_2](./Images/Apple_KeyChain_Export_Cert_2.png "Apple_KeyChain_Export_Cert_2")

5) Enter a strong password for the file, make sure you write it down as Azure DevOps will need it in order to be able to open the certificate file later during the build process. You will also need to enter an administrator password for your MacBook to finish exporting the file:
![Apple_KeyChain_Export_Cert_3](./Images/Apple_KeyChain_Export_Cert_3.png "Apple_KeyChain_Export_Cert_3")

Phew! That's a lot of work. Now that we have a valid p12 file and the password for that file, we can upload it to Azure DevOps to use in our build pipeline:

1) In your Azure DevOps project, go to Pipelines > Library, and click the Secure files tab:
![Azure_DevOps_SecureFiles](./Images/Azure_DevOps_SecureFiles.png "Azure_DevOps_SecureFiles")

2) Click + Secure file, and choose the p12 file you exported from your macOS device earlier. Click OK to upload the file.
![Azure_DevOps_SecureFiles_2](./Images/Azure_DevOps_SecureFiles_2.png "Azure_DevOps_SecureFiles_2")

3) Once uploaded, click on the filename in the list to open its properties. You can change the filename to another value if you wish. The important step here is to authorise the secure file for use in all pipelines by turning the switch for that setting to ON. If you don't do this, then the first time the YAML pipeline tries to access this file it will fail, and you will have to authorise the pipeline access manually before it can run. Click Save to save changes:
![Azure_DevOps_SecureFiles_3](./Images/Azure_DevOps_SecureFiles_3.png "Azure_DevOps_SecureFiles_3")

4) Go back to Pipelines > Library, then open the CI-Build variable group that we created earlier, and update the AppleCertificatePassword variable to the password you used when exporting the p12 file, as this is what enables the certificate to be installed. Make sure it is set as a secret variable so that it cannot be viewed, and that you maintain a record of that password somewhere else, as you will have to re-export the p12 file if you lose the password.

5) In the azure-pipelines.yml file, you will need to update the InstallAppleCertificate@2 task to use the filename of the p12 file exactly as it appears in Azure DevOps. As far as I know, it is NOT currently possible to use a variable to refer to the p12 filename indirectly, it must be hardcoded into the YAML file directly, which is pretty annoying. This is an open issue in Azure Pipelines and may be resolved in future - see [https://github.com/microsoft/azure-pipelines-tasks/issues/6885](https://github.com/microsoft/azure-pipelines-tasks/issues/6885) for reference.

We also need to provide a provisioning profile that links to an identifier and signing certificate for our app, and specifies what devices are allowed to run the app, which will also be downloaded and installed on the build agent. This also involves quite a few setup steps if this is the first time you've ever done this!

Before we can create a provisioning profile, we must first create an App ID that identifies our app. We have two basic choices here, we can either create an explicit App ID for the app bundle identifier, or we can create a wildcard App ID where some or all of the bundle ID is replaced by an asterisk (*), meaning it matches any values from that part of the bundle ID onwards (for example, com.sampiper.* will match com.sampiper.devops, com.sampiper.someotherapp.uat, etc, while * by itself will match ANY bundle ID you want to use).

The main difference between these two types is that explicit App IDs can specify ANY capabilities other than the defaults allowed for any app, whereas wildcard App IDs cannot. For example, if you wanted to enable Push Notifications or HealthKit integration as capabilities for your app, you would need to associate these with an explicit App ID that your account owns. If you just wanted Wallet integration, for example, then you could use either type. Here are the steps to follow to set up an App ID, Device registration and Provisioning Profile:

1) Open a web browser and sign in to your Apple Developer account - note that you can do this part on any suitable laptop, Windows or Mac, as we only need to use the online Developer Portal to create a provisioning profile.

2) From your Developer Account home page, click the Certificates, Identifiers and Profiles link

3) Click the Identifiers link in the left-hand sidebar, then click the + button next to the Identifiers title:
![Apple_Identifier_Setup_1](./Images/Apple_Identifier_Setup_1.png "Apple_Identifier_Setup_1")

4) Select the  App IDs option (the default) and click Continue:
![Apple_Identifier_Setup_2](./Images/Apple_Identifier_Setup_2.png "Apple_Identifier_Setup_2")

5) Select the App option (the default) and click Continue:
![Apple_Identifier_Setup_3](./Images/Apple_Identifier_Setup_3.png "Apple_Identifier_Setup_3")

6) Enter a simple description for your app, choose the Explicit or Wildcard option, then enter the Bundle ID you want to use. I've entered the value for my sample app, but you should either use an explicit ID that is unique and owned by your account, or a wildcard (*) if you don't care and just want to try things out. Select any platform capabilities that you want your app to be able to use, and note that the capability list is quite restricted if you use the wildcard option. Finally, click Continue:
![Apple_Identifier_Setup_4](./Images/Apple_Identifier_Setup_4.png "Apple_Identifier_Setup_4")

7) Confirm that your details are correct, and click Register to save your new App ID:
![Apple_Identifier_Setup_5](./Images/Apple_Identifier_Setup_5.png "Apple_Identifier_Setup_5")

8) We also need to register AT LEAST one physical device that we can test our app on, which will also be linked to our provisioning profile. We will be using automatic provisioning in App Center later on to specify the actual devices we want to be able to test on when deploying to our hosted environments in App Center, but for the purposes of building and packaging our app into an *.IPA file, we just need one device registered first. To do this, click the Devices link in the navigation sidebar from the Certificates, Identifiers & Profiles home page:
![Apple_Devices_Setup_1](./Images/Apple_Devices_Setup_1.png "Apple_Devices_Setup_1")

9) Enter the device's platform, name and UDID. To get the UDID value, I recommend using iTunes, as per this link, as it's easier to copy and paste the value back into this page. Click Continue. If the device is valid, it should appear in your list of devices.
![Apple_Devices_Setup_2](./Images/Apple_Devices_Setup_2.png "Apple_Devices_Setup_2")

10) Now that we have all the components we need, we can create a provisioning profile that we can use to build and package our iOS app in Azure DevOps. From the Certificates, Identifiers & Profiles home page, click the Profiles link in the left-hand sidebar, then click the + button next to the Profiles heading:
![Apple_Profile_Setup_1](./Images/Apple_Profile_Setup_1.png "Apple_Profile_Setup_1")

11) Select the Ad Hoc provisioning profile option as indicated, and click Continue:
![Apple_Profile_Setup_2](./Images/Apple_Profile_Setup_2.png "Apple_Profile_Setup_2")

12) Select the App ID that you want to associate with the profile from the dropdown, and click Continue. This must match the bundle ID you are using when you build the iOS app in Azure DevOps, using either an explicit or wildcard matching pattern:
![Apple_Profile_Setup_3](./Images/Apple_Profile_Setup_3.png "Apple_Profile_Setup_3")

13) Select the Distribution certificate that you created earlier, this should be the same certificate that you exported to a *.p12 file and uploaded to Azure DevOps earlier on:
![Apple_Profile_Setup_4](./Images/Apple_Profile_Setup_4.png "Apple_Profile_Setup_4")

14) Select the devices that you want to include in this profile then click Continue - for an Ad Hoc profile, you can include up to 100 unique devices, but you only need one for this stage:
![Apple_Profile_Setup_5](./Images/Apple_Profile_Setup_5.png "Apple_Profile_Setup_5")

15) Enter a name for your profile, then click Generate:
![Apple_Profile_Setup_6](./Images/Apple_Profile_Setup_6.png "Apple_Profile_Setup_6")

16) Download the profile to your local computer.
![Apple_Profile_Setup_7](./Images/Apple_Profile_Setup_6.png "Apple_Profile_Setup_6")

Once you have downloaded the provisioning profile to your local computer, upload it to Azure DevOps as a secure file, at **Pipelines > Library > Secure Files**, using the same process as for the p12 certificate file. I won't go over all the steps to do that again. The same restriction applies for the provProfileSecureFile parameter on the **InstallAppleProvisioningProfile@1** task - the name you use must be hardcoded to the name of the secure file you uploaded.

The next step is to create a matching build definition in your Azure DevOps project that references the YAML source file in your repository, which will allow us to trigger a build instance and view its execution progress:

1) In your Azure DevOps project, select the Pipelines menu option from the navigation sidebar, and click the New Pipeline button in the right hand corner of that page:
![Azure_DevOps_New_Pipeline](./Images/Azure_DevOps_New_Pipeline.png "Azure_DevOps_New_Pipeline")

2) Next, select the type of repository you are using to host your build definition YAML file. For demonstration purposes, here is shown how to create a build pipeline that points to a GitHub repository, but you can easily apply the same process to other types of repositories, such as Azure Repos. Continue by clicking the GitHub option:
![Azure_DevOps_Select_Repo](./Images/Azure_DevOps_Select_Repo.png "Azure_DevOps_Select_Repo")

3) You will need to sign in to GitHub via the OAuth prompt shown next, so that Azure Pipelines can obtain a token it can use to access your GitHub repositories. In Azure Repos this is easier, you just select the repository you want to build from without needing to leave Azure DevOps. Once you've signed in, you must then authorise Azure Pipelines to access your repositories, this will then redirect you back to Azure DevOps.

4) Select the repository you want to build. This will redirect you to GitHub again to approve the repository access, then you will be redirected back to Azure DevOps:
![Azure_DevOps_SelectGitHubRepo](./Images/Azure_DevOps_SelectGitHubRepo.png "Azure_DevOps_SelectGitHubRepo")

5) You should now see a screen that automatically selects your azure-pipelines.yml file, you can click Run to save your pipeline and queue a new build immediately, or use the Save dropdown option to just save the pipeline if you want to try running later on:
![Azure_DevOps_ReviewYAMLPipeline](./Images/Azure_DevOps_ReviewYAMLPipeline.png "Azure_DevOps_ReviewYAMLPipeline")

6) When you run the pipeline, you'll first see a summary page similar to the following screenshot. You can click the link 5 Published under the Related heading, which will open the artifact explorer for the build, from here you can download the output packages for the build if it was for the main branch:
![Azure_DevOps_Build_Summary](./Images/Azure_DevOps_Build_Summary.png "Azure_DevOps_Build_Summary")

Just last settings needed for the YAML file, setup SonarQube and it's connection to Devops.

1) Create a new project in SonarQube
![SonarQube_Setup_Project](./Images/Sonar_Setup_1.png "SonarQube Setup 1")

2) Select From Azure DevOps and fill in the fields
![SonarQube_Fill_In_Setup_Project](./Images/Sonar_Setup_2.png "SonarQube Setup 2")

3) For the Personal Access Token you need to go to your DevOps and go to User Settings and select **Personal Access Token**
![Personal_Access_Token_1](./Images/Personal_Access_Token_1.png "Personal Access Token 1")

4) Click **New Token**
![Personal_Access_Token_2](./Images/Personal_Access_Token_2.png "Personal Access Token 2")

5) Fill in the **Name**, **Organization**,  **Expiration (UTC)**, check the **Custom defined** in Scopes and select **Read & write** in Code section and click Create.
![Personal_Access_Token_3](./Images/Personal_Access_Token_3.png "Personal Access Token 3")

6) Copy the token and paste it on the right field for step 2 of this current section.
![Personal_Access_Token_4](./Images/Personal_Access_Token_4.png "Personal Access Token 4")

7) Reenter the Personal Access Token after fill in all the fields for step 2 in this current section.
![SonarQube_Reperat_PAT](./Images/Sonar_Setup_3.png "SonarQube Setup 3")

8) Now you have a new sonarqube project created.
![SonarQube_Project](./Images/Sonar_Setup_4.png "SonarQube Setup 4")

9) Click on **With Azure Pipelines** and follow the steps untill step 2 and copy the **server url** and Generated Token when click on **Generate Token** button
![SonarQube_Project](./Images/Sonar_Setup_5.png "SonarQube Setup 5")
![SonarQube_Project](./Images/Sonar_Setup_6.png "SonarQube Setup 6")
![SonarQube_Project](./Images/Sonar_Setup_7.png "SonarQube Setup 7")
![SonarQube_Project](./Images/Sonar_Setup_8.png "SonarQube Setup 8")

10) On step 3 select the .NET type and copy the **Project Key** and then click **Finish this tutorial**
![SonarQube_Project](./Images/Sonar_Setup_9.png "SonarQube Setup 9")

Up to you to start setting all the Quality Gates, Quality Profiles for your project.

At this point there is only the last think, setup the Devops Connection with Sonarqube.

1) On your devops project go to settings.
![DevOps_Sonarqube_Connection_1](./Images/DevOps_Sonarqube_Connection_1.png "Devops Project Settings")

2) Go to **Service connections**
![DevOps_Sonarqube_Connection_2](./Images/DevOps_Sonarqube_Connection_2.png "Devops service connections")

3) Click **New service connection**
![DevOps_Sonarqube_Connection_3](./Images/DevOps_Sonarqube_Connection_3.png "Devops new service connections")

4) Select **SonarQube** and click **Next**
![DevOps_Sonarqube_Connection_4](./Images/DevOps_Sonarqube_Connection_4.png "Devops new service connections")

5) Fill in the fields with the **Sonarqube Server Url** and **SonarQube Token** previously generated, add a service connection name and make sure that **Grant access permission to all pipelines**
![DevOps_Sonarqube_Connection_5](./Images/DevOps_Sonarqube_Connection_5.png "Devops new service connections")

Now that we have all the required setup in place let's see how the YAML looks like.

The YAML file contains 2 stages:

* QualityControl
* BuildArtifacts

#### **QualityControl Stage**

This stage is for check the quality of the code and execute the tests.
Uses Sonarqube, so you need the following settings:

* Your SonarQube Project Key
* Your SonarQube Project Name

1) Downloads the right certificate for UWP compilation from the previous created variables.
2) Prepares the sonarqube to perform the analysis later.
3) Restore Nuget packages.
4) Build the solution.
5) Executes the Unit tests.
6) Install the dotnet-reportgenerator-globaltool to convert the test reports for sonar be able to compute the code coverage.
7) Convert tests reports to OpenCover format so Sonarqube can import them.
8) Publish the unit test results.
9) Run the sonarqube analysis.
10) Publish the results to Sonarqube.
11) Install the UWP to execute the Automation Testings
12) Run the automation tests
13) Publish the results.

#### **BuildArtifacts Stage**

This stage contains 2 diferents Jobs, one for UWP that requires a Windows Agent and one for Android and iOS that requires a Mac Agent.

**UWP Job**

1) Downloads the right certificate for UWP compilation from the previous created variables.
2) Install the certificates to generate the UWP into the agent.
3) Update the configuration settings file with the variables.
4) Build the application for the x64, x86 and ARM architecture.
5) Create the MSI installers.
6) Publish the result to the Artifacts.

**Android & iOS Job**

1) Install dotnet.
2) Install Nuget.
3) Restore solution.
4) Update the configuration settings file with the variables.
5) Build Android Application.
   1) Update Android version.
   2) Compile Android project.
   3) Copy the apk to artifacts folder.
   4) Publish the Android artifacts.
6) Build iOS Application.
   1) Install apple certificates.
   2) Install provision profile.
   3) Update iOS version.
   4) Build and Sign the Ipa file.
   5) Copy the generated Ipa file to the artifacts folder.
   6) Publish the iOS artifacts.

