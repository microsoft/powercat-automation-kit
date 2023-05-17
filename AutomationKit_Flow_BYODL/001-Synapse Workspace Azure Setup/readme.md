# Deploy Azure Synapse Workspace in Your Azure Environment

## Pre-requisites to Deploy Synapse

- You must have an active azure subscription

## Deployment Steps
Please follow the below steps to successfully deploy a Synapse workspace and its artifacts on your Azure subscription

[Click here](https://portal.azure.com/#create/Microsoft.Synapse) to create Synapse Workspace and Datalake Gen 2.

Incase the need is to have voluminous data in Deltalake then follow steps to create Synapse with Spark-Pool. 

###     [![Deploy To Azure](../Images/deploytoazure.svg?sanitize=true)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fmicrosoft%2Fpowercat-automation-kit%2FFlow-byodl%2FAutomationKit_Flow_BYODL%2FARMTemplate%2Fazuredeploy.json)

- [Click here](https://github.com/microsoft/powercat-automation-kit/tree/27a0b53cd74963d2daede56bdb9fbc118aaccc4e/AutomationKit_Flow_BYODL/001-Synapse%20Workspace%20Azure%20Setup/Synapse-with-managed-identity) to follow the instructions to enbale restrcited network on datalake and synapse,**Use managed identities for Azure with your Azure data lake storage**.

#### Conrgatulations, Now you have completed setup of synapse workspace !! As a next step, you need to setup "[Synpase link in your Power Apps Environment](https://github.com/microsoft/powercat-automation-kit/tree/27a0b53cd74963d2daede56bdb9fbc118aaccc4e/AutomationKit_Flow_BYODL/002-%20Synapse%20link%20Setup)". 
