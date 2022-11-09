---
title: Vragen over het schrijven
description: Vragen over het ontwerpen van Automation Kit
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---
Deze pagina bevat informatie over de indeling die wordt gebruikt om interactieve vragen te stellen die zijn opgenomen als onderdeel van de {{<product-name>}} starter.

{{<toc>}}

## Slag

De vragen die worden gebruikt op de startpagina's van de kit zijn gebaseerd op [Open Source Survey JS Bibliotheek](https://github.com/surveyjs/survey-library). Met behulp van deze bibliotheek kunnen alle ondersteunde kant-en-klare besturingselementen worden gebruikt.

Om het raamwerk te begrijpen waar u naar kunt kijken

- De [Enquête JS Docs](https://surveyjs.io/form-library/documentation/overview)

- Eenvoudige vraagtypen zoals [Sms](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [Radio groepen](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [Selectievakje](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) of [Ranking](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- Voorwaardelijke zichtbaarheid gebruiken [zichtbaarIf](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- Bekijk enkele van de bestaande vragen die op de site worden gebruikt. Bijvoorbeeld de [Vragen over monitoring](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- Bekijk hoe u de shortcode kunt opnemen in uw inhoudsmarkering. Bijvoorbeeld [Afwaardering monitoren](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## Vragen insluiten in uw inhoud

Als u een reeks vragen op uw pagina wilt insluiten, kunt u het volgende toevoegen aan uw markering en de naam wijzigen in het vraagbestand waaruit u wilt lezen

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

De {{<product-name>}} bevat ook enkele extra functies die u binnen expressies kunt gebruiken.

### Len

De functie len retourneert de lengte van een tekenreeks of array

#### len voorbeeld

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### Bevat

De functie bevat retourneert true of false als de tekenreeks of array van tekenreeksen overeenkomt met de opgegeven waarde

#### bevat voorbeeld

Maakt element zichtbaar als een van de geselecteerde rollen maker is

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

Maakt element zichtbaar als een van de geselecteerde rollen maker of architect is

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## Aangepaste widgets

### Afbeeldingstaak

De {{<product-name>}} omvat ook de **image-taak** aangepaste widget. Deze widget kan worden opgenomen in uw vraagelementen met behulp van het volgende json-fragment.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### Eigenschappen

- **titel** - De tekst om aan de gebruiker weer te geven
- **type** - Moet beeld-taak zijn
- **Src** - De url van het SVG bestand weer te geven

#### Hoe het werkt

Het bron svg-bestand ondersteunt de volgende aangepaste hyperlinkkoppelingen voor elementen in uw svg-bestand

- **template://item/selected** - Definieert het formaat van het object om het geselecteerde formaat in de afbeelding in te stellen
- **template://item/unselected** - Definieert het formaat van het object om het niet-geselecteerde formaat van items in de afbeelding in te stellen
- **question://question-name/value** - Definieert het formaat van het object om het niet-geselecteerde formaat van items in de afbeelding in te stellen

Visuele elementen met een hyperkoppeling van question:// worden gebruikt om de array met waarden in de set vragen in of uit te stellen. Deze mogelijkheid biedt de mogelijkheid om interactief te wijzigen hoe andere vragen aan de gebruiker worden getoond. Bijvoorbeeld als het svg-bestand twee objecten had met de volgende hyperlinks:

- **question://roles/maker**
- **question://roles/architect**

Als de gebruiker deze objecten selecteert, kunnen bijvoorbeeld andere elementen op de pagina worden weergegeven

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

## Vraag en antwoord

### **Vraag** Waarom is deze aanpak gebruikt in plaats van Microsoft Forms?

Het gebruik van de vragen shortcode maakt het mogelijk om de vragen deel uit te laten maken van elke inhoudspagina in plaats van een afzonderlijke link.

### **Vraag** Welke voordelen zijn er aan deze aanpak?

De volgende voordelen van deze aanpak omvatten

- De mogelijkheid om kant-en-klare vraagtypen te gebruiken

- Het maken van vragen is configuratiegedreven en vereist alleen kennis van JSon om vragen te bouwen

- Het vragenframework is uitbreidbaar waardoor nieuwe functies of widgets kunnen worden toegevoegd

- Door JSon te gebruiken voor de vraagdefinities kunnen de vragen worden opgeslagen in bronbeheer en in de loop van de tijd worden beoordeeld en geversieerd

### **Vraag** Kan deze aanpak worden gebruikt in een Power App of Power Page?

Absoluut, dezelfde JavaScript- en vraagdefinities kunnen worden gebruikt door een [Code Component](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **Vraag** Hoe kan ik de SVG-afbeeldingstaakvragen maken?

Een optie om de svg-bestanden te maken is [Microsoft Visio](https://www.microsoft.com/microsoft-365/visio/) die diagrammen exporteren naar een svg-bestand met de vereiste hyperlinks die compatibel zijn met **image-taak** Vragen.

### **Vraag** Kan ik Microsoft PowerPoint gebruiken om SVG-bestanden met afbeeldingstaken te exporteren?

Hoewel Microsoft Power Point een dia kan exporteren naar een SVG-bestand, exporteert het niet de hyperlinks die nodig zijn om een interactieve **image-taak** succesvol werken.

### **Vraag** Mijn geëxporteerde SVG-bestanden zijn groot, kan ik ze kleiner maken?

Een optie voor SVG-bestanden om ze kleiner te maken voordat ze worden toegewezen aan bronbeheer. Er zijn meerdere tools die kunnen worden gebruikt om de grootte van een SVG te verkleinen, een optie om te overwegen is [Svgo](https://github.com/svg/svgo) een op NodeJs gebaseerde SVG-optimizer.
