# Deploy Azure Synapse Workspace in Your Azure Environment

## Pre-requisites to Deploy Synapse

- You must have an active azure subscription

## Deployment Steps

Please follow the below steps to successfully deploy a Synapse workspace and its artifacts on your Azure subscription

[Click here](https://portal.azure.com/#create/Microsoft.Synapse) to create Synapse Workspace and Datalake Gen 2

### Optional Delta Lake Deployment

In case the need is to have voluminous data in Deltalake then follow steps to create Synapse with Spark-Pool.

###     [![Deploy To Azure](../Images/deploytoazure.svg?sanitize=true)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fmicrosoft%2Fpowercat-automation-kit%2FFlow-byodl%2FAutomationKit_Flow_BYODL%2FARMTemplate%2Fazuredeploy.json)

### Optional Restricted Network Setup

- [Click here](./Synapse-with-managed-identity/readme.md) to follow the instructions to enable restricted network on Datalake and synapse, **Use managed identities for Azure with your Azure data lake storage**.

### Congratulations, Now you have completed setup of synapse workspace

As a next step, you need to setup "[Synapse link in your Power Apps Environment](../002-%20Synapse%20link%20Setup/readme.md)".
