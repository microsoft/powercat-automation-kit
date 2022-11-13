---
title: Data Packs
description: Automation Kit - Data Packs
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---

{{<toc>}}

## Introduction

Data Packs are prepackaged set of data that can be optionally installed into your installed Automation Kit to accelerate your usage.

{{<border>}}
![Data Packs Overview](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

Introduced as part of the [November 2022](/releases/november-2022), Datapacks provide you the ability to optionally import sample data.

The Return on Investment (ROI) data pack allows you to rapidly demonstrate planning, metering and monitoring of return on investment via the Automation Kit Power BI dashboard. You can load your first data pack using the [Getting Started](#getting-started) section below.

Overtime we will add other data packs to the backlog for prioritization and document how you can collaborate on publishing data packs to the community.

## Roadmap

{{<border>}}
![Data Packs Roadmap](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

In future milestones we will look to improve the datapacks by including them as an optional part of the Automation Kit automated install process.

The ability to include Data Packs as part of the install will allow for a web based install, rather than the command line install process for this release.

## Return On Investment Main Solution

The Return on Investment (ROI) main solution data pack includes Automation projects, machines and sample Power Automate Desktop telemetry so that you can get hands on with the end to end process.

### Getting Started

To get started with this data pack

- Install the Creator Kit from [App Source](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) or via [Learn setup guide](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Install the latest version of the Automation Kit Main from [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) using [Learn setup guide](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Install Power Platform Command Line Interface using [Learn setup guide](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Create authentication to your environment

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Download the **AutomationKit.zip** from [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Extract the file **AutomationKit-SampleData.zip** from **AutomationKit.zip**

- Import the data into your environment

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- Connect the Power BI Dashboard downloaded from with your environment to explore the imported data. Use [Install Power BI Dashboard](/get-started/install-powerbi-dashboard) for more information

## Feedback

{{<questions name="/content/en-us/features/datapacks.json" completed="Thank you for providing feedback" showNavigationButtons=false >}}