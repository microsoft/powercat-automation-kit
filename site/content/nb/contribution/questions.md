---
title: "Spørsmål om redigering"
description: "Automation Kit - Spørsmål om redigering"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 2FDE38C6576920DE548EFE209151F9776EB47B41
---

Denne siden inneholder informasjon om formatet som brukes til å lage interaktive spørsmål som er inkludert som en del av {{<product-name>}} starter.

{{<toc>}}

## Komme i gang

Spørsmålene som brukes på startsidene er basert på [Åpen kildekode-undersøkelse JS-bibliotek](https://github.com/surveyjs/survey-library). Ved å bruke dette biblioteket kan alle de medfølgende kontrollene som støttes, brukes.

For å forstå rammeverket kan du se på

- Den [Undersøkelse JS Docs](https://surveyjs.io/form-library/documentation/overview)

- Enkle spørsmålstyper som [Tekst](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [Radio Grupper](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [Avmerkingsboks](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) eller [Rangering](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- Bruke betinget synlighet [synligHvis](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- Se gjennom noen av de eksisterende spørsmålene som brukes på nettstedet. For eksempel [Overvåking Spørsmål](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- Gå gjennom hvordan du inkluderer kortkoden i innholdsmarkeringen. For eksempel [Overvåking markdown](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## Bygge inn spørsmål i innholdet ditt

Hvis du vil bygge inn et sett med spørsmål på siden, kan du legge til følgende i markdown og endre navnet til spørsmålsfilen du vil lese fra.

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

Den {{<product-name>}} inneholder også noen tilleggsfunksjoner du kan bruke i uttrykk.

### Len

Funksjonen len returnerer lengden på en streng eller matrise

#### len eksempel

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### Inneholder

Funksjonen inneholder returnerer sann eller usann hvis strengen eller matrisen med strenger samsvarer med den angitte verdien

#### inneholder eksempel

Vil gjøre elementet synlig hvis en av rollene som er valgt, er oppretter

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

Vil gjøre elementet synlig hvis en av rollene som er valgt, er oppretter eller arkitekt

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## Tilpassede widgeter

### Bilde oppgave

Den {{<product-name>}} inkluderer også **image-oppgave** tilpasset widget. Denne widgeten kan inkluderes i spørsmålselementene dine ved å bruke følgende json-kodebit.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### Egenskaper

- **tittel** - Teksten som skal vises til brukeren
- **type** - Må være bilde-oppgave
- **Src** - Nettadressen til SVG-filen som skal gjengis

#### Slik fungerer det

Kilden svg-filen støtter følgende egendefinerte hyperkoblingskoblinger for elementer i svg-filen

- **template://item/selected** - Vil definere formatet på objektet for å angi det valgte formatet i bildet
- **template://item/unselected** - Vil definere formatet på objektet for å angi det uvalgte formatet for elementer i bildet

Visuelle elementer med en hyperkobling av question:// vil bli brukt til å angi eller fjerne matrisen med verdier i settet med spørsmål. Denne funksjonen gir muligheten til interaktivt å endre hvordan andre spørsmål vises til brukeren. Hvis svg-filen for eksempel hadde to objekter med følgende hyperkoblinger:

- **question://roles/maker**
- **question://roles/architect**

Hvis brukeren velger disse objektene, kan andre elementer på siden vises for eksempel

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

Visuelle elementer med en hyperkobling av option:// vil bli brukt til å angi verdien av et alternativsett eller enkeltverdispørsmål. Hvis svg-filen for eksempel hadde to objekter med følgende hyperkoblinger:

- **option://type/A**
- **option://type/B**

```json
{
    "type": "html",
    "html": "Type A has been selected",
    "visibleIf": "{type} == 'A'"
}
```

## Spørsmål og svar

### **Spørsmål** Hvorfor har denne tilnærmingen blitt brukt i stedet for Microsoft Forms?

Bruken av spørsmålenes kortkode gjør at spørsmålene kan være en del av hver innholdsside i stedet for en egen lenke.

### **Spørsmål** Hvilke fordeler er det med denne tilnærmingen?

Følgende fordeler med denne tilnærmingen inkluderer

- Muligheten til å bruke bruksklare spørsmålstyper

- Opprettelsen av spørsmål er konfigurasjonsdrevet og krever bare kunnskap om JSon for å bygge spørsmål

- Spørsmålet rammeverket er utvidbar slik at nye funksjoner eller widgets som skal legges

- Ved å bruke JSon for spørsmålsdefinisjonene kan spørsmålene lagres i kildekontroll og gjennomgås og versjoneres over tid

### **Spørsmål** Kan denne fremgangsmåten brukes i Power App eller Power Page?

Absolutt, det samme JavaScript og spørsmål definisjoner kan brukes ved å lage en [Kode komponent](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **Spørsmål** Hvordan kan jeg forfatte spørsmålene om SVG-bildeoppgaver?

Et alternativ for å opprette svg-filene er [Microsoft Visio](https://www.microsoft.com/microsoft-365/visio/) Hvilken WLL eksporterer diagrammer til en SVG-fil med de nødvendige hyperkoblingene som er kompatible med **image-oppgave** Spørsmål.

### **Spørsmål** Kan jeg bruke Microsoft PowerPoint til å eksportere SVG-filer med bildeoppgavespørsmål?

Mens Microsoft Power Point kan eksportere et lysbilde til en SVG-fil første testsko, eksporterer den ikke hyperkoblingene som kreves for å lage en interaktiv **image-oppgave** arbeid vellykket.

### **Spørsmål** Mine eksporterte SVG-filer er store, kan jeg gjøre dem mindre?

Ett alternativ for SVG-filer for å gjøre dem mindre før du forplikter dem til kildekontroll. Det er flere verktøy som kan brukes til å krympe størrelsen på en SVG, ett alternativ å vurdere er [SVGO](https://github.com/svg/svgo) en NodeJs-basert SVG-optimaliserer.
