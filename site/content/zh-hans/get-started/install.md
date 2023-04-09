---
title: "命令行安装"
description: "自动化套件 - 安装"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: BBA164EE25537E568BEC4EE4FC9CAA168C26E18B
---

要使用命令行安装最新版本的自动化工具包，可以使用以下步骤。如果无法使用命令行工具，可以使用中记录的手动步骤[设置指南](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1.确保您有<a ref='https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">启用 Power Apps 组件框架功能</a>在要为主环境和从属环境安装自动化工具包的环境中。

1.确保<a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">已安装创建者工具包</a>到您要安装到的环境中

1.从<a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">自动化工具包 GitHub 发布</a>

1.下载**自动化套件安装.zip**从“资产”部分

1.在 Windows 资源管理器中，选择下载的**自动化套件安装.zip**，然后打开属性对话框

1.选择**疏通**按钮

1.选择**自动化套件安装.zip**并使用上下文菜单**全部提取**

1.确保您拥有<a href="https://learn.microsoft.com/power-platform/developer/cli/introduction" target="_blank">Power Platform命令行界面</a>安装

1.使用以下命令行执行 powershell 脚本

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

注意：
1.根据 PowerShell 执行策略，可能需要运行以下命令

```cmd
Unblock-File Install_AutomationKit.ps1
```

1.PowerShell 脚本将提示您使用[安装安装程序](/zh-hans/get-started/setup).设置配置页面将为您提供以下内容

    -选择主解决方案或卫星解决方案的配置
   
    -选择要分配给安全组的用户
   
    -创建安装解决方案所需的连接
    
    -定义环境变量
    
    -（可选）定义是否应导入示例数据
    
    -（可选）启用电源自动化 应启用解决方案中包含的流

1.完成网站设置步骤后，您可以复制下载的内容**automation-kit-main-install.json**或**automation-kit-satellite-install.json**文件到**自动化套件安装**上面的文件夹

1.下载文件后，脚本将提示**y**要安装主解决方案，**n**安装卫星解决方案

1.然后，安装将使用定义的设置上传开始安装

## 反馈

想要提供有关[设置过程](/zh-hans/get-started/setup)?以下问题有助于我们改进流程。

{{<questions name="/content/zh-hans/get-started/setup-feedback.json" completed="感谢您提供反馈" showNavigationButtons="false" locale="zh-hans">}}
