param ( 
    [Parameter(Mandatory=$true)] $DropLocation
)
function Copy-Package {
    param (
        $DropLocation,
        $type,
        $name
    )
    $sourceManagedPackage = Get-ChildItem -path (($DropLocation) + "/drop/AutomationCoE$($name)*_managed.zip") | Select-Object FullName

    Write-Host "Found following $type package"
    Write-Host $sourceManagedPackage

    if ( $null -ne $sourceManagedPackage ) {
        Copy-Item $sourceManagedPackage.FullName -Destination "$($PSScriptRoot)\..\AutomationKITPackage_$($name)\PkgAssets"
    }

    $packageAsset = Get-ChildItem -path "$($PSScriptRoot)\..\AutomationKITPackage_$($name)\PkgAssets\AutomationCoE$($name)*.zip" | Select-Object FullName

    if ( $null -ne $packageAsset) {
        [xml]$xmlDoc = Get-Content -Path "$($PSScriptRoot)\..\AutomationKITPackage_$($name)\PkgAssets\ImportConfig.xml"
        $newPackageName = ([System.IO.Path]::GetFileName($packageAsset.FullName).ToString())
        $xmlDoc.configdatastorage.solutions.configsolutionfile.solutionpackagefilename = "$newPackageName"

        $configFile = "$($PSScriptRoot)\..\AutomationKITPackage_$($name)\PkgAssets\ImportConfig.xml"
        $xmlDoc.save($configFile)
    } else {
        Write-Error "Unable to find $type release package"
        exit 1
    }
}

function Build-Package {
    param (
        $name
    )
    Push-Location
    Set-Location "$($PSScriptRoot)\..\AutomationKITPackage_$($name)"
    dotnet publish -f net472 -c Release
    Pop-Location
}

function Deploy-Package {
    param (
        $name
    )

    $packageDeployment = Get-ChildItem -path "$($PSScriptRoot)\..\AutomationKITPackage_$($name)\bin\Release\AutomationKit_$($name)*.zip" | Select-Object FullName

    if ($null -ne $packageDeployment) {
        Copy-Item ($packageDeployment.FullName) -Destination "$($PSScriptRoot)\Microsoft_AutomationKIT_$($name)_Package.zip"
    } else {
        Write-Error "Unable to find deployment package"
        exit 1
    }
}

function Invoke-PackageAndDeploy {
    param (
        $DropLocation,
        $type,
        $name
    )

    Copy-Package $DropLocation $type $Name

    Build-Package $Name

    Deploy-Package $Name
}

if ( $global:exitScript ) {
	return
}

Write-Host "Read files from $DropLocation"

Invoke-PackageAndDeploy $DropLocation "main" "Main" 
Invoke-PackageAndDeploy $DropLocation "satellite" "Satellite" 