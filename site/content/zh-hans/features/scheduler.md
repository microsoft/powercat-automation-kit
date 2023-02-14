---
title: "调度"
description: "自动化套件 - 调度程序"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B8DC4418FD2312850E01B5DB52344E2BB9B93C2F
---

{{<toc>}}

## 介绍

自动化工具包计划程序允许查看解决方案中重复的 Power Automate Cloud 流的计划，其中包括对 Power Automate 桌面流的调用。

此功能是作为[2023 年 2 月](/zh-hans/releases/february-2023)，以后的版本将继续改进和增长调度程序的功能。

{{<border>}}
![调度](/images/schedule.png)
{{</border>}}

调度程序的主要功能包括：

-能够查看定期云端流的计划
-按天、周、月和计划视图查看计划
-查看计划流的状态（成功、失败或计划）
-查看云端流运行的持续时间
-查看任何错误的详细信息。

## 笔记

对于当前版本，以下注意事项适用

1.仅显示解决方案中包含的电源自动化桌面和电源自动化解决方案
1.至少注册并执行了一个 Power Automate 桌面

## 安装

要安装调度程序解决方案，您可以执行以下操作：

1.确保 Power Apps 组件框架<a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">阅读更多</a>
1.您已将创建者工具包安装到目标环境中。<a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">从应用程序源安装</a>
1.您已从最新的资产部分下载了 AutomationKit.zip 文件<a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub 发布</a>
1.您已导入最新的自动化工具包调度程序_*_托管.zip文件使用。<a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">阅读更多</a>

## 路线图

您可以访问我们的<a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub 问题</a>以查看建议的新功能。

您可以添加新的<a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">调度程序功能请求</a>

## 反馈

{{<questions name="/content/zh-hans/features/scheduler.json" completed="感谢您提供反馈" showNavigationButtons="false" locale="zh-hans">}}
