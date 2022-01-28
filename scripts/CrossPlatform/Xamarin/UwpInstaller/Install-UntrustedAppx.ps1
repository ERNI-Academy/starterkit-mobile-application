param(
    [string]$packageName = $null,
    [switch]$RunAsAdmin
)

$PackageSignature = Get-AuthenticodeSignature "$PSScriptRoot\$packageName.appxbundle"
$PackageCertificate = $PackageSignature.SignerCertificate
if (!$PackageCertificate)
{
	throw "Usigned package"
	exit -1
}


if($RunAsAdmin){

    $RelaunchArgs = '-ExecutionPolicy Bypass -file "' + "$PSScriptRoot\Install-UntrustedAppx.ps1" + '"' + " $packageName"
    
    $AdminProcess = Start-Process "powershell.exe" -Verb RunAs -WorkingDirectory $PSScriptRoot -ArgumentList $RelaunchArgs -Wait
    
    exit 0
}
else{

    $DependencyPackages = Get-ChildItem (Join-Path (Join-Path $PSScriptRoot "Dependencies") "*.appx")
    
    if ($DependencyPackages.Count -gt 0)
    {
    	Add-AppxProvisionedPackage -Online -PackagePath "$PSScriptRoot\$packageName.appxbundle" -DependencyPackagePath $DependencyPackages.FullName -SkipLicense
    }
    else
    {
    	Add-AppxProvisionedPackage -Online -PackagePath "$PSScriptRoot\$packageName.appxbundle" -SkipLicense
    }
    
    exit 0
}