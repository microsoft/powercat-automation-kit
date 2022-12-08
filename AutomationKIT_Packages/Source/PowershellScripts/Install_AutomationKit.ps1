
Write-Host ========================================================
Write-Host  Getting things Ready to install Automation Kit  
Write-Host ===========================================================

$UserChoice= Read-Host -Prompt "Welcome to Automation kit installation.  Press y/n/c to continue setup (y- Install Main solution, n- Install Satellite solution and c- or other to cancel the installation):"

# True for main solution installation and false for satellite solution 

[boolean]$InstallMainSolution=$True
$Installation_Solution =''

	$CharArray =$UserChoice.ToLower().ToCharArray()

	if ($CharArray[0] -eq "y")
	{
		$InstallMainSolution =[System.Convert]::ToBoolean('true')	
		$Installation_Solution ='Main'

	}
	elseif ($CharArray[0] -eq "n")
	{
		$InstallMainSolution =[System.Convert]::ToBoolean('false') 
		$Installation_Solution ='Satellite'

	}
	else {
		write-host "you have choosen not to install Automation kit. Setup process will be aborted."
		break;
	}

Write-Host ========================================================================
Write-Host  Getting things ready to install Automation Kit -$Installation_Solution solution 
Write-Host =========================================================================

class InstallSettings { 

	[boolean] $InstallMainSolution=$True
	[string] $DeploymentSettingsFile = ""
	[string] $UserResponsesFile = ""
	[string] $UpdatedDeploymentSettingsFile=""	
	[string] $AutoCOE_ProfileName=""
	[string] $PackageFilePath=""	
	[string] $LogFile=""

	[object] loadDeploymentSettings() {
		return Get-Content $this.DeploymentSettingsFile -raw|ConvertFrom-Json
	}

	[object] loadUserResponseFile() {
		return Get-Content $this.UserResponsesFile -raw|ConvertFrom-Json
	}

	[void] mergeDeploymentSettings([PSCustomObject] $deploymentSettings, [PSCustomObject] $userResponse) {
		
		if ( $deploymentSettings -eq $null -or $deploymentSettings.PSObject -eq $null ) {
			
			return
		}
		
		$deploymentSettings.PSObject.Properties | foreach {
			$name = $_.Name
			$val = $_.Value
			if ( $val -ne $NULL ) {		
				Switch ( $val.GetType().Name.ToLower() ) {
					"pscustomobject" {
						$this.mergeDeploymentSettings($val, $userResponse)
					}
					"object[]" {
						if ( ($val.Count -gt 0) -and $val[0].GetType().Name.ToLower() -eq "string") {
							[string[]]$array = $val -as [string[]]
							for( $i=0; $i -lt $array.Count; $i++ ) {
								if ( $array[$i] -ne $null -and $array[$i].IndexOf('connection[') -gt 0 ) 
								{
									$parts = $array[$i].Replace("#","").Split('.')
									$connection =  $parts[0].Replace("connection[","").Replace("]","")
									$nameValue = $parts[1];
									$val[$i] = $this.getConnectionId($userResponse.$nameValue, $connection)
								} else {
									if ( $array[$i] -ne $null -and $array[$i].IndexOf('#') -eq 0 ) 
									{
										$propName = $array[$i].Replace("#","")
										if (($userResponse.PSObject.Properties.Name -contains $propName) ) {
											$val[$i] = $userResponse.$propName
										}
									}
								}
							}
						} else {
							foreach ( $item in $val ) {
								$this.mergeDeploymentSettings($item, $userResponse)
							}
						}
					}
					"string" {
						if ( -not [string]::IsNullOrEmpty($val) ) {
							if ( ($val.IndexOf("#") -ge 0)) {
								$propName = $val.Replace("#","")

								if ( $propName.IndexOf('connection[') -eq 0 ) {
									$parts = $propName.Split('.')
									$connection =  $parts[0].Replace("connection[","").Replace("]","")
									$nameValue = $parts[1];
									
									if (($userResponse.PSObject.Properties.Name -contains $nameValue) ) {
										$deploymentSettings.$name = $this.getConnectionId($userResponse.$nameValue, $connection)									
									}
								} else {
									if (($userResponse.PSObject.Properties.Name -contains $propName) ) {
										$deploymentSettings.$name = $userResponse.$propName
									}
								}
							}
						}
					}
				}
			}
		}
	}

