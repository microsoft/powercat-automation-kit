---
title: "Planlegger"
description: "Automatiseringssett - Planlegger"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B97833AB30777C813B3E62592D32D7E5B882ACEE
---

{{<toc>}}

## Introduksjon

Automation Kit Scheduler gjør det mulig å vise tidsplanen for regelmessige Power Automate Cloud-flyter i løsninger som inkluderer kall til Power Automate Desktop-flyter.

Denne funksjonen ble oppdatert som en del av [Mars 2023](/nb/releases/march-2023), Senere utgivelser vil fortsette å forbedre og utvide funksjonaliteten planleggeren.

{{<border>}}
![Planlegger](/images/schedule.png)
{{</border>}}

De viktigste funksjonene i planleggeren er:

- Muligheten til å vise tidsplanen for regelmessige skyflyter
- Filtrer tidsplan etter maskin og maskingrupper
- Kjøre en Power Automate Desktop-flyt
- Vise tidsplan etter dag, uke, måned og tidsplanvisning
- Vise statusen for Planlagte flyter (Vellykket, Feil eller Planlagt)
- Vise varigheten av en Cloud Flow-kjøring
- Vis detaljer om eventuelle feil.

## Kjør flyt

### Skrivebeskyttet virkemåte for planlagte flyter

Når en flyt er planlagt for fremtidig kjøring, er den som standard satt til skrivebeskyttet modus og deaktivert for umiddelbar kjøring. Dette betyr at brukere ikke kan endre eller kjøre flyten før den planlagte datoen og klokkeslettet er passert. Denne virkemåten er utformet for å gi en bedre brukeropplevelse og forhindre utilsiktet kjøring av flyter før de er ment å kjøre.
Det er flere fordeler med denne tilnærmingen, inkludert:

- Forhindre utilsiktet kjøring: Ved å deaktivere umiddelbar kjøring av flyter som er planlagt for fremtidig kjøring, er det mindre sannsynlig at brukere ved et uhell kjører en flyt før den er ment å kjøre.

- Forbedret forutsigbarhet: Ved å sette flyter i skrivebeskyttet modus når de planlegges for fremtidig kjøring, kan brukere enklere forutsi når flyter vil kjøre og sikre at de har de nødvendige inndataene og ressursene klare.

- Konsekvent brukeropplevelse: Ved å standardisere virkemåten til planlagte flyter kan den gi en konsekvent og forutsigbar brukeropplevelse på tvers av alle forekomster av Flow.

- Hvis du vil endre eller kjøre en planlagt flyt, kan brukere redigere flyten og oppdatere den planlagte datoen og klokkeslettet. Når den nye tidsplanen er angitt, deaktiveres flyten igjen for umiddelbar kjøring og settes til skrivebeskyttet modus til den nye tidsplanen er passert.

## Feilmeldinger

Mulige feilmeldinger som kan oppstå når du kjører flyt.

### Feilmelding: "InvalidArgument - Finner ikke en gyldig tilkobling knyttet til den angitte tilkoblingsreferansen."

#### Beskrivelse

Denne feilmeldingen angir vanligvis at det er et problem med tilkoblingsreferansen som er angitt i koden eller konfigurasjonen. Systemet kan ikke finne en gyldig tilkobling knyttet til referansen, noe som hindrer det i å utføre den forespurte handlingen.

#### Årsaker

Det finnes flere mulige årsaker til denne feilmeldingen, inkludert:

- Feil eller ugyldig tilkoblingsreferanse: Den angitte tilkoblingsreferansen kan være ugyldig eller feil, noe som kan føre til at systemet ikke finner en gyldig tilkobling som er knyttet til den.

- Tilkoblingen er slettet eller endret: Hvis tilkoblingen som brukes i koden eller konfigurasjonen, er slettet eller endret, kan det føre til at systemet ikke finner en gyldig tilkobling som er knyttet til referansen.

- Tillatelsesproblem: Brukerkontoen som utfører koden eller konfigurasjonen, har kanskje ikke de nødvendige tillatelsene for å få tilgang til tilkoblingen eller ressursene som er knyttet til den.

#### Resolusjon

Hvis du vil løse dette problemet, kan du gjøre følgende:

- Kontroller tilkoblingsreferansen: Kontroller tilkoblingsreferansen som er angitt i koden eller konfigurasjonen, og kontroller at den er gyldig og riktig.

## Notater

For gjeldende versjon gjelder følgende merknader

1. Bare Power Automate Desktop- og Power Automate-løsninger i en løsning vises
1. Minst én Power Automate Desktop er registrert og utført

## Installere

For å installere planleggerløsningen kan du gjøre følgende:

1. Sikre rammeverket for Power Apps-komponenten <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Les også</a>
1. Du har installert Creator Kit i målmiljøet. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installer fra appkilde</a>
1. Du har lastet ned AutomationKit.zip-filen fra Aktiva-delen av den nyeste <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub-utgivelse</a>
1. Du har importert den nyeste AutomationKitScheduler_*_administrert.zip fil ved hjelp av. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Les også</a>

## Veikart

Du kan besøke vår <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-problemer</a> for å se foreslåtte nye funksjoner.

Du kan legge til en ny <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Forespørsel om planleggerfunksjon</a>

## Tilbakemelding

{{<questions name="/content/nb/features/scheduler.json" completed="Takk for at du gir tilbakemelding" showNavigationButtons="false" locale="nb">}}
