---
title: Power CAT Application Lifecycle Management (ALM)
description: Automation Kit - ALM Power CAT 
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---

The Automation Kit leverages the [ALM Accelerator](https://aka.ms/aa4pp) to provide ALM functionality for solutions that include Power Automate Desktop

{{<border>}}

![ALM Roadmap November 2022](/images/illustrations/alm-roadmap-2022-11.svg)

{{</border>}}

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