	[string] getEnvironmentId([string] $url) {
		if ($url -ne '')
		{
			$connectorsArray = $url.Split("/")
			$counter = 0
			
			foreach ($element in $connectorsArray) 
			{
				if ($element.ToLower() -eq "environments")
				{
					return $ConnectorsArray[$counter+1]
				}
				else
				{
					$counter+=1
				}		
			}

			return "";
		}
		return "";
	}

	[string] getUsers([object] $userInfo) {
		[string] $result = ""
		foreach ($tempEmail in $userInfo) 
		{
			$result +=$TempEmail.ToString().Trim() + ","       
		}
		if ($result -ne '')
		{
			$result=$result.Substring(0,($result.Length)-1)	
		}
		
		return $result
	}

	# Function to identify and exact connection id and returns from user response json file
	[string] getConnectionId ([string] $BaseURL, [string] $ConnectorID)
	{

		$ConnectorsArray =$BaseURL.Split("/")
		$counter=0
		$ResultValue=""

		foreach ($connector in $ConnectorsArray) 
		{
			if ($connector -eq $ConnectorID)
			{
				$ResultValue=$ConnectorsArray[$counter+1]
			}
			else
			{
				$counter+=1
			}		
		}
		 		 
		return $ResultValue	
	}
}

class Deployment {
	[InstallSettings] $settings
	
	# Connection references
	$shared_approvals=""
	$shared_commondataserviceforapps=""
	$shared_office365users=""
	$shared_office365=""
	$shared_powerplatformforadmins=""
		
	Deployment([InstallSettings] $settings) {
		$this.settings = $settings
	}

