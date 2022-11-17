---
title: "应用程序生命周期管理 （ALM）"
description: "自动化套件 - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 7A054C4EE36843CB023C64E2B26C68DDF722666D
---

{{<slideStyles>}}

<div class="optional">

本页概述了可帮助您将 ALM 与 Power Automate 桌面工作流的自动化工具包配合使用的组件，这些组件包含在[<mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> Solutions](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## 总结

When looking at ALM for <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> solutions that include Power Automate Desktop components

1. Review the features of Managed Environment <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> Pipelines to take advantage of enterprise scale in-product features to manage and govern solutions within environments.

<br/>

2.如果需要，请调查[Microsoft <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools),[GitHub Actions for Microsoft <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary>](https://learn.microsoft.com/power-platform/alm/devops-github-actions)或[<mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction)集成和自动化您的 ALM 开发运营流程。

<br/>

3.考虑使用[ALM Accelerator for <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary>](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). The ALM Accelerator provides a prebuilt set of Azure DevOps templates that automates many of the <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> ALM tasks using integrated source control governance.

## 向电源猫学习

您还可以阅读更多我们作为 Power CAT 团队如何使用 ALM 加速器来运送[电源 CAT 自动化套件 ALM](/zh-hans/features/alm/powercat).

## 资源

[ALM Accelerator for <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> Learning Catalog](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## 路线图

自动化工具包团队正在与 ALM 加速器团队合作，将特定于 Power Automate Desktop 的任务添加到现有模板中，这些模板涵盖：

-并排比较电源自动化桌面定义。

-电源自动化桌面的验证规则检查。

-作为 CI/CD 管道的一部分执行单元、集成和系统测试。

查看我们的[自动化套件 ALM 相关积压工作](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## 反馈

{{<questions name="/content/zh-hans/features/alm.json" completed="感谢您提供反馈" showNavigationButtons="false" locale="zh-hans">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

托管环境使您能够大规模优化和简化治理。管理员只需单击几下即可激活托管环境，并立即点亮功能，这些功能可提供更高的可见性、更多的控制，从而减少管理所有低代码资产的工作量。

Managed environments are a key part of the <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> family, in the same ways that AI Builder infused intelligence into our products and Dataverse provides the data backbone. Managed environments streamline governance of the platform at scale.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

托管环境为您提供：

-通过主页上的使用情况见解、管理员摘要电子邮件、许可证报告和数据策略视图提高可见性
-通过共享限制进行更多控制，使你能够控制画布应用和解决方案流可以共享的范围和人数。
-您还可以将共享限制为有限的安全组。
-为安全性或可靠性检查配置解决方案检查器，以便在将解决方案导入托管环境时自动运行规则
-自定义制作者欢迎和共享体验，以便引导用户走上正确的道路。
-只需单击几下即可简化、简化和自动化开箱即用的步骤，省力省略。
- The <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> Pipelines provides the ability to simplify the Application Lifecycle Management (ALM) process.

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

这是我在Maker门户中使用的解决方案。

我继续选择已设置的此管道。管道基本上是一系列自动化步骤，可将工作从一个环境转移到另一个环境。此管道会将我的解决方案从左侧的开发环境带到测试环境。然后还有另一个阶段将其从测试带到生产。

让我们部署以进行测试，选择“下一步”，在这里，我将确认我的连接以测试环境，以确保我使用的是正确的凭据。接下来，我将配置我的环境变量，以确保例如我在测试中指向正确的 SharePoint 网站。如果网站与我在开发中使用的网站不同，这一点很重要。

完成所有设置后，只需选择“部署”，并自动运行预检验证，以使我拥有正确的依赖项，并且解决方案不会违反该目标环境中的 DLP 策略。还可以设置管道，以便在运行部署之前需要批准。

看起来这里的一切都很成功。

运行管道后，我可以获得整个组织中部署的完整可见性和审核跟踪，并备份和版本控制每个解决方案。

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

这些功能将分阶段推出。其中一些，如管理员摘要和共享限制，今天可用。其余的将在今年年底推出。

在接下来的几周和几个月内，你将在主页上看到使用情况见解。管理员摘要中的新趋势以及许可使用情况的报告。共享限制将获得更多控件并支持解决方案流。您将能够使用解决方案检查器阻止不安全的部署。客户制作者入职和管道功能也将在今年晚些时候推出。

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

You have a number of options to consider for your ALM choices in the <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary>. The Managed Environment <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> pipelines provide in product Application Lifecycle management.

Optionally you could use the extension points of the Managed Environment <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> pipelines combined with [<mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)这[GitHub Actions for Microsoft <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary>](https://learn.microsoft.com/power-platform/alm/devops-github-actions)或[<mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> CLI](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction)以推出您自己的自定义 ALM 开发运营流程。

最后，您可以利用[ALM Accelerator for <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary>](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)从 CoE 工具包中，为使用 Azure DevOps 的端到端 ALM 提供预构建的模板和示例。ALM 加速器提供了许多常见方案来跨环境构建和管理解决方案。

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

What is ALM Accelerator for <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary>?

The ALM Accelerator for <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> includes Power Apps that sits on top of Azure DevOps Pipelines and Git source control. The app provides a simplified interface for makers to regularly export the components in their <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> Solutions to source control and create deployment requests to have their work reviewed before deploying to target environments.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

查看 ALM 加速器工作流，它从开发环境开始。它们与 ALM 流程的交互是通过 ALM 加速器画布应用或托管环境管道进行的

制作者使用 ALM 加速器画布应用执行其 ALM 任务，例如从源代码管理导入解决方案、将更改导出到源代码管理以及创建拉取请求以合并更改

适用于 Azure DevOps 管道的 ALM 加速器模板基于制作者与 ALM 加速器画布应用的交互，有助于实现 ALM 任务的自动化

ALM 加速器包括管道模板，以支持从 3 阶段部署到生产环境。
可以自定义模板以适应特定需求和方案

The ALM Accelerator for <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> is a Canvas App that sits on top of Azure DevOps Pipelines to provide a simplified interface for Makers to regularly commit and create pull requests for their development work in the <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary>. 

The combination of the Azure DevOps Pipelines and the Canvas App are what make up the full ALM Accelerator for <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary>  solution. 
The pipelines and the App are reference implementations. They were developed for use by the development team for the CoE Starter Kit internally but have been open sourced and released in order to demonstrate how healthy ALM can be achieved in the <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary>. They can be used as is or customized for specific business scenarios.

{{</slide>}}
