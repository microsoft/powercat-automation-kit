# Automation CoE Extensibility Solution

## Solution Overview

This Automation CoE sample solution has been developed to showcases some of the  pro-code extensibility options we have in Power Platform and Dataverse. The solution is based on a real-world use case for machine status monitoring which leverages Dataverse [Custom API](https://docs.microsoft.com/powerapps/developer/data-platform/custom-api) and [plug-in](https://docs.microsoft.com/powerapps/developer/data-platform/plug-ins) features.

## Setup instructions

### Pre-requisites

Following pre-requisites are required before you can deploy the sample solution.

1. Microsoft Visual Studio 2019 (tested with Version 16.11.11) [Download Link](https://visualstudio.microsoft.com/vs/older-downloads/)
2. .NET Framework 4.6.2 (required only for plug-in and workflow activity development) [Download Link](https://dotnet.microsoft.com/download/dotnet-framework/net462)
3. Use of the C# programming language
4. [Power Platform Tools extension](https://docs.microsoft.com/powerapps/developer/data-platform/tools/devtools-install) for Visual Studio 2019 [Download Link](https://marketplace.visualstudio.com/items?itemName=microsoft-IsvExpTools.PowerPlatformTools).

> Please note that Visual Studio 2022 is currently not supported as it is different enough from previous versions which requires its own vsix installer. The Microsoft team plans to release this extension for VS2022 by June2022.

These guides describe how to install and use the **Power Platform Tools** extension.

- <https://docs.microsoft.com/powerapps/developer/data-platform/tools/devtools-install>

- <https://docs.microsoft.com/powerapps/developer/data-platform/tools/devtools-create-project>

- <https://docs.microsoft.com/powerapps/developer/data-platform/tools/devtools-create-plugin>

- <https://docs.microsoft.com/powerapps/developer/data-platform/tutorial-debug-plug-in>

### Setup & Deployment Video

If you prefer video instructions, please go ahead and watch the [Machine Status Sample Deployment & Setup Video](https://rpacoestorage.blob.core.windows.net/public-coe-blobs/Machine_Status_Sample_Setup.mp4), otherwise just follow the steps outlined in [Setup & Deployment Steps](#setup--deployment-steps).

[![Watch the video](https://rpacoestorage.blob.core.windows.net/public-coe-blobs/Machine_Status_Sample_Setup_First_Frame.png)](https://rpacoestorage.blob.core.windows.net/public-coe-blobs/Machine_Status_Sample_Setup.mp4)

### Setup & Deployment Steps

1. Open Visual Studio 2019 and clone this repo <https://github.com/rpapostolis/autocoe-extensibility.git>
2. Right-click on solution and **Restore NuGet Packages**.
3. Build the **AutoCoE.Extensibility** solution.
4. Right-click **Plugins** Project and select Properties.
5. Select Signing and then under **Choose a strong key name file** choose *<New...>*.
6. Give your key a name and enter / confirm password.
7. Save and close the properties pane and Rebuild the solution.
8. Right-click on Plugins --> Dataverse Solution folder and select *Open. Folder in File Explorer*
9. Copy path to the folder.
10. Go to the Power Automate portal and select **Solutions** (left sidebar).
11. In the upper toolbar select **Import** and **Browse** to the location of the previously copied folder path.
12. Select **Next** and again **Next**.
13. Select or create the required 2 connections and press **Import**.
14. Enter boolean values (true/false) for the 2 environment variables.
15. After the solution has been imported, head over to the Power Platform Admin Center (<https://aka.ms/ppac>), select your environment and navigate to its details.
16. On the environment details page, under *Access* and *Security roles* select **See all**.
17. Search for the **Machine Status Log Admin** security role and navigate to its details page.
18. Select **Add people** and add yourself and/or other users to this role.
19. Go back to the Machine Status Solution artifacts and select Custom API and then click on the **Auto CoE Update Desktop Flow Machine Status Log**s custom API to open its record details.
20. Just review the settings and keep this page open as we will come back to it to assign the **Plugin Type** value.
21. Now, go back to the Visual Studio solution and select **Tools** and **Connect to Dataverse...**.
22. On the dialog login to the respective environment by selecting
    - Office 365
    - Display list of available organizations
    - Show Advanced  
        - Online Region = Don't Know
        - User name
        - Password
23. Next, select you environment and select Next.
24. Under **Select Solution** make sure you select the *MachineStatusUpdate* solution name and press **Done**.
25. Once loading completes, select Solution Explorer and navigate to the **Plugin Code** folder, right-click on *UpdateDesktopFlowMachineStatusLogs.cs* file, select **Power Platform Tools** and then **Deploy**.
26. Once the deployment has finished, go to the **Power Platform Explorer** and hit **Refresh** and wait couple of seconds for the process to complete.
27. Open the **Power Platform Explorer** tree and navigate to **Plug-in Assemblies** and open the sub-tree *AutoCoE.Extensibility.Plugins* and its child nodes. Just observe the structure and information for now, we'll come back to this in a second.
28. Back in the Browser go the the previously opened Custom API record from **step 19** and set the Plugin Type to (drop down) **AutoCoE.Extensibility.Plugins.UpdateDesktopFlowMachineStatusLogs** and save the record.
29. Go back to Visual Studio and refresh the Power Platform Explorer window.
30. Navigate again to the Plug-in Assemblies and then expand the AutoCoE.Extensibility.Plugins.UpdateDesktopFlowMachineStatusLogs nodes.
31. You will notice that there's a new Step available that starts with CustomApi.
32. Please right-click on the other step(s) and delete them.
33. Now, open the advanced settings of your environment (e.g. https://[organization].crm[regionid].dynamics.com/main.aspx?settingsonly=true), select **Settings**, **Administration** and then **System Settings**.
34. On the System settings dialog, go to the **Customization** tab and set **Enable logging to plug-in trace log** to **All** and press **Ok**. This will allow you to monitor any custom tracing message and exception that comes from plug-in executions.
35. You can review plug-in trace logs under Settings and Plug-In Trace Log.
36. That's it. Now make sure that the **Update Machine Status Logs** is turned on and running. From here on all machine status changes will be captured in the custom Dataverse Tables called **Machine Status Log** and **Machine Status Log Update**.

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft trademarks or logos is subject to and must follow Microsoft's Trademark & Brand Guidelines. Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship. Any use of third-party trademarks or logos are subject to those third-party's policies.

## License

[MIT License](https://github.com/rpapostolis/autocoe-extensibility/blob/master/LICENSE)