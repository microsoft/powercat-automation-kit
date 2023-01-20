enum EnumLogType
{
	Logs
	Warnings
	Erorrs
	Debug
}

class Logger
{	
	
	#LogType could be like below
	#1=Normal
	#2=Warning
	#3=Error
	#4=Debug

	[void] LogMessage ([string] $Message,[EnumLogType] $LogType)
	{
		if ($LogType-eq 1)
		{
		write-host $Message
		}
		elseif ($LogType-eq 2)
		{
			write-warning $Message
		}
		elseif ($LogType-eq 3)
		{
			write-Error $Message -ErrorId B1 -Category NotSpecified
		}
		elseif ($LogType-eq 4)
		{
			$DebugPreference = "Continue"
			write-debug $Message
		}
	}	
}

class InstallationType { 

	[boolean]$InstallMainSolution=$True
	[Logger]$ObjLogger

	InstallationType([Logger]$DefaultLogger )
	{
		
		$this.ObjLogger = $DefaultLogger
	}

	[string] GetInstallationType()
	{
		$this.ObjLogger.LogMessage("Welcome to Automation kit installation.",1)
		
		[string]$UserChoice= Read-Host -Prompt "Do you want to create and download connection settings from Automation Kit setup Page? (y/n) (y- create now, n- dont require (already if you have done)"
		
		$CharArray =$UserChoice.ToLower().ToCharArray()

		if ($CharArray[0] -eq "y")
		{
			$this.ObjLogger.LogMessage("Opening Automation Kit Setup page to create connections and other settings",1)
			
			Start-Process "https://microsoft.github.io/powercat-automation-kit/get-started/setup/"
		
			[string]$UserChoice= Read-Host -Prompt "Are you ready to install now?(y/n) (y-start installation and n-cancel the installation)"
			
			$CharArray =$UserChoice.ToLower().ToCharArray()

			if ($CharArray[0] -ne "y")
			{
				$this.ObjLogger.LogMessage("you have choosen not to install Automation kit now. Setup process will be aborted.",2)				
				break;
			}
		
		}
		
		$this.ObjLogger.LogMessage("========================================================",1)
		$this.ObjLogger.LogMessage("Getting things ready to install Automation Kit",1)
		$this.ObjLogger.LogMessage("========================================================",1)
		
		[string]$UserChoice= Read-Host -Prompt "Press y/n/c to continue setup (y- Install to Main solution, n- Install Satellite solution and c- or other to cancel the installation):"

		#True for main solution installation and false for satellite solution 

		$CharArray =$UserChoice.ToLower().ToCharArray()

		if ($CharArray[0] -eq "y")
		{
			$this.InstallMainSolution =[System.Convert]::ToBoolean('true')	
			
			$this.ObjLogger.LogMessage("========================================================================",1)
			$this.ObjLogger.LogMessage("Getting things ready to install Automation Kit - Main solution",1)
			$this.ObjLogger.LogMessage("========================================================================",1)
			
			return $this.InstallMainSolution
			
		}
		elseif ($CharArray[0] -eq "n")
		{
			$this.InstallMainSolution =[System.Convert]::ToBoolean('false') 
			
			$this.ObjLogger.LogMessage("========================================================================",1)
			$this.ObjLogger.LogMessage("Getting things ready to install Automation Kit - Satellite solution ",1)
			$this.ObjLogger.LogMessage("========================================================================",1)
			
			return $this.InstallMainSolution
			
			
		}
		else
		{			
			$this.ObjLogger.LogMessage("you have choosen not to install Automation kit. Setup process will be aborted.",2)
			break;
		}
		
		return $this.InstallMainSolution
	}
}

class InstallSettings { 

	[boolean] $InstallMainSolution=$True
	[string] $DeploymentSettingsFile = ".\DeploymentSettings_Main.json"
	[string] $UserResponsesFile = ".\automation-kit-main-install.json"
	[string] $UpdatedDeploymentSettingsFile=".\DeploymentSettings_Main.json"	
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
	[Logger]$ObjLogger	
		
