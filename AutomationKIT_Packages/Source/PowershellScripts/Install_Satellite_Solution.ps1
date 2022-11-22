# installing satellite soluiton with deployment settings
Write-Host ========================================================
Write-Host  Getting things to ready to install Satellite solution
Write-Host ===========================================================

$DeploymentSettingsFile = ".\AutomationCoESatellite_1.0.20221102.1_managed.json"
$UserResponsesFile = ".\automation-kit-satellite-install.json"
$UpdatedDeploymentSettingsFile=".\DeploymentSettings_Satellite.json"
$AutoCOE_Satellite_ProfileName="AutoCOE_Satellite_Env"
$StoreExtractedScript="yes"
$PackageFilePath="C:\Kotesh\AppSourceFolder\Microsoft_AutomationKIT_Satellite_Package.zip"
$CreatorKITPackageFilePath="C:\Kotesh\AppSourceFolder\Microsoft_CreatorKITPackage.zip"
$LogFile=".\logsForSatelliteSolution.txt"
$InstallSampleData="true"

# Environment variables
$AKVClientIdSecret=""
$AKVClientSecretSecret=""
$AKVTenantIdSecret=""
$AutomationCoEAlertEmailRecipient=""
$AutomationProjectAppID=""
$DesktopFlowsBaseURL=""
$EnvironmentId=""
$EnvironmentName=""
$EnvironmentRegion=""
$EnvironmentUniqeName=""
$EnvironmentUniqueNameofCoEMain=""
$EnvironmentURL=""
$FlowSessionTraceRecordOwnerId=""

# Connection references
$shared_commondataserviceforapps=""
$shared_commondataservice=""
$shared_flowmanagement=""
$shared_office365users=""
$shared_powerplatformforadmins=""
$shared_office365=""

$Error.clear()

# open json files
$DeploymentSettingsData = Get-Content $DeploymentSettingsFile -raw|ConvertFrom-Json
$UserResponseData = Get-Content $UserResponsesFile -raw|ConvertFrom-Json

# getting Environment variables data from user response json file
$AKVClientIdSecret= $UserResponseData.'satellite-azureKeyVaultClientId'
$AKVClientSecretSecret= $UserResponseData.'satellite-azureKeyVaultClientSecret'
$AKVTenantIdSecret= $UserResponseData.'satellite-azureKeyVaultTenantIdSecret'
$AutomationCoEAlertEmailRecipient= $UserResponseData.'satellite-automationCoEAlertEmailRecipient'
$AutomationProjectAppID= $UserResponseData.'satellite-automationProjectAppId'
$DesktopFlowsBaseURL= $UserResponseData.'satellite-desktopFlowsBaseUrl'
$EnvironmentId= $UserResponseData.'satellite-environmentId'
$EnvironmentName= $UserResponseData.'satellite-environmentName'
$EnvironmentRegion= $UserResponseData.'satellite-environmentRegion'
$EnvironmentUniqeName= $UserResponseData.'satellite-environmentUniqueName'
$EnvironmentUniqueNameofCoEMain= $UserResponseData.'satellite-environmentUniqueNameMain'
$EnvironmentURL= $UserResponseData.'satellite-environmentUrl'
$FlowSessionTraceRecordOwnerId= $UserResponseData.'satellite-flowSessionTraceRecordOwnerId'

# Getting Connectoin References data from user response json file
$shared_commondataserviceforapps=$UserResponseData.'satellite-dataverseConnection'
$shared_commondataservice=$UserResponseData.'satellite-dataverseLegacyConnection'
$shared_flowmanagement=$UserResponseData.'satellite-flowManagementConnection'
$shared_office365users=$UserResponseData.'satellite-office365UserConnection'
$shared_powerplatformforadmins=$UserResponseData.'satellite-powerPlatformAdminConnection'
$shared_office365=$UserResponseData.'satellite-office365OutlookConnection'

