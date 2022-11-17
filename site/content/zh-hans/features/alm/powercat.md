---
title: "Power CAT 应用程序生命周期管理 （ALM）"
description: "自动化套件 - ALM 电源卡特"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: EE6E212FD39B87D233249859750DDF2D7FC71E60
---

{{<slideStyles>}}

<div class="optional">

自动化套件利用[ALM 加速器](https://aka.ms/aa4pp)为包含 Power Automate Desktop 的解决方案提供 ALM 功能

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## GitHub 部署过程

与用于其他 Power CAT 托管套件的发布过程类似，{{<product-name>}} 使用 ALM 加速器将版本部署到我们的公共 GitHub 版本。

Our internal process has a <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> environment for Development, Test and Production. Once we are ready for a release our integrated GitHub Actions package the managed and unmanaged deployment solutions along with release notes automatically for a GitHub Draft release.

一旦草稿版本准备就绪，我们可以根据需要发布新版本或修补程序。

### 这对您意味着什么

现在我们已经实现了这种自动化，自动化 ALM 版本为您提供了以下好处：

-了解构成自动化工具包的所有低代码源代码，以便您可以调查我们如何构建该工具包。

-简化的自动化过程，可以快速响应错误或问题，并在需要时提供修补程序。

-自动编译版本中包含的所有错误和功能。

-我们将 Power Apps、Power Automate、Dataverse 和 Power Automate Desktop 作为持续集成/持续部署的 ALM 流程的一部分。

## 路线图

您可以在我们的[GitHub 问题注册](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

Overall we build on the existing out of the box <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> and Microsoft DevOps product features together ALM Accelerator. This combination allows us to focus on specific extensions that help with hyperautomtion.

## 反馈

{{<questions name="/content/zh-hans/features/alm/powercat.json" completed="感谢您提供反馈" showNavigationButtons="false" locale="zh-hans">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Power CAT 团队使用 ALM 加速器来构建和部署我们的每个[释放](https://github.com/microsoft/powercat-automation-kit/releases).

Each release promotes changes from our development into test and production environments. The <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> solutions inside the kit use an automated process to package assets for deployment to public GitHub releases.

在未来的里程碑中，我们将在现有平台上进行扩展[铝业管理功能](/zh-hans/features/alm)提供示例，说明如何将验证规则和 RPA 示例的可视化比较作为 DevOps 过程的一部分。

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

下面概述了自动化工具包发布过程中的关键步骤：

1. Changes made in our <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> Dev environment are saved to a branch in the public GitHub repository

2.当更改准备好包含在测试版本中时，它们将使用拉取请求合并到主分支中。在完成拉取请求之前，需要成功完成 Azure DevOps 验证管道并审核拉取请求。

3. Once the Pull Request has passed the automated checks and received review approval it can be merged into the main branch. This merge triggers the test Azure DevOps build pipeline which publishes the managed build to the test <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> environment.

4. After internal testing the Azure DevOps production pipeline is manually triggered to generate a Production <mstrans:dictionary translation='Power Platform'>Power Platform</mstrans:dictionary> deployment.

5.准备好发布后，发布 Azure DevOps 管道会创建一个草稿版本，其中包含发行说明和生成资产。最终发布版本将关闭所有未解决的问题并关闭里程碑。已发布的构建标记 GitHub 存储库，并应用了月份和年份标签。

{{</slide>}}
