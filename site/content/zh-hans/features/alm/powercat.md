---
title: "Power CAT 应用程序生命周期管理 （ALM）"
description: "自动化套件 - ALM 电源卡特"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 0087DF5B505764347AC2AF0B6C170474826A5D65
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

我们的内部流程具有用于开发、测试和生产的电源平台环境。一旦我们准备好发布，我们的集成 GitHub 操作会自动打包托管和非托管部署解决方案以及 GitHub 草稿版本的发行说明。

一旦草稿版本准备就绪，我们可以根据需要发布新版本或修补程序。

### 这对您意味着什么

现在我们已经实现了这种自动化，自动化 ALM 版本为您提供了以下好处：

-了解构成自动化工具包的所有低代码源代码，以便您可以调查我们如何构建该工具包。

-简化的自动化过程，可以快速响应错误或问题，并在需要时提供修补程序。

-自动编译版本中包含的所有错误和功能。

-我们将 Power Apps、Power Automate、Dataverse 和 Power Automate Desktop 作为持续集成/持续部署的 ALM 流程的一部分。

## 路线图

您可以在我们的[GitHub 问题注册](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

总体而言，我们将现有的开箱即用的Power Platform和Microsoft DevOps产品功能一起构建ALM Accelerator。这种组合使我们能够专注于有助于超自动化的特定扩展。

## 反馈

{{<questions name="/content/zh-hans/features/alm/powercat.json" completed="感谢您提供反馈" shownavigationbuttons="false" locale="zh-hans">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Power CAT 团队使用 ALM 加速器来构建和部署我们的每个[释放](https://github.com/microsoft/powercat-automation-kit/releases).

每个版本都会促进从我们的开发到测试和生产环境的更改。工具包中的 Power Platform 解决方案使用自动化流程打包资产以部署到公共 GitHub 版本。

在未来的里程碑中，我们将在现有平台上进行扩展[铝业管理功能](/zh-hans/features/alm)提供示例，说明如何将验证规则和 RPA 示例的可视化比较作为 DevOps 过程的一部分。

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

下面概述了自动化工具包发布过程中的关键步骤：

1.在我们的 Power Platform Dev 环境中所做的更改将保存到公共 GitHub 存储库中的分支

2.当更改准备好包含在测试版本中时，它们将使用拉取请求合并到主分支中。在完成拉取请求之前，需要成功完成 Azure DevOps 验证管道并审核拉取请求。

3.一旦拉取请求通过自动检查并获得审查批准，它就可以合并到主分支中。此合并会触发测试 Azure DevOps 生成管道，该管道将托管生成发布到测试 Power Platform 环境。

4.内部测试后，将手动触发 Azure DevOps 生产管道以生成生产电源平台部署。

5.准备好发布后，发布 Azure DevOps 管道会创建一个草稿版本，其中包含发行说明和生成资产。最终发布版本将关闭所有未解决的问题并关闭里程碑。已发布的构建标记 GitHub 存储库，并应用了月份和年份标签。

{{</slide>}}
