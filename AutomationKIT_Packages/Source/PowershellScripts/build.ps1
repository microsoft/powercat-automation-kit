param( [Parameter(Mandatory=$true)] $DropLocation )

Push-Location

Set-Location "$($PSScriptRoot)\..\AutomationKITPackage_Main"

Copy-Item (($DropLocation) + "/drop/AutomationCoEMain*_managed.zip") -Destination PkgAssets
$paths = Get-ChildItem -path "PkgAssets/AutomationCoEMain*.zip" | Select-Object FullName

if ($paths.Count -ge 1) {
    $content = (Get-Content "PkgAssets/ImportConfig.xml")
    $content = $content.Replace("AutomationCoEMain.zip", [System.IO.Path]::GetFileName($paths[0].FullName))
    
    Set-Content -Path "PkgAssets/ImportConfig.xml" -Value $content
}
dotnet publish -f net472 -c Release

$paths = Get-ChildItem -path "bin/Release/AutomationKit_Main*.zip" | Select-Object FullName

Set-Location $($PSScriptRoot)

if ($paths.Count -ge 1) {
    Copy-Item ($paths[0].FullName) -Destination "Microsoft_AutomationKIT_Main_Package.zip"
}

Pop-Location
