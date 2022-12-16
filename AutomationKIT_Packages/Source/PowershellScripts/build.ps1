param( [Parameter(Mandatory=$true)] $DropLocation )

Push-Location

Write-Host "Read files from $DropLocation"
Set-Location "$($PSScriptRoot)\..\AutomationKITPackage_Main"

$sourceManagedPackages = Get-ChildItem -path (($DropLocation) + "/drop/*_managed.zip") | Select-Object FullName
Write-Host $sourceManagedPackages

Copy-Item (($DropLocation) + "/drop/AutomationCoEMain*_managed.zip") -Destination PkgAssets
$paths = Get-ChildItem -path "PkgAssets/AutomationCoEMain*.zip" | Select-Object FullName

if ($paths.Count -ge 1) {
    [xml]$xmlDoc = Get-Content -Path "PkgAssets/ImportConfig.xml"
    $newPakage = ([System.IO.Path]::GetFileName($paths[0].FullName).ToString())
    $xmlDoc.configdatastorage.solutions.configsolutionfile.solutionpackagefilename = "$newPakage"
    $configPath = Get-ChildItem -path "PkgAssets/ImportConfig.xml" | Select-Object FullName

    $configFile = $configPath[0].FullName
    Write-Host $configFile
    $xmlDoc.save($configFile)
} else {
    Write-Error "Unable to file main release package"
    exit 1
}

dotnet publish -f net472 -c Release

$paths = Get-ChildItem -path "bin/Release/AutomationKit_Main*.zip" | Select-Object FullName

Set-Location $($PSScriptRoot)

if ($paths.Count -ge 1) {
    Copy-Item ($paths[0].FullName) -Destination "Microsoft_AutomationKIT_Main_Package.zip"
}

Pop-Location
