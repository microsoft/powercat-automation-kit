# Use managed identities for Azure with your Azure data lake storage
Azure Data Lake Storage provides a layered security model. This model enables you to secure and control the level of access to your storage accounts that your applications and enterprise environments demand, based on the type and subset of networks or resources used. When network rules are configured, only applications requesting data over the specified set of networks or through the specified set of Azure resources can access a storage account. You can limit access to your storage account to requests originating from specified IP addresses, IP ranges, subnets in an Azure Virtual Network (VNet), or resource instances of some Azure services.
Managed identities for Azure, formerly know as Managed Service Identity (MSI), help with the management of secrets. Microsoft Dataverse customers using Azure capabilities create a managed identity (part of enterprise policy creation) that can be used for one or more Dataverse environments. This managed identity that will be provisioned in your tenant is then used by Dataverse to access your Azure data lake.

With managed identities, access to your storage account is restricted to requests originating from the Dataverse environment associated with your tenant. When Dataverse connects to storage on behalf of you, it includes additional context information to prove that the request originates from a secure, trusted environment. This allows storage to grant Dataverse access to your storage account. Managed identities are used to sign the context information in order to establish trust.

# Getting strated

## Create enterprise policy

- Click here to run the powershell script

## Grant reader access to the enterprise policy
- Click here to run the powershell script

## Connect enterprise policy to Dataverse environment
- Obtain the Dataverse environment ID.
- Sign into the Power Platform admin center.Select Environments, and then open your environment. In the Details section, copy the Environment ID.
- To link to the Dataverse environment, run this PowerShell script: ./ NewIdentity.ps1
![image](https://user-images.githubusercontent.com/29349597/232248283-27c05d8e-4553-4771-800f-60754f3a2317.png)

## Configure network access to the Azure Data Lake Storage Gen2

- Open the storage account connected to your Azure Synapse Link for Dataverse profile.
- On the left navigation pane, select Networking. Then, on the Firewalls and virtual networks tab select the following settings:
- Enabled from selected virtual networks and IP addresses.
- Under Resource instances, select Allow Azure services on the trusted services list to access this storage account
- Select Save.
![image](https://user-images.githubusercontent.com/29349597/232248314-a6e3a007-c76c-420e-8eef-aaa65de924f6.png)

## Configure network access to the Azure Synapse Workspace
Open the Azure Synapse workspace connected to your Azure Synapse Link for Dataverse profile.

On the left navigation pane, select Networking.

Enable Public network access to workspace endpoints
Select Allow all azure services and resources to access this workspace.
If there is a IP firewall rules created for all IP range, delete them.
Add a new IP firewall rule, give it a name, Start IP, and End IP.
Select Save when done. For more information: Azure Synapse Analytics IP firewall rules
![image](https://user-images.githubusercontent.com/29349597/232248437-4d7b95e0-85c0-4c99-ba70-3f80c43ccfe4.png)

Or while creating a new Synapse workspace 
![image](https://user-images.githubusercontent.com/29349597/232248435-fdeb4a21-462f-4256-8ab9-37e24618a693.png)

