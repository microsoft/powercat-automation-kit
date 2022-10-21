---
title: Data Packs
description: Automation Kit Data Packs
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---

Data Packs are prepackaged set of data that can be optionally installed into your installed Automation Kit to accelerate your usage.

## Return On Investment Main Solution

The Return on Investment (ROI) main solution data pack includes Automation projects, machines and sample Power Automate Desktop telemetry so that you can get hands on with the end to end process.

### Getting Started

To get started with this data pack

- Install the Creator Kit from [App Source](https://appsource.microsoft.com/en-US/product/dynamics-365/microsoftpowercatarch.creatorkit1) or via [Learn setup guide](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Install the latest version of the Automation Kit Main from [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) using [Learn setup guide](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Install Power Platform Command Line Interface using [Learn setup guide](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Create authentication to your environment

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Download the **AutomationKitROIMain.zip** from [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Import the data into your environment

```pwsh
pac data import -d AutomationKitROIMain.zip --environment https://contoso.crm.dynamics.com/ 
```

- Connect the Power BI Dashboard downloaded from with your environment to explore the imported data. Use [Install Power BI Dashboard](/get-started/install-powerbi-dashboard) for more information
