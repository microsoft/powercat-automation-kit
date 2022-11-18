---
title: "Richtlijnen voor het opstellen van richtlijnen"
description: "Automation Kit - Richtlijnen voor het schrijven van documentatie"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Documentation', 'Guidelines']
generated: ED14A36CD731A55AE5FC328528A10CB645825C47
---

In de volgende secties worden richtlijnen en opmerkingen voor het schrijven van startdocumentatie beschreven.

{{<toc>}}

## Richtsnoeren

In de volgende secties worden technische, ontwerp- en resultaatgebaseerde richtlijnen voor het schrijven van bijdragen beschreven

## Doelen

Bij het samenstellen van onze documentatie is het belangrijk om na te denken over hoe we onze lezers in staat stellen om **Val in de put van succes**.

Brad Abrams gedefinieerd [De put van succes in 2003](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) als

> De put van succes: in schril contrast met een top, een piek of een reis door een woestijn om de overwinning te vinden door middel van vele beproevingen
> en verrassingen, we willen dat onze klanten gewoon vervallen in winnende praktijken
> door gebruik te maken van ons platform en onze frameworks. In de mate dat we het gemakkelijk maken om in de problemen te komen, falen we.

Overweeg gezien dit doel het volgende:

- Zorg voor een "no cliffs experience"

  - Beheerders en centrale governanceteams helpen bij het maken van een selfservicemodel voor het gebruik van {{<product-name>}}

  - Gebruikers toestaan gebruik te maken van ontwikkelomgevingen om in handen te krijgen als een centrale omgeving niet beschikbaar is en ze functies willen hebben voordat een test of productie-implementatie van de {{<product-name>}}

  - Bespreek het gebruik van proefomgevingen met eenvoudige installatie om in handen te krijgen met de {{<product-name>}}

- Zorg voor een kanaal voor feedback. Geef opties voor klanten om input te geven over wat we kunnen verbeteren

### Bronbeheer

- Je hebt afgerond [Documentatie](/nl/contribution/documentation) stappen om wijzigingen naar de GitHub-opslagplaats te downloaden en te pushen
- Nieuwe wijzigingen worden gepusht naar een nieuwe vestiging en hebben een pull-aanvraag om wijzigingen te beoordelen
- Alle documentatie moet bestaan uit markdown, JSon of statische assets die versiebesturingselementen kunnen zijn en kunnen worden beoordeeld met behulp van het standaard pull-aanvraagproces

## Ontwerprichtlijnen

### Hoofdpagina

- Zorg voor een duidelijke titel en ondertitel die het doel van de starterservaring schetst
- Geef een call-to-action om andere gerelateerde gebeurtenissen op te nemen. Schrijf je bijvoorbeeld in voor Kantooruren.
- Koppeling naar de actie Aan de slag als primaire actie om nieuwe gebruikers aan boord te helpen
- Secundaire actie om deel te nemen aan kantooruren om een community van gebruikers op te bouwen
- Tegels van veelvoorkomende acties opnemen
- Overzichtslijst met functies die gebruikers helpen bij het beheren van hyperautomatieprojecten
- Voettekstnavigatie voor algemene koppelingen.

Lees de [Site configuratie](/nl/contribution/site-configuration) voor meer informatie over het configureren van de startpagina.

### Hergebruik

- Gebruik hugo-lay-outs om een nieuw thema op te geven of het huidige thema te overschrijven door inhoud in de map site\layouts te plaatsen
- Als u lay-outs wijzigt, moet statische HTML op veel hostinglocaties kunnen worden opgenomen. Bijvoorbeeld

  - GitHub-pagina's
  - Power-pagina's
  - Punt delen
  - Statische Azure-websites

- De aanpak kan door partners of klanten worden gebruikt als een sjabloon om "documentatiepakketten" te bouwen om de nuture-fase van {{<product-name>}} documentatie
- De mogelijkheid bieden voor meerdere gebruikers van de documentatie (bijv. Teams van klanten en partnercentra)
- Toestaan dat door de gebruiker geleverde inhoud wordt opgenomen
- Upgradeproces toestaan waarmee nieuwe wijzigingen kunnen worden opgehaald uit {{<product-name>}} starter documentatie

## Markdown-pagina's

