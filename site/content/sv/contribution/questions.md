---
title: "Frågor om redigering"
description: "Automation Kit - Frågor om redigering"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 2FDE38C6576920DE548EFE209151F9776EB47B41
---

Den här sidan innehåller information om det format som används för att skapa interaktiva frågor som ingår som en del av {{<product-name>}} förrätt.

{{<toc>}}

## Komma igång

Frågorna som används på kitstartsidorna baseras på [JS-bibliotek för undersökning med öppen källkod](https://github.com/surveyjs/survey-library). Med det här biblioteket kan alla färdiga kontroller som stöds användas.

För att förstå ramverket kan du titta på

- Den [Undersökning JS-dokument](https://surveyjs.io/form-library/documentation/overview)

- Enkla frågetyper som [SMS](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [Radiogrupper](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [Kryssruta](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) eller [Rankning](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- Använda villkorlig synlighet [visibleIf](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- Granska några av de befintliga frågorna som används på webbplatsen. Till exempel [Frågor om övervakning](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- Läs om hur du inkluderar den korta koden i innehållsmarkeringen. Till exempel [Övervakning av markdown](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## Bädda in frågor i ditt innehåll

Om du vill bädda in en uppsättning frågor på din sida kan du lägga till följande i din markdown och ändra namnet till frågefilen du vill läsa från

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

Den {{<product-name>}} innehåller också några ytterligare funktioner som du kan använda inuti uttryck.

### Len

Funktionen len returnerar längden på en sträng eller matris

#### len exempel

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### Innehåller

Funktionen contains returnerar true eller false om strängen eller matrisen med strängar matchar det angivna värdet

#### innehåller exempel

Kommer att göra elementet synligt om en av de valda rollerna är skapare

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

Kommer att göra elementet synligt om en av de valda rollerna är maker eller arkitekt

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## Anpassade widgets

### Bild uppgift

Den {{<product-name>}} inkluderar även **bild-uppgift** anpassad widget. Den här widgeten kan inkluderas i dina frågeelement med hjälp av följande json-kodfragment.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### Egenskaper

- **titel** - Texten som ska visas för användaren
- **typ** - Måste vara bild-uppgift
- **Src** - Url:en till SVG-filen som ska återges

#### Så funkar det

Källfilen svg stöder följande anpassade hyperlänklänkar för element i svg-filen

- **template://item/selected** - Kommer att definiera objektets format för att ställa in det valda formatet i bilden
- **template://item/unselected** - Kommer att definiera objektets format för att ställa in det omarkerade formatet för objekt i bilden

Visuella element med en hyperlänk av question:// kommer att användas för att ställa in eller ta bort matrisen med värden i uppsättningen frågor. Den här möjligheten ger möjlighet att interaktivt ändra hur andra frågor visas för användaren. Till exempel om svg-filen hade två objekt med följande hyperlänkar:

- **question://roles/maker**
- **question://roles/architect**

Om användaren väljer dessa objekt kan andra element på sidan visas till exempel

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

Visuella element med en hyperlänk av option:// kommer att användas för att ställa in värdet på en alternativuppsättning eller en enda värdefråga. Till exempel om svg-filen hade två objekt med följande hyperlänkar:

- **option://type/A**
- **option://type/B**

```json
{
    "type": "html",
    "html": "Type A has been selected",
    "visibleIf": "{type} == 'A'"
}
```

## Fråga och svar

### **Fråga** Varför har den här metoden använts i stället för Microsoft Forms?

Användningen av frågekortkoden gör att frågorna kan vara en del av varje innehållssida snarare än en separat länk.

### **Fråga** Vilka fördelar finns det med detta tillvägagångssätt?

Följande fördelar med detta tillvägagångssätt inkluderar

- Möjligheten att använda färdiga frågetyper

- Skapandet av frågor är konfigurationsdrivet och kräver endast kunskap om JSon för att skapa frågor

- Frågeramverket är utökningsbart så att nya funktioner eller widgets kan läggas till

- Genom att använda JSon för frågedefinitionerna kan frågorna lagras i källkontroll och granskas och versionshanteras över tid

### **Fråga** Kan den här metoden användas i en Power App eller Power Page?

Absolut, samma JavaScript- och frågedefinitioner kan användas genom att skapa en [Kod komponent](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **Fråga** Hur kan jag skapa SVG-bilduppgiftsfrågorna?

Ett alternativ för att skapa svg-filerna är [Microsoft Visio](https://www.microsoft.com/microsoft-365/visio/) Vilka WLL exporterar diagram till en SVG-fil med nödvändiga hyperlänkar som är kompatibla med **bild-uppgift** frågor.

### **Fråga** Kan jag använda Microsoft PowerPoint för att exportera SVG-filer med bilduppgiftsfrågor?

Microsoft Power Point kan exportera en bild till en SVG-fil inledande testsko, men den exporterar inte de hyperlänkar som krävs för att göra en interaktiv **bild-uppgift** arbeta framgångsrikt.

### **Fråga** Mina exporterade SVG-filer är stora kan jag göra dem mindre?

Ett alternativ för SVG-filer att göra dem mindre innan de åtar sig källkontroll. Det finns flera verktyg som kan användas för att krympa storleken på en SVG, ett alternativ att överväga är [svgo](https://github.com/svg/svgo) en NodeJs-baserad SVG-optimerare.
