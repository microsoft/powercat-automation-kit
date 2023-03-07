---
title: "Pianificazione"
description: "Kit di automazione - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B97833AB30777C813B3E62592D32D7E5B882ACEE
---

{{<toc>}}

## Introduzione

L'Automation Kit Scheduler consente di visualizzare la pianificazione dei flussi ricorrenti di Power Automate Cloud all'interno delle soluzioni che includono chiamate ai flussi Power Automate Desktop.

Questa funzionalità è stata aggiornata come parte del [aprile 2023](/it/releases/march-2023), le versioni successive continueranno a migliorare e far crescere la funzionalità dell'utilità di pianificazione.

{{<border>}}
![Pianificazione](/images/schedule.png)
{{</border>}}

Le caratteristiche principali dello scheduler sono:

- La possibilità di visualizzare la pianificazione dei flussi cloud ricorrenti
- Filtrare la pianificazione per macchina e gruppi di macchine
- Eseguire un flusso di Power Automate Desktop
- Visualizza la pianificazione per giorno, settimana, mese e visualizzazione pianificazione
- Visualizzare lo stato dei flussi pianificati (operazione riuscita, non riuscita o pianificata)
- Visualizzare la durata di un'esecuzione di Cloud Flow
- Visualizzare i dettagli di eventuali errori.

## Esegui flusso

### Comportamento di sola lettura dei flussi pianificati

Per impostazione predefinita, quando un flusso è pianificato per l'esecuzione futura, viene impostato sulla modalità di sola lettura e disabilitato per l'esecuzione immediata. Ciò significa che gli utenti non possono modificare o eseguire il flusso fino a quando non sono trascorsi la data e l'ora pianificate. Questo comportamento è progettato per fornire una migliore esperienza utente e impedire l'esecuzione accidentale dei flussi prima che siano destinati all'esecuzione.
Ci sono diversi vantaggi di questo approccio, tra cui:

- Prevenzione dell'esecuzione accidentale: disabilitando l'esecuzione immediata dei flussi pianificati per l'esecuzione futura, è meno probabile che gli utenti eseguano accidentalmente un flusso prima che sia previsto per l'esecuzione.

- Maggiore prevedibilità: impostando i flussi in modalità di sola lettura quando sono pianificati per l'esecuzione futura, gli utenti possono prevedere più facilmente quando verranno eseguiti i flussi e assicurarsi di avere gli input e le risorse necessari pronti.

- Esperienza utente coerente: standardizzando il comportamento dei flussi pianificati, può fornire un'esperienza utente coerente e prevedibile in tutte le istanze di Flow.

- Per modificare o eseguire un flusso pianificato, gli utenti possono modificare il flusso e aggiornare la data e l'ora pianificate. Una volta impostata la nuova pianificazione, il flusso verrà nuovamente disabilitato per l'esecuzione immediata e impostato in modalità di sola lettura fino al superamento della nuova pianificazione.

## Messaggi di errore

Possibili messaggi di errore che potrebbero verificarsi durante l'esecuzione del flusso di esecuzione.

### Messaggio di errore: "InvalidArgument - Impossibile trovare una connessione valida associata al riferimento di connessione fornito."

#### Descrizione

Questo messaggio di errore indica in genere che si è verificato un problema con il riferimento di connessione fornito nel codice o nella configurazione. Il sistema non è in grado di individuare una connessione valida associata al riferimento, il che impedisce l'esecuzione dell'azione richiesta.

#### Cause

Esistono diverse cause potenziali per questo messaggio di errore, tra cui:

- Riferimento di connessione errato o non valido: il riferimento di connessione fornito potrebbe essere non valido o errato, il che può impedire al sistema di individuare una connessione valida associata.

- Connessione eliminata o modificata: se la connessione utilizzata nel codice o nella configurazione è stata eliminata o modificata, il sistema può impedire al sistema di individuare una connessione valida associata al riferimento.

- Problema di autorizzazioni: l'account utente che esegue il codice o la configurazione potrebbe non disporre delle autorizzazioni necessarie per accedere alla connessione o alle risorse ad essa associate.

#### Risoluzione

Per risolvere il problema, è possibile effettuare le seguenti operazioni:

- Verificare il riferimento di connessione: controllare il riferimento di connessione fornito nel codice o nella configurazione e assicurarsi che sia valido e corretto.

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