	Deployment([InstallSettings] $settings,[Logger]$DefaultLogger) {
		$this.settings = $settings
		$this.ObjLogger = $DefaultLogger
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
		
		$NeedToCreateApplicationUser=""
		$AzureAppID=""
		$AzureAppName=""
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
			$NeedToCreateApplicationUser=$UserResponseData.'satellite-createApplicationUser' #need to read from user response json	
			$AzureAppID=$UserResponseData.'satellite-azureAppId' #need to read from user response json	
			$AzureAppName=$UserResponseData.'satellite-azureAppName' #need to read from user response json	
			
		}
		
		$this.settings.mergeDeploymentSettings($DeploymentSettingsData, $UserResponseData)
		$DeploymentSettingsData|ConvertTo-Json -depth 32| set-content $this.settings.UpdatedDeploymentSettingsFile
			
		
		#pac auth profile creation for Main environment to deploy the package 
		$this.ObjLogger.LogMessage("Creating profile authorization for the environment",1);
		
		pac auth delete -n $this.settings.AutoCOE_ProfileName

		$this.ObjLogger.LogMessage($EnvironmentURL,1);	

		pac auth create --url $EnvironmentURL   --name $this.settings.AutoCOE_ProfileName

		if ($Error -ne '')
		{
			$this.ObjLogger.LogMessage("authentication profile is not created due to User canceled authentication/ not authenticated properly. Unable to continue to install. original exception is " + $Error,3);
			Break;
		}
		pac auth select -n $this.settings.AutoCOE_ProfileName

		if ($Error -ne '')
		{
			$this.ObjLogger.LogMessage("Unable to select profile authorization for $this.settings.AutoCOE_ProfileName. Exception is " + $Error,3);
			Break;
		}
		
		$this.ObjLogger.LogMessage("Completed profile authorization for the environment and connected to your environment",1)

		$this.ObjLogger.LogMessage("Encoding Deployment settings",1)

		$Bytes = [System.Text.Encoding]::UTF8.GetBytes(($DeploymentSettingsData|ConvertTo-Json -Compress -depth 32))
		$EncodedSettings = [System.Convert]::ToBase64String($Bytes)
		
		$this.ObjLogger.LogMessage("Completed of Encoding Deployment settings",1)		
		
		$paths = Get-ChildItem -path ([System.IO.Path]::GetDirectoryName((Get-Command pac).Source)) -Filter "pac.exe" -Recurse -ErrorAction SilentlyContinue | Sort-Object -Property LastWriteTime | Select-Object FullName
				
		if ($paths.Count -gt 1)
		{			
			$PAC_exePath= $paths.FullName[$paths.Count-1].ToString()
		}
		else
		{				
			$PAC_exePath= $paths.FullName;			
		}
		
