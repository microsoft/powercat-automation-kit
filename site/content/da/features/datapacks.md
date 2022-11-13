---
title: "Datapakker"
description: "Automatiseringssæt - Datapakker"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 59DCC2AA961720CBEBCC57AD3C8C2B774F7B3FD1
---

{{<toc>}}

## Indførelsen

Data Packs er færdigpakkede datasæt, der valgfrit kan installeres i dit installerede automatiseringssæt for at fremskynde din brug.

{{<border>}}
![Oversigt over datapakker](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

Indført som en del af [Marts 2022](/da/releases/november-2022), Datapacks giver dig mulighed for eventuelt at importere eksempeldata.

Datapakken Return on Investment (ROI) giver dig mulighed for hurtigt at demonstrere planlægning, måling og overvågning af investeringsafkast via Automation Kit Power BI-dashboardet. Du kan indlæse din første datapakke ved hjælp af [Introduktion](/da#getting-started) afsnit nedenfor.

Overarbejde tilføjer vi andre datapakker til efterslæbet for prioritering og dokumenterer, hvordan du kan samarbejde om at udgive datapakker til fællesskabet.

## Køreplan

{{<border>}}
![Køreplan for datapakker](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

I fremtidige milepæle vil vi forsøge at forbedre datapakkerne ved at inkludere dem som en valgfri del af den automatiserede installationsproces Automation Kit.

Muligheden for at medtage Data Packs som en del af installationen giver mulighed for en webbaseret installation i stedet for kommandolinjeinstallationsprocessen for denne version.

## Investeringsafkast hovedløsning

Return on Investment (ROI)-hovedløsningsdatapakken indeholder automatiseringsprojekter, maskiner og Power Automate Desktop-eksempeltelemetri, så du kan få fat i processen fra start til slut.

### Introduktion

Sådan kommer du i gang med denne datapakke

- Installer skabersættet fra [App Kilde](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) eller via [Få mere at vide om opsætningsvejledning](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Installer den nyeste version af Automation Kit Main fra [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) Bruge [Få mere at vide om opsætningsvejledning](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Installer Power Platform-kommandolinjegrænsefladen ved hjælp af [Få mere at vide om opsætningsvejledning](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Opret godkendelse til dit miljø

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Download **AutomationKit.zip** fra [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Uddrag filen **AutomationKit-SampleData.zip** fra **AutomationKit.zip**

- Importer dataene til dit miljø

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- Opret forbindelse mellem det Power BI Dashboard, der er hentet fra, med dit miljø for at udforske de importerede data. Brug [Installer Power BI Dashboard](/da/get-started/install-powerbi-dashboard) Yderligere oplysninger

## Feedback

{{<questions name="/content/da/features/datapacks.json" completed="Tak, fordi du gav feedback" showNavigationButtons="false" locale="da">}}
