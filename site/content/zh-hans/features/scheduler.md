---
title: "调度"
description: "自动化套件 - 调度程序"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 3191EC35273FDF75E031467EB6C5BF37F2883B67
---

{{<toc>}}

## 介绍

通过自动化工具包自动化中心计划程序页面，可以查看解决方案中重复出现的 Power Automate 云流的计划，其中包括对 Power Automate 桌面流的调用。

此功能已作为[2023 年 6 月](/zh-hans/releases/june-2023)

{{<border>}}
![调度](/images/schedule.png)
{{</border>}}

调度程序的主要功能包括：

-能够查看定期云端流的计划
-按计算机和计算机组及状态筛选计划
-打开桌面流运行的网格视图
-运行电源自动化桌面流
-按天、周、月和计划视图查看计划
-查看计划流的状态（成功、失败或计划）
-查看云端流运行的持续时间
-查看任何错误的详细信息。

## 云端流

如上所述，仅作为解决方案的一部分包含的云端流。最近的[https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/)包括有关如何使用“默认情况下的 Dataverse 解决方案”的新预览版来帮助确保解决方案中包含云端流的信息。使用此功能可以帮助用户确保创建的计划云端流在计划程序中可见。

## 日历视图

## 日、周、月视图

日、周、月视图显示有关已执行或计划执行的桌面云流运行的信息。

项目的颜色编码如下：

-绿色表示运行成功

-红色表示运行失败

-蓝色表示计划的未来运行。

在事件上长按或悬停鼠标即可获得状态和运行信息。

### 附表

{{<border>}}
![调度程序 - 调度视图](/images/scheduler-schedule-view.png)
{{</border>}}

计划视图包括一组基于当前时间和未来几天计划流的云端流。

## 立即运行

{{<border>}}
![调度程序 - 立即运行](/images/scheduler-run-now.png?v=1)
{{</border>}}

当前版本的“立即运行”将执行 Power Automate 桌面。假定执行桌面流不需要任何参数。桌面上次运行信息中提供了其他运行信息。

## 打开网格视图

{{<border>}}
![调度程序 - 打开网格视图](/images/scheduler-open-grid-view.png)
{{</border>}}

用户可以从我们的控制中心主页导航到电源自动化中的桌面流运行页面
主页上用于导航到 Power Automate 门户中的桌面流运行页面的新按钮“打开网格视图”的屏幕截图。

### 计划流的只读行为

默认情况下，当计划将来执行流时，将其设置为只读模式并禁用以立即执行。这意味着在计划的日期和时间过去之前，用户无法修改或执行流。此行为旨在提供更好的用户体验，并防止在流打算运行之前意外执行流。
此方法有几个好处，包括：

-防止意外执行：通过禁用计划在将来执行的流的立即执行，用户不太可能在流打算运行之前意外运行流。

-改进的可预测性：通过在计划将来执行时将流设置为只读模式，用户可以更轻松地预测流何时运行，并确保他们准备好必要的输入和资源。

-一致的用户体验：通过标准化计划流的行为，它可以跨所有 Flow 实例提供一致且可预测的用户体验。

-要修改或执行计划流程，用户可以编辑流程并更新计划的日期和时间。设置新计划后，流将再次禁用以立即执行并设置为只读模式，直到新计划过去。

## 错误消息

执行运行流时可能出现的错误消息。

### 错误消息：“无效参数 - 找不到与提供的连接引用关联的有效连接。

#### 描述

此错误消息通常表示代码或配置中提供的连接引用存在问题。系统找不到与引用关联的有效连接，这会阻止它执行请求的操作。

#### 原因

此错误消息有几个潜在原因，包括：

-连接引用不正确或无效：提供的连接引用可能无效或不正确，这可能导致系统无法找到与其关联的有效连接。

-连接已删除或更改：如果代码或配置中使用的连接已被删除或修改，则可能导致系统无法找到与引用关联的有效连接。

-权限问题：执行代码或配置的用户帐户可能没有访问连接或与之关联的资源所需的权限。

#### 分辨率

要解决此问题，您可以执行以下步骤：

-验证连接引用：检查代码或配置中提供的连接引用，并确保其有效且正确。

-删除现有连接并重新创建：如果流检查器警告未使用连接引用，则可以使用流检查器删除现有连接。删除连接后，可以重新创建对计算机或计算机组的连接引用，以使流能够运行。

## 笔记

对于当前版本，以下注意事项适用

1.仅显示解决方案中包含的电源自动化桌面和电源自动化解决方案
1.至少注册并执行了一个 Power Automate 桌面

## 安装

要安装控制中心，可以执行以下操作：

1.确保已启用 Power Apps 组件框架<a href="https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">阅读更多</a>
1.您已将创建者工具包安装到目标环境中。<a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">从应用程序源安装</a>
1.您已导入最新的自动化工具包控制中心_*_托管.zip文件使用。<a href='https://learn.microsoft.com/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">阅读更多</a>

## 路线图

您可以访问我们的<a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub 问题</a>以查看建议的新功能。

您可以添加新的<a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">调度程序功能请求</a>

## 反馈

{{<questions name="/content/zh-hans/features/scheduler.json" completed="感谢您提供反馈" showNavigationButtons="false" locale="zh-hans">}}
