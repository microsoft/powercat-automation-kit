param( [Parameter(Mandatory=$true)] $DropLocation )

Write-Host "Read files from $DropLocation"

$sourceManagedPackage = Get-ChildItem -path (($DropLocation) + "/drop/AutomationCoEMain*_managed.zip") | Select-Object FullName
$sourceSatelliteManagedPackage = Get-ChildItem -path (($DropLocation) + "/drop/AutomationCoESatellite*_managed.zip") | Select-Object FullName

Write-Host "Found following main package"
Write-Host $sourceManagedPackage

Write-Host "Found following satellite package"
Write-Host $sourceSatelliteManagedPackage

if ( $null -ne $sourceManagedPackage ) {
    Copy-Item $sourceManagedPackage.FullName -Destination "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets"
}

if ( $null -ne $sourceManagedPackage ) {
    Copy-Item $sourceSatelliteManagedPackage.FullName -Destination "$($PSScriptRoot)\..\AutomationKITSatellite_Main\PkgAssets"
}

$packageAsset = Get-ChildItem -path "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets\AutomationCoEMain*.zip" | Select-Object FullName
$packageSatelliteAsset = Get-ChildItem -path "$($PSScriptRoot)\..\AutomationKITPackage_Satellite\PkgAssets\AutomationCoESatellite*.zip" | Select-Object FullName

if ( $null -ne $packageAsset) {
    [xml]$xmlDoc = Get-Content -Path "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets\ImportConfig.xml"
    $newPackageName = ([System.IO.Path]::GetFileName($packageAsset.FullName).ToString())
    $xmlDoc.configdatastorage.solutions.configsolutionfile.solutionpackagefilename = "$newPackageName"

    $configFile = "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets\ImportConfig.xml"
    $xmlDoc.save($configFile)
} else {
    Write-Error "Unable to find main release package"
    exit 1
}

if ( $null -ne $packageSatelliteAsset) {
    [xml]$xmlDoc = Get-Content -Path "$($PSScriptRoot)\..\AutomationKITPackage_Satellite\PkgAssets\ImportConfig.xml"
    $newPackageName = ([System.IO.Path]::GetFileName($packageAsset.FullName).ToString())
    $xmlDoc.configdatastorage.solutions.configsolutionfile.solutionpackagefilename = "$newPackageName"

    $configFile = "$($PSScriptRoot)\..\AutomationKITPackage_Satellite\PkgAssets\ImportConfig.xml"
    $xmlDoc.save($configFile)
} else {
    Write-Error "Unable to find Satellite release package"
    exit 1
}

Push-Location
Set-Location "$($PSScriptRoot)\..\AutomationKITPackage_Main"
dotnet publish -f net472 -c Release
Pop-Location

Push-Location
Set-Location "$($PSScriptRoot)\..\AutomationKITPackage_Satellite"
dotnet publish -f net472 -c Release
Pop-Location

$packageDeployment = Get-ChildItem -path "$($PSScriptRoot)\..\AutomationKITPackage_Main\bin\Release\AutomationKit_Main*.zip" | Select-Object FullName

if ($null -ne $packageDeployment) {
    Copy-Item ($packageDeployment.FullName) -Destination "$($PSScriptRoot)\Microsoft_AutomationKIT_Main_Package.zip"
} else {
    Write-Error "Unable to find deployment package"
    exit 1
}

$packageSatelliteDeployment = Get-ChildItem -path "$($PSScriptRoot)\..\AutomationKITPackage_Satellite\bin\Release\AutomationKit_Satellite*.zip" | Select-Object FullName

if ($null -ne $packageSatelliteDeployment) {
    Copy-Item ($packageSatelliteDeployment.FullName) -Destination "$($PSScriptRoot)\Microsoft_AutomationKIT_Satellite_Package.zip"
} else {
    Write-Error "Unable to find satellite deployment package"
    exit 1
}