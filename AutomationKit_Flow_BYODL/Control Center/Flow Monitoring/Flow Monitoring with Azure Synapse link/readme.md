# Azure Synapse Link for Deskflow activities
Azure Synapse Link for Dataverse enables real-time analytics over Dataverse data with Azure Synapse Analytics. It provides a seamless and simplified way to analyze large volumes of data in Dataverse, without the need to extract, transform, and load (ETL) data into a separate data warehouse.

## Prerequisites
Before you can use Azure Synapse Link for Dataverse, you need to have the following:

- **Dataverse:** You must have the Dataverse system administrator security role. Additionally, tables you want to export via Synapse Link must have the Track changes property enabled. 

- **Azure Data Lake Storage Gen2:** You must have an Azure Data Lake Storage Gen2 account and Owner and Storage Blob Data Contributor role access. Your storage account must enable Hierarchical namespace and public network access for both initial setup and delta sync. Allow storage account key access is required only for the initial setup.

- **Synapse workspace:** You must have a Synapse workspace and the Synapse Administrator role access within the Synapse Studio. The Synapse workspace must be in the same region as your Azure Data Lake Storage Gen2 account with allowAll IP addresses access rule. The storage account must be added as a linked service within the Synapse Studio. 

- To create a Synapse workspace, click here **Creating a Synapse workspace** ().
- To enbale restrcited network on datalake and synapse, Use managed identities for Azure with your Azure data lake storage. [click here](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/azure-synapse-link-msi) to follow the instructions.

-Check here [How it works](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/export-to-data-lake), 
Azure Synapse Link for Dataverse uses a log-based change tracking mechanism to replicate the data from Dataverse to Azure Synapse Analytics in near real-time. This replication process is fully managed by Microsoft and does not require any ETL jobs or pipelines to be created.

# Getting Started

## How to land desktop flow data in Azure Synapse
Dataverse includes the ability to synchronize tables to Azure Data Lake Storage (ADLS) and then connect to that data through an Azure Synapse workspace. With minimal effort, you can set up Azure Synapse Link to populate Dataverse data into Azure Synapse and enable data teams to discover deeper insights.

Azure Synapse Link enables a continuous replication of the data and metadata from Dataverse into the data lake. It also provides a built-in serverless SQL pool as a convenient data source for Power BI queries.
![image](https://user-images.githubusercontent.com/29349597/232242259-599bc503-983b-4a0b-ac60-40b97b01430a.png)

## Create an Azure Synapse Link for Dataverse with your Azure Synapse Workspace

- Sign in to Power Apps and select your preferred environment.
- On the left navigation pane, select Azure Synapse Link. If the item isn’t in the left navigation pane, select …More and then select the item you want.
- On the command bar, select + New link.
- Select the Connect to your Azure Synapse workspace option.
- Select the Subscription, Resource group, Workspace name, and Storage account. Ensure that the Synapse workspace and storage account meet the requirements specified    in the Prerequisites section. Select Next.

https://user-images.githubusercontent.com/29349597/232242364-6e031cf9-7572-452d-aaeb-c3deed7556c1.mp4

# Monitoring 

## Analyze your Dataverse data using Azure Synapse
As soon as you launch your Azure Synapse workspace, you can start processing your Dataverse data with Azure Synapse to perform analytics jobs such as:
- Serverless data lake exploration: Use familiar T-SQL for ad-hoc analysis and quick insights that aren’t tied to a specific workload all without importing data.
- Data integration: Build scalable ETL pipelines to ingest, integrate, and transform data.

## Build reports using Power BI

Feed your Dataverse data to Power BI using Direct Query or Import mode via Azure Synapse Analytics connector in Get Data in Power BI. 

Reccomnedations :

- click here to find the simplified version of custom sql view which you can create in Azure synapse lake DB under a new schema to access it on Power BI, Custom view has been much simplified for better performance to load larger datasets.These view will serve as straightforward, clean sources of data that Power BI connects

- click here to ** get the custom sql view script for desktop flow activities. **

![image](https://user-images.githubusercontent.com/29349597/232244757-49b8d5ee-0e6c-458d-af8f-25ecc2b4b147.png)


