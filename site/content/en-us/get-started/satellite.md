---
title: Satellite - Get Started
description: Automation Kit - Satellite - Get Started
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
---

# Overview

Welcome to the starter page for the Satellite solution. This section covers important changes made in April 2023 and later releases. After April 2023 we have removed the need for Azure Key Vault to store Azure Application tenant, Application id and Azure Application secret information.

## Conceptual Design

Our learn page outlines the [Conceptual Design](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) of the {{product-name}}. The key element of the solution is the Power Platform main environment.

There are usually several satellite production environments that run your automation projects. Depending on your environment strategy, these could also be development or test environments.

Between these environments there is a near-real-time synchronization process that includes cloud or desktop flow telemetry, machine and machine group usage, and audit logs. The Power BI dashboard for the Automation Kit displays this information.

## What Has Changed

As part of resolving [[Automation Kit - Feature]: Azure Key Vault alternative for Satellite environments](https://github.com/microsoft/powercat-automation-kit/issues/84) Azure Key Vault is no longer required. This is important as it significantly reduces the complexity of install and how security is managed to obtain Solution Artifacts when using the Automation Solution Manager.

## What is the same?

Once key elements is the same been the older Pre-April 2023 and April 2023 releases is the need for an Azure Active Directory Application.

An [application user](https://learn.microsoft.com/power-platform/admin/manage-application-users) is a type of user in the Power Platform that is identified by the presence of ApplicationId attribute in the system user record. Application users are created in Azure Active Directory (Azure AD) and are used to authenticate and authorize access to the Power Platform. They are typically used to represent an application or service that needs to access data or perform operations in the Power Platform on behalf of users or other applications.

Specifically the Application user is used by the Automation Solution Manager to allow you to query the solution components in an environment so that you can enable a user to meter a deployed Power Platform solution.

## Install

The [command line install](/get-started/install) for satellite solutions will prompt you for the Azure Active Directory Application Name and Azure Active Directory Application Id. Using this information it will:

1. Add the Azure Active Directory Application as an Application User
1. Add the Application User to the System Administrator Role
1. Add the User Id of the Application user to the environment variable **Solution Manager Artifacts Read User Id**

The new role dataverse role **Automation Solution Manager User** has been added that allows users to call the new Dataverse GetDataverseSolutionArtifacts Custom API that will query solution artifacts using the provided environment variable **Solution Manager Artifacts Read User Id**.

If you wish to install the satelitte solution manually the following changes need to be made to the [Set up satellites](https://learn.microsoft.com/en-us/power-automate/guidance/automation-kit/setup/satellite) instructions.

1. Skip the step "Add a new client secret" as this no longer needed for April 2023 or newer.
1. Skip the step to create Secrets in the Azure Key Vault.
1. Add the User Id of the Application User to the **Solution Manager Artifacts Read User Id** environment variable.

## Post Install

Ensure that user(s) that will run the Automation Solution Manager application are granted the **Automation Solution Manager User** Dataverse security role.

## Previous Releases

Prior to the April 2023 release installations of Satellite solution required environment variables of type secret. This required an [Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) to store the values for Tenant Id, Application Id and Application Secret. To use this feature also required the [prerequistes](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/environmentvariables#prerequisites) of the Azure Key Vault being im the same tenant, setup of Microsoft.PowerPlatform as a resource provider.

In the March 2023 or older releases the Azure Key Vault was used to store a Tenant Id, APplication Id and Application Secret. Using these values an access token was requested to query dataverse so that it could return the list of Solution Components.

## Recommendations

For existing users it is recommended to simplify ongoing management and remove the need for a dependency of Azure Key Vault that you upgrade the existing satellite install to April 2023 or later to take advantages of the new features.
