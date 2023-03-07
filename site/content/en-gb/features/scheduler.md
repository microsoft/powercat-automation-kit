---
title: "Scheduler"
description: "Automation Kit - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B97833AB30777C813B3E62592D32D7E5B882ACEE
---

{{<toc>}}

## Introduction

The Automation Kit Scheduler allows to view the schedule of recurring Power Automate Cloud flows inside Solutions that include calls to Power Automate Desktop flows.

This feature was updated as part of the [March 2023](/en-gb/releases/march-2023), Later releases will continue to improve and grow the functionality the scheduler.

{{<border>}}
![Scheduler](/images/schedule.png)
{{</border>}}

The key features of the scheduler are:

- The ability to view the schedule of Recurring cloud flows
- Filter schedule by machine and machine groups
- Run a Power Automate Desktop flow
- View schedule by Day, Week, Month and Schedule view
- View the status of Scheduled flows (Success, Failure or Scheduled)
- View the duration of a Cloud Flow run
- View the details of any errors.

## Run Flow

### Read-only behavior of scheduled flows

By default, when a flow is scheduled for future execution, it is set to read-only mode and disabled for immediate execution. This means that users cannot modify or execute the flow until the scheduled date and time has passed. This behavior is designed to provide a better user experience and prevent accidental execution of flows before they are intended to run.
There are several benefits to this approach, including:

- Preventing accidental execution: By disabling immediate execution of flows that are scheduled for future execution, users are less likely to accidentally run a flow before it is intended to run.

- Improved predictability: By setting flows to read-only mode when they are scheduled for future execution, users can more easily predict when flows will run and ensure that they have the necessary inputs and resources ready.

- Consistent user experience: By standardizing the behavior of scheduled flows, it can provide a consistent and predictable user experience across all instances of Flow.

- To modify or execute a scheduled flow, users can edit the flow and update the scheduled date and time. Once the new schedule has been set, the flow will once again be disabled for immediate execution and set to read-only mode until the new schedule has passed.

## Error Messages

Possible error messages that could occur when executing run flow.

### Error Message: "InvalidArgument - Cannot find a valid connection associated with the provided connection reference."

#### Description

This error message typically indicates that there is an issue with the connection reference provided in the code or configuration. The system cannot locate a valid connection associated with the reference, which prevents it from executing the requested action.

#### Causes

There are several potential causes for this error message, including:

- Incorrect or invalid connection reference: The provided connection reference may be invalid or incorrect, which can cause the system to fail to locate a valid connection associated with it.

- Connection deleted or changed: If the connection used in the code or configuration has been deleted or modified, it can cause the system to fail to locate a valid connection associated with the reference.

- Permissions issue: The user account executing the code or configuration may not have the necessary permissions to access the connection or the resources associated with it.

#### Resolution

To resolve this issue, you can take the following steps:

- Verify the connection reference: Check the connection reference provided in the code or configuration and ensure that it is valid and correct.

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
