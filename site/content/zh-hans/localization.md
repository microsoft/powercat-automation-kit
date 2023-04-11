---
title: "地方化"
description: "自动化套件 - 本地化"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Localization']
generated: B663DBE982197FB3ECF0CBA5F0324E4044487914
---

**地位：**{{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} 进行中的工作 - 实验性

{{<toc>}}

## 使用本地化促进自动化工具包的包容性和多样性

{{<border>}}

![自动化套件本地化](/images/automation-kit-localization.png)

{{</border>}}

估计由[联合国](https://hr.un.org/unhq/languages/english)15亿人说英语。然而，鉴于世界人口估计[80亿](https://www.un.org/en/desa/world-population-reach-8-billion-15-november-2022)到 2022 年 11 月，这显然需要支持其他语言。

默认情况下，Power Platform自动化工具包团队使用美国英语，适用于不属于 Microsoft Learn 平台的内容。为了帮助迎合非英语人士的需求，我们正在尝试一种自动化流程，该流程可以转换属于我们自动化入门体验一部分的内容。使用这种方法，我们的目标是扩展到更广泛的社区。

作为一个团队，帮助我们的是获得[反馈](/zh-hans#provide-feedback)来自我们的用户社区，了解本地化对您的重要性。虽然这种方法不能取代专业的翻译流程，但我们欢迎您对本地化为您提供入门和使用自动化工具包的体验提供任何反馈。我们期待看到我们如何在试验和不断改进时支持更广泛、更多样化的体验。

我们的目标是利用这些知识，并将其应用于我们作为工具包的一部分生产的仪表板和应用程序。使用自动翻译流程将使我们能够生成您可以导入到您的组织中的内容，以便您可以支持和培养全球自动化项目的多语言采用。

## 目标

{{<product-name>}} 是通过内容的本地化来支持包容性。要实现此目标，适用以下条件：

-托管在 上的内容[入门网站](https://aka.ms/ak4pp/starter)通过 Azure 认知服务和自定义映射提供自动转换。

-核心初学者网站内容团队将在 en-us 中工作，并将内容转换为以下语言：

  - [丹麦语](https://microsoft.github.io/powercat-automation-kit/da/)
  - [荷兰语](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [法语](https://microsoft.github.io/powercat-automation-kit/fr/)
  - [德语](https://microsoft.github.io/powercat-automation-kit/de/) 
  - [意大利语](https://microsoft.github.io/powercat-automation-kit/it/)
  - [朝鲜语](https://microsoft.github.io/powercat-automation-kit/ko/)
  - [日语](https://microsoft.github.io/powercat-automation-kit/ja/)
  - [挪威语](https://microsoft.github.io/powercat-automation-kit/nb/)
  - [波兰语](https://microsoft.github.io/powercat-automation-kit/pl/)
  - [简体中文](https://microsoft.github.io/powercat-automation-kit/zh-hans)
  - [西班牙语](https://microsoft.github.io/powercat-automation-kit/es/)
  - [瑞典语](https://microsoft.github.io/powercat-automation-kit/sv/)

-提供反馈机制，以便随着时间的推移改进自动生成的内容。

-尽早解决本地化问题，以便在内容移动到[了解自动化 CoE 内容](https://aka.ms/AutomationCoE)内容已经以本地化格式提供。

-使用从初学者网站内容中学到的知识来改进其他工具包资产，例如仪表板模板报告或应用程序。

-允许使用“众包”贡献模型，从而改进语言转换。

-使用所学知识为自动化工具包提供可导入到组织中的特定于语言的“通信中心”内容。

## 当前状态

-尚未实施美式英语到英式英语支持

-上述试用语言上下文的默认值现成 Azure 认知服务文本翻译

## 路线图

我们计划将这些学习应用到我们使用的 Power BI 仪表板和 Power Apps，以便我们作为一个团队可以通过反馈循环扩展到自动翻译，从而使我们能够随着时间的推移提供更广泛的多语言覆盖范围。

您可以在我们的[GitHub 网站](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aopen+is%3Aissue+label%3Alocalization).

## 问与答

### **问题：**本地化内容是否经过专业翻译？

否，默认内容以美国英语创建，并使用 Azure 认知服务和映射术语自动翻译成其他语言。

### **问题：**如何改进我的语言翻译？

请考虑提供反馈或贡献，以帮助我们改进您的本地化语言版本。

### **问题：**与微软学习内容有什么关系？

初学者网站内容由 {{<product-name>}} 仅限团队和贡献者。当内容迁移到 Microsoft Learn 平台时，它会经过单独的内容审查和本地化过程。

### **问题：**可以添加其他语言吗？

是，如果该语言支持[Azure 认知服务语言支持](https://learn.microsoft.com/azure/cognitive-services/language-support)然后可以添加它。

## 提供反馈

对本地化流程提供哪些反馈？

{{<questions name="/content/zh-hans/localization.json" completed="感谢您完成问题" showNavigationButtons="false" locale="zh-hans">}}
