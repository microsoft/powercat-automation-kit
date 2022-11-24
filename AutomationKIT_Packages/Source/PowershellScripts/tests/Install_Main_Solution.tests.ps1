Describe 'Install-Main-Solution-Test' {
    BeforeAll {
        $global:exitScript = $true
       . "$PSScriptRoot\..\Install_Main_Solution.ps1"
    }

    It 'LoadDeploymentSettings' {
        $install = [InstallSettings]::new()

        Mock Get-Content { return "{'name':'value'}" }
        
        $settings = $install.loadDeploymentSettings()

        $settings.name | Should -Be "value"
    }

    It 'LoadUserResponseFile' {
        $install = [InstallSettings]::new()

        Mock Get-Content { return "{'name':'value'}" }
        
        $settings = $install.loadUserResponseFile()

        $settings.name | Should -Be "value"
    }

    It 'Get Environment Id' {
        $install = [InstallSettings]::new()

        $result = $install.getEnvironmentId("https://foo/environments/a")

        $result | Should -Be "a"
    }

    It 'No match - Get Environment Id' {
        $install = [InstallSettings]::new()

        $result = $install.getEnvironmentId("https://foo/a")

        $result | Should -Be ""
    }

    It 'Get Single User' {
        $sample = "{
            item: [ 
                {
                    'user': 'a'
                }
            ]
        }" | ConvertFrom-Json

        $install = [InstallSettings]::new()

        $result = $install.getUsers($sample.item.user)

        $result | Should -Be "a"
    }

    It 'Get Multiple Users' {
        $sample = "{
            item: [ 
                {
                    'user': 'a'
                },
                {
                    'user': 'b'
                }
            ]
        }" | ConvertFrom-Json

        $install = [InstallSettings]::new()

        $result = $install.getUsers($sample.item.user)

        $result | Should -Be "a,b"
    }

    It 'Get Connection Id' {
        $install = [InstallSettings]::new()

        $result = $install.getConnectionId("https://a/foo/value", "foo")

        $result | Should -Be "value"
    }

    It 'Merge Simple String' {
        $install = [InstallSettings]::new()

        $target = "{'name':'#foo#'}" | ConvertFrom-Json
        $values = "{'foo':'value'}" | ConvertFrom-Json

        $install.mergeDeploymentSettings( $target, $values )

        $target.name | Should -Be "value"
    }

    It 'Merge Array Simple String' {
        $install = [InstallSettings]::new()

        $target = "{'name':[{'item':'#foo#'}]}" | ConvertFrom-Json
        $values = "{'foo':'value'}" | ConvertFrom-Json

        $install.mergeDeploymentSettings( $target, $values )

        $target.name[0].item | Should -Be "value"
    }

    It 'Merge Object String' {
        $install = [InstallSettings]::new()

        $target = "{'name':{'item':'#foo#'}}" | ConvertFrom-Json
        $values = "{'foo':'value'}" | ConvertFrom-Json

        $install.mergeDeploymentSettings( $target, $values )

        $target.name.item | Should -Be "value"
    }

    It 'Merge connection id' {
        $install = [InstallSettings]::new()

        $target = "{'name':{'item':'#connection[shared_data].foo#'}}" | ConvertFrom-Json
        $values = "{'foo':'https://a/shared_data/ABC/'}" | ConvertFrom-Json

        $install.mergeDeploymentSettings( $target, $values )

        $target.name.item | Should -Be "ABC"
    }

    It 'Deploy Happy Path' {
        Mock Get-Content { return "{'name':'value'}" }

        $settings = [InstallSettings]::new()

        $deploy = [Deployment]::new($settings)
        
        Mock pac

        $deploy.install()
    }
}
 