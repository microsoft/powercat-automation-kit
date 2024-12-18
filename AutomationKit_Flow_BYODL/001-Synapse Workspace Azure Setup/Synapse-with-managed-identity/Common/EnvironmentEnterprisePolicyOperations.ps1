﻿# Load the environment script
. "$PSScriptRoot\EnvironmentOperations.ps1"

# Load the environment script
. "$PSScriptRoot\EnterprisePolicyOperations.ps1"

function Login($endpoint) {

    $logIn = $false

    # Login - only needs to be run once per session
    if ($null -eq $global:currentSession.userId) {
        $logIn = $true
    }

    if (($null -eq $global:currentSession.expiresOn) -or (get-date $global:currentSession.expiresOn) -lt (Get-Date)) {
        $logIn = $true
    }

    $envSearch = $env + "*"

    if ($global:currentSession.bapEndpoint -notlike $envSearch) {
        $logIn = $true
    }

    if ($logIn) {
        $result = Add-PowerAppsAccount -Endpoint $endpoint
        echo $result
    }

    $connect = Connect-AzAccount

    if ($null -eq $connect)
    {
        Write-Host "Error connecting to Azure Account `n" -ForegroundColor Red
        return $false
    }
    return $true
}

function LinkPolicyToEnv 
{
    param(
        [Parameter(Mandatory=$true)]
        [ValidateSet("cmk","vnet", "identity")]
        [ValidateNotNullOrEmpty()]
        [String]$policyType,

        [Parameter(Mandatory=$true)]
        [ValidateNotNullOrEmpty()]
        [String]$environmentId,

        [Parameter(Mandatory=$true)]
        [ValidateNotNullOrEmpty()]
        [String]$policyArmId,

        [Parameter(Mandatory=$false)]
        [ValidateSet("tip1", "tip2", "prod")]
        [String]$endpoint

    )

    if (![bool]$endpoint) {
        $endpoint = "prod"
    }

    Write-Host "Logging In..." -ForegroundColor Green
    $connect = Login $endpoint
    if ($false -eq $connect)
    {
        return
    }

    Write-Host "Logged In..." -ForegroundColor Green

    #Validate Environment
    $env = GetEnvironment $environmentId

    if ($env -eq $null) 
    {
        return
    }
    Write-Host "Environment reterieved `n" -ForegroundColor Green

    #Validate Enterprise Policy
    $policySystemId = GetEnterprisePolicySystemId $policyArmId
    if ($null -eq $policySystemId)
    {
        return
    }
    Write-Host "Enterprise Policy reterieved `n" -ForegroundColor Green


    $linkResult = LinkEnterprisePolicy $env $policyType $policySystemId

    $linkResultString = $linkResult | ConvertTo-Json

    if ($null -eq $linkResult -or $linkResult.StatusCode -ne "202")
    {
        Write-Host "Linking of $policyType policy did not start for environement $environmentId"
        Write-Host "Error: $linkResultString"
        return 
    }

    # Not do polling for identity ep linking since its not a long running operation
    if ($policyType -eq "identity")
    {
        Write-Host "Start linking of identity enterprise policy, Reponse received from link request: $linkResultString"
        return 
    }

    Write-Host "Linking of $policyType policy started for environement $environmentId"
    $Headers = $linkResult.Headers

    Write-Host "Do you want to poll the linking operation (y/n)"
    $poll = Read-Host

    if ("n" -eq $poll)
    {
        return
    }

    # Poll the operation every retry-after seconds
    $operationLocation = $headers.'operation-location'
    $retryAfter = $headers.'Retry-After'
    Write-Host "Polling the link operation every $retryAfter seconds."

    PollLinkUnlinkOperation $operationLocation $retryAfter
}

function UnLinkPolicyFromEnv 
{
    param(
        [Parameter(Mandatory=$true)]
        [ValidateSet("cmk","vnet", "identity")]
        [ValidateNotNullOrEmpty()]
        [String]$policyType,

        [Parameter(Mandatory=$true)]
        [ValidateNotNullOrEmpty()]
        [String]$environmentId,

        [Parameter(Mandatory=$true)]
        [ValidateNotNullOrEmpty()]
        [String]$policyArmId,

        [Parameter(Mandatory=$false)]
        [ValidateSet("tip1", "tip2", "prod")]
        [String]$endpoint

    )

    if (![bool]$endpoint) {
        $endpoint = "prod"
    }

    Write-Host "Logging In..." -ForegroundColor Green
    $connect = Login $endpoint
    if ($false -eq $connect)
    {
        return
    }

    Write-Host "Logged In..." -ForegroundColor Green

    #Validate Environment
    $env = GetEnvironment $environmentId

    if ($env -eq $null) 
    {
        return
    }
    Write-Host "Environment reterieved `n" -ForegroundColor Green

    $epPropertyName = switch ( $policyType )
    {
        "cmk" { "CustomerManagedKeys" }
        "vnet" { "VNets" }
        "identity" { "Identity" }
    }
    
    if ($null -eq $env.properties.enterprisePolicies -or $null -eq $env.properties.enterprisePolicies.$epPropertyName)
    {
        Write-Host "No enterprise policy present to remove for environement $environmentId"
        return
    }

    if (!$policyArmId.Equals($env.properties.enterprisePolicies.$epPropertyName.id))
    {
        Write-Host "Given policyArmId $policyArmId not matching with $policyType policy ArmId for environement $environmentId"
        return 
    }


    #Validate Enterprise Policy
    $policySystemId = GetEnterprisePolicySystemId $policyArmId
    if ($null -eq $policySystemId)
    {
        return
    }
    Write-Host "Enterprise Policy reterieved `n" -ForegroundColor Green


    $unLinkResult = UnLinkEnterprisePolicy $env $policyType $policySystemId

    $unLinkResultString = $UnLinkResult | ConvertTo-Json

    if ($null -eq $unLinkResult -or $unLinkResult.StatusCode -ne "202")
    {
        Write-Host "Unlinking of $policyType policy did not start for environement $environmentId"
        Write-Host "Error: $unLinkResultString"
        return 
    }

    # Not do polling for identity ep unlinking since its not a long running operation
    if ($policyType -eq "identity")
    {
        Write-Host "Start unlinking of identity enterprise policy, Reponse received from link request: $unLinkResultString"
        return 
    }

    Write-Host "Unlinking of $policyType policy started for environement $environmentId"
    $headers = $unlinkResult.Headers

    Write-Host "Do you want to poll the unlink operation (y/n)"
    $poll = Read-Host

    if ("n" -eq $poll)
    {
        return
    }

    # Poll the operation every retry-after seconds
    $operationLocation = $headers.'operation-location'
    $retryAfter = $headers.'Retry-After'
    Write-Host "Polling the unlink operation every $retryAfter seconds."

    PollLinkUnlinkOperation $operationLocation $retryAfter
    
}

