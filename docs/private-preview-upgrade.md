# Overview

When upgrading the Automation Kit from a private preview installation the Dataverse Plugin has changed in the September 2022 release. To allow the new September release to be installed the Dataverse Plugin actions must first be uninstalled to allow the new plugin to be registered.

The steps in [Dataverse Plugin Unregister](#dataverse-plugin-unregister) describe how to unregister the actions not needed in the September release.

## Problem

As noted in [[Automation Kit - Private Preview Upgrade] Satellite Dataverse Plugin Upgrade](https://github.com/microsoft/powercat-automation-kit/issues/17) the following error when upgrading from the April 2022 to August 2022 release.

![Issue when upgrading from April Release](https://user-images.githubusercontent.com/94862471/190780451-0c8d0d18-3981-4845-8cbc-295434521e2b.png)

With an error similar to the following

Error Log:Error log: Plugin Assemblies import: FAILURE. Error: Plugin: AutoCoE.Extensibility.Plugins, Version=0.1.0.0, Culture=neutral, PublicKeyToken=65fb68c99935ed4d caused an exception.: PluginType [AutoCoE.Extensibility.Plugins.RPALogSyncToAzureLogAnalytics] not found in PluginAssembly [AutoCoE.Extensibility.Plugins, Version=0.1.0.0, Culture=neutral, PublicKeyToken=65fb68c99935ed4d] which has a total of [3] plugin/workflow activity types. Could be due to customization on same plugin through multiple solutions. PluginType tried to install conflicted with PluginType: AutoCoE.Extensibility.Plugins.RPALogSyncToAzureLogAnalytics (Id: 45cd7896-678f-4e8f-8a2e-90152df5862c) , PluginAssembly: AutoCoE.Extensibility.Plugins (Id: c8f4f22d-c74c-4d46-b206-8eee6f084e4f), Solution: AutomationCoESatellite (Id: 6ff2f158-aa87-4c2f-a4a6-009a9649bb59).

## Analysis

There are two un-used actions in the AutoCOE Plugin:

- RPALogSyncToAzureLogAnalytics

- DesktopFlowStaticAnalysis

## Dataverse Plugin Unregister

Follow these steps to un-register  un-used actions in the AutoCOE Plugin

1. Download or install PluginRegistrationTool through Package manager ( url: NuGet Gallery | Microsoft.CrmSdk.XrmTooling.PluginRegistrationTool 9.1.0.148 or (https://docs.microsoft.com/en-us/power-apps/developer/data-platform/download-tools-nuget)

1. Run PluginRegistration.exe from c:\Microsoft.CrmSdk.XrmTooling.PluginRegistrationTool.9.1.0.148\tools\PluginRegistration.exe

1. Select “Create New Connection” to connect to your satellite environment

1. Provide necessary login credentials and select respective checkboxes as screen shot below

1. Select “Login” button

1. Select your COE satellite Environment and select “Login” as screen shot below

1. Your satellite environment will be loaded. NOTE: It may take 5 seconds to load.

1. Expand the node “AutoCOE.Extenibility.Plugins” to show actions in that plugin.

1. Select the plugin Action “AutoCOE.Extensibility.Plugins.DesktopFlowStaticAnalysis” and click on “Unregister”. And then Confirm ‘Yes’ to unregister.

1. Select the plugin Action “AutoCOE.Extensibility.Plugins.RPALogSyncToAzureLogAnalytics” and click on “Unregister”. And then Confirm ‘Yes’ to unregister.

1. After un-registering of above 2 actions, there will only be 3 actions.

1. Close the Pluginregistration.exe window and try to import satellite solution in environment.

## Unregister Example

The video include a summary of the steps above to unregister the actions that are no longer required for the September 2022 release.

<a href='https://www.youtube.com/watch?v=W6X5U9g_wlo&list=PLi9EhCY4z99VlRg4j7D1Or6XfXbUcEWZy&index=8' target='_blank'>

![Prerequistes Video](https://img.youtube.com/vi/W6X5U9g_wlo/0.jpg)

</a>