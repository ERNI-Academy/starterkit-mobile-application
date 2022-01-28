param(
    [string]$packageName = $null,
    [string]$templateName = $null,
    [switch]$InstallCert,
    [switch]$EnableSideLoad
)
$WixRoot = "$PSScriptRoot\wix"
$InstallFileswsx = "..\$templateName.wxs"
$InstallFilesWixobj = "..\$packageName.wixobj"

if(!(Test-Path "$WixRoot\candle.exe"))
{
    
	Write-Host Downloading Wixtools..
    New-Item $WixRoot -type directory -force | Out-Null
    # Download Wix version 3.10.2 - https://wix.codeplex.com/releases/view/619491
    Invoke-WebRequest -Uri https://github.com/wixtoolset/wix3/releases/download/wix3112rtm/wix311-binaries.zip -Method Get -OutFile $WixRoot\WixTools.zip

    Write-Host Extracting Wixtools..
    Add-Type -AssemblyName System.IO.Compression.FileSystem
    [System.IO.Compression.ZipFile]::ExtractToDirectory("$WixRoot\WixTools.zip", "$PSScriptRoot\wix")
}

pushd "$WixRoot"
.\candle.exe $InstallFileswsx -ext WixUtilExtension -o "$PSScriptRoot\$packageName.wixobj" 
.\light.exe $InstallFilesWixobj -ext WixUtilExtension -b "$PSScriptRoot" -o "$PSScriptRoot\$packageName.msi" 
popd

#msiexec.exe /i Erni.Mobile.msi /log log.txt
#msiexec.exe /x Erni.Mobile.msi /log log.txt