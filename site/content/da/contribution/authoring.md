---
title: Retningslinjer for oprettelse
description: Retningslinjer for oprettelse af dokumentationsmateriale til automatiseringssæt
sidebar: false
sidebarlogo: fresh-white
include_footer: true

generated: BA10815D9FEC78E27624D30D5760900841FA742C
---

I de følgende afsnit beskrives retningslinjer og noter til oprettelse af startdokumentation.

{{<toc>}}

## Retningslinjer

I de følgende afsnit beskrives tekniske, designmæssige og resultatbaserede retningslinjer for oprettelse af bidrag

## Mål

Når vi bygger vores dokumentation, er det vigtigt at overveje, hvordan vi gør det muligt for vores læsere at **Fald i succesens hul**.

Brad Abrams definerede [Succesen i 2003](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) som

> The Pit of Success: i skarp kontrast til et topmøde, en top eller en rejse gennem en ørken for at finde sejr gennem mange prøvelser
> og overraskelser, vi ønsker, at vores kunder simpelthen skal falde i vindende praksis
> ved at bruge vores platform og frameworks. I det omfang vi gør det let at komme i problemer, fejler vi.

I betragtning af dette mål overveje følgende:

- Giv en "ingen klippeoplevelse"

  - Hjælp administratorer og centrale styringsteams med at oprette en selvbetjeningsmodel til brug af {{<product-name>}}

  - Tillad brugere at gøre brug af udviklingsmiljøer til at få fat i, hvis et centralt miljø ikke er tilgængeligt, og de vil have funktioner før en test- eller produktionsinstallation af {{<product-name>}}

  - Diskuter brugen af prøvemiljøer med nem opsætning for at få fat i {{<product-name>}}

- Giv en kanal til feedback. Giv kunderne mulighed for at komme med input til, hvad vi kan forbedre

### Kontrol af kilder

- Du har gennemført [Dokumentation](/da/contribution/documentation) trin til at downloade og skubbe ændringer til GitHub-lageret
- Nye ændringer skubbes til en ny gren og har en pullanmodning om at gennemgå ændringer
- Al dokumentation skal enten være markdown, JSon eller statiske aktiver, der kan versionskontrolleres og gennemgås ved hjælp af standard pull-anmodningsproces

## Retningslinjer for design

### Hjemmeside

- Har klar titel og undertekst, der skitserer formålet med startoplevelsen
- Giv en opfordring til handling for at inkludere andre relaterede begivenheder. Tilmeld dig f.eks. kontortid.
- Link til Introduktion som den primære handling for at hjælpe nye brugere med at onboarde
- Sekundær handling for at deltage i kontortid for at hjælpe med at opbygge et fællesskab af brugere
- Medtag felter med almindelige handlinger
- Oversigtsliste over funktioner, der hjælper brugerne med at administrere hyperautomatiseringsprojekter
- Sidefodsnavigation til almindelige links.

Læs [Konfiguration af websted](/da/contribution/site-configuration) for mere information om konfiguration af startsiden.

### Genbrug

- Brug hugo-layout til at kunne angive nyt tema eller tilsidesætte det aktuelle tema ved at placere indhold i mappen site\layouts
- Ændring af layout skal gøre det muligt at inkludere statisk HTML på mange hostingplaceringer. For eksempel

  - GitHub-sider
  - Power-sider
  - Del point
  - Statiske Azure-websteder

- Tilgangen kan bruges som skabeloner af partnere eller kunder til at opbygge "dokumentationspakker" for at fremskynde plejefasen af {{<product-name>}} dokumentation
- Giv mulighed for flere brugere af dokumentationen (f.eks. kunde- og partnercenterteams)
- Tillad, at brugerleveret indhold medtages
- Tillad opgraderingsproces, der gør det muligt at hente nye ændringer fra {{<product-name>}} Dokumentation til start

## Markdown sider

