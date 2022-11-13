---
title: "Retningslinjer for redigering"
description: "Automation Kit – retningslinjer for redigering av dokumentasjon"
sidebar: false
sidebarlogo: fresh-white
include_footer: true

generated: E4B23EEC2B540A4AF01501764C42DFF50F0CBC8C
---

Delene nedenfor beskriver retningslinjer og merknader for redigering av startdokumentasjon.

{{<toc>}}

## Retningslinjer

De følgende avsnittene skisserer tekniske, design- og resultatbaserte retningslinjer for redigering av bidrag

## Mål

Når vi bygger dokumentasjonen vår, er det viktig å vurdere hvordan vi gjør det mulig for leserne våre å **Fall i gropen av suksess**.

Brad Abrams definert [Suksessgropen i 2003](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) som

> The Pit of Success: i sterk kontrast til en topp, en topp eller en reise over en ørken for å finne seier gjennom mange prøvelser
> og overraskelser, vi vil at kundene våre bare skal falle inn i vinnende praksis
> ved å bruke vår plattform og rammeverk. I den grad vi gjør det enkelt å komme i trøbbel, mislykkes vi.

Gitt dette målet, bør du vurdere følgende:

- Gi en "ingen klipper opplevelse"

  - Hjelp administratorer og sentrale styringsteam med å opprette en selvbetjeningsmodell for bruk av {{<product-name>}}

  - Tillat brukere å bruke utviklingsmiljøer for å få tak i dette hvis et sentralt miljø ikke er tilgjengelig og de vil ha funksjoner før en test- eller produksjonsdistribusjon av {{<product-name>}}

  - Diskuter bruk av prøveversjonsmiljøer med enkelt oppsett for å få tak i {{<product-name>}}

- Gi en kanal for tilbakemelding. Gi kundene muligheter til å komme med innspill til hva vi kan forbedre

### Kildekontroll

- Du har fullført [Dokumentasjon](/nb/contribution/documentation) trinn for å laste ned og overføre endringer til GitHub-repositoriet
- Nye endringer sendes til en ny gren og har en pull-forespørsel for å se gjennom endringer
- All dokumentasjon bør være enten markdown, JSon eller statiske ressurser som kan versjonskontrolleres og gjennomgås ved hjelp av standard pull-forespørselsprosess

## Retningslinjer for utforming

### Hjemmeside

- Ha tydelig tittel og undertekst som skisserer målet med startopplevelsen
- Gi en oppfordring til handling for å inkludere andre relaterte hendelser. For eksempel registrere deg for kontortid.
- Kobling til Komme i gang-handlingen som den primære handlingen for å hjelpe nye brukere med å komme i gang
- Sekundær handling for å bli med i kontortiden for å bidra til å bygge fellesskap av brukere
- Inkluder fliser med vanlige handlinger
- Sammendragsliste over funksjoner som hjelper brukerne med å administrere hyperautomatiseringsprosjekter
- Bunntekstnavigasjon for vanlige koblinger.

Les gjennom [Konfigurasjon av nettsted](/nb/contribution/site-configuration) for mer informasjon om konfigurering av hjemmesiden.

### Gjenbruk

- Bruk hugo oppsett for å kunne spesifisere nytt tema eller overstyre gjeldende tema ved å plassere innhold i site \ layouts mappe
- Endring av oppsett bør tillate statisk HTML å bli inkludert i mange vertssteder. For eksempel

  - GitHub-sider
  - Power Sider
  - Del poeng
  - Azure Statiske nettsteder

- Tilnærmingen kan brukes som en mal av partnere eller kunder for å bygge "dokumentasjonspakker" for å akselerere kjernefasen av {{<product-name>}} dokumentasjon
- Gi mulighet for flere brukere av dokumentasjonen (f.eks. kunde- og partnersenter for fremragende forskning)
- Tillat at brukerlevert innhold inkluderes
- Tillat oppgraderingsprosess som gjør det mulig å hente nye endringer fra {{<product-name>}} starter dokumentasjon

## Markdown-sider

