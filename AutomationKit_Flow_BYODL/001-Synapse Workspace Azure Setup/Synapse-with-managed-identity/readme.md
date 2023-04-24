# Use managed identities for Azure with your Azure data lake storage
Azure Data Lake Storage provides layered security, including the ability to limit access based on networks or resources. Managed identities for Azure help manage secrets and access to storage accounts, restricting requests to those originating from a specific Dataverse environment. This ensures secure, trusted access to your storage account, with managed identities used to sign context information and establish trust.

# Getting strated

- Create enterprise policy &rarr; [Click here](https://github.com/microsoft/powercat-automation-kit/blob/Flow-byodl/AutomationKit_Flow_BYODL/Control%20Center/Flow%20Monitoring/Flow%20Monitoring%20with%20Azure%20Synapse%20link/Synapse-with-managed-identity-azure-template/CreateIdentityEnterprisePolicy.ps1) 
- Grant reader access to the enterprise policy 
  - Obtain the Power Platform admin user’s ObjectID. Replace "user@example.com" with the actual user's email address. Run below command in CLI or PowerShell to get the objectid.
  ```
      Connect-AzAccount
      $user = Get-AzADUser -UserPrincipalName user@example.com
      $userId = $user.Id
      Write-Host "User ObjectID: $userId"

 - Obtain the enterprise policies ID:
    - Go to the Azure Resource Graph Explorer.
    - Run this query: resources | where type == 'microsoft.powerplatform/enterprisepolicies' Run query from Azure Resource Graph Explorer
    - Scroll to the right of the results page and select the See details link.
    - On the Details page, copy the ID.
- Open Azure CLI and run the following command, replacing the <objId> with the user’s ObjectID and the <EP Resource Id> with the enterprise policy ID.


New-AzRoleAssignment -ObjectId <objId> -RoleDefinitionName Reader -Scope <EP Resource Id>

- Connect enterprise policy to Dataverse environment
  - Obtain the Dataverse environment ID.
  - Sign into the Power Platform admin center.Select Environments, and then open your environment. In the Details section, copy the Environment ID.
  - To link to the Dataverse environment, run this PowerShell script: ./ NewIdentity.ps1 [click here](https://github.com/microsoft/powercat-automation-kit/blob/Flow-byodl/AutomationKit_Flow_BYODL/Control%20Center/Flow%20Monitoring/Flow%20Monitoring%20with%20Azure%20Synapse%20link/Synapse-with-managed-identity-azure-template/NewIdentity.ps1)
  
<img src="https://user-images.githubusercontent.com/29349597/232248283-27c05d8e-4553-4771-800f-60754f3a2317.png" width="500" />

### Configure network access to the Azure Data Lake Storage Gen2

- Open the storage account connected to your Azure Synapse Link for Dataverse profile.
- On the left navigation pane, select Networking. Then, on the Firewalls and virtual networks tab select the following settings:
- Enabled from selected virtual networks and IP addresses.
- Under Resource instances, select Allow Azure services on the trusted services list to access this storage account
- Select Save.

<img src="https://user-images.githubusercontent.com/29349597/232248314-a6e3a007-c76c-420e-8eef-aaa65de924f6.png" width="500" />

### Configure network access to the Azure Synapse Workspace
- Open the Azure Synapse workspace connected to your Azure Synapse Link for Dataverse profile.
 - On the left navigation pane, select Networking.
    - Enable Public network access to workspace endpoints
    - Select Allow all azure services and resources to access this workspace.
    - If there is a IP firewall rules created for all IP range, delete them.
    - Add a new IP firewall rule, give it a name, Start IP, and End IP.
    - Select Save when done. For more information: Azure Synapse Analytics IP firewall rules

<img src="https://user-images.githubusercontent.com/29349597/232248437-4d7b95e0-85c0-4c99-ba70-3f80c43ccfe4.png" width="500" />

### Or while creating a new Synapse workspace 
<img src="https://user-images.githubusercontent.com/29349597/232248435-fdeb4a21-462f-4256-8ab9-37e24618a693.png" width="500" />