	[void] install() {
		$DeploymentSettingsData = $this.settings.loadDeploymentSettings()
		$UserResponseData = $this.settings.loadUserResponseFile()
		
		$EnableApprovalFlow=""
		$EnableROIFlow=""
		$EnableSyncFlow=""
		$Admin_users =""
		$Contributor_users = ""
		$Viewer_users =""
		$ProjectBusinessOwnerEmailId=""
		
		$AzureAppID=""
		$ActivateAllCloudFlows=""
		
		if ($this.settings.InstallMainSolution -eq $True)
		{
			$environmentId = $this.settings.getEnvironmentId($UserResponseData.'main-installEnvironment')

			$Admin_users =$this.settings.getUsers($UserResponseData.'main-administrators'.user)
			$Contributor_users = $this.settings.getUsers($UserResponseData.'main-contributors'.user)
			$Viewer_users = $this.settings.getUsers($UserResponseData.'main-viewers'.user)
			
			$EnvironmentURL = $UserResponseData.'main-instanceUrl'
			$installSampleData = $UserResponseData.'main-installSampleData'
			$EnableROIFlow=$UserResponseData.'main-enableROIFlow'
			$EnableApprovalFlow=$UserResponseData.'main-enableApprovalFlow'
			$EnableSyncFlow=$UserResponseData.'main-enableSyncFlow'	
			$ProjectBusinessOwnerEmailId=$UserResponseData.'main-businessApprover'	
		}
		else
		{			
			$EnvironmentId= $UserResponseData.'satellite-environmentId'
			$EnvironmentURL= $UserResponseData.'satellite-environmentUrl'
			$InstallSampleData=$UserResponseData.'satellite-installSampleData'		
			$ActivateAllCloudFlows=$UserResponseData.'satellite-activateAllCloudFlows'
			$AzureAppID=$UserResponseData.'satellite-azureAppId' #need to read from user response json		
		}
		
		$this.settings.mergeDeploymentSettings($DeploymentSettingsData, $UserResponseData)
		$DeploymentSettingsData|ConvertTo-Json -depth 32| set-content $this.settings.UpdatedDeploymentSettingsFile
			
		
		#pac auth profile creation for Main environment to deploy the package 
		write-host "Creating profile authorization for the environment"

		pac auth delete -n $this.settings.AutoCOE_ProfileName

		Write-Host $EnvironmentURL 

		pac auth create --url $EnvironmentURL   --name $this.settings.AutoCOE_ProfileName

		if ($Error -ne '')
		{
			write-host "authentication profile is not created due to User canceled authentication/ not authenticated properly. Unable to continue to install. original exception is " + $Error
			Break;
		}
		pac auth select -n $this.settings.AutoCOE_ProfileName

		if ($Error -ne '')
		{
			write-host "Unable to select profile authorization for $this.settings.AutoCOE_ProfileName. Exception is " + $Error
			Break;
		}
		write-host "Completed profile authorization for the environment and connected to your environment"

		write-host "Encoding Deployment settings"

		$Bytes = [System.Text.Encoding]::UTF8.GetBytes(($DeploymentSettingsData|ConvertTo-Json -Compress -depth 32))
		$EncodedSettings = [System.Convert]::ToBase64String($Bytes)
		
		write-host "Completed of Encoding Deployment settings"
				
		#C:\users\kmarram\.nuget\packages\microsoft.powerapps.cli\1.20.3\tools\pac.exe
		
		$paths = Get-ChildItem -Path "c:\users\" -Filter "pac.exe" -Recurse -ErrorAction SilentlyContinue | Select-Object FullName
		
		if ($paths.Count -ge 0)
		{
			$PAC_exePath= $paths.FullName[$paths.Count-1].ToString()
		}
		else
		{
			$PAC_exePath= $paths
		}
		
		write-host "Pac Path=" $PAC_exePath
								
		if ($this.settings.InstallMainSolution -eq $True)
		{
			$Args= " package deploy --logFile " + $this.settings.LogFile + " -c true  --package " + $this.settings.PackageFilePath + " --settings installmainsolution=true|importconfigdata=$InstallSampleData|AutomationCoEMain_componentarguments=$EncodedSettings|activateapprovalflow=$EnableApprovalFlow|activateroiflow=$enableROIFlow|activatesyncflow=$enableSyncFlow|projectadminusers=$Admin_users|projectcontributors=$Contributor_users|projectviewers=$Viewer_users|businessowneremail=$ProjectBusinessOwnerEmailId" 
						
			Write-Host ========================================================		
			Write-Host  Installing Main solution
			Write-Host ========================================================
			try
			{
				
				#Start-Transcript -Path "$($PSScriptRoot)\StartProcess.log"
 
				$PInfo = New-Object System.Diagnostics.ProcessStartInfo -Prop @{
					 RedirectStandardError = $True
					 RedirectStandardOutput = $True
					 UseShellExecute = $False
					 WorkingDirectory = $PSScriptRoot
					 FileName = $PAC_exePath
					 Arguments = $Args
					 WindowStyle = "Hidden"
					 				 }
				 
				 $Prc = New-Object System.Diagnostics.Process
				 $Prc.StartInfo = $PInfo
				 Write-Host "Please wait for couple of minutes while installation is in-porgress:"
				 $Prc.Start() | Out-Null				 
				 #$Prc.WaitForExit()
				 
				 $stdout = $Prc.StandardOutput.ReadToEnd()
				 $stderr = $Prc.StandardError.ReadToEnd()
				 Write-Host "Logs: $stdout"
				 
				 #Write-Host "stderr: $stderr"
				 #Write-Host "exit code: " + $Prc.ExitCode
				 
			}
			catch 
			{
				$_ | format-list -force | Out-String 
				throw
			}
					
			#pac package deploy --logFile $this.settings.LogFile -c true  --package $this.settings.PackageFilePath --settings "installmainsolution=false|importconfigdata=$InstallSampleData|AutomationCoEMain_componentarguments=$EncodedSettings|activateapprovalflow=$EnableApprovalFlow|activateroiflow=$enableROIFlow|activateyncflow=$enableSyncFlow|projectadminusers=$Admin_users|projectcontributors=$Contributor_users|projectviewers=$Viewer_users|businessowneremail=$ProjectBusinessOwnerEmailId"
		}
		else
		{
			Write-Host ========================================================		
			Write-Host  Installing Satellite soluiton
			Write-Host ========================================================
			
			$Args= " package deploy --logFile " + $this.settings.LogFile + " -c true  --package " + $this.settings.PackageFilePath + " --settings installsatellitesolution=true|AutomationCoESatellite_componentarguments=$EncodedSettings|importconfigdata=$InstallSampleData|activateallflows=$ActivateAllCloudFlows"
			
			try
			{					
			$PrInfo = New-Object System.Diagnostics.ProcessStartInfo -Prop @{
				 RedirectStandardError = $True
				 RedirectStandardOutput = $True
				 UseShellExecute = $False
				 WorkingDirectory = $PSScriptRoot
				 FileName = $PAC_exePath
				 Arguments = $Args
				 WindowStyle = "Hidden"				 
				}
			 
			 $Prc = New-Object System.Diagnostics.Process
			 $Prc.StartInfo = $PrInfo
			 $Prc.Start() | Out-Null
			 Write-Host "Please wait for couple of minutes while installation is in-porgress:"
			 
			 $stdout = $Prc.StandardOutput.ReadToEnd()
			 $stderr = $Prc.StandardError.ReadToEnd()
			Write-Host "Logs: $stdout"			
			Write-Host "Error: $stderr"
			
			}
			catch 
			{
				$_ | format-list -force | Out-String 
				throw
			}
			
			#Pac package deploy --logFile $this.settings.LogFile  -c true  --package $this.settings.PackageFilePath  --settings "installsatellitesolution=true|AutomationCoESatellite_componentarguments=$EncodedSettings|importconfigdata=$InstallSampleData|activateallflows=$ActivateAllCloudFlows"
		}
		
		# Reading log file for errors or dependencies	
		$LogDetails = Get-Content $this.settings.LogFile
		
		if (($LogDetails -imatch "Error") -and ($LogDetails -imatch "Some dependencies are missing")-and ($LogDetails -imatch "CreatorKitCore"))
		{	
			write-host "The Automation Kit setup has found dependency of creator kit to install. Please install the creator kit from appsource URL:https://appsource.microsoft.com/en-US/home. And later you can retry to install Automation kit."
			break;
		}

		Write-Host ========================================================
		Write-Host  Performing post deployment operations
		Write-Host ========================================================
		
		# Removing of newly created profile 
		pac auth delete -n $this.settings.AutoCOE_ProfileName
		
		if ($this.settings.InstallMainSolution -eq $False)
		{
			#Creating application user for satellite environment			
			pac auth create --url $EnvironmentURL --kind admin -n $this.settings.AutoCOE_ProfileName

			pac auth select  $this.settings.AutoCOE_ProfileName

			write-host "Creating applicaiton user"

			pac admin assign-user  --environment $EnvironmentId   --user $AzureAppID   --role "System Administrator"   --application-user
			write-host "Successfully created applicaiton user"
			
			pac auth delete -n $this.settings.AutoCOE_ProfileName
		}
	}
}

