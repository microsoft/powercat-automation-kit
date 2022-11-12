---
title: "Gegevenspakketten"
description: "Automatiseringskit - Data packs"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 16D52F35701BF93D5BAB05162D94D9E9866918C6
---

{{<toc>}}

## Introductie

Data Packs zijn voorverpakte gegevenssets die optioneel in uw geïnstalleerde Automation Kit kunnen worden geïnstalleerd om uw gebruik te versnellen.

{{<border>}}
![Overzicht van datapacks](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

Geïntroduceerd als onderdeel van de [mei 2022](/nl/releases/november-2022), Datapacks bieden u de mogelijkheid om optioneel voorbeeldgegevens te importeren.

Met het Return on Investment (ROI)-gegevenspakket kunt u snel de planning, meting en bewaking van het rendement op investering demonstreren via het Power BI-dashboard van de Automation Kit. U kunt uw eerste gegevenspakket laden met behulp van de [Slag](/nl#getting-started) hieronder.

Na verloop van tijd voegen we andere gegevenspakketten toe aan de backlog voor prioritering en documenteren we hoe u kunt samenwerken aan het publiceren van gegevenspakketten aan de community.

## Routekaart

{{<border>}}
![Routekaart voor datapakketten](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

In toekomstige mijlpalen zullen we proberen de datapacks te verbeteren door ze op te nemen als een optioneel onderdeel van het geautomatiseerde installatieproces van de Automation Kit.

De mogelijkheid om datapacks op te nemen als onderdeel van de installatie maakt een webgebaseerde installatie mogelijk, in plaats van het installatieproces op de opdrachtregel voor deze release.

## Return On Investment Hoofdoplossing

Het return on investment (ROI) hoofdpakket van de oplossing omvat automatiseringsprojecten, machines en voorbeeld van Power Automate Desktop-telemetrie, zodat u het end-to-end proces kunt voltooien.

### Slag

Aan de slag met dit gegevenspakket

- Installeer de Creator Kit vanaf [App-bron](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) of via [Meer informatie over de installatiehandleiding](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Installeer de nieuwste versie van de Automation Kit Main vanaf [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) Gebruik [Meer informatie over de installatiehandleiding](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Power Platform Command Line Interface installeren met behulp van [Meer informatie over de installatiehandleiding](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Verificatie voor uw omgeving maken

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Download de **AutomationKit.zip** Van [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Het bestand uitpakken **AutomationKit-SampleData.zip** Van **AutomationKit.zip**

- Importeer de gegevens in uw omgeving

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- Verbind het Power BI-dashboard dat is gedownload met uw omgeving om de geïmporteerde gegevens te verkennen. Gebruiken [Power BI-dashboard installeren](/nl/get-started/install-powerbi-dashboard) voor meer informatie

## Terugkoppeling

{{<questions name="/content/nl/features/datapacks.json" completed="Bedankt voor het geven van feedback" showNavigationButtons="false" locale="nl">}}
