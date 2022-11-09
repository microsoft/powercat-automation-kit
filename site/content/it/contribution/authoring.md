---
title: Linee guida per la creazione
description: Linee guida per la creazione della documentazione di Automation Kit
sidebar: false
sidebarlogo: fresh-white
include_footer: true

---
Nelle sezioni seguenti vengono illustrate le linee guida e le note per la creazione della documentazione introduttiva.

{{<toc>}}

## Istruzioni

Le sezioni seguenti delineano linee guida tecniche, di progettazione e basate sui risultati per la creazione di contributi

## Obiettivi

Mentre costruiamo la nostra documentazione, è importante considerare come consentiamo ai nostri lettori di **Cadere nella fossa del successo**.

Brad Abrams definito [Il pozzo del successo nel 2003](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) come

> The Pit of Success: in netto contrasto con una vetta, una vetta o un viaggio attraverso un deserto per trovare la vittoria attraverso molte prove
> e sorprese, vogliamo che i nostri clienti cadano semplicemente in pratiche vincenti
> utilizzando la nostra piattaforma e i nostri framework. Nella misura in cui rendiamo facile mettersi nei guai, falliamo.

Dato questo obiettivo, considera quanto segue:

- Fornire una "esperienza senza scogliere"

  - Aiutare gli amministratori e i team di governance centrale a creare un modello self-service di utilizzo di {{<product-name>}}

  - Consentire agli utenti di utilizzare gli ambienti di sviluppo per mettere le mani su se un ambiente centrale non è disponibile e desiderano funzionalità prima di una distribuzione di test o di produzione del {{<product-name>}}

  - Discutere l'utilizzo degli ambienti di prova con una facile configurazione per mettere le mani su {{<product-name>}}

- Fornire un canale per il feedback. Offri opzioni ai clienti per fornire input su ciò che possiamo migliorare

### Controllo del codice sorgente

- Hai completato [Documentazione](/it/contribution/documentation) passaggi per scaricare e inviare le modifiche al repository GitHub
- Le nuove modifiche vengono inviate a un nuovo ramo e hanno una richiesta pull per rivedere le modifiche
- Tutta la documentazione deve essere markdown, JSon o risorse statiche che possono essere controllate dalla versione e riviste utilizzando il processo di richiesta pull standard

## Linee guida per la progettazione

### Pagina iniziale

- Avere un titolo e un sottotitolo chiari che delineino l'obiettivo dell'esperienza iniziale
- Fornisci un invito all'azione per includere altri eventi correlati. Ad esempio, registrati per l'orario d'ufficio.
- Collegamento all'azione Guida introduttiva come azione principale per aiutare i nuovi utenti a eseguire l'onboarding
- Azione secondaria per unire l'orario d'ufficio per aiutare a costruire una comunità di utenti
- Includi riquadri di azioni comuni
- Elenco riepilogativo delle funzionalità che consentono agli utenti di gestire i progetti di iperautomazione
- Navigazione a piè di pagina per i collegamenti comuni.

Leggi il [Configurazione del sito](/it/contribution/site-configuration) per ulteriori informazioni sulla configurazione della home page.

### Riuso

- Utilizzare i layout hugo per poter specificare un nuovo tema o sostituire il tema corrente inserendo il contenuto nella cartella site\layouts
- La modifica dei layout dovrebbe consentire l'inclusione di HTML statico in molte posizioni di hosting. Per esempio

  - Pagine GitHub
  - Pagine di potenza
  - Condividi punto
  - Siti Web statici di Azure

- L'approccio può essere utilizzato come modello da partner o clienti per creare "pacchetti di documentazione" per accelerare la fase di nutrimento di {{<product-name>}} documentazione
- Fornire la possibilità a più utenti della documentazione (ad esempio i team del Centro clienti e del Centro di eccellenza per i partner)
- Consenti l'inclusione di contenuti forniti dall'utente
- Consenti processo di aggiornamento che consente di estrarre nuove modifiche da {{<product-name>}} Documentazione iniziale

## Pagine Markdown

