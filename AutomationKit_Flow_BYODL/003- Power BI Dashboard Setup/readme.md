## How to use Power BI report

- Downlaod the [Power BI report](https://github.com/microsoft/powercat-automation-kit/blob/Flow-byodl/AutomationKit_Flow_BYODL/003-%20Power%20BI%20Dashboard%20Setup/Automation-kit-desktopflow-activity.pbix).

<img src="https://user-images.githubusercontent.com/29349597/233945148-e2697341-40d5-4678-964e-7e3bf48c8531.png" width="800" />

Feed your Dataverse data to Power BI using Direct Query or Import mode via Azure Synapse Analytics connector in Get Data in Power BI. 

To connect Synapse with Power BI use the Serverless SQL endpoint and start reporting on your Dataverse data using Power BI. 
<img src="https://user-images.githubusercontent.com/29349597/232245861-35c52a34-a89a-46c1-89bf-4bc415498505.png" width="800" />

Grab the Serverless SQL endpoint by going to Azure portal and navigating to your Azure Synapse Analytics workspace.

<img src="https://user-images.githubusercontent.com/29349597/232245894-dc109c1d-af37-4ff6-b75b-1e72833bc7d6.png" width="800" />


Follow the Power BI best practices and guideance for Power platform [here](https://learn.microsoft.com/en-us/power-bi/guidance/powerbi-modeling-guidance-for-power-platform) 


## Best Practices for Large datasets: [Learn more](https://learn.microsoft.com/en-us/power-bi/guidance/powerbi-modeling-guidance-for-power-platform)

#### Use import mode with regular/nightly refreshes in Power BI instead of relying on DirectQuery

To improve performance and avoid potential issues with DirectQuery, consider using import mode with regular or nightly refreshes in Power BI. Additionally, Synapse Link Delta Lake will be announced for public preview in the coming weeks, which should offer higher performance for very large datasets.

#### Here are some best practices to follow when using import mode in Power BI:

1. Set up incremental refresh: This limits the amount of data that needs to be refreshed, speeding up the overall process.

2. Consolidate query logic in a view: This simplifies the process of consuming the data and can improve performance.

3. Use "_partitioned" views to avoid read-write conflicts and deadlocks.

By following these best practices, you can improve the performance and reliability of your Power BI import mode implementation.

<img src="https://user-images.githubusercontent.com/29349597/233840286-273404a4-ae0e-44c7-b2dc-1eece45c2a4b.png" width="800" />

- [Click here](https://github.com/microsoft/powercat-automation-kit/blob/c192589e5dd795ab5ff66ac2f8d8b9304d55ddfb/AutomationKit_Flow_BYODL/Control%20Center/Flow%20Monitoring/Power%20BI/Scripts/flowsessionview.sql) to find the simplified version of custom sql view which you can create in Azure synapse lake DB under a new schema to access it on Power BI, Custom view has been much simplified for better performance to load larger datasets. This view will serve as straightforward, clean sources of data that Power BI connects.

<img src="https://user-images.githubusercontent.com/29349597/232245432-930bc4bc-a895-4b35-8ad9-d39a2b7c87a0.png" width="800"/>

