# installing Main soluiton with deployment settings
Write-Host ========================================================
Write-Host  Getting things to ready to install Main solution
Write-Host ===========================================================

<#$UserResponsesFile = ".\*satellite*.json"
$FileExist = Test-Path -Path $UserResponsesFile  -PathType Leaf
write-host $FileExist
break;#>


$DeploymentSettingsFile = ".\AutomationCoEMain_1.0.20221102.1_managed.json"
$UserResponsesFile = ".\automation-kit-main-install.json"
$UpdatedDeploymentSettingsFile=".\DeploymentSettings_Main.json"
$StoreExtractedScript="yes"
$AutoCOE_Main_ProfileName="AutoCOE_Main_Env"
$PackageFilePath="C:\Kotesh\AppSourceFolder\Microsoft_AutomationKIT_Main_Package.zip"
$CreatorKITPackageFilePath="C:\Kotesh\AppSourceFolder\Microsoft_CreatorKITPackage.zip"
$LogFile=".\logsForMainSolution.txt"


#Variables
$AdminUsers=""
$ContributorUsers=""
$ViewerUsers=""


# Connection references
$shared_approvals=""
$shared_commondataserviceforapps=""
$shared_office365users=""
$shared_office365=""
$shared_powerplatformforadmins=""

$Error.clear()
# open json files
$DeploymentSettingsData = Get-Content $DeploymentSettingsFile -raw|ConvertFrom-Json
$UserResponseData = Get-Content $UserResponsesFile -raw|ConvertFrom-Json

$EnvironmentURL= $UserResponseData.'main-instanceUrl'
$installSampleData=$UserResponseData.'main-installSampleData'

write-host "installSampleData=$installSampleData"

#Getting EnvironmentID from Environment URL
$TempURL= $UserResponseData.'main-installEnvironment'

if ($TempURL -ne '')
{
	$ConnectorsArray = $TempURL.Split("/")
	
	foreach ($connector in $ConnectorsArray) 
	{
        if ($connector.ToLower() -eq "environments")
		{
			$EnvironmentId=$ConnectorsArray[$counter+1]
		}
		else
		{
			$counter+=1
		}		
	}
}

$TempUsers= $UserResponseData.'main-administrators'.user

$AdminUsers=""
   foreach ($TempEmail in $TempUsers) 
	{
		$AdminUsers +=$TempEmail.ToString().Trim() + ","       
	
	}
	if ($AdminUsers -ne '')
	{
	$AdminUsers=$AdminUsers.Substring(0,($AdminUsers.Length)-1)	
	}

$TempUsers= $UserResponseData.'main-contributors'.user

$ContributorUsers=""
   foreach ($TempEmail in $TempUsers) 
	{
		$ContributorUsers +=$TempEmail.ToString().Trim() + ","
        
	}
	
	if ($ContributorUsers -ne '')
	{
	$ContributorUsers=$ContributorUsers.Substring(0,($ContributorUsers.Length)-1)
	}	

$TempUsers= $UserResponseData.'main-viewers'.user

$ViewerUsers=""
   foreach ($TempEmail in $TempUsers) 
	{
		$ViewerUsers +=$TempEmail.ToString().Trim() + ","        
	}
	
	if ($ViewerUsers -ne '')
	{
	$ViewerUsers=$ViewerUsers.Substring(0,($ViewerUsers.Length)-1)	
	}

