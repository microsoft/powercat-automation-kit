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

Learn more [How it works](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/export-to-data-lake).

# Connect Dataverse to Synapse workspace and export data in Delta Lake format (Preview)
#### Sign into Power Apps and select the environment

1. Open Power Apps and sign in with your credentials.
2. Select the desired environment from the available options.

#### Access Azure Synapse Link

1. On the left navigation pane, locate and select **Azure Synapse Link**. If you don't see it, click on the **...More** option and then select **Azure Synapse Link** from the menu.

#### Create a new link

1. On the command bar, click on **+ New link**.
2. In your web browser's address bar, append `?athena.deltaLake=true` to the URL that ends with `exporttodatalake`.

#### Connect to Azure Synapse Analytics workspace

1. Select **Connect to your Azure Synapse Analytics workspace**.
2. Choose the desired **Subscription**, **Resource group**, and **Workspace name**.

#### Configure Spark pool and Storage account

1. Select **Use Spark pool for processing**.
2. Choose the pre-created **Spark pool** and **Storage account** from the available options.

![image](https://github.com/microsoft/powercat-automation-kit/assets/29349597/70a11c24-c449-45db-a7ea-0d5e0b4f0a3f)

3. Once you have configured the Spark pool and Storage account, select **Next**.
4. Select "Process", "Flow Session", Flow Machine" and "Flow MachineGroup" table.
5. Select **Advanced**.Optionally, if you want to customize the incremental updates, select **Show advanced configuration settings**.
6. Enter the desired time interval, in minutes, for capturing the incremental updates. Select **Save**.

#### Congratulations, now you have completed setup of synapse link in your dataverse envrionment

As a last step, you need to configure "[Desktop flow activities monitoring](../003-%20Power%20BI%20Dashboard%20Setup/readme.md)"
