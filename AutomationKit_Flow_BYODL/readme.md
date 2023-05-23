# Desktop Flow Monitoring using Azure Synapse link

This repository provides one-click infrastructure and artifact deployment for Azure Synapse Analytics to get you started with Big Data Analytics on a large sized Desktop flow data. You will learn how to ingest, process, and serve large volumes of data using various components of Synapse.

# Decision tree for Desktop Flow monitoing
When it comes to decision-making regarding desktop flow monitoring based on large volume data, there are a few factors to consider. One option is to choose the "Synapse Link" feature, while the alternative is to use the in-product "Desktop Flow monitoring" available in make.powerautomate.com. The decision can be guided by certain considerations, such as the organization's need to meet restricted network requirements and the associated costs of Azure resources.

| Option | Pros | Cons |
|--------|------|------|
| Synapse Link | - Real-time analytics <br>- Scalability <br>- Advanced analytics capabilities | - Cost considerations <br>- Learning curve |
| In-product "Desktop Flow monitoring" in make.powerautomate.com | - Integration with Power Automate <br>- Ease of use <br>- Cost considerations | - Potential limitations |
| Additional Considerations | - Restricted network compatibility <br>- Enhanced security with Enterprise policy and MSI | - Associated costs <br>- Resource management considerations |

<img src="https://github.com/microsoft/powercat-automation-kit/assets/29349597/07a8b954-73fb-4251-8352-d24ecb50eb64" width="1000" />

It is essential to carefully weigh the advantages, disadvantages, costs, and specific requirements of the organization when making a decision. Organizations should also consider consulting with Azure experts or IT professionals to evaluate the best fit for their specific use case.

## Reference Architecture

Dataverse includes the ability to synchronize tables to Azure Data Lake Storage (ADLS) and then connect to that data through an Azure Synapse workspace. With minimal effort, you can set up Azure Synapse Link to populate Dataverse data into Azure Synapse and enable data teams to discover deeper insights.

Azure Synapse Link enables a continuous replication of the data and metadata from Dataverse into the data lake. It also provides a built-in serverless SQL pool as a convenient data source for Power BI queries.

![image](https://github.com/microsoft/powercat-automation-kit/assets/29349597/8cd5df95-872d-44e0-8387-0a57756d97fb)


![image](https://github.com/microsoft/powercat-automation-kit/assets/29349597/0a7ac4fb-091d-4ef1-93ec-cf4ef0e924da)

## Contents

- [001- Setup Azure Synapse workspace](./001-Synapse%20Workspace%20Azure%20Setup/readme.md)
- [002- Setup Synapse link in Power Apps](https://github.com/microsoft/powercat-automation-kit/blob/Flow-byodl/AutomationKit_Flow_BYODL/002-%20Synapse%20link%20Setup/readme.md)
- [003- Setup Power BI Dashboard](https://github.com/microsoft/powercat-automation-kit/blob/Flow-byodl/AutomationKit_Flow_BYODL/003-%20Power%20BI%20Dashboard%20Setup/readme.md)
