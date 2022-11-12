---
title: "Application Lifecycle Management (ALM)"
description: "Automation Kit - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9879BCED5F4B223A5305D8514B67FB43AA12FDDD
---

{{<slideStyles>}}

<div class="optional">

This page provides an overview of components that can assist you with using ALM with the Automation Kit for Power Automate Desktop workflows included in [Power Platform Solutions](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## Summary

When looking at ALM for Power Platform solutions that include Power Automate Desktop components

1. Review the features of Managed Environment Power Platform Pipelines to take advantage of enterprise scale in-product features to manage and govern solutions within environments.

<br/>

2. If needed, investigate the [Microsoft Power Platform Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [GitHub Actions for Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) or [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) to integrate and automate your ALM DevOps processes.

<br/>

3. Consider using the [ALM Accelerator for Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). The ALM Accelerator provides a prebuilt set of Azure DevOps templates that automates many of the Power Platform ALM tasks using integrated source control governance.

## Learning from Power CAT

You can also read more how we as the Power CAT team use ALM Accelerator to ship the [Power CAT Automation Kit ALM](/en-gb/features/alm/powercat).

## Resources

[ALM Accelerator for Power Platform Learning Catalog](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## Roadmap

The Automation Kit team is working with the ALM Accelerator team to add Power Automate Desktop specific tasks to the existing templates that cover:

- Side by side compare of Power Automate Desktop definitions.

- Validation Rule checks for Power Automate Desktop.

- Execution of Unit, Integration and System tests as part of CI/CD pipeline.

Review our [Automation Kit ALM related backlog](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## Feedback

{{<questions name="/content/en-gb/features/alm.json" completed="Thank you for providing feedback" showNavigationButtons="false" locale="en-gb">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

Managed environments provide you the ability to streamline and simplify governance at scale. Admins can activate Managed Environments with just a few clicks and immediately light up features that provide more visibility, more control with less effort to manage all your low code assets.

Managed environments are a key part of the Power Platform family, in the same ways that AI Builder infused intelligence into our products and Dataverse provides the data backbone. Managed environments streamline governance of the platform at scale.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

Managed environments provide you:

- More visibility with usage insights on the home page, admin digest emails, license reports and data policy views
- More control with sharing limits giving you control on how widely and with how many people canvas app and solution flows can be shared with.
- You can also restrict sharing to limited security groups.
- Configure solution checker for security or reliability checks to run rules automatically whenever a solution is imported to a managed environment
- Customize the maker welcome and sharing experience so that you guide users down the correct path.
- Less effort streamline, simplify and automate steps out of the box just a few clicks. 
- The Power Platform Pipelines provides the ability to simplify the Application Lifecycle Management (ALM) process.

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

This a solution in that I am working with in the Maker Portal.

I've gone ahead to select this pipeline that already been setup. Pipelines are basically a series of automated steps that move your work from one environment to another. This pipeline will take my solution from the development environment on the left to the test environment. Then there's another stage to take it from test to production.

Lets deploy to test, select next and here, I'll confirm my connections to test the environment to make sure I am using the right credentials. Next I'll configure my environment variables to make sure for example that I am pointing to the right SharePoint site in test. This is important if the site was different than the one I was using in development. 

Once I set it all up I can just select "Deploy" and preflight validations are automatically run to make I've got the right dependencies and the solution doesn't violate and DLP policies in that target environment. The pipeline can also be setup so that approval is required before deployment can be run. 

Looks like everything was successful here.

After I run my pipeline I get full visibility and an audit trail of the deployments across my organization with every solution backed up and versioned.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

The features will be rolled out in phases. Some of them like the admin digests and sharing limits are available today. The rest will be rolling out by the end of the year.

In the coming weeks and months, you will see usage insights on the home page. New trends in the admin digests, and reports for licensed usage. Sharing limits will get more controls and support solution flows. You will be able to able to block unsafe deployments with Solution Checker. The customer maker onboarding and pipeline capabilities will also come later this year.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

You have a number of options to consider for your ALM choices in the Power Platform. The Managed Environment Power Platform pipelines provide in product Application Lifecycle management.

Optionally you could use the extension points of the Managed Environment Power Platform pipelines combined with [Power Platform Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), the [GitHub Actions for Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) or [Power Platform CLI](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction) to roll your own custom ALM DevOps processes.

Finally you could take advantage of the [ALM Accelerator for Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) from the CoE Kit to provide pre-built templates and samples for End-to-End ALM using Azure DevOps. The ALM Accelerator provide s many common scenarios to build and govern your solutions across environments.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

What is ALM Accelerator for Power Platform?

The ALM Accelerator for Power Platform includes Power Apps that sits on top of Azure DevOps Pipelines and Git source control. The app provides a simplified interface for makers to regularly export the components in their Power Platform Solutions to source control and create deployment requests to have their work reviewed before deploying to target environments.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

Looking at the ALM Accelerator workflow it starts with Development environments. Their interaction with the ALM process is via the ALM Accelerator Canvas App or Managed Environment Pipelines

Makers use the ALM Accelerator Canvas App for their ALM tasks such as import solution from source control, export changes to source control and create pull request to merge changes

ALM Accelerator templates for Azure DevOps pipelines facilitates the automation of ALM tasks based on the Makers interaction with the ALM Accelerator Canvas App

ALM Accelerator includes pipeline templates to support a 3 stage deployment to production.
Templates can be customized to fit specific needs and scenarios

The ALM Accelerator for Power Platform is a Canvas App that sits on top of Azure DevOps Pipelines to provide a simplified interface for Makers to regularly commit and create pull requests for their development work in the Power Platform. 

The combination of the Azure DevOps Pipelines and the Canvas App are what make up the full ALM Accelerator for Power Platform  solution. 
The pipelines and the App are reference implementations. They were developed for use by the development team for the CoE Starter Kit internally but have been open sourced and released in order to demonstrate how healthy ALM can be achieved in the Power Platform. They can be used as is or customized for specific business scenarios.

{{</slide>}}
