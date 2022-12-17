Describe 'Build-Test' {
    BeforeAll {
        $global:exitScript = $true
       . "$PSScriptRoot\..\build.ps1" "X:\Foo"
    }

    It "Should Invoke-PackageAndDeploy" {
        Mock -CommandName "Copy-Package" { }
        Mock -CommandName "Build-Package" { }
        Mock -CommandName "Deploy-Package" { }

        Invoke-PackageAndDeploy "X:\temp" "main" "Main"

        Assert-MockCalled Copy-Package -ParameterFilter { $DropLocation -eq "X:\temp" -and $type -eq "main" -and $name -eq "Main" }
        Assert-MockCalled Build-Package -ParameterFilter { $name -eq "Main" }
        Assert-MockCalled Deploy-Package -ParameterFilter { $name -eq "Main" }
    }
}