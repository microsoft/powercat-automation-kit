# Deploy Azure Synapse Workspace in Your Azure Environment

## Pre-requisites to Deploy Synapse

- You must have an active azure subscription

## Deployment Steps

Please follow the below steps to successfully deploy a Synapse workspace and its artifacts on your Azure subscription

 [![Deploy To Azure](../Images/deploytoazure.svg?sanitize=true)](https://portal.azure.com/#create/Microsoft.Synapse) 

 ### Optional Restricted Network Setup

[Click here](./Synapse-with-managed-identity/readme.md) to follow the instructions to enable restricted network on Datalake and synapse, **Use managed identities for Azure with your Azure data lake storage**.

### Optional Delta Lake Deployment (Preview)

In case the need is to have voluminous data in Delta Lake then follow steps to create Synapse with Spark-Pool.

###     [![Deploy To Azure](../Images/deploytoazure.svg?sanitize=true)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fmicrosoft%2Fpowercat-automation-kit%2FFlow-byodl-Patch%2FAutomationKit_Flow_BYODL%2FARMTemplate%2Fazuredeploy.json)

**Provide the values for:**
- Region: [region_value]
- Allow All Connections: [true/false]
- Storage Account Name: [storage_account_name]
- Storage Container Name: [storage_container_name]
- Workspace Name: [workspace_name]
- Managed Resource Group Name: [managed_resource_group_name]
- Spark Pool Name: [spark_pool_name] (Optional)
- Sql Administrator Login: [sql_administrator_login]
- Sql Administrator Login Password: [sql_administrator_login_password]
### Azure Services being deployed
This template deploys necessary resources to run an Azure Synapse workspace. Following resources are deployed with this template along with some RBAC role assignments:

- An Azure Synapse Workspace
- Built-in serverless SQL Pool
- An optional Apache Spark Pool 
- Azure Data Lake Storage Gen2 account
- A new File System inside the Storage Account to be used by Azure Synapse

#### Recommended Spark Pool configuration
This configuration can be considered a bootstrap step for average use cases.

- Node size: small (4 vCores / 32 GB)
- Autoscale: Enabled
- Number of nodes: 5 to 10
- Automatic pausing: Enabled
- Number of minutes idle: 5
- Apache Spark: 3.1

For more information [click here](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/azure-synapse-link-delta-lake)

**Costs**

To estimate the average cost of your setup, you can utilize the Azure Cost Calculator available at the following URL: [Azure Cost Calculator](https://azure.microsoft.com/en-in/pricing/calculator/). By accessing the Azure Cost Calculator, you can input your specific setup details and receive an estimate of the associated costs.
### DataVerse Synapse link with Delta Lake Architecture. 
<img src="https://github.com/microsoft/powercat-automation-kit/assets/29349597/dd42eaab-2cc4-4671-85d3-2d4146823c30" width="1000"/>

### Congratulations, Now you have completed setup of synapse workspace!

As a next step, you need to setup [Synapse link in your Power Apps Environment](../002-%20Synapse%20link%20Setup/readme.md).