- U kunt gebruik maken van [Visual Studio-code](https://code.visualstudio.com/) om de markeringsbestanden te bewerken

- Markdown-bestanden moeten zich in de map /site/content bevinden

- Elk markdown-bestand moet een gemeenschappelijke koptekst op elke pagina bevatten

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- Markdown-bestanden moeten shortcodes gebruiken om JavaScript in te sluiten

## shortcodes

Shortcodes bieden de mogelijkheid om dynamische inhoud op te nemen in een afwaarderingspagina. U kunt meer lezen over shortcodes van de [Hugo shortcode documentatie](https://gohugo.io/content-management/shortcodes/)

Dit project bevat ook extra shortcodes

### Inhoudsopgave

Voeg de **Inhoudsopgave** het volgen van shortcode naar uw markdown om een tabel met inhoud van markdown-headers op te nemen in de pagina omringd door \{\{ en \}\}

```html
<toc/>
```

### Vraag

Neem een reeks vragen op uw pagina op, omringd door \{\{ en \}\}

```html
<questions name="/content/en-us/foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

Parameters:

- **naam** De naam van het JSon-bestand met vragen die u wilt importeren. Lezen [Vragen](/nl/contribution/questions) voor meer informatie over de bestandsindeling van de vraag
- **volbracht** De tekst die moet worden weergegeven wanneer de vragen zijn voltooid
- **showNavigatieKnoppen** true/false-waarde naar de navigatieknoppen Volgende/Terug/Voltooid

### Externe afbeelding

Een afbeelding van een formaat van een externe bron opnemen in uw pagina omringd door \{\{ en \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

Parameters:

- **Src** Het bronpad naar de te importeren afbeelding
- **grootte** De grootte in pixels om het formaat van de bronafbeelding te wijzigen in
- **Sms** De alternatieve tekst die u bij de afbeelding wilt opnemen

## Notities

### GitHub-pagina's instellen

De volgende stappen werden gebruikt om de GitHub-pagina's voor de site in te stellen

1. Nieuwe verweesde tak gemaakt in git

    ```bash
    git checkout --orphan gh-pages
    ```

1. Wis de bestaande inhoud (bestanden en mappen)

    ```bash
    git clean -d -f
    ```

1. Hugo is geïnstalleerd

    - U kunt ook installeren met chocolatey op ramen
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. Hugo-uitvoer geconfigureerd om uit te voeren naar de map /docs

1. Test uw wijzigingen

    ```bash
    hugo serve
    ```

1. Als u de statische html-site in de sitemap wilt bouwen, voert u de volgende opdracht uit

    ```bash  
    hugo
    ```
 
1. Push je gh-pages branch naar GitHub

1. GitHub-project instellen om Pages in te schakelen

    - Zie Een publicatiebron configureren voor uw GitHub Pages-site - GitHub-documenten
    - Geselecteerde gh-pages branch en /docs map

### Afbeeldingsbadge voor startpagina bijwerken

Als u de afbeelding van de startpagina wilt aanpassen naar een status: Badge voor openbare voorvertoning Ga als volgt te werk:

1. Kloon de svg-badges repo

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. Modules installeren

    ```bash
    npm install
    ```

1. Start de webserver om badges te genereren

    ```bash
    npm run start
    ```

1. Badge genereren

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. Download de svg badge

1. Gebruik inkscape om bestaande svg te bewerken en resultaten op te slaan

1. Nieuwe afbeelding uploaden naar de map statisch\afbeeldingen\illustraties

1. De afbeelding config.yaml hero wijzigen

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## Vraag en antwoord

### **Vraag** Waarom is Hugo geselecteerd?

[Hugo](https://gohugo.io/) is een populaire statische sitegenerator die inhoud van de {{<product-name>}} starterdocumentatie die moet worden omgezet in statische HTML die kan worden gehost in GitHub-pagina's

### **Vraag** Waarom hebt u niet een andere statische sitegenerator geselecteerd?

Het kern power CAT-team had eerdere ervaring met Hugo

### **Vraag** Waarom is Microsoft Forms niet gebruikt voor vragen?

Een van de doelen van het ontwerp was om het vraagproces direct in de inhoud te integreren.

### **Vraag** Waarom GitHub-pagina's om inhoud te hosten?

De broncode voor de {{<product-name>}} bestaat al op GitHub en de ondersteuning van de native GitHub-pagina's was een keuze van waar de inhoud moest worden gehost.

### **Vraag** Waarom is deze inhoud niet ingeschakeld [http://learn.microsoft.com]()?

- Naarmate inhoud volwassener wordt tot algemeen herbruikbare begeleiding, kan deze migreren naar [https://learn.microsoft.com]()

- Een belangrijk ontwerpdoel wordt mogelijk gemaakt door GitHub-hosting

   - Sta actieve bijdrage van de community toe
   
   - Stimuleer het Nuture-proces van center of excellence, zodat documentatie kan worden hergebruikt door klanten en de partnergemeenschap

### **Vraag** Waarom wordt de aanpak niet toegepast op andere Power CAT-projecten?

De {{<product-name>}} experimenteert met dit kanaal van documentatie om onze bestaande te complimenteren en te koppelen aan onze bestaande [Leerinhoud](https://aka.ms/automation-kit-learn). Op basis van de feedback en de resultaten van dit experiment zullen we evalueren of andere door Power CAT beheerde projecten een vergelijkbare aanpak zullen volgen.

### **Vraag** Hoe zie ik problemen met openstaande documentatie?

U kunt onze [Problemen met open documentatie](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) bladzijde

### **Vraag** Hoe kan ik een nieuwe aanvraag voor een documentatiefunctie indienen?

Een nieuwe maken [Functieverzoek](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
