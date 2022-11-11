---
title: "Administrasjon av Power CAT-programmets livssyklus (ALM)"
description: "Automatiseringssett – ALM Power CAT"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 0087DF5B505764347AC2AF0B6C170474826A5D65
---

{{<slideStyles>}}

<div class="optional">

Automatiseringssettet utnytter [ALM-akselerator](https://aka.ms/aa4pp) for å tilby ALM-funksjonalitet for løsninger som inkluderer Power Automate Desktop

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## Distribusjonsprosess for GitHub

I likhet med utgivelsesprosessen som brukes for andre Power CAT-administrerte sett, er {{<product-name>}} bruker ALM Accelerator til å distribuere utgivelser til våre offentlige GitHub-utgivelser.

Den interne prosessen vår har et Power Platform-miljø for utvikling, test og produksjon. Når vi er klare for en utgivelse, pakker våre integrerte GitHub-handlinger de administrerte og uadministrerte distribusjonsløsningene sammen med produktmerknader automatisk for en GitHub Draft-utgivelse.

Når utkastet til utgivelsen er klar, kan vi publisere nye versjoner eller hurtigreparasjoner etter behov.

### Hva dette betyr for deg

Nå som vi har denne automatiseringen på plass, har den automatiserte ALM-utgivelsen følgende fordeler for deg:

- Innsyn i all kildekoden med lav kode som utgjør automatiseringssettet, slik at du kan undersøke hvordan vi har bygget settet.

- Strømlinjeformet automatiseringsprosess som kan reagere raskt på feil eller problemer og gi hurtigreparasjoner om nødvendig.

- Automatisk kompilering av alle feil og funksjoner som er inkludert i en utgivelse.

- Vi inkluderer Power Apps, Power Automate, Dataverse og Power Automate Desktop som en del av ALM-prosessen for kontinuerlig integrering / kontinuerlig distribusjon.

## Veikart

Du kan undersøke våre åpne ALM-relaterte etterslepsposter i vår [Register for GitHub-problemer](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

Alt i alt bygger vi videre på de eksisterende bruksklare Power Platform- og Microsoft DevOps-produktfunksjonene sammen ALM Accelerator. Denne kombinasjonen lar oss fokusere på spesifikke utvidelser som hjelper med hyperautomtion.

## Tilbakemelding

{{<questions name="/content/nb/features/alm/powercat.json" completed="Takk for at du gir tilbakemelding" shownavigationbuttons="false" locale="nb">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Power CAT-teamet bruker ALM-akseleratoren til å bygge og distribuere hver av våre [Utgivelser](https://github.com/microsoft/powercat-automation-kit/releases).

Hver utgivelse fremmer endringer fra utviklingen vår til test- og produksjonsmiljøer. Power Platform-løsningene i settet bruker en automatisert prosess til å pakke ressurser for distribusjon til offentlige GitHub-utgivelser.

I fremtidige milepæler vil vi utvide på eksisterende plattform [ALM-funksjoner](/nb/features/alm) for å gi eksempler på hvordan du inkluderer valideringsregler og visuell sammenligning av RPA-eksempler som en del av DevOps-prosessen.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

Følgende beskriver viktige trinn i utgivelsesprosessen for automatiseringssettet:

1. Endringer som gjøres i Power Platform Dev-miljøet, lagres i en filial i det offentlige GitHub-repositoriet

2. Når endringer er klare for inkludering i en testversjon, slås de sammen til hovedgrenen ved hjelp av en henteforespørsel. Før pull-forespørselen kan fullføres, må Azure DevOps-valideringspipelinen fullføres og pull-forespørselen gjennomgås.

3. Når pull-forespørselen har bestått de automatiserte kontrollene og mottatt godkjenningen for gjennomgang, kan den slås sammen til hovedgrenen. Denne flettingen utløser testdatasamlebåndet for Azure DevOps-kompilering som publiserer den administrerte versjonen til testmiljøet i Power Platform.

4. Etter intern testing utløses Azure DevOps-produksjonspipelinen manuelt for å generere en Power Platform-distribusjon for produksjon.

5. Når utgivelsen er klar, oppretter Azure DevOps-datasamlebåndet et utkast til utgivelse, inkludert produktmerknader og build-ressurser. Den endelige versjonen vil lukke alle åpne problemer og lukke milepælen. Publisert build-kode GitHub-repositoriet med en Måned og år-etikett brukt.

{{</slide>}}
