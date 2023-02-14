---
title: "Scheduler"
description: "Automation Kit - Schemaläggare"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B8DC4418FD2312850E01B5DB52344E2BB9B93C2F
---

{{<toc>}}

## Införandet

Med Automation Kit Scheduler kan du visa schemat för återkommande Power Automate Cloud-flöden i lösningar som innehåller anrop till Power Automate Desktop-flöden.

Denna funktion introducerades som en del av [Februari 2023](/sv/releases/february-2023)kommer senare versioner att fortsätta att förbättra och utöka schemaläggarens funktionalitet.

{{<border>}}
![Scheduler](/images/schedule.png)
{{</border>}}

De viktigaste funktionerna i schemaläggaren är:

- Möjligheten att visa schemat för återkommande molnflöden
- Visa schema efter dag-, vecko-, månads- och schemavy
- Visa status för Schemalagda flöden (Lyckades, Misslyckades eller Schemalagd)
- Visa varaktigheten för en Cloud Flow-körning
- Visa detaljerna eventuella fel.

## Anteckningar

För den aktuella versionen gäller följande information

1. Endast Power Automate Desktop- och Power Automate-lösningar som ingår i en lösning visas
1. Minst en Power Automate Desktop har registrerats och körts

## Installera

För att installera schemaläggningslösningen kan du göra följande:

1. Se till att Power Apps komponentramverk <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Läs mer</a>
1. Du har installerat Creator Kit i målmiljön. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installera från appkällan</a>
1. Du har laddat ned filen AutomationKit.zip från avsnittet Tillgångar i den senaste <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub-versionen</a>
1. Du har importerat den senaste AutomationKitScheduler_*_hanterad.zip fil med. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Läs mer</a>

## Färdplan

Du kan besöka vår <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-problem</a> för att visa föreslagna nya funktioner.

Du kan lägga till en ny <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Begäran om schemaläggningsfunktion</a>

## Feedback

{{<questions name="/content/sv/features/scheduler.json" completed="Tack för att du ger feedback" showNavigationButtons="false" locale="sv">}}
