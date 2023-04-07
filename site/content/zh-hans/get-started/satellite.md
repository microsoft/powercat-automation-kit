---
title: "卫星 - 入门"
description: "自动化套件 - 卫星 - 入门"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: 425608BE149AA6D640338A5F34EB704ADDAAAEF5
---

# 概述

欢迎来到卫星解决方案的入门页面。本节介绍 2023 年 4 月及更高版本中所做的重要更改。2023 年 4 月之后，我们不再需要 Azure 密钥保管库来存储 Azure 应用程序租户、应用程序 ID 和 Azure 应用程序机密信息。

## 概念设计

我们的学习页面概述了[概念设计](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design)的 {{<product-name>}}.解决方案的关键要素是主环境Power Platform。

通常有几个卫星生产环境运行您的自动化项目。根据您的环境策略，这些也可能是开发或测试环境。

在这些环境之间有一个近乎实时的同步过程，其中包括云或桌面流遥测、计算机和计算机组使用情况以及审核日志。自动化工具包的 Power BI 仪表板显示此信息。

## 发生了哪些变化

作为解决的一部分[[自动化工具包 - 功能]：用于附属环境的 Azure 密钥保管库替代项](https://github.com/microsoft/powercat-automation-kit/issues/84)不再需要 Azure 密钥保管库。这很重要，因为它显著降低了安装的复杂性，以及在使用自动化解决方案管理器时如何管理安全性以获取解决方案项目。

## 有什么相同之处？

一旦关键元素与 2023 年 4 月之前和 2023 年 4 月之前的旧版本相同，就需要 Azure 活动目录应用程序。

一[应用程序用户](https://learn.microsoft.com/power-platform/admin/manage-application-users) 是Power Platform中的一种用户类型，由系统用户记录中是否存在 ApplicationId 属性来标识。应用程序用户在 Azure Active Directory （Azure AD） 中创建，用于对Power Platform进行身份验证和授权访问。它们通常用于表示需要代表用户或其他应用程序访问数据或在Power Platform中执行操作的应用程序或服务。

具体而言，自动化解决方案管理器使用应用程序用户来查询环境中的解决方案组件，以便使用户能够计量已部署Power Platform解决方案。

## 安装

这[命令行安装](/zh-hans/get-started/install)对于卫星解决方案，将提示您输入 Azure Active Directory 应用程序名称和 Azure Active Directory 应用程序 ID。 使用此信息，它将：

1.将 Azure Active Directory 应用程序添加为应用程序用户
1.将应用程序用户添加到系统管理员角色
1.将应用程序用户的用户 ID 添加到环境变量**解决方案管理器工件读取用户 ID**

新角色数据节角色**自动化解决方案管理器用户**已添加允许用户调用新的 Dataverse GetDataverseSolutionArtifacts 自定义 API，该 API 将使用提供的环境变量查询解决方案工件**解决方案管理器工件读取用户 ID**.

如果您希望手动安装 satelitte 解决方案，则需要对[设置卫星](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/satellite)指示。

1.跳过“添加新客户端密码”步骤，因为 2023 年 4 月或更高版本不再需要此步骤。
1.跳过在 Azure 密钥保管库中创建机密的步骤。
1.将应用程序用户的用户 ID 添加到**解决方案管理器工件读取用户 ID**环境变量。

## 安装后

确保将运行自动化解决方案管理器应用程序的用户被授予**自动化解决方案管理器用户**数据节安全角色。

## 以前的版本

在 2023 年 4 月版本之前，安装卫星解决方案需要 secret 类型的环境变量。这需要[Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview)以存储租户 ID、应用程序 ID 和应用程序机密的值。要使用此功能还需要[先决条件](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#prerequisites)Azure Key Vault 是同一租户，将 Microsoft.PowerPlatform 设置为资源提供程序。

在 2023 年 3 月或更早版本中，Azure 密钥保管库用于存储租户 ID、应用程序 ID 和应用程序机密。使用这些值请求访问令牌来查询 dataverse，以便它可以返回解决方案组件的列表。

## 建议

对于现有用户，建议简化日常管理，并消除将现有附属安装升级到 2023 年 4 月或更高版本以利用新功能的 Azure Key Vault 依赖项的需要。
