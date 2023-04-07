---
title: "Satellite - Per iniziare"
description: "Kit di automazione - Satellite - Inizia"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: 425608BE149AA6D640338A5F34EB704ADDAAAEF5
---

# Panoramica

Benvenuti nella pagina iniziale per la soluzione Satellite. Questa sezione illustra le modifiche importanti apportate nell'aprile 2023 e versioni successive. Dopo aprile 2023 è stata rimossa la necessità per Azure Key Vault di archiviare le informazioni sul tenant dell'applicazione di Azure, sull'ID applicazione e sul segreto dell'applicazione Azure.

## Progettazione concettuale

La nostra pagina di apprendimento delinea il [Progettazione concettuale](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) del {{<product-name>}}. L'elemento chiave della soluzione è l'ambiente principale Power Platform.

Di solito ci sono diversi ambienti di produzione satellite che eseguono i tuoi progetti di automazione. A seconda della strategia dell'ambiente, questi potrebbero anche essere ambienti di sviluppo o di test.

Tra questi ambienti esiste un processo di sincronizzazione quasi in tempo reale che include la telemetria del flusso cloud o desktop, l'utilizzo di macchine e gruppi di computer e registri di controllo. Nel dashboard di Power BI per Automation Kit vengono visualizzate queste informazioni.

## Cosa è cambiato

Come parte della risoluzione [[Kit di automazione - Funzionalità]: alternativa di Azure Key Vault per ambienti satellite](https://github.com/microsoft/powercat-automation-kit/issues/84) Azure Key Vault non è più necessario. Questo è importante in quanto riduce significativamente la complessità dell'installazione e il modo in cui viene gestita la protezione per ottenere gli artefatti della soluzione quando si utilizza Automation Solution Manager.

## Cos'è lo stesso?

Una volta che gli elementi chiave sono gli stessi, le versioni precedenti precedenti ad aprile 2023 e aprile 2023 è necessaria un'applicazione Azure Active Directory.

Un [Utente dell'applicazione](https://learn.microsoft.com/power-platform/admin/manage-application-users) è un tipo di utente nel Power Platform identificato dalla presenza dell'attributo ApplicationId nel record utente di sistema. Gli utenti dell'applicazione vengono creati in Azure Active Directory (Azure AD) e vengono usati per autenticare e autorizzare l'accesso al Power Platform. Vengono in genere utilizzati per rappresentare un'applicazione o un servizio che deve accedere ai dati o eseguire operazioni nel Power Platform per conto di utenti o altre applicazioni.

In particolare, l'utente dell'applicazione viene utilizzato da Automation Solution Manager per consentire di eseguire query sui componenti della soluzione in un ambiente in modo da consentire a un utente di misurare una soluzione Power Platform distribuita.

## Installare

Le [Installazione dalla riga di comando](/it/get-started/install) per le soluzioni satellitari verrà richiesto il nome dell'applicazione Azure Active Directory e l'ID applicazione di Azure Active Directory. Utilizzando queste informazioni:

1. Aggiungere l'applicazione Azure Active Directory come utente dell'applicazione
1. Aggiungere l'utente dell'applicazione al ruolo di amministratore di sistema
1. Aggiungere l'ID utente dell'utente dell'applicazione alla variabile di ambiente **ID utente di lettura degli artefatti di Solution Manager**

Il nuovo ruolo Common Data Service di ruolo **Utente di Automation Solution Manager** è stato aggiunto che consente agli utenti di chiamare la nuova API personalizzata Common Data Service GetDataverseSolutionArtifacts che eseguirà query sugli elementi della soluzione utilizzando la variabile di ambiente fornita **ID utente di lettura degli artefatti di Solution Manager**.

Se si desidera installare manualmente la soluzione di satelitte, è necessario apportare le seguenti modifiche al [Configurare i satelliti](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/satellite) disposizioni.

1. Salta il passaggio "Aggiungi un nuovo segreto client" poiché non è più necessario per aprile 2023 o versioni successive.
1. Saltare il passaggio per creare segreti nell'insieme di credenziali delle chiavi di Azure.
1. Aggiungere l'ID utente dell'utente dell'applicazione alla finestra di dialogo **ID utente di lettura degli artefatti di Solution Manager** variabile di ambiente.

## Post installazione

Assicurarsi che agli utenti che eseguiranno l'applicazione Automation Solution Manager sia concesso il **Utente di Automation Solution Manager** Ruolo di sicurezza Common Data Service.

## Versioni precedenti

Prima della versione di aprile 2023 le installazioni della soluzione Satellite richiedevano variabili di ambiente di tipo segreto. Ciò ha richiesto un [Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) per archiviare i valori per ID tenant, ID applicazione e Segreto applicazione. Per utilizzare questa funzione è inoltre necessario il [Prerequisiti](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#prerequisites) dell'Azure Key Vault essendo im lo stesso tenant, configurazione di Microsoft.PowerPlatform come provider di risorse.

Nelle versioni di marzo 2023 o precedenti Azure Key Vault è stato usato per archiviare un ID tenant, un ID APplication e un segreto applicazione. Utilizzando questi valori, è stato richiesto un token di accesso per eseguire query su Common Data Service in modo da poter restituire l'elenco dei componenti della soluzione.

## Consigli

Per gli utenti esistenti è consigliabile semplificare la gestione continua ed eliminare la necessità di una dipendenza di Azure Key Vault che si aggiorna l'installazione satellite esistente ad aprile 2023 o versione successiva per sfruttare le nuove funzionalità.
