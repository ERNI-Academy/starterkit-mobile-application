param(
    [string]$packageName = $null,
    [string]$Bitness= $null,
    [switch]$RunAsAdmin
)


if($RunAsAdmin){
    $RelaunchArgs = '-ExecutionPolicy Bypass -file "' + "$PSScriptRoot\Uninstall-UntrustedAppx.ps1" + '"' + " $packageName" + " $Bitness"    
    $AdminProcess = Start-Process "powershell.exe" -Verb RunAs -WorkingDirectory $PSScriptRoot -ArgumentList $RelaunchArgs -Wait    
    exit 0
}
else{
    $base = @();
    $packageName | ForEach-Object{$base += $base = (Get-AppxPackage -Name "*$_*").PackageFullName;};
    $base;
    $base | ForEach-Object { If($_ -match "_$($Bitness)_"){ $_ | Remove-AppxPackage } };
    exit 0
}
