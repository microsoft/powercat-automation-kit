---
title: Forfatter spørgsmål
description: Spørgsmål om oprettelse af automatiseringssæt
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---
Denne side indeholder oplysninger om det format, der bruges til at oprette interaktive spørgsmål, der er inkluderet som en del af {{<product-name>}} starter.

{{<toc>}}

## Introduktion

De spørgsmål, der bruges på startsiderne for pakken, er baseret på [Open Source-undersøgelse JS Library](https://github.com/surveyjs/survey-library). Brug af dette bibliotek gør det muligt at bruge alle de indbyggede kontroller, der understøttes.

For at forstå de rammer, du kan se på

- Den [Undersøgelse JS Docs](https://surveyjs.io/form-library/documentation/overview)

- Enkle spørgsmålstyper som [Tekst](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [Radiogrupper](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [Afkrydsningsfelt](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) eller [Rangering](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- Brug af betinget synlighed [synligHvis](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- Gennemgå nogle af de eksisterende spørgsmål, der bruges på webstedet. Det gælder f.eks. [Spørgsmål om overvågning](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- Gennemgå, hvordan du inkluderer den korte kode i din indholdsmarkering. For eksempel [Overvågning af markdown](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## Integrering af spørgsmål i dit indhold

Hvis du vil integrere et sæt spørgsmål på din side, kan du føje følgende til din markering og ændre navnet til den spørgsmålsfil, du vil læse fra

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

Den {{<product-name>}} indeholder også nogle ekstra funktioner, du kan bruge i udtryk.

### Len

Len-funktionen returnerer længden af en streng eller matrix

#### len eksempel

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### Indeholder

Funktionen indeholder returnerer sand eller falsk, hvis strengen eller matrixen af strenge svarer til den angivne værdi

#### indeholder eksempel

Vil gøre elementet synligt, hvis en af de valgte roller er opretter

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

Vil gøre elementet synligt, hvis en af de valgte roller er skaber eller arkitekt

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## Brugerdefinerede widgets

### Billedopgave

Den {{<product-name>}} indeholder også **billed-opgave** brugerdefineret widget. Denne widget kan inkluderes i dine spørgsmålselementer ved hjælp af følgende json-uddrag.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### Egenskaber

- **titel** - Teksten, der skal vises til brugeren
- **slags** - Skal være billed-opgave
- **Src** - URL'en til SVG-filen, der skal gengives

#### Sådan fungerer det

Kilde-svg-filen understøtter følgende brugerdefinerede hyperlinklinks til elementer i svg-filen

- **template://item/selected** - Vil definere objektets format for at indstille det valgte format i billedet
- **template://item/unselected** - Vil definere objektets format for at indstille det ikke-valgte format af elementer i billedet
- **question://question-name/value** - Vil definere objektets format for at indstille det ikke-valgte format af elementer i billedet

Visuelle elementer med et hyperlink af question:// vil blive brugt til at indstille eller fjerne matrixen af værdier inde i sættet af spørgsmål. Denne mulighed giver mulighed for interaktivt at ændre, hvordan andre spørgsmål vises til brugeren. For eksempel hvis svg-filen havde to objekter med følgende hyperlinks:

- **question://roles/maker**
- **question://roles/architect**

Hvis brugeren vælger disse objekter, kan andre elementer på siden f.eks.

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

## Spørgsmål og svar

### **Spørgsmål** Hvorfor er denne tilgang blevet brugt i stedet for Microsoft Forms?

Brugen af spørgsmålskortkoden gør det muligt for spørgsmålene at være en del af hver indholdsside i stedet for et separat link.

### **Spørgsmål** Hvilke fordele er der ved denne tilgang?

Følgende fordele ved denne tilgang omfatter

- Evnen til at bruge out of the box spørgsmålstyper

- Oprettelsen af spørgsmål er konfigurationsdrevet og kræver kun kendskab til JSon for at opbygge spørgsmål

- Spørgsmålsrammen kan udvides, så nye funktioner eller widgets kan tilføjes

- Brug af JSon til spørgsmålsdefinitionerne gør det muligt at gemme spørgsmålene i kildekontrol og gennemgås og versioneres over tid

### **Spørgsmål** Kan denne fremgangsmåde bruges i en Power App eller Power Page?

Absolut, den samme JavaScript og spørgsmål definitioner kunne bruges ved at oprette en [Kode komponent](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **Spørgsmål** Hvordan kan jeg skrive spørgsmålene til SVG-billedopgaven?

En mulighed for at oprette svg-filerne er [Microsoft Visio](https://www.microsoft.com/microsoft-365/visio/) som WLL eksporterer diagrammer til en SVG-fil med de nødvendige hyperlinks, der er kompatible med **billed-opgave** Spørgsmål.

### **Spørgsmål** Kan jeg bruge Microsoft PowerPoint til at eksportere billedopgavespørgsmål SVG-filer?

Mens Microsoft Power Point kan eksportere et dias til en SVG-fil indledende testsko, eksporterer den ikke de hyperlinks, der kræves for at lave en interaktiv **billed-opgave** arbejde med succes.

### **Spørgsmål** Mine eksporterede SVG-filer er store, kan jeg gøre dem mindre?

En mulighed for SVG-filer for at gøre dem mindre, før de forpligter dem til kildekontrol. Der er flere værktøjer, der kan bruges til at formindske størrelsen på en SVG, en mulighed at overveje er [svgo](https://github.com/svg/svgo) en NodeJs-baseret SVG-optimering.
