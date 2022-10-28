---
title: Application Lifecycle Management (ALM)
description: Automation Kit - ALM
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---

This page provides an overview of using ALM with the Automation Kit.

## Summary

When looking at ALM for Power Platform solutions that include Power Automate Desktop components

1. Review and follow the [Streamline low code governance in your organization](https://learn.microsoft.com/en-us/events/ignite-2022/brk41-streamline-low-code-governance-in-your-organization) to leverage in product feature to move solutions between environments.

1. If needed investigate the [Microsoft Power Platform Build Tools for Azure DevOps](https://learn.microsoft.com/en-us/power-platform/alm/devops-build-tools), [GitHub Actions for Microsoft Power Platform](https://learn.microsoft.com/en-us/power-platform/alm/devops-github-actions) or [Power Platform CLI](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction) to integrate and automate your ALM DevOps processes

1. Consider using the [ALM Accelerator for Power Platform](https://learn.microsoft.com/en-us/power-platform/guidance/coe/almacceleratorpowerplatform-components) which provides a prebuilt set of Azure DevOps templates that automates many of the Power Platform ALM tasks using an integrated source control governance

## Learning from Power CAT

You can also read more how we as the Power CAT team use ALM Accelerator to ship the [Power CAT Automtion Kit ALM](/features/alm/powercat).

## Roadmap

The Automation Kit team is working with the ALM Accelerator team to add Power Automate Desktop specific tasks to the existing templates that cover:

- Side by side compare of Power Automate Desktop definitions

- Validation Rule checks for Power Automate Desktop

- Execution of Unit, Integration and System tests as part of integration pipeline

Review our [Automation Kit ALM related backlog](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

## Feedback

{{<questions name="/features/alm.json" completed="Thank you for providing feedback" showNavigationButtons=false >}}