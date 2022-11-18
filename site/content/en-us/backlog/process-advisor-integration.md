---
title: Process Advisor Integration
description: Automation Kit - Process Advisor Integration
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Process Advisor', 'Integration', 'RPA']
---

The {{<product-name>}} integrates with [Process Advisor](https://learn.microsoft.com/en-us/power-automate/process-advisor-overview) to support the following scenarios:

- **Processing Mining** Analysis of Business Processes to identify and support the business case to create Automation Projects supported by data analysis.

- **Data Driven Automation Project Requests** Use the results of your process analysis to create an Automation Project from Process Advisor results.

- **Semi automated Automation Project creation** Integrate Dataverse data between Process Advisor and Automation Kit to reduce the amount of work to create Automation Project.

- **Analysis of Power Automate Desktop** Analyze RPA process data to identify improvements to modernize, improve resiliency and reliability using Task mining.

## Processing Mining

Using Process mining with Process Advisor enables you to discover of inefficiencies in organization-wide processes. These insights enables you to gain a deep understanding of your processes using event log files that you can get from your system of recording (apps you use in your processes). Process mining displays maps of your processes with data and metrics to recognize performance issues. Example processes suitable for process mining include accounts receivable and order-to-cash.

This data allows you to create data driven Automation Project requests.

## Automation Projects Creation

Using the results of Process Advisor process mining and reporting you can use the following Process Advisor information to support your automation project using Process Advisor calculated analysis results:

Automation Kit|Process Advisor|Notes        |
--------------|---------------|-------------|
Duration Total (Total Processing Time in minutes)|Duration Total Per activity|Top-level metrics currently only median and average duration which can be transformed with some customization
Case frequency| (volume per process frequency)|Case count||
Resource count (Number of FTEs needed, Number of FTEs needed for Review/Rework)|Resource count
Rework percentage (AVG Error Rate %)|Rework percentage||
Currency||In Process Advisor data model

## Semi Automated Automation Project

Using the data collected in the Process Advisor in your Power BI custom workspace you can integrate the results using Power Automate or Power Apps.

![Automation Kit Process Advisor Integration](/images/illustrations/process-advisor-integration.svg)

Using the Process Advisor Import process simplifies the amount of information that needs to be entered and offers you a choice of options to integrate with you Automation Project.

Reviewers of the Automation Project and take into account the Process Advisor results when considering if they should Approve or Deny the Automation Project request.

NOTE:

1. We currently have items on the Automation Kit backlog to add additional templates and applications in upcoming milestones that enable you quickly get started with integrating your Processed Advisor data with the Automation Kit.

2. More information on configuring your Process Advisor analysis with a custom workspace can be found in [Load your process analytics in power bi](https://learn.microsoft.com/en-us/power-automate/process-mining-pbi-workspace#load-your-process-analytics-in-power-bi)

### Power Automate Templates

You could use out of the box Power BI connector actions and Power Automate cloud flows to create or update you Automation Kit projects.

## Questions

{{<questions name="/content/en-us/backlog/process-advisor-integration.json" completed="Thank you for completing Process Advisor questions" showNavigationButtons=false >}}
