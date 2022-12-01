---
title: "创作问题"
description: "自动化工具包 - 创作问题"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 2FDE38C6576920DE548EFE209151F9776EB47B41
---

此页面包含用于创作交互式问题的格式的信息，这些问题作为 {{ 的一部分包含在<product-name>}} 启动器。

{{<toc>}}

## 开始

工具包入门页面中使用的问题基于[开源调查 JS 库](https://github.com/surveyjs/survey-library).使用此库允许使用支持的所有现成控件。

要了解框架，您可以查看

-这[调查 JS 文档](https://surveyjs.io/form-library/documentation/overview)

-简单的问题类型，例如[发短信](https://surveyjs.io/form-library/examples/questiontype-text/reactjs),[无线电组](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs),[复选框](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs)或[排名](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

-使用条件可见性[可见如果](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

-查看网站中使用的一些现有问题。例如[监控问题](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

-查看如何在内容标记中包含短代码。例如[监控降价](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## 在内容中嵌入问题

要在页面中嵌入一组问题，您可以将以下内容添加到您的 markdown 中，并将名称更改为您要从中阅读的问题文件

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

该 {{<product-name>}} 还包括一些可以在表达式中使用的附加函数。

### 莱恩

len 函数返回字符串或数组的长度

#### len 示例

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### 包含

如果字符串或字符串数组与提供的值匹配，则包含函数返回 true 或 false

#### 包含示例

如果所选角色之一是 maker 将使元素可见

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

如果所选角色之一是制作者或架构师，将使元素可见

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## 自定义小部件

### 图像任务

该 {{<product-name>}} 还包括**图像任务**自定义小部件。可以使用以下 json 代码段将此小组件包含在您的问题元素中。

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### 性能

- **标题**- 要向用户显示的文本
- **类型**- 必须是图像任务
- **来源**- 要渲染的 SVG 文件的网址

#### 工作原理

源 svg 文件支持 svg 文件中元素的以下自定义超链接链接

- **template://item/selected**- 将定义对象的格式以设置图像中的选定格式
- **template://item/unselected**- 将定义对象的格式以设置图像中项目的未选择格式

超链接为 question:// 的可视元素将用于设置或取消设置问题集中的值数组。此功能提供了以交互方式更改向用户显示其他问题的方式的能力。例如，如果 svg 文件有两个具有以下超链接的对象：

- **question://roles/maker**
- **question://roles/architect**

如果用户选择这些对象，则可以显示页面上的其他元素，例如

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

超链接为 option:// 的可视元素将用于设置选项集或单值问题的值。例如，如果 svg 文件有两个具有以下超链接的对象：

- **option://type/A**
- **option://type/B**

```json
{
    "type": "html",
    "html": "Type A has been selected",
    "visibleIf": "{type} == 'A'"
}
```

## 问与答

### **问题**为什么使用这种方法而不是Microsoft Forms？

问题简码的使用允许问题成为每个内容页面的一部分，而不是单独的链接。

### **问题**这种方法有什么优点？

此方法的以下优点包括

-使用开箱即用的问题类型的能力

-问题的创建是配置驱动的，只需要JSon的知识来构建问题

-问题框架是可扩展的，允许添加新函数或小部件

-将 JSon 用于问题定义允许将问题存储在源代码管理中，并随着时间的推移进行审查和版本控制

### **问题**是否可以在 Power App 或 Power Page 中使用此方法？

当然，可以通过创建一个[代码组件](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **问题**如何创作 SVG 图像任务问题？

创建 svg 文件的一个选项是[微软视觉](https://www.microsoft.com/microsoft-365/visio/)哪个 wll 将图表导出到具有与**图像任务**问题。

### **问题**我可以使用 Microsoft PowerPoint 导出图像任务问题 SVG 文件吗？

虽然Microsoft Power Point可以将幻灯片导出到SVG文件初始测试鞋，但它不会导出进行交互式所需的超链接**图像任务**工作成功。

### **问题**我导出的 SVG 文件很大，我可以使它们变小吗？

SVG 文件的一个选项是在将它们提交到源代码管理之前使它们更小。有多种工具可用于缩小 SVG 的大小，可以考虑的一种选择是[SVGO](https://github.com/svg/svgo)一个基于 NodeJs 的 SVG 优化器。
