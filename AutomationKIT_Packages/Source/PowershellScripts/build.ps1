param( [Parameter(Mandatory=$true)] $DropLocation )

Write-Host "Read files from $DropLocation"

$sourceManagedPackage = Get-ChildItem -path (($DropLocation) + "/drop/AutomationCoEMain*_managed.zip") | Select-Object FullName

Write-Host "Found following main package"
Write-Host $sourceManagedPackage

if ( $null -ne $sourceManagedPackage ) {
    Copy-Item $sourceManagedPackage.FullName -Destination "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets"
}

$packageAsset = Get-ChildItem -path "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets\AutomationCoEMain*.zip" | Select-Object FullName

if ( $null -ne $packageAsset) {
    [xml]$xmlDoc = Get-Content -Path "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets\ImportConfig.xml"
    $newPackageName = ([System.IO.Path]::GetFileName($packageAsset.FullName).ToString())
    $xmlDoc.configdatastorage.solutions.configsolutionfile.solutionpackagefilename = "$newPackageName"

    $configFile = "$($PSScriptRoot)\..\AutomationKITPackage_Main\PkgAssets\ImportConfig.xml"
    $xmlDoc.save($configFile)
} else {
    Write-Error "Unable to file main release package"
    exit 1
}

dotnet publish -f net472 -c Release

$packageDeployment = Get-ChildItem -path "$($PSScriptRoot)\..\AutomationKITPackage_Main\bin\Release\AutomationKit_Main*.zip" | Select-Object FullName

if ($null -ne $packageDeployment) {
    Copy-Item ($packageDeployment.FullName) -Destination "$($PSScriptRoot)\Microsoft_AutomationKIT_Main_Package.zip"
} else {
    Write-Error "Unable to file deployment package"
    exit 1
}