# Getting Connection References data from user response json file
$shared_approvals=$UserResponseData.'main-approvalConnection'
$shared_commondataserviceforapps=$UserResponseData.'main-dataverseConnection'
$shared_office365users=$UserResponseData.'main-offiec365UserConnection'
$shared_office365=$UserResponseData.'main-office365OutlookConnection'
$shared_powerplatformforadmins=$UserResponseData.'main-powerPlatformAdminConnection'

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
$shared_approvals = Get-ConnectionID -BaseURL $shared_approvals -ConnectorID 'shared_approvals'
$shared_commondataserviceforapps = Get-ConnectionID -BaseURL $shared_commondataserviceforapps -ConnectorID 'shared_commondataserviceforapps'
$shared_office365users = Get-ConnectionID -BaseURL $shared_office365users -ConnectorID 'shared_office365users'
$shared_office365 = Get-ConnectionID -BaseURL $shared_office365 -ConnectorID 'shared_office365'
$shared_powerplatformforadmins = Get-ConnectionID -BaseURL $shared_powerplatformforadmins -ConnectorID 'shared_powerplatformforadmins'

# Updating Connections references
$DeploymentSettingsData.ConnectionReferences | %{
		if($_.ConnectorId.Contains("shared_approvals") -and $_.ConnectionId -eq ''){$_.ConnectionId=$shared_approvals}
	elseif(($_.ConnectorId.Contains("shared_commondataserviceforapps")) -and ( $_.ConnectionId -eq '')){$_.ConnectionId=$shared_commondataserviceforapps}	
	elseif($_.ConnectorId.Contains("shared_flowmanagement") -and $_.ConnectionId -eq ''){$_.ConnectionId=$shared_flowmanagement}
	elseif($_.ConnectorId.Contains("shared_office365users") -and $_.ConnectionId -eq ''){$_.ConnectionId=$shared_office365users}	
	elseif($_.ConnectorId.Contains("shared_office365") -and $_.ConnectionId -eq ''){$_.ConnectionId=$shared_office365}
	elseif($_.ConnectorId.Contains("shared_powerplatformforadmins") -and $_.ConnectionId -eq ''){$_.ConnectionId=$shared_powerplatformforadmins}
}

# Creating new deployment settings json file to parse base64 encoding
$DeploymentSettingsData | ConvertTo-Json -depth 32| set-content $UpdatedDeploymentSettingsFile
write-host "Deployment settings created / updated in respective file"

#pac auth profile creation for Main environment to deploy the package 
write-host "Creating profile authorization for the environment"

pac auth delete -n $AutoCOE_Main_ProfileName

pac auth create --url $EnvironmentURL   --name $AutoCOE_Main_ProfileName

if ($Error -ne '')
{
	write-host "authentication profile is not created due to User canceled authentication/ not authenticated properly. Unable to continue to install. original exception is " + $Error
	Break;
}
pac auth select -n $AutoCOE_Main_ProfileName

if ($Error -ne '')
{
	write-host "Unable to select profile authorization for $AutoCOE_Main_ProfileName.Exception is " + $Error
	Break;
}



write-host "Completed profile authorization for the environment and connected to your Main environment"

write-host "Encoding Deployment settings"

$UpdatedContentDeploymentSettings= get-content $UpdatedDeploymentSettingsFile
$Bytes = [System.Text.Encoding]::UTF8.GetBytes($UpdatedContentDeploymentSettings)
$EncodedSettings = [System.Convert]::ToBase64String($Bytes)
#$EncodedSettings | set-content .\EncodedFile_Main.txt
#write-host $EncodedSettings

write-host "Completed of Encoding Deployment settings"
Write-Host ========================================================
Write-Host  installing Main soluiton with deployment settings
Write-Host ========================================================

pac package deploy --logFile $LogFile -c true  --package $PackageFilePath --settings "installmainsolution=true | enablepcf=true | importconfigdata=$InstallSampleData"
		
$LogDetails = Get-Content $LogFile
write-host $logDetails

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
		
		pac package deploy --logFile $LogFile -c true  --package $PackageFilePath --settings "installmainsolution=true |`enablepcf=true|`importconfigdata=$InstallSampleData"

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
pac auth delete -n $AutoCOE_Main_ProfileName

function Update-AssignSecurityRoles {	
	Param
    (
		[Parameter(Mandatory = $true)] [string] $EnvironmentID,
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





 