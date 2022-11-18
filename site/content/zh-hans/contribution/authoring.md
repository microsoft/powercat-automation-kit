---
title: "创作准则"
description: "自动化工具包 - 文档创作指南"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Documentation', 'Guidelines']
generated: ED14A36CD731A55AE5FC328528A10CB645825C47
---

以下各节概述了创作初学者文档的准则和说明。

{{<toc>}}

## 指引

以下各节概述了创作贡献的技术、设计和基于结果的准则

## 目标

在我们构建文档时，重要的是要考虑我们如何使读者能够**掉进成功的深渊**.

布拉德·艾布拉姆斯定义[2003年的成功之坑](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/)如

> 成功之坑：与山顶、山峰或穿越沙漠的旅程形成鲜明对比，通过多次考验找到胜利
> 和惊喜，我们希望我们的客户简单地陷入成功的实践
> 通过使用我们的平台和框架。在某种程度上，我们很容易陷入麻烦，我们失败了。

鉴于此目标，请考虑以下事项：

-提供“无悬崖体验”

  -帮助管理员和中心治理团队创建使用 {{<product-name>}}

  -允许用户在中央环境不可用并且他们希望在 {{ 的测试或生产部署之前使用开发环境来动手操作<product-name>}}

  -讨论试用环境的用法，轻松设置以动手使用 {{<product-name>}}

-提供反馈渠道。为客户提供选项，以就我们可以改进的地方提供意见

### 源代码管理

-您已完成[文档](/zh-hans/contribution/documentation)下载更改并将其推送到 GitHub 存储库的步骤
-新更改将推送到新分支，并具有拉取请求以查看更改
-所有文档都应该是 markdown、JSon 或静态资产，这些资产可以是版本控制并使用标准拉取请求流程进行审查

## 设计指南

### 主页

-有清晰的标题和副标题，概述入门体验的目标
-提供号召性用语以包含其他相关事件。例如，注册办公时间。
-链接到入门操作，作为帮助新用户加入的主要操作
-加入办公时间的次要操作，以帮助建立用户社区
-包括常见操作的磁贴
-帮助用户管理超自动化项目的功能摘要列表
-常见链接的页脚导航。

阅读[站点配置](/zh-hans/contribution/site-configuration)有关配置主页的详细信息。

### 再使用

-使用 hugo 布局，通过将内容放置在 site\layouts 文件夹中来指定新主题或覆盖当前主题
-更改布局应允许将静态 HTML 包含在许多托管位置中。例如

  -GitHub 页面
  -电源页面
  -分享点
  -Azure Static Sites

-该方法可由合作伙伴或客户用作模板，以构建“文档包”以加速 {{<product-name>}} 文档
-为文档的多个用户（例如，客户和合作伙伴卓越中心团队）提供功能。
-允许包含用户提供的内容
-允许允许从 {{ 中提取新更改的升级过程<product-name>}} 入门文档

## 降价页面

-您可以使用[视觉工作室代码](https://code.visualstudio.com/)编辑降价文件

-降价文件应位于 /site/content 文件夹中

-每个降价文件应在每页上包含通用标题

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

-Markdown 文件应该使用短代码来嵌入任何 JavaScript

## 简码

短代码提供了在降价页面中包含动态内容的功能。您可以从[雨果简码文档](https://gohugo.io/content-management/shortcodes/)

该项目还包括其他短代码

### 目录

添加**目录**遵循 Markdown 的简码，以在页面中包含 Markdown 标题的目录，周围环绕着\{\{ 和\}\}

```html
<toc/>
```

### 问题

在页面中包含一组问题，周围环绕着\{\{ 和\}\}

```html
<questions name="/content/en-us/foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

参数：

- **名字**包含要导入的问题的 JSon 文件的名称。读[问题](/zh-hans/contribution/questions)有关问题文件格式的更多信息
- **完成**完成问题时要显示的文本
- **显示导航按钮**鞋的真/假值 下一个/返回/已完成的导航按钮

### 外部图像

在页面中包含来自外部来源的尺寸图像，周围环绕着\{\{ 和\}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

参数：

- **来源**要导入的图像的源路径
- **大小**要将源图像大小调整为的大小（以像素为单位）
- **发短信**要包含在图像中的替换文本

## 笔记

### GitHub 页面设置

以下步骤用于为网站设置 GitHub 页面

1.在 git 中创建新的孤立分支

    ```bash
    git checkout --orphan gh-pages
    ```

1.清除现有内容（文件和文件夹）

    ```bash
    git clean -d -f
    ```

1.雨果已安装

    -您也可以在窗户上安装巧克力
 
    ```bash
    choco install hugo-extended -confirm
    ```

1.雨果输出配置为输出到 /docs 文件夹

1.测试更改

    ```bash
    hugo serve
    ```

1.要在站点文件夹中构建静态 html 站点，请运行以下命令

    ```bash  
    hugo
    ```
 
1.将你的 gh-pages 分支推送到 GitHub

1.设置 GitHub 项目以启用页面

    -请参阅为 GitHub 页面网站配置发布源 - GitHub 文档
    -选定的 gh-pages 分支和 /docs 文件夹

### 更新主页图像徽章

若要将主页图像自定义为“状态：公共预览版”徽章，我执行以下操作：

1.克隆 svg 徽章存储库

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1.安装模块

    ```bash
    npm install
    ```

1.启动 Web 服务器以生成徽章

    ```bash
    npm run start
    ```

1.生成徽章

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1.下载 svg 徽章

1.使用 inkscape 编辑现有 svg 并保存结果

1.将新图像上传到静态\图像\插图文件夹

1.更改 config.yaml 主映像

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## 问与答

### **问题**雨果为什么被选中？

[雨 果](https://gohugo.io/)是一个流行的静态站点生成器，允许 {{<product-name>}} 启动器文档要转换为可托管在 GitHub 页面中的静态 HTML

### **问题**为什么你没有选择其他静态站点生成器？

Power CAT 核心团队之前有使用 Hugo 的经验

### **问题**为什么微软表单不用于提问？

一个设计目标是将问题过程直接整合到内容中。

### **问题**为什么要使用 GitHub 页面来托管内容？

{{<product-name>}} 已经存在于 GitHub 上，原生 GitHub 页面支持是托管内容位置的一种选择。

### **问题**为什么此内容未打开[http://learn.microsoft.com]()?

-随着内容成熟到通常可重用的指南，它可能会迁移到[https://learn.microsoft.com]()

-GitHub 托管实现了关键设计目标

   -允许积极的社区贡献
   
   -促进卓越中心的发展流程，以便客户和合作伙伴社区可以重复使用文档

### **问题**为什么该方法不适用于其他 Power CAT 项目？

该 {{<product-name>}} 正在尝试使用这个文档渠道来补充并链接到我们现有的[学习内容](https://aka.ms/automation-kit-learn).根据此实验的反馈和结果，我们将评估其他 Power CAT 管理的项目是否会采用类似的方法。

### **问题**如何查看未解决的文档问题？

您可以访问我们的[未解决的文档问题](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation)页

### **问题**如何提出新的文档功能请求？

创建一个新的[功能请求](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