- Du kan bruge [Visual Studio-kode](https://code.visualstudio.com/) Sådan redigeres markdown-filerne

- Markdown-filer skal være placeret i mappen /site/content

- Hver markdown-fil skal indeholde fælles header på hver side

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- Markdown-filer skal bruge kortkoder til at integrere ethvert JavaScript

## kortkoder

Korte koder giver mulighed for at inkludere dynamisk indhold på en markdown-side. Du kan læse mere om kortkoder fra [Hugo kortkode dokumentation](https://gohugo.io/content-management/shortcodes/)

Dette projekt indeholder også yderligere kortkoder

### Indholdsfortegnelse

Tilføj **Indholdsfortegnelsen** følgende kortkode til din markdown for at inkludere en indholdsfortegnelse med markdown-overskrifter på siden omgivet af \{\{ og \}\}

```html
<toc/>
```

### Spørgsmål

Medtag et sæt spørgsmål på din side omgivet af \{\{ og \}\}

```html
<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

Parametre:

- **Navn** Navnet på den JSon-fil, der indeholder spørgsmål, der skal importeres. Læse [Spørgsmål](/da/contribution/questions) For mere information om spørgsmålsfilformat
- **Afsluttet** Den tekst, der skal vises, når spørgsmålene er afsluttet
- **showNavigationButtons** true/falsk værdi til sko Næste/Tilbage/Fuldført navigationsknapper

### Eksternt billede

Medtag et billede i størrelse fra en ekstern kilde på din side omgivet af \{\{ og \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

Parametre:

- **Src** Kildestien til det billede, der skal importeres
- **størrelse** Størrelsen i pixels for at ændre størrelsen på kildebilledet til
- **Tekst** Den alternative tekst, der skal medtages i billedet

## Noter

### Opsætning af GitHub-sider

Følgende trin blev brugt til at konfigurere GitHub-siderne for webstedet

1. Oprettede ny forældreløs gren i git

    ```bash
    git checkout --orphan gh-pages
    ```

1. Ryd det eksisterende indhold (filer og mapper)

    ```bash
    git clean -d -f
    ```

1. Hugo er installeret

    - Du kan også installere med chokolade på vinduer
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. Hugo-output konfigureret til output til / docs-mappen

1. Test dine ændringer

    ```bash
    hugo serve
    ```

1. For at opbygge dig statiske html-websted inde i webstedsmappen skal du køre følgende kommando

    ```bash  
    hugo
    ```
 
1. Skub din gh-sider-gren til GitHub

1. Konfigurer GitHub-projekt for at aktivere sider

    - Se Konfiguration af en udgivelseskilde til dit GitHub-sidewebsted - GitHub Docs
    - Markeret gh-sider gren og /docs mappe

### Opdater hjemmesidens billedbadge

Hvis du vil tilpasse billedet på startsiden til badget Status: Offentlig prøveversion, gør jeg følgende:

1. Klon svg-badges repo

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. Installer moduler

    ```bash
    npm install
    ```

1. Start webserveren for at generere badges

    ```bash
    npm run start
    ```

1. Generer badge

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. Download svg-badget

1. Brug inkscape til at redigere eksisterende svg og gemme resultater

1. Upload nyt billede til mappen static \images\illustrations

1. Ændre config.yaml hero-billedet

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## Spørgsmål og svar

### **Spørgsmål** Hvorfor blev Hugo valgt?

[Hugo](https://gohugo.io/) er en populær statisk webstedsgenerator, der tillader indhold af {{<product-name>}} startdokumentation, der skal transformeres til statisk HTML, der kan hostes på GitHub-sider

### **Spørgsmål** Hvorfor valgte du ikke en anden statisk webstedsgenerator?

Det centrale Power CAT-team havde tidligere erfaring med at bruge Hugo

### **Spørgsmål** Hvorfor blev Microsoft Forms ikke brugt til spørgsmål?

Et designmål var at integrere spørgeprocessen direkte i indholdet.

### **Spørgsmål** Hvorfor GitHub-sider til hosting af indhold?

Kildekoden til {{<product-name>}} findes allerede på GitHub, og understøttelsen af de oprindelige GitHub-sider var et valg af, hvor indholdet skulle hostes.

### **Spørgsmål** Hvorfor er dette indhold ikke tændt [http://learn.microsoft.com]()?

- Efterhånden som indholdet modnes til almindeligt genanvendelig vejledning, kan det migrere til [https://learn.microsoft.com]()

- Et vigtigt designmål er aktiveret af GitHub-hosting

   - Tillad aktivt samfundsbidrag
   
   - Fremme plejeprocessen i Center of Excellence, så dokumentation kan genbruges af kunder og partnerfællesskab

### **Spørgsmål** Hvorfor anvendes tilgangen ikke på andre Power CAT-projekter?

Den {{<product-name>}} eksperimenterer med denne dokumentationskanal for at komplimentere og linke til vores eksisterende [Læringsindhold](https://aka.ms/automation-kit-learn). Baseret på feedback og resultat af dette eksperiment vil vi evaluere, om andre Power CAT-styrede projekter vil vedtage en lignende tilgang.

### **Spørgsmål** Hvordan kan jeg se problemer med åben dokumentation?

Du kan besøge vores [Problemer med åben dokumentation](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) side

### **Spørgsmål** Hvordan rejser jeg en anmodning om en ny dokumentationsfunktion?

Opret en ny [Anmodning om funktion](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
