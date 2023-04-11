---
title: "Gestione del ciclo di vita delle applicazioni (ALM)"
description: "Kit di automazione - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['ALM', 'Guidance']
generated: CFA547EC584269A54557898046D235E91F77E46A
---

{{<slideStyles>}}

<div class="optional">

Questa pagina fornisce una panoramica dei componenti che possono facilitare l'utilizzo di ALM con i flussi di lavoro di Automation Kit for Power Automate Desktop inclusi in [Soluzioni Power Platform](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## Sommario

Quando si cerca ALM per soluzioni Power Platform che includono componenti Power Automate Desktop

1. Esamina le funzionalità di Managed Environment Power Platform Pipelines per sfruttare le funzionalità integrate nel prodotto su scala aziendale per gestire e governare le soluzioni all'interno degli ambienti.

<br/>

2. Se necessario, esaminare il [Strumenti di compilazione di Microsoft Power Platform per Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [Azioni GitHub per Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) o [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) per integrare e automatizzare i processi DevOps ALM.

<br/>

3. Considerare l'utilizzo del [Acceleratore ALM per Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). ALM Accelerator offre un set predefinito di modelli DevOps di Azure che automatizza molte delle attività ALM Power Platform usando la governance integrata del controllo del codice sorgente.

## Imparare da Power CAT

Puoi anche leggere di più su come noi, come team Power CAT, utilizziamo ALM Accelerator per spedire il [Kit di automazione CAT di potenza ALM](/it/features/alm/powercat).

## Risorse

[ALM Accelerator per Power Platform catalogo di apprendimento](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## Cartina stradale

Il team di Automation Kit sta collaborando con il team di ALM Accelerator per aggiungere attività specifiche di Power Automate Desktop ai modelli esistenti che riguardano:

- Confronto affiancato delle definizioni di Power Automate Desktop.

- Controlli delle regole di convalida per Power Automate Desktop.

- Esecuzione di test di unità, integrazione e sistema come parte della pipeline CI/CD.

Recensisci il nostro [Backlog relativo a Automation Kit ALM](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## Valutazione

{{<questions name="/content/it/features/alm.json" completed="Grazie per aver fornito feedback" showNavigationButtons="false" locale="it">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

Gli ambienti gestiti offrono la possibilità di ottimizzare e semplificare la governance su larga scala. Gli amministratori possono attivare gli ambienti gestiti con pochi clic e illuminare immediatamente le funzionalità che offrono maggiore visibilità, maggiore controllo con meno sforzo per gestire tutte le risorse low code.

Gli ambienti gestiti sono una parte fondamentale della famiglia Power Platform, nello stesso modo in cui AI Builder ha infuso intelligenza nei nostri prodotti e Common Data Service fornisce la dorsale dei dati. Gli ambienti gestiti semplificano la governance della piattaforma su larga scala.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

Gli ambienti gestiti offrono:

- Maggiore visibilità con informazioni dettagliate sull'utilizzo nella home page, e-mail di digest amministratori, report sulle licenze e visualizzazioni dei criteri dei dati
- Maggiore controllo con limiti di condivisione che ti consentono di controllare l'ampiezza e il numero di persone con cui è possibile condividere i flussi di app canvas e soluzioni.
- È inoltre possibile limitare la condivisione a gruppi di sicurezza limitati.
- Configurare lo strumento di verifica della soluzione per i controlli di sicurezza o affidabilità per l'esecuzione automatica delle regole ogni volta che una soluzione viene importata in un ambiente gestito
- Personalizza l'esperienza di benvenuto e condivisione del creatore in modo da guidare gli utenti lungo il percorso corretto.
- Meno sforzo per ottimizzare, semplificare e automatizzare i passaggi pronti all'uso con pochi clic. 
- Le pipeline Power Platform consentono di semplificare il processo ALM (Application Lifecycle Management).

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

Questa è una soluzione con cui sto lavorando nel Maker Portal.

Sono andato avanti per selezionare questa pipeline che è già stata configurata. Le pipeline sono fondamentalmente una serie di passaggi automatizzati che spostano il lavoro da un ambiente a un altro. Questa pipeline porterà la mia soluzione dall'ambiente di sviluppo a sinistra all'ambiente di test. Poi c'è un'altra fase per portarlo dal test alla produzione.

Consente di eseguire la distribuzione per testare, selezionare avanti e qui, confermerò le mie connessioni per testare l'ambiente per assicurarsi di utilizzare le credenziali corrette. Successivamente configurerò le variabili di ambiente per assicurarmi, ad esempio, di puntare al sito di SharePoint corretto in test. Questo è importante se il sito era diverso da quello che stavo usando in fase di sviluppo. 

Una volta impostato tutto, posso semplicemente selezionare "Distribuisci" e le convalide preflight vengono eseguite automaticamente per avere le giuste dipendenze e la soluzione non viola le politiche DLP in quell'ambiente di destinazione. La pipeline può anche essere configurata in modo che sia necessaria l'approvazione prima di poter eseguire la distribuzione. 

Sembra che tutto abbia avuto successo qui.

Dopo aver eseguito la pipeline, ottengo visibilità completa e un audit trail delle distribuzioni all'interno dell'organizzazione con ogni soluzione sottoposta a backup e controllo delle versioni.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

Le funzionalità saranno implementate in fasi. Alcuni di loro come i digest di amministrazione e i limiti di condivisione sono disponibili oggi. Il resto sarà lanciato entro la fine dell'anno.

Nelle prossime settimane e mesi, vedrai le informazioni sull'utilizzo nella home page. Nuove tendenze nei digest di amministrazione e nei report per l'utilizzo con licenza. I limiti di condivisione otterranno più controlli e supporteranno i flussi di soluzioni. Sarà possibile bloccare le distribuzioni non sicure con Solution Checker. Anche le funzionalità di onboarding e pipeline dei customer maker arriveranno entro la fine dell'anno.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

Hai una serie di opzioni da considerare per le tue scelte ALM nel Power Platform. Le pipeline di Power Platform dell'ambiente gestito forniscono la gestione del ciclo di vita delle applicazioni del prodotto.

Facoltativamente, è possibile utilizzare i punti di estensione dell'ambiente gestito Power Platform pipeline combinati con [Power Platform Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)Le [Azioni GitHub per Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) o [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) per eseguire il rollback dei processi DevOps ALM personalizzati.

Finalmente potresti approfittare del [Acceleratore ALM per Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) dal kit CoE per fornire modelli ed esempi predefiniti per ALM end-to-end usando Azure DevOps. ALM Accelerator fornisce molti scenari comuni per creare e governare le soluzioni in tutti gli ambienti.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

Cos'è ALM Accelerator per Power Platform?

ALM Accelerator for Power Platform include Power Apps che si trova in cima alle pipeline DevOps di Azure e al controllo del codice sorgente Git. L'app fornisce un'interfaccia semplificata per consentire ai creatori di esportare regolarmente i componenti nelle loro soluzioni Power Platform nel controllo del codice sorgente e creare richieste di distribuzione per esaminare il proprio lavoro prima della distribuzione negli ambienti di destinazione.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

Osservando il flusso di lavoro di ALM Accelerator, inizia con gli ambienti di sviluppo. La loro interazione con il processo ALM avviene tramite l'app Canvas ALM Accelerator o le pipeline dell'ambiente gestito

I creatori utilizzano l'app Canvas ALM Accelerator per le loro attività ALM, ad esempio importare soluzioni dal controllo del codice sorgente, esportare le modifiche nel controllo del codice sorgente e creare richieste pull per unire le modifiche

I modelli di ALM Accelerator per le pipeline DevOps di Azure facilitano l'automazione delle attività ALM in base all'interazione di Makers con l'app Canvas di ALM Accelerator

ALM Accelerator include modelli di pipeline per supportare una distribuzione in 3 fasi in produzione.
I modelli possono essere personalizzati per soddisfare esigenze e scenari specifici

ALM Accelerator for Power Platform è un'app canvas che si trova in cima alle pipeline DevOps di Azure per fornire un'interfaccia semplificata che consente ai creatori di eseguire regolarmente il commit e creare richieste pull per il loro lavoro di sviluppo in Power Platform. 

La combinazione di Azure DevOps Pipelines e dell'app Canvas è ciò che costituisce la soluzione completa di ALM Accelerator for Power Platform. 
Le pipeline e l'App sono implementazioni di riferimento. Sono stati sviluppati internamente per l'uso da parte del team di sviluppo per lo starter kit CoE, ma sono stati open source e rilasciati per dimostrare quanto ALM sano possa essere raggiunto nel Power Platform. Possono essere utilizzati così come sono o personalizzati per scenari aziendali specifici.

{{</slide>}}