# Funciton to identify and exact connection id and returns from user response json file
function Get-ConnectionID {	
	Param
    (
        [Parameter(Mandatory = $true)] [string] $BaseURL,
        [Parameter(Mandatory = $true)] [string] $ConnectorID
    )	

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

$shared_commondataserviceforapps = Get-ConnectionID -BaseURL $shared_commondataserviceforapps -ConnectorID 'shared_commondataserviceforapps'
$shared_commondataservice = Get-ConnectionID -BaseURL $shared_commondataservice -ConnectorID 'shared_commondataservice'
$shared_flowmanagement = Get-ConnectionID -BaseURL $shared_flowmanagement -ConnectorID 'shared_flowmanagement'
$shared_office365users = Get-ConnectionID -BaseURL $shared_office365users -ConnectorID 'shared_office365users'
$shared_powerplatformforadmins = Get-ConnectionID -BaseURL $shared_powerplatformforadmins -ConnectorID 'shared_powerplatformforadmins'
$shared_office365 = Get-ConnectionID -BaseURL $shared_office365 -ConnectorID 'shared_office365'

# Updating Environment variables 
$DeploymentSettingsData.EnvironmentVariables | %{
	if($_.SchemaName.ToUpper() -eq 'autocoe_AKVClientIdSecret'.ToUpper()){$_.Value=$AKVClientIdSecret}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_AKVClientSecretSecret'.ToUpper()){$_.Value=$AKVClientSecretSecret}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_AKVTenantIdSecret'.ToUpper()){$_.Value=$AKVTenantIdSecret}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_AutomationCoEAlertEmailRecipient'.ToUpper()){$_.Value=$AutomationCoEAlertEmailRecipient}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_AutomationProjectAppID'.ToUpper()){$_.Value=$AutomationProjectAppID}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_DesktopFlowsBaseURL'.ToUpper()){$_.Value=$DesktopFlowsBaseURL}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentId'.ToUpper()){$_.Value=$EnvironmentId}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentName'.ToUpper()){$_.Value=$EnvironmentName}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentRegion'.ToUpper()){$_.Value=$EnvironmentRegion}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentUniqeName'.ToUpper()){$_.Value=$EnvironmentUniqeName}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentUniqueNameofCoEMain'.ToUpper()){$_.Value=$EnvironmentUniqueNameofCoEMain}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentURL'.ToUpper()){$_.Value=$EnvironmentURL}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_FlowSessionTraceRecordOwnerId'.ToUpper()){$_.Value=$FlowSessionTraceRecordOwnerId}
elseif($_.SchemaName.ToUpper() -eq 'autocoe_StoreExtractedScript'.ToUpper()){$_.Value=$StoreExtractedScript}
}

# Updating Connections references
$DeploymentSettingsData.ConnectionReferences | %{
	if( ($_.ConnectorId.Contains("shared_commondataserviceforapps")) -and ( $_.ConnectionId -eq '')){$_.ConnectionId=$shared_commondataserviceforapps}
	elseif($_.ConnectorId.Contains("shared_commondataservice") -and $_.ConnectionId -eq ''){$_.ConnectionId=$shared_commondataservice}
	elseif($_.ConnectorId.Contains("shared_flowmanagement") -and $_.ConnectionId -eq ''){$_.ConnectionId=$shared_flowmanagement}
	elseif($_.ConnectorId.Contains("shared_office365users") -and $_.ConnectionId -eq ''){$_.ConnectionId=$shared_office365users}
	elseif($_.ConnectorId.Contains("shared_powerplatformforadmins") -and $_.ConnectionId -eq ''){$_.ConnectionId=$shared_powerplatformforadmins}
	elseif($_.ConnectorId.Contains("shared_office365") -and $_.ConnectionId -eq ''){$_.ConnectionId=$shared_office365}
}

# Creating new deployment settings json file to parse base64 encoding
$DeploymentSettingsData | ConvertTo-Json -depth 32| set-content $UpdatedDeploymentSettingsFile
write-host "Deployment settings created / updated in respective file"

write-host performing validations for deployment settings
$ValidateDeploymentSettings= get-content $UpdatedDeploymentSettingsFile -raw|ConvertFrom-Json

