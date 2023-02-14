---
title: "Scheduler"
description: "Automation Kit - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B8DC4418FD2312850E01B5DB52344E2BB9B93C2F
---

{{<toc>}}

## Introduction

The Automation Kit Scheduler allows to view the schedule of recurring Power Automate Cloud flows inside Solutions that include calls to Power Automate Desktop flows.

This feature was introduced as part of the [February 2023](/en-gb/releases/february-2023), Later releases will continue to improve and grow the functionality the scheduler.

{{<border>}}
![Scheduler](/images/schedule.png)
{{</border>}}

The key features of the scheduler are:

- The ability to view the schedule of Recurring cloud flows
- View schedule by Day, Week, Month and Schedule view
- View the status of Scheduled flows (Success, Failure or Scheduled)
- View the duration of a Cloud Flow run
- View the details any any errors.

## Notes

For the current release the following notes apply

1. Only Power Automate Desktop and Power Automate solutions contained within a solution are displayed
1. At least one Power Automate Desktop has been registered and executed

## Install

To install the scheduler solution you can do the following:

1. Ensure Power Apps component framework <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Read more</a>
1. You have installed the Creator Kit into the target environment. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Install from App Source</a>
1. You have downloaded the AutomationKit.zip file from the Assets section of the latest <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub release</a>
1. You have imported the the latest AutomationKitScheduler_*_managed.zip file using. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Read more</a>

## Roadmap

You can visit our <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub Issues</a> to view proposed new features.

You can add a new <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Scheduler Feature request</a>

## Feedback

{{<questions name="/content/en-gb/features/scheduler.json" completed="Thank you for providing feedback" showNavigationButtons="false" locale="en-gb">}}
