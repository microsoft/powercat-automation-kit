# installing Main soluiton with deployment settings
Write-Host ========================================================
Write-Host  Getting things to ready to install Main solution
Write-Host ===========================================================

<#$UserResponsesFile = ".\*satellite*.json"
$FileExist = Test-Path -Path $UserResponsesFile  -PathType Leaf
write-host $FileExist
break;#>


class InstallSettings { 
	[string] $DeploymentSettingsFile = ".\AutomationCoEMain_1.0.20221102.1_managed.json"
	[string] $UserResponsesFile = ".\automation-kit-main-install.json"
	[string] $UpdatedDeploymentSettingsFile=".\DeploymentSettings_Main.json"
	[string] $StoreExtractedScript="yes"
	[string] $AutoCOE_Main_ProfileName="AutoCOE_Main_Env"
	[string] $PackageFilePath=".\Microsoft_AutomationKIT_Main_Package.zip"
	[string] $CreatorKITPackageFilePath=".\Microsoft_CreatorKITPackage.zip"
	[string] $LogFile=".\logsForMainSolution.txt"

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
			Switch ( $val.GetType().Name.ToLower() ) {
				"pscustomobject" {
					$this.mergeDeploymentSettings($val, $userResponse)
				}
				"object[]" {
					foreach ( $item in $val ) {
						$this.mergeDeploymentSettings($item, $userResponse)
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
	$AdminUsers=""
	$ContributorUsers=""
	$ViewerUsers=""

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
		
		$EnvironmentURL = $UserResponseData.'main-instanceUrl'
		$installSampleData = $UserResponseData.'main-installSampleData'

		#Getting EnvironmentID from Environment URL
		$environmentId = $this.settings.getEnvironmentId($UserResponseData.'main-installEnvironment')

		$this.AdminUsers =$this.settings.getUsers($UserResponseData.'main-administrators'.user)
		$this.ContributorUsers = $this.settings.getUsers($UserResponseData.'main-contributors'.user)
		$this.ViewerUsers = $this.settings.getUsers($UserResponseData.'main-viewers'.user)

		$this.settings.mergeDeploymentSettings($DeploymentSettingsData, $UserResponseData)

		#pac auth profile creation for Main environment to deploy the package 
		write-host "Creating profile authorization for the environment"

		pac auth delete -n $this.settings.AutoCOE_Main_ProfileName

		Write-Host $EnvironmentURL 

		pac auth create --url $EnvironmentURL   --name $this.settings.AutoCOE_Main_ProfileName

		if ($Error -ne '')
		{
			write-host "authentication profile is not created due to User canceled authentication/ not authenticated properly. Unable to continue to install. original exception is " + $Error
			Break;
		}
		pac auth select -n $this.settings.AutoCOE_Main_ProfileName

		if ($Error -ne '')
		{
			write-host "Unable to select profile authorization for $this.settings.AutoCOE_Main_ProfileName.Exception is " + $Error
			Break;
		}

		write-host "Completed profile authorization for the environment and connected to your Main environment"

		write-host "Encoding Deployment settings"

		$Bytes = [System.Text.Encoding]::UTF8.GetBytes(($DeploymentSettingsData | ConvertTo-Json -Compress -depth 32))
		$EncodedSettings = [System.Convert]::ToBase64String($Bytes)

		write-host "Completed of Encoding Deployment settings"
		Write-Host ========================================================
		Write-Host  installing Main soluiton with deployment settings
		Write-Host ========================================================

		pac package deploy --logFile $this.settings.LogFile -c true  --package $this.settings.PackageFilePath --settings "installmainsolution=true|enablepcf=true|importconfigdata=$InstallSampleData|AutomationCOEMain_deploymentsettings = $EncodedSettings"
				
		$LogDetails = Get-Content $this.settings.LogFile
		write-host $logDetails

		Write-Host ========================================================
		Write-Host  Performing post deployment operations
		Write-Host ========================================================

		# Removing of newly created profile 
		Write-Host pac auth delete -n $this.settings.AutoCOE_Main_ProfileName
	}
}

if ( $global:exitScript ) {
	return
}

#Variables
$install = [InstallSettings]::new()

$deploy = [Deployment]::new($install)

$deploy.install()


$Error.clear()
# open json files

return

if (($LogDetails -imatch "Error") -and ($LogDetails -imatch "Some dependencies are missing")-and ($LogDetails -imatch "CreatorKitCore"))
{
	write-host""
	
$UserChoice= Read-Host -Prompt "The Automation Kit setup has found some dependencies to install. Do you want to install dependencies to continue? Press y/n to continue setup (y-yes and n-no):"

	$CharArray =$UserChoice.ToLower().ToCharArray()

	if ($CharArray[0] -eq "y")
	{
		write-host "Installing Creator kit package..."
		pac package deploy --logFile .\logsFor_CreatorKIT.txt -c true --package $CreatorKITPackageFilePath 
		write-host "Creator kit package installation is completed successfully and trying to install Automation kit"
		
		pac package deploy --logFile $LogFile -c true  --package $PackageFilePath --settings "installmainsolution=true|enablepcf=true|importconfigdata=$InstallSampleData"

	}
	else
	{
		write-host "Current installation is failed and exiting now.You have not selected to install dependencies. Please install dependencies of creator kit First and later install this Automation kit. "
		break;
	}
}



function Update-AssignSecurityRoles {	
	Param
    (
		[Parameter(Mandatory = $true)] [string] $EnvironmentId,
	    [Parameter(Mandatory = $true)] [string] $UserList,
        [Parameter(Mandatory = $true)] [string] $SecurityRole		
    )	
	$UsersArray =$UserList.Split(",")		 

    foreach ($UserEmail in $UsersArray) 
	{
        pac admin assign-user `  --environment $EnvironmentID --user $UserEmail  --role $SecurityRole
		if ($Error -ne '')
		{
			write-host "Unable to assign user $UserEmail to role $SecurityRole on environment $EnvironmentID" 
			$Error.clear()
		}
	}
	return $true	
}

if (($AdminUsers -ne '') -or ($ViewerUsers -ne '') -or ($ContributorUsers -ne ''))
{
	
pac auth create --url $EnvironmentURL --kind admin -n $AutoCOE_Main_ProfileName

write-host "Assigning users to security group Automation Project Admin"


	$SecurityRole="Automation Project Admin"

	if ($AdminUsers -ne '')
	{
	write-host "Assigning users to security group Automation $SecurityRole"
	Update-AssignSecurityRoles -EnvironmentID $EnvironmentId -UserList $AdminUsers -SecurityRole $SecurityRole
	write-host "Completed of Assigning users to security group $SecurityRole"
	}


	$SecurityRole="Automation Project Viewer"

	if ($ViewerUsers -ne '')
	{
	write-host "Assigning users to security group $SecurityRole"
	Update-AssignSecurityRoles -EnvironmentID $EnvironmentId -UserList $ViewerUsers -SecurityRole $SecurityRole
	write-host "Completed of Assigning users to security group $SecurityRole"
	}

	$SecurityRole="Automation Project Contributor"

	if ($ContributorUsers -ne '')
	{
	write-host "Assigning users to security group $SecurityRole"
	Update-AssignSecurityRoles -EnvironmentID $EnvironmentId -UserList $ContributorUsers -SecurityRole $SecurityRole
	write-host "Completed of Assigning users to security group $SecurityRole"
	}
	
	pac auth delete -n $AutoCOE_Main_ProfileName
}



write-host "Deployment completed successfully."





 