$FailedFields=""

$ValidateDeploymentSettings.EnvironmentVariables | %{
	if(($_.SchemaName.ToUpper() -eq 'autocoe_AKVClientIdSecret'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}	
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_AKVClientSecretSecret'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_AKVTenantIdSecret'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_AutomationCoEAlertEmailRecipient'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_AutomationProjectAppID'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_DesktopFlowsBaseURL'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentId'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentName'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentRegion'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentUniqeName'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentUniqueNameofCoEMain'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_EnvironmentURL'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_FlowSessionTraceRecordOwnerId'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
elseif(($_.SchemaName.ToUpper() -eq 'autocoe_StoreExtractedScript'.ToUpper()) -and $_.Value -eq '' ){$FailedFields+=$_.SchemaName + ","}
}

if ($FailedFields -ne '')
{
	$FailedFields=$FailedFields.Substring(0,($FailedFields.Length)-1) 
	write-host "validation failed / empty values found for following field (s) $FailedFields. Unable to install. Please verify once."
	Break;
}

write-host "validation successfully completed."

#pac auth profile creation for satellite environment to deploy the package
write-host "Creating profile authorization for the environment"

pac auth delete -n $AutoCOE_Satellite_ProfileName

pac auth create --url $EnvironmentURL   --name $AutoCOE_Satellite_ProfileName

if ($Error -ne '')
{
	write-host "authentication profile is not created due to User canceled authentication/ not authenticated properly. Unable to continue to install. original exception is " + $Error
	Break;
}
pac auth select -n $AutoCOE_Satellite_ProfileName

if ($Error -ne '')
{
	write-host "Unable to select profile authorization for $AutoCOE_Satellite_ProfileName. Exception is " + $Error
	Break;
}

write-host "Encoding Deployment settings"

$UpdatedContentDeploymentSettings= get-content $UpdatedDeploymentSettingsFile
$Bytes = [System.Text.Encoding]::UTF8.GetBytes($UpdatedContentDeploymentSettings)
$EncodedSettings = [System.Convert]::ToBase64String($Bytes)
#$EncodedSettings | set-content .\EncodedFile_Satellite.txt
#write-host $EncodedSettings

write-host "Completed of Encoding Deployment settings"
Write-Host ========================================================
Write-Host  installing satellite soluiton with deployment settings
Write-Host ========================================================

pac package deploy --logFile .\logsForSatelliteSolution.txt -c true  --package $PackageFilePath  --settings "installsatellitesolution=true | importconfigdata=$InstallSampleData"

$LogDetails = Get-Content $LogFile

if (($LogDetails -imatch "Error") -and ($LogDetails -imatch "Some dependencies are missing")-and ($LogDetails -imatch "CreatorKitCore"))
{
	write-host""
	
$UserChoice= Read-Host -Prompt "Hey. Automation kit setup has found some dependencies to install. Do you want to install dependencies to continue? Press y/n to continue setup (y-yes and n-no):"

	$CharArray =$UserChoice.ToLower().ToCharArray()

	if ($CharArray[0] -eq "y")
	{
		write-host "Installing Creator kit package..."
		pac package deploy --logFile .\logsFor_CreatorKIT.txt -c true --package $CreatorKITPackageFilePath 
		write-host "Creator kit package installation is completed successfully and trying to install Automation kit"
		
		pac package deploy --logFile .\logsForSatelliteSolution.txt -c true  --package $PackageFilePath  --settings "installsatellitesolution=true |`importconfigdata=$InstallSampleData"

	}
	else
	{
		write-host "Current installation is failed and exiting now.You have not selected to install dependencies. Please install dependencies of creator kit First and later install this Automation kit. "
		break;
	}
}


Write-Host ========================================================
Write-Host  Performing post deployment operations
Write-Host ========================================================

# Removing of newly created profile 
pac auth delete -n $AutoCOE_Satellite_ProfileName
Write-Host  "Post deployment operations completed successfully"




 