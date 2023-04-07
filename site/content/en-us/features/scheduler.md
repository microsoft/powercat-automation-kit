---
title: Scheduler
description: Automation Kit - Scheduler
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
---

{{<toc>}}

## Introduction

The Automation Kit Scheduler allows to view the schedule of recurring Power Automate Cloud flows inside Solutions that include calls to Power Automate Desktop flows.

This feature was updated as part of the [March 2023](/releases/march-2023), Later releases will continue to improve and grow the functionality the scheduler.

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

## Cloud Flows

As noted above only cloud flows that are included as part of a solution. The recent [https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/) includes information on how to use the new preview of "Dataverse solutions by default" to help ensure that cloud flows are included in solutions. Using this feature can assist users in ensuring the scheduled cloud flows that are created are visible in the scheduler.

## Calendar Views

## Day, Week, Month Views

The day, week, month views display information on Desktop Cloud flow runs that have executed or are scheduled to be executed.

Items are color coded as follows:

- Green indicates successful run

- Red indicates failed run

- Blue indicates a scheduled future run.

The status and run information is available with long touch or hover mouse on the event.

### Schedule

{{<border>}}
![Scheduler - Run Now](/images/scheduler-schedule-view.png)
{{</border>}}

The schedule view includes a set of cloud flows based on time from the current time and future scheduled flows over the next days.

## Run Now

{{<border>}}
![Scheduler - Run Now](/images/scheduler-run-now.png)
{{</border>}}

The current version of Run Now will execute the the Power Automate desktop. It is assume that there is no parameters required to execute the desktop flow. The additional run information is available in the Desktop last run information.

### Planned Changes

In future releases the following is being considered as new features:

1. Execute the cloud flow rather than the desktop flow. This will then include cloud flow run history and execution any additional cloud flow actions and parameters that are passed to the desktop flow.

2. Open Desktop and Cloud flow run pages.

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

- Delete existing connections and recreate: If the Flow Checker warns that a connection reference have not used been used you can use the flow checker to delete existing connections. Once the connections are deleted you can recreate connection references to the Machine or Machine group to enable the flow to be run.

## Notes

For the current release the following notes apply

1. Only Power Automate Desktop and Power Automate solutions contained within a solution are displayed
1. At least one Power Automate Desktop has been registered and executed

## Install

To install the scheduler solution you can do the following:

1. Ensure Power Apps component framework enabled <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Read more</a>
1. You have installed the Creator Kit into the target environment. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Install from App Source</a>
1. You have downloaded the AutomationKit.zip file from the Assets section of the latest <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub release</a>
1. You have imported the latest AutomationKitScheduler_*_managed.zip file using. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Read more</a>

## Roadmap

You can visit our <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub Issues</a> to view proposed new features.

You can add a new <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Scheduler Feature request</a>

## Feedback

{{<questions name="/content/en-us/features/scheduler.json" completed="Thank you for providing feedback" showNavigationButtons=false >}}