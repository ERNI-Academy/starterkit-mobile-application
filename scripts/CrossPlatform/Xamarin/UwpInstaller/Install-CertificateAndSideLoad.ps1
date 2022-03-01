param(
    [string]$packageName = $null,
    [switch]$RunAsAdmin
)
if($RunAsAdmin){
    $RelaunchArgs = '-ExecutionPolicy Bypass -file "' + "$PSScriptRoot\Install-CertificateAndSideLoad.ps1" + '"' + " $packageName"
    
    $AdminProcess = Start-Process "powershell.exe" -Verb RunAs -WorkingDirectory $PSScriptRoot -ArgumentList $RelaunchArgs -Wait
    
    exit 0
}
else{
    certutil.exe -addstore TrustedPeople "$PSScriptRoot\$packageName.cer"
    set-itemproperty -Path Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock -Name AllowAllTrustedApps -Value 1 -Verbose    
}
