Describe 'Install-Main-Solution-Test' {
    BeforeAll {
        $global:exitScript = $true
       . "$PSScriptRoot\..\Install_AutomationKit.ps1"
    }

	It 'GetInstallationType for Main solution'{		
		$installType =[InstallationType]::new([Logger]::new())		
		Mock Read-Host {return $True}		
		Mock -CommandName Write-Host -MockWith {}
		
		$installType.GetInstallationType()| Should -Be $True
	}
	It 'GetInstallationType for satellite solution selection'{		
		$installType =[InstallationType]::new([Logger]::new())
		Mock Read-Host {return $False}
		Mock -CommandName Write-Host -MockWith {}	
		Mock -CommandName write-warning -MockWith {}
		$installType.GetInstallationType()| Should -Be $False
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

    It 'Merge Array Object String' {
        $install = [InstallSettings]::new()

        $target = "[{'name':'#foo#'}]" | ConvertFrom-Json
        $values = "{'foo':'value'}" | ConvertFrom-Json

        $install.mergeDeploymentSettings( $target, $values )

        $target[0].name | Should -Be "value"
    }

    It 'Merge Array of Strings' {
        $install = [InstallSettings]::new()

        $target = "{'name':['a', '#foo#']}" | ConvertFrom-Json
        $values = "{'foo':'value'}" | ConvertFrom-Json

        $target.name.GetType().Name.ToLower() | Should -Be "object[]"
        $target.name[0].GetType().Name.ToLower() | Should -Be "string"

        $install.mergeDeploymentSettings( $target, $values )

        #$target.name[0] | Should -Be "a"
        #$target.name[1] | Should -Be "value"
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

        $deploy = [Deployment]::new($settings,[Logger]::new())
        Mock -CommandName Write-Host -MockWith {}	
		Mock -CommandName write-warning -MockWith {}
		Mock -CommandName write-Error -MockWith {}
		
        Mock pac

        $deploy.install()
    }
}
 