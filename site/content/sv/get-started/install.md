---
title: "Installera"
description: "Automation Kit - Installera"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 458A6A6E57855817B73D18C0F0A5855DDAFC40DE
---

Om du vill installera den senaste versionen av Automation Kit använder du följande steg nedan. Om du inte kan använda kommandoradsverktygen kan du använda de manuella stegen som dokumenteras i [Vägledning för installation](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. Se till att du har <a ref='https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">Aktivera funktionen Power Apps component framework</a> i de miljöer som du vill installera Automation Kit för både huvud- och satellitmiljöer.

1. Se till att <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">Creator Kit installerat</a> i de miljöer du vill installera i

1. Öppna den senaste versionen från <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Automation Kit GitHub-versioner</a>

1. Ladda ner den **AutomationKitInstall.zip** från avsnittet Tillgångar

1. I Utforskaren i Windows väljer du den nedladdade **AutomationKitInstall.zip** och öppna egenskapsdialogrutan

1. Välj ikonen **Avblockera** knapp

1. Utvald **AutomationKitInstall.zip** och använd snabbmenyn för att **Extrahera alla**

1. Se till att du har <a href="https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> installerad

1. Kör powershell-skriptet med följande kommandorad

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

NOT:
1. Beroende på din PowerShell-körningsprincip kan du behöva köra följande kommando

```cmd
Unblock-File Install_AutomationKit.ps1
```

1. PowerShell-skriptet uppmanar dig att skapa en installationskonfigurationsfil med hjälp av [Installera installationsprogrammet](/sv/get-started/setup). Konfigurationssidorna för konfiguration ger dig följande

    - Välj konfiguration för huvud- eller satellitlösningar
   
    - Välj användare att tilldela till säkerhetsgrupper
   
    - Skapa anslutningar som krävs för att installera lösningen
    
    - Definiera miljövariabler
    
    - Du kan också definiera om exempeldata ska importeras
    
    - Du kan också aktivera Power Automate-flöden som finns i lösningarna ska vara aktiverade

1. När du har slutfört installationen kopierar du **automation-kit-main-install.json** eller **automation-kit-satellite-install.json** fil till **AutomationKitInstallera** mappen ovan

1. När filen har laddats ner kommer skriptet att fråga efter **y** för att installera huvudlösningen, **n** för att installera satellitlösning

1. Installationen laddar sedan upp och startar installationen med de definierade inställningarna

## Feedback

Vill ge feedback på [installationsprocessen](/sv/get-started/setup)? Frågorna nedan hjälper oss att förbättra processen.

{{<questions name="/content/sv/get-started/setup-feedback.json" completed="Tack för att du ger feedback" showNavigationButtons=true locale="sv">}}