- È possibile utilizzare [Codice di Visual Studio](https://code.visualstudio.com/) Per modificare i file di markdown

- I file di markdown devono trovarsi nella cartella /site/content

- Ogni file di markdown deve includere un'intestazione comune su ogni pagina

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- I file Markdown devono utilizzare shortcode per incorporare qualsiasi JavaScript

## codici brevi

I codici brevi consentono di includere contenuto dinamico in una pagina di markdown. Puoi leggere ulteriori informazioni sugli shortcode dal [Documentazione dello shortcode Hugo](https://gohugo.io/content-management/shortcodes/)

Questo progetto include anche shortcode aggiuntivi

### Sommario

Aggiungere il comando **Toc** seguendo lo shortcode al markdown per includere un sommario di intestazioni markdown nella pagina circondata da \{\{ e \}\}

```html
<toc/>
```

### Domanda

Includi una serie di domande nella tua pagina circondata da \{\{ e \}\}

```html
<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

Parametri:

- **nome** Nome del file JSon che include le domande da importare. Leggere [Domande](/it/contribution/questions) Per ulteriori informazioni sul formato del file delle domande
- **finito** Testo da visualizzare al termine delle domande
- **showNavigationButtons** valore vero/falso per i pulsanti di navigazione successivo/indietro/completato

### Immagine esterna

Includi un'immagine di dimensioni da una fonte esterna nella tua pagina circondata da \{\{ e \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

Parametri:

- **Src** Il percorso di origine dell'immagine da importare
- **grandezza** La dimensione in pixel in cui ridimensionare l'immagine di origine
- **Testo** Testo alternativo da includere nell'immagine

## Note

### Configurazione delle pagine GitHub

I passaggi seguenti sono stati usati per configurare le pagine GitHub per il sito

1. Creato nuovo ramo orfano in git

    ```bash
    git checkout --orphan gh-pages
    ```

1. Cancellare il contenuto esistente (file e cartelle)

    ```bash
    git clean -d -f
    ```

1. Hugo è installato

    - Puoi anche installare con chocolatey su Windows
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. Output Hugo configurato per l'output nella cartella /docs

1. Testare le modifiche

    ```bash
    hugo serve
    ```

1. Per creare il sito html statico all'interno della cartella del sito eseguire il seguente comando

    ```bash  
    hugo
    ```
 
1. Spingi il tuo ramo gh-pages su GitHub

1. Configurare il progetto GitHub per abilitare le pagine

    - Vedere Configurazione di un'origine di pubblicazione per il sito GitHub Pages - GitHub Docs
    - Ramo gh-pages selezionato e cartella /docs

### Aggiorna badge immagine home page

Per personalizzare l'immagine della home page con un badge Stato: Anteprima pubblica procedo come segue:

1. Clonare il repository svg-badges

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. Installare i moduli

    ```bash
    npm install
    ```

1. Avviare il server Web per generare badge

    ```bash
    npm run start
    ```

1. Genera badge

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. Scarica il badge svg

1. Usa inkscape per modificare svg esistente e salvare i risultati

1. Carica una nuova immagine nella cartella static\images\illustrations

1. Modificare l'immagine hero config.yaml

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## Domande e risposte

### **Domanda** Perché è stato scelto Hugo?

[Hugo](https://gohugo.io/) è un popolare generatore di siti statici che consente il contenuto del {{<product-name>}} documentazione iniziale da trasformare in HTML statico che può essere ospitato in GitHub Pages

### **Domanda** Perché non hai selezionato qualche altro generatore di siti statici?

Il team principale di Power CAT aveva precedenti esperienze con Hugo

### **Domanda** Perché Microsoft Forms non è stato utilizzato per le domande?

Uno degli obiettivi del design era quello di integrare il processo di domanda direttamente nel contenuto.

### **Domanda** Perché le pagine GitHub per ospitare contenuti?

Il codice sorgente per il {{<product-name>}} esiste già su GitHub e il supporto nativo delle pagine GitHub era una scelta di dove ospitare il contenuto.

### **Domanda** Perché questo contenuto non è attivo [http://learn.microsoft.com]()?

- Man mano che il contenuto matura verso linee guida comunemente riutilizzabili, può migrare a [https://learn.microsoft.com]()

- Un obiettivo di progettazione chiave è abilitato dall'hosting GitHub

   - Consenti il contributo attivo della comunità
   
   - Promuovere il processo di Nuture del Centro di Eccellenza in modo che la documentazione possa essere riutilizzata dalla comunità di clienti e partner

### **Domanda** Perché l'approccio non viene applicato ad altri progetti Power CAT?

Il {{<product-name>}} sta sperimentando questo canale di documentazione per completare e collegare al nostro esistente [Contenuti formativi](https://aka.ms/automation-kit-learn). Sulla base del feedback e dell'esito di questo esperimento valuteremo se altri progetti gestiti da Power CAT adotteranno un approccio simile.

### **Domanda** Come posso riscontrare problemi di documentazione aperta?

Puoi visitare il nostro [Problemi relativi alla documentazione aperta](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) pagina

### **Domanda** Come posso inviare una nuova richiesta di funzionalità di documentazione?

Creare un nuovo [Richiesta di funzionalità](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
