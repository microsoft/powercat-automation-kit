---
title: "Pacchetti di dati"
description: "Kit di automazione - Data Packs"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Data', 'Integration']
generated: 5695D0411A1BD909454FF04F1BDDAA7D64578032
---

{{<toc>}}

## Introduzione

I Data Pack sono set preconfezionati di dati che possono essere installati facoltativamente nel kit di automazione installato per accelerare l'utilizzo.

{{<border>}}
![Panoramica dei pacchetti di dati](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

Introdotto nell'ambito del [luglio 2022](/it/releases/november-2022), i Datapack consentono di importare facoltativamente dati di esempio.

Il pacchetto di dati Return on Investment (ROI) consente di dimostrare rapidamente la pianificazione, la misurazione e il monitoraggio del ritorno sull'investimento tramite il dashboard Power BI di Automation Kit. È possibile caricare il primo pacchetto di dati utilizzando il comando [Introduttiva](/it#getting-started) di seguito.

Nel corso del tempo aggiungeremo altri pacchetti di dati al backlog per la definizione delle priorità e documenteremo come collaborare alla pubblicazione dei pacchetti di dati nella community.

## Cartina stradale

{{<border>}}
![Roadmap dei pacchetti di dati](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

Nelle tappe future cercheremo di migliorare i datapack includendoli come parte opzionale del processo di installazione automatizzata dell'Automation Kit.

La possibilità di includere Data Pack come parte dell'installazione consentirà un'installazione basata sul Web, anziché il processo di installazione dalla riga di comando per questa versione.

## Soluzione principale per il ritorno sull'investimento

Il pacchetto di dati della soluzione principale di ritorno sull'investimento (ROI) include progetti di automazione, macchine e telemetria Power Automate Desktop di esempio in modo da poter acquisire familiarità con il processo end-to-end.

### Introduttiva

Per iniziare a utilizzare questo pacchetto di dati

- Installa il Creator Kit da [Origine app](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) o tramite [Scopri la guida alla configurazione](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Installare la versione più recente di Automation Kit Main da [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) Utilizzando [Scopri la guida alla configurazione](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Installare Power Platform interfaccia della riga di comando utilizzando [Scopri la guida alla configurazione](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Creare l'autenticazione per l'ambiente

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Scarica il **Kit di automazione.zip** Da [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Estrarre il file **AutomationKit-SampleData.zip** Da **Kit di automazione.zip**

- Importare i dati nell'ambiente

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- Connetti il dashboard di Power BI scaricato dall'ambiente per esplorare i dati importati. Usare [Installare il dashboard di Power BI](/it/get-started/install-powerbi-dashboard) per maggiori informazioni

## Valutazione

{{<questions name="/content/it/features/datapacks.json" completed="Grazie per aver fornito feedback" showNavigationButtons="false" locale="it">}}
