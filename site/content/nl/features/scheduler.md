---
title: "Scheduler"
description: "Automatiseringskit - Planner"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B8DC4418FD2312850E01B5DB52344E2BB9B93C2F
---

{{<toc>}}

## Introductie

Met de Automation Kit Scheduler kunt u de planning van terugkerende Power Automate Cloud-stromen in oplossingen bekijken die aanroepen naar Power Automate Desktop-stromen bevatten.

Deze functie is geïntroduceerd als onderdeel van de [februari 2023](/nl/releases/february-2023), Zullen latere releases de functionaliteit van de planner blijven verbeteren en uitbreiden.

{{<border>}}
![Scheduler](/images/schedule.png)
{{</border>}}

De belangrijkste kenmerken van de planner zijn:

- De mogelijkheid om het schema van terugkerende cloudstromen te bekijken
- Bekijk het schema op dag, week, maand en planningsweergave
- De status van geplande stromen weergeven (geslaagd, mislukt of gepland)
- De duur van een Cloud Flow-run weergeven
- Bekijk de details van eventuele fouten.

## Notities

Voor de huidige release zijn de volgende opmerkingen van toepassing

1. Alleen Power Automate Desktop- en Power Automate-oplossingen in een oplossing worden weergegeven
1. Ten minste één Power Automate Desktop is geregistreerd en uitgevoerd

## Installeren

Om de scheduler-oplossing te installeren, kunt u het volgende doen:

1. Zorg voor een Power Apps-onderdeelframework <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Lees meer</a>
1. U hebt de Creator Kit in de doelomgeving geïnstalleerd. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installeren vanuit app-bron</a>
1. U hebt het AutomationKit.zip-bestand gedownload van het gedeelte Activa van de nieuwste <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub-versie</a>
1. U hebt de nieuwste AutomationKitScheduler geïmporteerd_*_beheerd.zip bestand gebruiken. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Lees meer</a>

## Routekaart

U kunt onze <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-problemen</a> om voorgestelde nieuwe functies te bekijken.

U kunt een nieuwe toevoegen <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Scheduler Feature aanvraag</a>

## Terugkoppeling

{{<questions name="/content/nl/features/scheduler.json" completed="Bedankt voor het geven van feedback" showNavigationButtons="false" locale="nl">}}
