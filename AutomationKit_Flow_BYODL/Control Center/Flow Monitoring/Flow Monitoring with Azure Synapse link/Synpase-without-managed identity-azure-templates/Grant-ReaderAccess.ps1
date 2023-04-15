function Grant-ReaderAccessToEnterprisePolicy {
    param(
        [Parameter(Mandatory = $true)]
        [string]$SubscriptionId,
        [Parameter(Mandatory = $true)]
        [string]$ResourceGroup,
        [Parameter(Mandatory = $true)]
        [string]$EnterprisePolicyName
    )

    # Authenticate with Azure
    Connect-AzAccount

    # Get the enterprise policy
    $EnterprisePolicy = Get-AzPolicy -SubscriptionId $SubscriptionId -Name $EnterprisePolicyName -ResourceGroupName $ResourceGroup

    # Add the reader role to the enterprise policy
    $RoleAssignmentId = (New-AzRoleAssignment -ObjectId (Get-AzADServicePrincipal -DisplayName "Reader").Id -RoleDefinitionName "Reader" -Scope $EnterprisePolicy.ResourceId).Id

    # Output the role assignment ID
    Write-Output "Reader role assigned to enterprise policy with ID $RoleAssignmentId"
}
Grant-ReaderAccessToEnterprisePolicy