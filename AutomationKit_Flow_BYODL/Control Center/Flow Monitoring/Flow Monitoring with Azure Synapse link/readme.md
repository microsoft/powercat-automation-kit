# Azure Synapse Link for Deskflow activities
Azure Synapse Link for Dataverse enables real-time analytics over Dataverse data with Azure Synapse Analytics. It provides a seamless and simplified way to analyze large volumes of data in Dataverse, without the need to extract, transform, and load (ETL) data into a separate data warehouse.

## Prerequisites
Before you can use Azure Synapse Link for Dataverse, you need to have the following:

- **Dataverse:** You must have the Dataverse system administrator security role. Additionally, tables you want to export via Synapse Link must have the Track changes property enabled. 

- **Azure Data Lake Storage Gen2:** You must have an Azure Data Lake Storage Gen2 account and Owner and Storage Blob Data Contributor role access. Your storage account must enable Hierarchical namespace and public network access for both initial setup and delta sync. Allow storage account key access is required only for the initial setup.

- **Synapse workspace:** You must have a Synapse workspace and the Synapse Administrator role access within the Synapse Studio. The Synapse workspace must be in the same region as your Azure Data Lake Storage Gen2 account with allowAll IP addresses access rule. The storage account must be added as a linked service within the Synapse Studio. 
- :memo: **Note:** To create a Synapse workspace without Managed Identity, click on ["Deploy to Azure"](https://portal.azure.com/#create/Microsoft.Synapse).

Check here [How it works](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/export-to-data-lake), 
Azure Synapse Link for Dataverse uses a log-based change tracking mechanism to replicate the data from Dataverse to Azure Synapse Analytics in near real-time. This replication process is fully managed by Microsoft and does not require any ETL jobs or pipelines to be created.

# Getting Started

