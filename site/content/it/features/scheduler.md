---
title: "Pianificazione"
description: "Kit di automazione - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 00B15DA73732A60B73A09229CEF9B843E259A121
---

{{<toc>}}

## Introduzione

L'Automation Kit Scheduler consente di visualizzare la pianificazione dei flussi ricorrenti di Power Automate Cloud all'interno delle soluzioni che includono chiamate ai flussi Power Automate Desktop.

Questa funzionalità è stata introdotta come parte del [febbraio 2023](/it/releases/february-2023), le versioni successive continueranno a migliorare e far crescere la funzionalità dell'utilità di pianificazione.

{{<border>}}
![Pianificazione](/images/schedule.png)
{{</border>}}

Le caratteristiche principali dello scheduler sono:

- La possibilità di visualizzare la pianificazione dei flussi cloud ricorrenti
- Visualizza la pianificazione per giorno, settimana, mese e visualizzazione pianificazione
- Visualizzare lo stato dei flussi pianificati (operazione riuscita, non riuscita o pianificata)
- Visualizzare la durata di un'esecuzione di Cloud Flow
- Visualizzare i dettagli di eventuali errori.

## Note

Per la versione corrente si applicano le seguenti note

1. Vengono visualizzate solo le soluzioni Power Automate Desktop e Power Automate contenute in una soluzione
1. Almeno un Power Automate Desktop è stato registrato ed eseguito

## Installare

Per installare la soluzione di pianificazione è possibile eseguire le operazioni seguenti:

1. Garantire il framework dei componenti Power Apps <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Per saperne di più</a>
1. Hai installato il Creator Kit nell'ambiente di destinazione. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installazione da origine app</a>
1. Hai scaricato il file AutomationKit.zip dalla sezione Risorse dell'ultima <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Versione di GitHub</a>
1. È stata importata la versione più recente di AutomationKitScheduler_*_gestito.zip file utilizzando. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Per saperne di più</a>

## Cartina stradale

Puoi visitare il nostro <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">Problemi di GitHub</a> per visualizzare le nuove funzionalità proposte.

È possibile aggiungere un nuovo <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Richiesta di funzionalità dell'utilità di pianificazione</a>

## Valutazione

{{<questions name="/content/it/features/scheduler.json" completed="Grazie per aver fornito feedback" showNavigationButtons="false" locale="it">}}
