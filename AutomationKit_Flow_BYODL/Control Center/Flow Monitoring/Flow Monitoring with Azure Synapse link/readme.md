# Azure Synapse Link for Deskflow activities
Azure Synapse Link for Dataverse enables real-time analytics over Dataverse data with Azure Synapse Analytics. It provides a seamless and simplified way to analyze large volumes of data in Dataverse, without the need to extract, transform, and load (ETL) data into a separate data warehouse.

## Prerequisites
Before you can use Azure Synapse Link for Dataverse, you need to have the following:

| Service                   | Requirements                                                                                                                                                                                                                      |
|---------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Dataverse                 | *Must have the Dataverse system administrator security role.<br>* Tables you want to export via Synapse Link must have the Track changes property enabled.                                                                            |
| Azure Data Lake Storage Gen2 | *Must have an Azure Data Lake Storage Gen2 account.<br>* Must have Owner and Storage Blob Data Contributor role access.<br>* Storage account must enable Hierarchical namespace.<br>* Allow storage account key access is required only for the initial setup. |
| Synapse workspace         | *Must have a Synapse workspace.<br>* Must have the Synapse Administrator role access within the Synapse Studio.<br>* The Synapse workspace must be in the same region as your Azure Data Lake Storage Gen2 account.<br>* The storage account must be added as a linked service within the Synapse Studio. |



# Getting Started

## Land desktop flow data in Azure Synapse
Dataverse includes the ability to synchronize tables to Azure Data Lake Storage (ADLS) and then connect to that data through an Azure Synapse workspace. With minimal effort, you can set up Azure Synapse Link to populate Dataverse data into Azure Synapse and enable data teams to discover deeper insights.

Azure Synapse Link enables a continuous replication of the data and metadata from Dataverse into the data lake. It also provides a built-in serverless SQL pool as a convenient data source for Power BI queries.

<img src="https://user-images.githubusercontent.com/29349597/232242259-599bc503-983b-4a0b-ac60-40b97b01430a.png" width="500"/>

## Create an Azure Synapse Link for Dataverse with your Azure Synapse Workspace
- **To create a Synapse workspace,** [click here](https://portal.azure.com/#create/Microsoft.Synapse).

- Sign in to Power Apps and select your preferred environment.
- On the left navigation pane, **select Azure Synapse Link**. If the item isn’t in the left navigation pane, **select …More** and then select the item you want.
- On the command bar, **select + New link**.
- Select the Connect to your Azure Synapse workspace option.
- Select the Subscription, Resource group, Workspace name, and Storage account. Ensure that the Synapse workspace and storage account meet the requirements specified    in the Prerequisites section. Select Next.

- **To enbale restrcited network on datalake and synapse, Use managed identities for Azure with your Azure data lake storage.** [click here](https://github.com/microsoft/powercat-automation-kit/blob/Flow-byodl/AutomationKit_Flow_BYODL/Control%20Center/Flow%20Monitoring/Flow%20Monitoring%20with%20Azure%20Synapse%20link/Synapse-with-managed-identity-azure-template/readme.md) to follow the instructions.

     * When you create the link, Azure Synapse Link for Dataverse gets details about the currently linked enterprise policy under the Dataverse environment then caches the identity client secret URL to connect to Azure.

        - Sign into Power Apps and select your environment.
        - In your web browsers address bar, **append ?athena.managedIdentity=true to the web address that ends with exporttodatalake**.
        - On the left navigation pane, select Azure Synapse Link, and then select + New link. If the item isn’t in the left navigation pane, select …More and then select the item you want.
       - Select Select Enterprise Policy with Managed Service Identity, and then select Next.
       - Add the tables you want to export, and then select Save.

- Check here [How it works](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/export-to-data-lake), 

https://user-images.githubusercontent.com/29349597/232242364-6e031cf9-7572-452d-aaeb-c3deed7556c1.mp4

# Monitoring 

## Analyze your Dataverse data using Azure Synapse
As soon as you launch your Azure Synapse workspace, you can start processing your Dataverse data with Azure Synapse to perform analytics jobs such as:
- Serverless data lake exploration: Use familiar T-SQL for ad-hoc analysis and quick insights that aren’t tied to a specific workload all without importing data.
- Data integration: Build scalable ETL pipelines to ingest, integrate, and transform data.

## Build reports using Power BI

Feed your Dataverse data to Power BI using Direct Query or Import mode via Azure Synapse Analytics connector in Get Data in Power BI. 

**Reccomnedations :**

- [Click here](https://github.com/microsoft/powercat-automation-kit/blob/c192589e5dd795ab5ff66ac2f8d8b9304d55ddfb/AutomationKit_Flow_BYODL/Control%20Center/Flow%20Monitoring/Power%20BI/Scripts/flowsessionview.sql) to find the simplified version of custom sql view which you can create in Azure synapse lake DB under a new schema to access it on Power BI, Custom view has been much simplified for better performance to load larger datasets. This view will serve as straightforward, clean sources of data that Power BI connects.

<img src="https://user-images.githubusercontent.com/29349597/232245432-930bc4bc-a895-4b35-8ad9-d39a2b7c87a0.png" width="500"/>

Toc onnect Synapse with Power BI use the Serverless SQL endpoint and start reporting on your Dataverse data using Power BI. 
<img src="https://user-images.githubusercontent.com/29349597/232245861-35c52a34-a89a-46c1-89bf-4bc415498505.png" width="500" />

Grab the Serverless SQL endpoint by going to Azure portal and navigating to your Azure Synapse Analytics workspace.

<img src="https://user-images.githubusercontent.com/29349597/232245894-dc109c1d-af37-4ff6-b75b-1e72833bc7d6.png" width="500" />



Follow the Power BI best practices and guideance for Power platform [here](https://learn.microsoft.com/en-us/power-bi/guidance/powerbi-modeling-guidance-for-power-platform) 