		$this.ObjLogger.LogMessage("Pac Path=" + $PAC_exePath,1)
		
				
		if ($this.settings.InstallMainSolution -eq $True)
		{
			
			Set-Content -Path $this.settings.LogFile '' -Force
			
			if($InstallSampleData -eq $True)
			{
				#getting current environment name
				$tempdetails = pac org who
				$CurrentEnvironment=""
				foreach ($env in $tempdetails)
				{
					[String]$line =$env
					
					if($line -imatch "Fri")
					{	
						$temp = $line.Split(':')
						if($temp.count -ge 0)
						{
						$CurrentEnvironment = $temp[1].Trim()
						}
						
					}
				}
				# extracting and updating database details
				
				#extract zip file
				Expand-Archive -Path $this.settings.PackageFilePath  -DestinationPath .\Updated\ -Force

				Expand-Archive -Path .\Updated\PkgAssets\AutomationKit-SampleData.zip  -DestinationPath .\Updated\PkgAssets\Updated\ -Force
				
				# replacing data file
				$tpath=get-location
				$currentFolder =$tpath.path
				[string] $xmlfileName= $currentFolder + "\Updated\PkgAssets\Updated\data.xml"

				$data = [xml](Get-Content  $xmlfileName )

				foreach ($obj in $data.entities.entity.records.record.field)
				{		
					if($obj.GetAttribute("value") -eq "administrator@contoso.onmicrosoft.com")
					{
						if($ProjectBusinessOwnerEmailId -ne '')
						{
						$obj.SetAttribute("value",$ProjectBusinessOwnerEmailId);
						}
					}
					elseif($obj.GetAttribute("value") -eq "Constoso_Prod")
					{
						
						$obj.SetAttribute("value",$CurrentEnvironment);
					}
					elseif($obj.GetAttribute("lookupentityname") -eq "Constoso_Prod")
					{
						
						$obj.SetAttribute("lookupentityname",$CurrentEnvironment);
					}
					
				}
				$data.Save($xmlfileName)

				# compressing the data file

				Compress-Archive -Path '.\Updated\PkgAssets\Updated\*conten*.xml','.\Updated\PkgAssets\Updated\data.xml','.\Updated\PkgAssets\Updated\data_schema.xml'  .\Updated\PkgAssets\AutomationKit-SampleData.zip -Force;

				# main package creation
				 Compress-Archive -Path '.\Updated\AutomationKIT_Main.dll','.\Updated\AutomationKIT_Main.dll.conf*','.\Updated\*conten*.xml','.\Updated\Input.xml','.\Updated\logo32x32.png','.\Updated\TermsOfUse.html','.\Updated\PkgAssets'-DestinationPath $this.settings.PackageFilePath -Force;	

				#Deleting newly created Updated folder
				$tpath=get-location
				$currentFolder =$tpath.path
				[string] $RemoveFolder= $currentFolder + "\Updated"
				Remove-Item $RemoveFolder -Recurse				
				 			
			}
					
			$Args= " package deploy --logFile " + $this.settings.LogFile + " -c true  --package " + $this.settings.PackageFilePath + " --settings installmainsolution=true|importconfigdata=$InstallSampleData|AutomationCoEMain_componentarguments=$EncodedSettings|activateapprovalflow=$EnableApprovalFlow|activateroiflow=$enableROIFlow|activatesyncflow=$enableSyncFlow|projectadminusers=$Admin_users|projectcontributors=$Contributor_users|projectviewers=$Viewer_users|businessowneremail=$ProjectBusinessOwnerEmailId" 
						
			$this.ObjLogger.LogMessage("========================================================",1)		
			$this.ObjLogger.LogMessage(" Installing Main solution",1)
			$this.ObjLogger.LogMessage("========================================================",1)
			
			try
			{

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
				 $this.ObjLogger.LogMessage("Please wait for couple of minutes while installation is in-progress:",1)
				 $Prc.Start() | Out-Null				 
				 
				 $stdout = $Prc.StandardOutput.ReadToEnd()
				 $stderr = $Prc.StandardError.ReadToEnd()
				 $this.ObjLogger.LogMessage("Logs:"+ $stdout,1)
				 
				 
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
			$this.ObjLogger.LogMessage("========================================================",1)
			$this.ObjLogger.LogMessage(" Installing Satellite solution",1)
			$this.ObjLogger.LogMessage("========================================================",1)
			
			Set-Content -Path $this.settings.LogFile '' -Force
				
			$Args= " package deploy --logFile " + $this.settings.LogFile + " -c true  --package " + $this.settings.PackageFilePath + " --settings installsatellitesolution=true|AutomationCoESatellite_componentarguments=$EncodedSettings|importconfigdata=$InstallSampleData|activateallflows=$ActivateAllCloudFlows|needtocreateapplicationuser=$NeedToCreateApplicationUser|azure_appid=$AzureAppID|azure_appname=$AzureAppName"
			
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
			 $this.ObjLogger.LogMessage("Please wait for couple of minutes while installation is in-progress:",1)
			 
			 $stdout = $Prc.StandardOutput.ReadToEnd()
			 $stderr = $Prc.StandardError.ReadToEnd()
				$this.ObjLogger.LogMessage("Logs:"+ $stdout,1)		
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
			$this.ObjLogger.LogMessage("The Automation Kit setup has found dependency of creator kit to install. Please install the creator kit from appsource URL: https://appsource.microsoft.com/en-US/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Overview . And later you can retry to install Automation kit.",3)
			break;
		}

		<#$this.ObjLogger.LogMessage("========================================================",1)
		#$this.ObjLogger.LogMessage(" Performing post deployment operations",1)
		$this.ObjLogger.LogMessage("========================================================",1)#>
		
		# Removing of newly created profile 
		pac auth delete -n $this.settings.AutoCOE_ProfileName
		
		<#if ($this.settings.InstallMainSolution -eq $False)
		{
			#Creating application user for satellite environment
			$this.ObjLogger.LogMessage("Creating application user",1);

			pac auth create --url $EnvironmentURL --kind admin -n $this.settings.AutoCOE_ProfileName

			pac auth select  $this.settings.AutoCOE_ProfileName			

			pac admin assign-user  --environment $EnvironmentId   --user $AzureAppID   --role "System Administrator"   --application-user
			$this.ObjLogger.LogMessage("Successfully created application user",1)
			
			pac auth delete -n $this.settings.AutoCOE_ProfileName
		}#>
		
		if ($LogDetails -imatch "Result:SUCCESS") 
		{	
			$this.ObjLogger.LogMessage("Deployment completed successfully",1);
		}
		else
		{
			$this.ObjLogger.LogMessage("Deployment Failed. Please verify logs from " + $this.settings.LogFile ,1);
		}
		
	}
}

