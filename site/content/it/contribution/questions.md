---
title: Domande sulla creazione
description: Domande sulla creazione di Automation Kit
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---
Questa pagina contiene informazioni sul formato utilizzato per creare domande interattive incluse come parte del {{<product-name>}} antipasto.

{{<toc>}}

## Introduttiva

Le domande utilizzate all'interno delle pagine iniziali del kit si basano su [Libreria JS Open Source Survey](https://github.com/surveyjs/survey-library). L'utilizzo di questa libreria consente di utilizzare tutti i controlli predefiniti supportati.

Per capire il quadro puoi guardare

- Le [Sondaggio JS Docs](https://surveyjs.io/form-library/documentation/overview)

- Tipi di domande semplici come [Testo](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [Gruppi radio](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [Casella di controllo](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) o [Graduatoria](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- Utilizzo della visibilità condizionale [visibleIf](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- Esaminare alcune delle domande esistenti utilizzate nel sito. Ad esempio, il [Domande sul monitoraggio](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- Scopri come includere il codice breve nel markdown dei contenuti. Per esempio [Monitoraggio markdown](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## Incorporare domande nei tuoi contenuti

Per incorporare una serie di domande nella tua pagina, puoi aggiungere quanto segue al markdown e modificare il nome del file di domande da cui desideri leggere

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

Il {{<product-name>}} include anche alcune funzioni aggiuntive che è possibile utilizzare all'interno delle espressioni.

### Len

La funzione len restituisce la lunghezza di una stringa o di una matrice

#### Esempio Len

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### Contiene

La funzione contains restituisce true o false se la stringa o la matrice di stringhe corrisponde al valore fornito

#### contiene un esempio

Renderà visibile l'elemento se uno dei ruoli selezionati è maker

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

Renderà visibile l'elemento se uno dei ruoli selezionati è maker o architetto

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## Widget personalizzati

### Attività immagine

Il {{<product-name>}} include anche il **immagine-attività** widget personalizzato. Questo widget può essere incluso negli elementi della domanda utilizzando il seguente frammento json.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### Proprietà

- **titolo** - Il testo da visualizzare all'utente
- **digitare** - Deve essere immagine-compito
- **Src** - L'url del file SVG di cui eseguire il rendering

#### Come funziona

Il file svg di origine supporta i seguenti collegamenti ipertestuali personalizzati per gli elementi nel file svg

- **template://item/selected** - Definirà il formato dell'oggetto per impostare il formato selezionato nell'immagine
- **template://item/unselected** - Definirà il formato dell'oggetto per impostare il formato non selezionato degli elementi nell'immagine
- **question://question-name/value** - Definirà il formato dell'oggetto per impostare il formato non selezionato degli elementi nell'immagine

Gli elementi visivi con un collegamento ipertestuale di question:// verranno utilizzati per impostare o annullare la matrice di valori all'interno del set di domande. Questa capacità offre la possibilità di modificare in modo interattivo il modo in cui altre domande vengono mostrate all'utente. Ad esempio, se il file svg contiene due oggetti con i seguenti collegamenti ipertestuali:

- **question://roles/maker**
- **question://roles/architect**

Se l'utente seleziona questi oggetti, ad esempio potrebbero essere visualizzati altri elementi nella pagina.

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

## Domande e risposte

### **Domanda** Perché è stato utilizzato questo approccio anziché Microsoft Forms?

L'uso dello shortcode delle domande consente alle domande di far parte di ogni pagina di contenuto piuttosto che di un collegamento separato.

### **Domanda** Quali sono i vantaggi di questo approccio?

I seguenti vantaggi di questo approccio includono:

- La possibilità di utilizzare tipi di domande predefiniti

- La creazione di domande è guidata dalla configurazione e richiede solo la conoscenza di JSon per creare domande

- Il framework delle domande è estensibile consentendo l'aggiunta di nuove funzioni o widget

- L'utilizzo di JSon per le definizioni delle domande consente di archiviare le domande nel controllo del codice sorgente e di esaminarle e di controllarne le versioni nel tempo

### **Domanda** Questo approccio può essere usato all'interno di una Power App o Power Page?

Assolutamente, le stesse definizioni JavaScript e domande potrebbero essere utilizzate creando un [Componente di codice](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **Domanda** Come posso creare le domande sull'attività immagine SVG?

Un'opzione per creare i file svg è [Microsoft Visio](https://www.microsoft.com/microsoft-365/visio/) che esporterà diagrammi in un file SVG con i collegamenti ipertestuali richiesti compatibile con **immagine-attività** Domande.

### **Domanda** Posso usare Microsoft PowerPoint per esportare file SVG di domande immagine-attività?

Mentre Microsoft Power Point può esportare una diapositiva in un file SVG test iniziale shoe non esporta i collegamenti ipertestuali necessari per rendere un interattivo **immagine-attività** funziona con successo.

### **Domanda** I miei file SVG esportati sono grandi, posso renderli più piccoli?

Un'opzione per i file SVG per renderli più piccoli prima di eseguirne il commit nel controllo del codice sorgente. Esistono più strumenti che possono essere utilizzati per ridurre le dimensioni di un SVG, un'opzione da considerare è [SVGO](https://github.com/svg/svgo) un ottimizzatore SVG basato su NodeJs.
