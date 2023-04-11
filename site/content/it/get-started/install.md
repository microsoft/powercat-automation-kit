---
title: "Installazione dalla riga di comando"
description: "Kit di automazione - Installazione"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 41BD476CCC700CAAAD43657E9716A73ABDD00A15
---

<div class="optional">

Per installare la versione più recente di Automation Kit utilizzando la riga di comando, è possibile utilizzare la procedura seguente di seguito. Se non è possibile utilizzare gli strumenti da riga di comando, è possibile utilizzare i passaggi manuali documentati in [Linee guida per l'installazione](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. Assicurati di avere <a ref='https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">Abilitare la funzionalità del framework dei componenti Power Apps</a> negli ambienti in cui si desidera installare il Kit di automazione sia per ambienti Main che Satellite.

1. Assicurarsi che il <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">Creator Kit installato</a> negli ambienti in cui si desidera eseguire l'installazione

1. Aprire l'ultima versione dal <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Rilascio del kit di automazione GitHub</a>

1. Scarica il **AutomationKitInstall.zip** dalla sezione Risorse

1. In Esplora risorse selezionare l'icona scaricata **AutomationKitInstall.zip** e aprire la finestra di dialogo Proprietà

1. Selezionare l'icona **Sbloccare** bottone

1. Selezionare **AutomationKitInstall.zip** e utilizzare il menu contestuale per **Estrai tutto**

1. Assicurati di avere il <a href="https://learn.microsoft.com/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> Installato

1. Eseguire lo script di PowerShell usando la riga di comando seguente

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

NOTA:
1. A seconda dei criteri di esecuzione di PowerShell, potrebbe essere necessario eseguire il comando seguente

```cmd
Unblock-File Install_AutomationKit.ps1
```

1. Lo script di PowerShell richiederà di creare un file di configurazione dell'installazione utilizzando [Installare il programma di installazione](/it/get-started/setup). Le pagine di configurazione dell'installazione forniranno quanto segue

    - Seleziona la configurazione per soluzioni principali o satellitari
   
    - Selezionare gli utenti da assegnare ai gruppi di sicurezza
   
    - Creare le connessioni necessarie per installare la soluzione
    
    - Definire le variabili di ambiente
    
    - Facoltativamente, definire se i dati di esempio devono essere importati
    
    - Facoltativamente, l'opzione Abilita flussi Power Automate contenuti nelle soluzioni deve essere abilitata

1. Dopo aver completato i passaggi di configurazione del sito Web, è possibile copiare i download **automation-kit-main-install.json** o **automation-kit-satellite-install.json** nella cartella **AutomationKitInstalla** cartella sopra

1. Una volta scaricato il file, lo script richiederà **y** per installare la soluzione principale, **n** Per installare la soluzione satellitare

1. L'installazione verrà quindi caricata avviare l'installazione con le impostazioni definite

## Valutazione

Desidera fornire un feedback sul [Processo di installazione](/it/get-started/setup)? Le domande seguenti ci aiutano a migliorare il processo.

{{<questions name="/content/it/get-started/setup-feedback.json" completed="Grazie per aver fornito feedback" showNavigationButtons="false" locale="it">}}

</div>

