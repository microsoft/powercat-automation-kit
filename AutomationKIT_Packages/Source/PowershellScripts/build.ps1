param( [Parameter(Mandatory=$true)] $DropLocation )

Write-Host "Read files from $DropLocation"

$sourceManagedPackages = Get-ChildItem -path (($DropLocation) + "/drop/AutomationCoEMain*_managed.zip") | Select-Object FullName

Write-Host "Found following main package - ($sourceManagedPackages.Count)"
Write-Host $sourceManagedPackages

if ($sourceManagedPackages.Count -ge 1) {
    Copy-Item $sourceManagedPackages[0].FullName -Destination "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets"
}

Copy-Item (($DropLocation) + "/drop/AutomationCoEMain*_managed.zip") -Destination "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets"
$paths = Get-ChildItem -path "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets\AutomationCoEMain*.zip" | Select-Object FullName

if ($paths.Count -ge 1) {
    [xml]$xmlDoc = Get-Content -Path "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets\ImportConfig.xml"
    $newPakage = ([System.IO.Path]::GetFileName($paths[0].FullName).ToString())
    $xmlDoc.configdatastorage.solutions.configsolutionfile.solutionpackagefilename = "$newPakage"

    $configFile = "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets\ImportConfig.xml"
    Write-Host $configFile
    $xmlDoc.save($configFile)
} else {
    Write-Error "Unable to file main release package"
    exit 1
}

dotnet publish -f net472 -c Release

$paths = Get-ChildItem -path "$($PSScriptRoot)\..\AutomationKITPackage_Main\bin\Release\AutomationKit_Main*.zip" | Select-Object FullName

if ($paths.Count -ge 1) {
    Copy-Item ($paths[0].FullName) -Destination "$($PSScriptRoot)\Microsoft_AutomationKIT_Main_Package.zip"
}