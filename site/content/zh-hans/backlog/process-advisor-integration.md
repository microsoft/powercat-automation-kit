---
title: "Process Advisor集成"
description: "自动化套件 - Process Advisor集成"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Process Advisor', 'Integration', 'RPA']
generated: 1314509EA465891ED5914448D4EC119A8218FE57
---
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

2. More information on configuring your Process Advisor analysis with a custom workspace can be found in [Load your process analytics in power bi](https://learn.microsoft.com/power-automate/process-mining-pbi-workspace#load-your-process-analytics-in-power-bi)

### Power Automate Templates

You could use out of the box Power BI connector actions and Power Automate cloud flows to create or update you Automation Kit projects.

## Questions

{{<questions name="/content/en-us/backlog/process-advisor-integration.json" completed="Thank you for completing Process Advisor questions" showNavigationButtons=false />}}

该 {{<product-name>}} 集成[Process Advisor](https://learn.microsoft.com/power-automate/process-advisor-overview)以支持以下方案：

- **加工采矿**业务流程分析，以识别和支持业务案例，以创建由数据分析支持的自动化项目。

- **数据驱动的自动化项目请求** 使用过程分析的结果根据Process Advisor结果创建自动化项目。

- **半自动化项目创建** 在Process Advisor和自动化工具包之间集成 Dataverse 数据，以减少创建自动化项目的工作量。

- **电源自动化桌面分析**分析 RPA 流程数据，以确定使用任务挖掘实现现代化、提高弹性和可靠性的改进。

## 加工采矿

将流程挖掘与Process Advisor结合使用，可以发现组织范围内流程中的低效率。这些见解使你能够使用可从记录系统（在流程中使用的应用）获取的事件日志文件深入了解进程。流程挖掘显示包含数据和指标的流程图，以识别性能问题。适用于流程挖掘的示例流程包括应收账款和订单到现金。

此数据允许您创建数据驱动的自动化项目请求。

## 自动化项目创建

使用Process Advisor流程挖掘和报告的结果，您可以使用以下Process Advisor信息来支持使用Process Advisor计算分析结果的自动化项目：

自动化套件|Process Advisor|笔记|
