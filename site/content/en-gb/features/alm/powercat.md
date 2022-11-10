---
title: Power CAT Application Lifecycle Management (ALM)
description: Automation Kit - ALM Power CAT
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 0087DF5B505764347AC2AF0B6C170474826A5D65
---

{{<slideStyles>}}

<div class="optional">

The Automation Kit leverages the [ALM Accelerator](https://aka.ms/aa4pp) to provide ALM functionality for solutions that include Power Automate Desktop

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## GitHub Deployment Process

Similar to the release process used for other Power CAT managed kits the {{<product-name>}} uses the ALM Accelerator to deploy releases to our public GitHub releases.

Our internal process has a Power Platform environment for Development, Test and Production. Once we are ready for a release our integrated GitHub Actions package the managed and unmanaged deployment solutions along with release notes automatically for a GitHub Draft release.

Once the draft release is ready we can publish new versions or hotfixes as needed.

### What this means for you

Now that we have this automation in place the automated ALM release has the following benefits for you:

- Visibility into all the low code source code that makes up the Automation Kit so that you can investigate how we have built the kit.

- Streamlined automation process that can respond to bugs or issues quickly and provide hotfixes if needed.

- Automated compilation of all Bugs and Features that are included in a release.

- We include Power Apps, Power Automate, Dataverse and Power Automate Desktop as part of our ALM process for our Continuous Integration / Continuous Deployment.

## Roadmap

You can investigate our open ALM related backlog items in our [GitHub Issues Register](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

Overall we build on the existing out of the box Power Platform and Microsoft DevOps product features together ALM Accelerator. This combination allows us to focus on specific extensions that help with hyperautomtion.

## Feedback

{{<questions name="/features/alm/powercat.json" completed="Thank you for providing feedback" showNavigationButtons=false >}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

The Power CAT team uses the ALM Accelerator to build and deploy each of our [Releases](https://github.com/microsoft/powercat-automation-kit/releases).

Each release promotes changes from our development into test and production environments. The Power Platform solutions inside the kit use an automated process to package assets for deployment to public GitHub releases.

In future milestones we will be expanding on existing platform [ALM Features](/en-gb/features/alm) to provide examples of how to include validation rules and visual comparison of RPA samples as part of the DevOps process.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

The following outlines key steps in the Automation Kit release process:

1. Changes made in our Power Platform Dev environment are saved to a branch in the public GitHub repository

2. When changes are ready for inclusion into a test release they are merged into the main branch using a Pull Request. Before the Pull Request can be completed, the Azure DevOps validation pipeline needs to successfully complete and the Pull Request reviewed.

3. Once the Pull Request has passed the automated checks and received review approval it can be merged into the main branch. This merge triggers the test Azure DevOps build pipeline which publishes the managed build to the test Power Platform environment.

4. After internal testing the Azure DevOps production pipeline is manually triggered to generate a Production Power Platform deployment.

5. Once the is ready a release, the release Azure DevOps pipeline creates a draft release including release notes and build assets. The final release build will close all open issues and close the milestone. Published build tag the GitHub repository with a Month and year label applied.

{{</slide>}}
