---
title: "Datapaket"
description: "Automation Kit - Datapaket"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Data', 'Integration']
generated: 5695D0411A1BD909454FF04F1BDDAA7D64578032
---

{{<toc>}}

## Införandet

Datapaket är en förpaketerad uppsättning data som kan installeras i ditt installerade Automation Kit för att påskynda användningen.

{{<border>}}
![Översikt över datapaket](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

Infördes som en del av [November 2022](/sv/releases/november-2022)ger Datapacks dig möjlighet att eventuellt importera exempeldata.

Med ROI-datapaketet (Return on Investment) kan du snabbt demonstrera planering, mätning och övervakning av avkastning på investeringen via Automation Kit Power BI-instrumentpanelen. Du kan läsa in ditt första datapaket med hjälp av [Komma igång](/sv#getting-started) nedan.

Övertid lägger vi till andra datapaket i eftersläpningen för prioritering och dokumenterar hur du kan samarbeta för att publicera datapaket till communityn.

## Färdplan

{{<border>}}
![Översikt över datapaket](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

I framtida milstolpar kommer vi att försöka förbättra datapaketen genom att inkludera dem som en valfri del av Automation Kit automatiserade installationsprocessen.

Möjligheten att inkludera datapaket som en del av installationen möjliggör en webbaserad installation i stället för kommandoradsinstallationsprocessen för den här versionen.

## Avkastning på investeringens huvudlösning

Huvudlösningsdatapaketet för avkastning på investeringar (ROI) innehåller automatiseringsprojekt, datorer och Power Automate Desktop-telemetri så att du kan komma igång med processen från början till slut.

### Komma igång

Så här kommer du igång med det här datapaketet

- Installera Creator Kit från [Appens källa](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) eller via [Läs mer om installationsguiden](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Installera den senaste versionen av Automation Kit Main från [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) användande [Läs mer om installationsguiden](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Installera Power Platform kommandoradsgränssnitt med [Läs mer om installationsguiden](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Skapa autentisering till din miljö

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Ladda ner den **AutomationKit.zip** från [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Extrahera filen **AutomationKit-SampleData.zip** från **AutomationKit.zip**

- Importera data till din miljö

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- Anslut Power BI-instrumentpanelen som laddats ned från din miljö för att utforska importerade data. Använda [Installera Power BI-instrumentpanelen](/sv/get-started/install-powerbi-dashboard) för mer information

## Feedback

{{<questions name="/content/sv/features/datapacks.json" completed="Tack för att du ger feedback" showNavigationButtons="false" locale="sv">}}