- Du kan bruke [Visual Studio-kode](https://code.visualstudio.com/) Slik redigerer du Markdown-filene

- Markdown-filer skal være plassert i /site/content-mappen

- Hver markdown-fil skal inneholde felles topptekst på hver side

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- Markdown-filer bør bruke kortkoder for å bygge inn JavaScript

## kortkoder

Kortkoder gir muligheten til å inkludere dynamisk innhold på en markdown-side. Du kan lese mer om kortkoder fra [Hugo kortkode dokumentasjon](https://gohugo.io/content-management/shortcodes/)

Dette prosjektet inneholder også flere kortkoder

### Innholdsfortegnelse

Legg til **innholdsfortegnelse** følge kortkode til markdown for å inkludere en innholdsfortegnelse med markdown-overskrifter på siden omgitt av \{\{ og \}\}

```html
<toc/>
```

### Spørsmål

Inkluder et sett med spørsmål på siden din omgitt av \{\{ og \}\}

```html
<questions name="/content/en-us/foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

Parametere:

- **navn** Navnet på JSon-filen som inneholder spørsmål som skal importeres. Lese [Spørsmål](/nb/contribution/questions) for mer informasjon om spørsmålsfilformat
- **Fullført** Teksten som skal vises når spørsmålene er fullført
- **showNavigationButtons** sann/usann-verdi til skoen Neste/Tilbake/Fullført navigasjonsknapper

### Eksternt bilde

Inkluder et størrelsesbilde fra en ekstern kilde på siden din omgitt av \{\{ og \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

Parametere:

- **Src** Kildebanen til bildet som skal importeres
- **størrelse** Størrelsen i piksler for å endre størrelsen på kildebildet til
- **Tekst** Den alternative teksten som skal inkluderes i bildet

## Notater

### Oppsett av GitHub-sider

Følgende trinn ble brukt til å konfigurere GitHub-sidene for området

1. Opprettet ny foreldreløs gren i git

    ```bash
    git checkout --orphan gh-pages
    ```

1. Fjerne eksisterende innhold (filer og mapper)

    ```bash
    git clean -d -f
    ```

1. Hugo er installert

    - Du kan også installere med chocolatey på vinduer
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. Hugo utgang konfigurert til å sende ut til / docs mappe

1. Teste endringene

    ```bash
    hugo serve
    ```

1. For å bygge deg statisk html-området inne i mappen mappen kjøre følgende kommando

    ```bash  
    hugo
    ```
 
1. Skyv gh-pages-grenen til GitHub

1. Konfigurer GitHub-prosjektet for å aktivere sider

    - Se Konfigurere en publiseringskilde for GitHub Pages-nettstedet – GitHub-dokumenter
    - Valgt gh-pages gren og /docs-mappe

### Oppdater bildemerke for startsiden

Hvis du vil tilpasse bildet på hjemmesiden til et Status: Offentlig forhåndsvisning-merke, gjør jeg følgende:

1. Klone svg-merker repo

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. Installere moduler

    ```bash
    npm install
    ```

1. Start webserveren for å generere merker

    ```bash
    npm run start
    ```

1. Generere merke

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. Last ned svg-merket

1. Bruk inkscape til å redigere eksisterende svg og lagre resultater

1. Last opp nytt bilde til mappen static\images\illustrations

1. Endre config.yaml-heltebildet

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## Spørsmål og svar

### **Spørsmål** Hvorfor ble Hugo valgt?

[Hugo](https://gohugo.io/) er en populær statisk nettsted generator som tillater innholdet i {{<product-name>}} startdokumentasjon som skal transformeres til statisk HTML som kan driftes på GitHub-sider

### **Spørsmål** Hvorfor valgte du ikke en annen statisk nettstedgenerator?

Kjernen i Power CAT-teamet hadde tidligere erfaring med å bruke Hugo

### **Spørsmål** Hvorfor ble ikke Microsoft Forms brukt til spørsmål?

Et designmål var å integrere spørsmålsprosessen direkte i innholdet.

### **Spørsmål** Hvorfor skal GitHub-sider være vert for innhold?

Kildekoden for {{<product-name>}} finnes allerede på GitHub, og den opprinnelige GitHub-sidestøtten var et valg av hvor innholdet skulle hostes.

### **Spørsmål** Hvorfor er dette innholdet ikke på [http://learn.microsoft.com]()?

- Etter hvert som innholdet modnes til vanlig gjenbrukbar veiledning, kan det overføres til [https://learn.microsoft.com]()

- Et viktig designmål aktiveres av GitHub-hosting

   - Tillat aktivt bidrag fra fellesskapet
   
   - Foster Nuture-prosessen til Center of Excellence, slik at dokumentasjon kan gjenbrukes av kunder og partnerfellesskap

### **Spørsmål** Hvorfor brukes ikke tilnærming til andre Power CAT-prosjekter?

Den {{<product-name>}} eksperimenterer med denne dokumentasjonskanalen for å komplimentere og lenke til vår eksisterende [Læringsinnhold](https://aka.ms/automation-kit-learn). Basert på tilbakemeldingene og resultatet av dette eksperimentet vil vi evaluere om andre Power CAT-styrte prosjekter vil vedta en lignende tilnærming.

### **Spørsmål** Hvordan ser jeg problemer med åpen dokumentasjon?

Du kan besøke vår [Åpne dokumentasjonsproblemer](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) side

### **Spørsmål** Hvordan sender jeg inn en ny forespørsel om dokumentasjonsfunksjoner?

Opprett en ny [Forespørsel om funksjon](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