if ( $global:exitScript ) {
	return
}

#Variables
$Error.clear()
$install = [InstallSettings]::new()
if ($InstallMainSolution -eq $True)
{
	$install.InstallMainSolution=$True
	$install.DeploymentSettingsFile = ".\AutomationCoEMain_manifest.ppkg.json"
	$install.UserResponsesFile = ".\automation-kit-main-install.json"
	$install.UpdatedDeploymentSettingsFile=".\DeploymentSettings_Main.json"	
	$install.AutoCOE_ProfileName="AutoCOE_Main_Env"
	$install.PackageFilePath=".\Microsoft_AutomationKIT_Main_Package.zip"	
	$install.LogFile=".\Logs.txt"
}
else
{
	$install.InstallMainSolution=$False
	$install.DeploymentSettingsFile = ".\AutomationCoESatellite_manifest.ppkg.json"
	$install.UserResponsesFile = ".\automation-kit-satellite-install.json"
	$install.UpdatedDeploymentSettingsFile=".\DeploymentSettings_Satellite.json"	
	$install.AutoCOE_ProfileName="AutoCOE_Satellite_Env"
	$install.PackageFilePath=".\Microsoft_AutomationKIT_Satellite_Package.zip"	
	$install.LogFile=".\Logs_Satellite.txt"
}

$deploy = [Deployment]::new($install)

$deploy.install()

$Error.clear()

write-host "Deployment completed successfully."





 