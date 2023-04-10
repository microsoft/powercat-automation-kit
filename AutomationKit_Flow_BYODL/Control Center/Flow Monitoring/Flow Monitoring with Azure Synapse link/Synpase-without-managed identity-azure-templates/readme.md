# Create a Synapse workspace in the Azure portal

### Required permissions
To deploy a Bicep file or ARM template, you need write access on the resources you're deploying and access to all operations on the Microsoft.Resources/deployments resource type.

[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fbiswapm%2FDesktopFlow-BYODL%2Fmain%2FControl%2520Center%2FFlow%2520Monitoring%2FFlow%2520Monitoring%2520with%2520Azure%2520Synapse%2520link%2FSynpase-workspace-without-managed%2520identity-azure-templates%2FSynapseworkspacewithdatalake.json)

To deploy this template, you can use the Azure CLI or PowerShell with the following commands:

```
## Azure CLI 
az deployment group create --resource-group <resource-group-name> --template-file <path-to-template-file> --parameters workspaceName=<workspace-name> location=<location>

### PowerShell
New-AzDeployment -Location <location> -TemplateFile <path-to-template-file> -TemplateParameterObject @{workspaceName=<workspace-name>} -ResourceGroupName <resource-group-name>
```

Make sure to replace #resource-group-name, #workspace-name, #location with your desired values.