if ( $global:exitScript ) {
	return
}

#Variables
$Error.clear()
[Logger]$loggerObj = [Logger]::new()
$installType = [InstallationType]::new($loggerObj)
$install_type= $installType.GetInstallationType()
$install = [InstallSettings]::new()
if ($installType.InstallMainSolution -eq $True)
{
	$install.InstallMainSolution=$True
	$install.DeploymentSettingsFile = ".\AutomationCoEMain_manifest.ppkg.json"
	$install.UserResponsesFile = ".\automation-kit-main-install.json"
	$install.UpdatedDeploymentSettingsFile=".\DeploymentSettings_Main.json"	
	$install.AutoCOE_ProfileName="AutoCOE_Main_Env"
	$install.PackageFilePath=".\Microsoft_AutomationKIT_Main_Package.zip"	
	$install.LogFile=".\Logs_Main.txt"
	
	$FileExist = Test-Path -Path $install.DeploymentSettingsFile  -PathType Leaf
			
	if ($FileExist -eq $False)
	{
		$loggerObj.LogMessage("Error: Deployment settings file '" + $install.DeploymentSettingsFile + "' is not found in current folder to install. Please verify once and try to install again.." ,1)	
		break;
	}
	
	$FileExist = Test-Path -Path $install.PackageFilePath  -PathType Leaf
			
	if ($FileExist -eq $False)
	{
		$loggerObj.LogMessage("Error: Automation Kit package file '" + $install.PackageFilePath + "' is not found in current folder to install. Please verify once and try to install again.." ,1)
	
		break;
	}
	
	$FileExist = Test-Path -Path $install.UserResponsesFile  -PathType Leaf
			
	if ($FileExist -eq $False)
	{
		$loggerObj.LogMessage("Error: User responses Json file '" + $install.UserResponsesFile + "' is not found in current folder to update connction references. Please verify once and try to install again.." ,1)
	
		break;
	}	
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
	
	$FileExist = Test-Path -Path $install.DeploymentSettingsFile  -PathType Leaf
			
	if ($FileExist -eq $False)
	{
		$loggerObj.LogMessage("Error: Deployment settings file '" + $install.DeploymentSettingsFile + "' is not found in current folder to install. Please verify once and try to install again.." ,1)
	
		break;
	}
	
	$FileExist = Test-Path -Path $install.PackageFilePath  -PathType Leaf
			
	if ($FileExist -eq $False)
	{
		$loggerObj.LogMessage("Error: Automation Kit package file '" + $install.PackageFilePath + "' is not found in current folder to install. Please verify once and try to install again.." ,1)
	
		break;
	}
	
	$FileExist = Test-Path -Path $install.UserResponsesFile  -PathType Leaf
			
	if ($FileExist -eq $False)
	{
		$loggerObj.LogMessage("Error: User responses Json file '" + $install.UserResponsesFile + "' is not found in current folder to update connction references. Please verify once and try to install again.." ,1)
	
		break;
	}	
}

$deploy = [Deployment]::new($install,$loggerObj)

$deploy.install()

$Error.clear()






 