function SwapPolicyForEnv 
{
    param(
        [Parameter(Mandatory=$true)]
        [ValidateSet("cmk","vnet", "identity")]
        [ValidateNotNullOrEmpty()]
        [String]$policyType,

        [Parameter(Mandatory=$true)]
        [ValidateNotNullOrEmpty()]
        [String]$environmentId,

        [Parameter(Mandatory=$true)]
        [ValidateNotNullOrEmpty()]
        [String]$policyArmId,

        [Parameter(Mandatory=$false)]
        [ValidateSet("tip1", "tip2", "prod")]
        [String]$endpoint

    )

    if (![bool]$endpoint) {
        $endpoint = "prod"
    }

    Write-Host "Logging In..." -ForegroundColor Green
    $connect = Login $endpoint
    if ($false -eq $connect)
    {
        return
    }

    Write-Host "Logged In..." -ForegroundColor Green

    #Validate Environment
    $env = GetEnvironment $environmentId

    if ($env -eq $null) 
    {
        return
    }
    Write-Host "Environment reterieved `n" -ForegroundColor Green

    $epPropertyName = switch ( $policyType )
    {
        "cmk" { "CustomerManagedKeys" }
        "vnet" { "VNets" }
        "identity" { "Identity" }
    }
    
    if ($null -eq $env.properties.enterprisePolicies -or $null -eq $env.properties.enterprisePolicies.$epPropertyName)
    {
        Write-Host "No enterprise policy of $policyType present to swap for environement $environmentId"
        return
    }

    #Validate Enterprise Policy
    $policySystemId = GetEnterprisePolicySystemId $policyArmId
    if ($null -eq $policySystemId)
    {
        return
    }
    Write-Host "Enterprise Policy reterieved `n" -ForegroundColor Green


    $swapResult = LinkEnterprisePolicy $env $policyType $policySystemId

    $swapResultString = $swapResult | ConvertTo-Json

    if ($null -eq $swapResult -or $swapResult.StatusCode -ne "202")
    {
        Write-Host "Swapping of $policyType policy did not start for environement $environmentId"
        Write-Host "Error: $swapResultString"
        return 
    }

    # Not do polling for identity ep swapping since its not a long running operation
    if ($policyType -eq "identity")
    {
        Write-Host "Start swapping of identity enterprise policy, Reponse received from link request: $swapResultString"
        return 
    }

    Write-Host "Swapping of $policyType policy started for environement $environmentId"
    $headers = $swapResult.Headers

    Write-Host "Do you want to poll the swapping operation (y/n)"
    $poll = Read-Host

    if ("n" -eq $poll)
    {
        return
    }

    # Poll the operation every retry-after seconds
    $operationLocation = $headers.'operation-location'
    $retryAfter = $headers.'Retry-After'
    Write-Host "Polling the swap operation every $retryAfter seconds."

    PollLinkUnlinkOperation $operationLocation $retryAfter
    
}


function GetEnterprisePolicyForEnvironment 
{
    param(
        [Parameter(Mandatory=$true)]
        [ValidateSet("cmk","vnet", "identity")]
        [ValidateNotNullOrEmpty()]
        [String]$policyType,

        [Parameter(Mandatory=$true)]
        [ValidateNotNullOrEmpty()]
        [String]$environmentId,

        [Parameter(Mandatory=$false)]
        [ValidateSet("tip1", "tip2", "prod")]
        [String]$endpoint

    )

    if (![bool]$endpoint) {
        $endpoint = "prod"
    }

    Write-Host "Logging In..." -ForegroundColor Green
    $connect = Login $endpoint
    if ($false -eq $connect)
    {
        return
    }

    Write-Host "Logged In..." -ForegroundColor Green

    #Validate Environment
    $env = GetEnvironment $environmentId

    if ($env -eq $null) 
    {
        return
    }
    Write-Host "Environment reterieved `n" -ForegroundColor Green

    $epPropertyName = switch ( $policyType )
    {
        "cmk" { "CustomerManagedKeys" }
        "vnet" { "VNets" }
        "identity" {"Identity"}
    }
    
    if ($null -eq $env.properties.enterprisePolicies -or $null -eq $env.properties.enterprisePolicies.$epPropertyName)
    {
        Write-Host "No enterprise policy present of $policyType in environement $environmentId"
        return
    }

    Write-Host "Enterprise Policy of type $policyType reterived for environment $environmentId `n" -ForegroundColor Green
    $policyArmId = $env.properties.enterprisePolicies.$epPropertyName.id
    Write-Host "Enterprise Policy Arm Id $policyArmId"
}




