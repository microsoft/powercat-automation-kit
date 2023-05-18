# Azure Synapse Link for Deskflow activities

Azure Synapse Link for Dataverse enables real-time analytics over Dataverse data with Azure Synapse Analytics. It provides a seamless and simplified way to analyze large volumes of data in Dataverse, without the need to extract, transform, and load (ETL) data into a separate data warehouse.

## Prerequisites
Before you can use Azure Synapse Link for Dataverse, you need to have the following:

| Service                   | Requirements                                                                                                                                                                                                                      |
|---------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Dataverse                 | *Must have the Dataverse system administrator security role.<br>* Tables you want to export via Synapse Link must have the Track changes property enabled.                                                                            |
| Azure Data Lake Storage Gen2 | *Must have an Azure Data Lake Storage Gen2 account.<br>* Must have Owner and Storage Blob Data Contributor role access.<br>* Storage account must enable Hierarchical namespace.<br>* Allow storage account key access is required only for the initial setup. |
| Synapse workspace         | *Must have a Synapse workspace.<br>* Must have the Synapse Administrator role access within the Synapse Studio.<br>* The Synapse workspace must be in the same region as your Azure Data Lake Storage Gen2 account.<br>* The storage account must be added as a linked service within the Synapse Studio. |

## Getting Started
- Sign in to Power Apps and select your preferred environment.
- On the left navigation pane, **select Azure Synapse Link**. If the item isn’t in the left navigation pane, **select …More** and then select the item you want.
- On the command bar, **select + New link**.
- Select the Connect to your Azure Synapse workspace option.
- Select the Subscription, Resource group, Workspace name, and Storage account. Ensure that the Synapse workspace and storage account meet the requirements specified in the Prerequisites section. Select Next.
- Select "Process", "Flow Session", Flow Machine" and "Flow MachineGroup" table and Save.

**To enable restricted network on datalake and synapse, Use managed identities for Azure with your Azure data lake storage**
 - Select Select Enterprise Policy with Managed Service Identity, and then select Next.

https://github.com/microsoft/powercat-automation-kit/assets/29349597/cd7445fe-7446-4b9f-bae3-ab0dc0048cbc


Leran more [How it works](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/export-to-data-lake).



#### Congratulations, now you have completed setup of synapse link in your dataverse envrionment

As a last step, you need to configure "[Desktop flow activities monitoring](../003-%20Power%20BI%20Dashboard%20Setup/readme.md)"
