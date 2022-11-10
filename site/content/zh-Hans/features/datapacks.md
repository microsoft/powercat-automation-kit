---
title: 数据包
description: 自动化套件数据包
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: BEA89993168AC33B19A338208B6665AE7E726557
---

{{<toc>}}

## 介绍

数据包是预先打包的数据集，可以选择将其安装到已安装的自动化工具包中，以加快使用速度。

{{<border>}}
![数据包概述](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

作为[2022年11月](/zh-hans/releases/november-2022)，则数据包使您能够选择性地导入示例数据。

投资回报 （ROI） 数据包允许你通过自动化工具包 Power BI 仪表板快速演示投资回报的规划、计量和监视。您可以使用[开始](/zh-hans#getting-started)部分。

随着时间的推移，我们会将其他数据包添加到积压工作中以确定优先级，并记录如何协作将数据包发布到社区。

## 路线图

{{<border>}}
![数据包路线图](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

在未来的里程碑中，我们将通过将其作为自动化工具包自动安装过程的可选部分来改进数据包。

将数据包作为安装的一部分包含的功能将允许基于 Web 的安装，而不是此版本的命令行安装过程。

## 投资回报主要解决方案

投资回报 （ROI） 主解决方案数据包包括自动化项目、计算机和示例 Power Automate 桌面遥测数据，以便你可以亲身体验端到端流程。

### 开始

开始使用此数据包

-从以下位置安装创建者工具包[应用源](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1)或通过[学习设置指南](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

-从以下位置安装最新版本的自动化工具包主[https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)用[学习设置指南](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

-使用 安装 Power Platform 命令行界面[学习设置指南](https://learn.microsoft.com/power-platform/developer/cli/introduction)

-为您的环境创建身份验证

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

-下载**自动化套件.zip**从[https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

-解压缩文件**自动化工具包-样本数据.zip**从**自动化套件.zip**

-将数据导入到您的环境中

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

-将从中下载的 Power BI 仪表板与环境连接，以浏览导入的数据。用[安装 Power BI 仪表板](/zh-hans/get-started/install-powerbi-dashboard)欲了解更多信息

## 反馈

{{<questions name="/features/datapacks.json" completed="Thank you for providing feedback" showNavigationButtons=false >}}
