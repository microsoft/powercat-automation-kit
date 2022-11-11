---
title: "Gestione del ciclo di vita delle applicazioni Power CAT (ALM)"
description: "Kit di automazione - ALM Power CAT"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 0087DF5B505764347AC2AF0B6C170474826A5D65
---

{{<slideStyles>}}

<div class="optional">

L'Automation Kit sfrutta il [Acceleratore ALM](https://aka.ms/aa4pp) per fornire funzionalità ALM per soluzioni che includono Power Automate Desktop

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## Processo di distribuzione di GitHub

Analogamente al processo di rilascio utilizzato per altri kit gestiti Power CAT, il {{<product-name>}} usa ALM Accelerator per distribuire le versioni nelle nostre versioni pubbliche di GitHub.

Il nostro processo interno ha un ambiente Power Platform per lo sviluppo, il test e la produzione. Una volta che siamo pronti per un rilascio, le nostre azioni GitHub integrate impacchettano automaticamente le soluzioni di distribuzione gestite e non gestite insieme alle note sulla versione per una versione di GitHub Draft.

Una volta che la bozza di rilascio è pronta, possiamo pubblicare nuove versioni o hotfix in base alle esigenze.

### Cosa significa questo per te

Ora che abbiamo implementato questa automazione, il rilascio automatico di ALM offre i seguenti vantaggi:

- Visibilità su tutto il codice sorgente low code che compone il kit di automazione in modo da poter indagare su come abbiamo costruito il kit.

- Processo di automazione semplificato in grado di rispondere rapidamente a bug o problemi e fornire hotfix se necessario.

- Compilazione automatica di tutti i bug e le funzionalità inclusi in una versione.

- Includiamo Power Apps, Power Automate, Common Data Service e Power Automate Desktop come parte del nostro processo ALM per la nostra integrazione continua / distribuzione continua.

## Cartina stradale

Puoi esaminare i nostri elementi di backlog relativi all'ALM aperti nel nostro [Registro dei problemi di GitHub](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

Nel complesso, ci basiamo sulle funzionalità esistenti di Power Platform e Microsoft DevOps insieme ad ALM Accelerator. Questa combinazione ci consente di concentrarci su estensioni specifiche che aiutano con l'iperautomzione.

## Valutazione

{{<questions name="/content/it/features/alm/powercat.json" completed="Grazie per aver fornito feedback" shownavigationbuttons="false" locale="it">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Il team Power CAT utilizza l'acceleratore ALM per creare e distribuire ciascuno dei nostri [Rilascia](https://github.com/microsoft/powercat-automation-kit/releases).

Ogni versione promuove modifiche dal nostro sviluppo in ambienti di test e produzione. Le soluzioni Power Platform all'interno del kit usano un processo automatizzato per creare pacchetti di risorse per la distribuzione nelle versioni pubbliche di GitHub.

Nelle tappe future espanderemo la piattaforma esistente [Caratteristiche di ALM](/it/features/alm) per fornire esempi su come includere regole di convalida e confronto visivo di esempi RPA come parte del processo DevOps.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

Di seguito vengono descritti i passaggi chiave del processo di rilascio di Automation Kit:

1. Le modifiche apportate nel nostro ambiente di sviluppo Power Platform vengono salvate in un ramo nel repository GitHub pubblico

2. Quando le modifiche sono pronte per l'inclusione in una versione di prova, vengono unite nel ramo principale utilizzando una richiesta pull. Prima che la richiesta pull possa essere completata, la pipeline di convalida di Azure DevOps deve essere completata correttamente e la richiesta pull deve essere esaminata.

3. Una volta che la richiesta pull ha superato i controlli automatici e ricevuto l'approvazione della revisione, può essere unita al ramo principale. Questa unione attiva la pipeline di compilazione di Azure DevOps di test che pubblica la build gestita nell'ambiente Power Platform di test.

4. Dopo i test interni, la pipeline di produzione di Azure DevOps viene attivata manualmente per generare una distribuzione di Production Power Platform.

5. Una volta che è pronta una release, la pipeline di Azure DevOps di rilascio crea una bozza di rilascio che include note sulla versione e asset di compilazione. La build di rilascio finale chiuderà tutti i problemi aperti e chiuderà la fase cardine. Tag di compilazione pubblicato nel repository GitHub con un'etichetta Month e Year applicata.

{{</slide>}}
