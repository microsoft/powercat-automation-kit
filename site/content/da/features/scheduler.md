---
title: "Planlægger"
description: "Automatiseringssæt - Planlægger"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 48371CA8CFDFD0F4020EBF42F1E13B1B5B8901F9
---

{{<toc>}}

## Indførelsen

Automatiseringspakken Scheduler giver mulighed for at få vist tidsplanen for tilbagevendende Power Automate Cloud-flows i løsninger, der omfatter opkald til Power Automate Desktop-flows.

Denne funktion blev opdateret som en del af [Marts 2023](/da/releases/march-2023), Senere udgivelser vil fortsætte med at forbedre og udvide funktionaliteten i planlæggeren.

{{<border>}}
![Planlægger](/images/schedule.png)
{{</border>}}

De vigtigste funktioner i planlæggeren er:

- Muligheden for at få vist tidsplanen for tilbagevendende cloudflows
- Filtrer tidsplan efter maskin- og maskingrupper
- Køre et Power Automate Desktop-flow
- Se tidsplan efter dag, uge, måned og tidsplanvisning
- Få vist status for planlagte flow (Fuldført, Mislykket eller Planlagt)
- Se varigheden af en Cloud Flow-kørsel
- Se detaljerne om eventuelle fejl.

## Cloud-flow

Som nævnt ovenfor er det kun cloudflows, der er inkluderet som en del af en løsning. Den seneste [https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/) indeholder oplysninger om, hvordan du bruger den nye prøveversion af "Dataverse-løsninger som standard" til at sikre, at cloudflows er inkluderet i løsninger. Brug af denne funktion kan hjælpe brugerne med at sikre, at de planlagte cloudflows, der oprettes, er synlige i planlæggeren.

## Kalendervisninger

## Dag, uge, måned visninger

Dag-, uge- og månedsvisningerne viser oplysninger om Desktop Cloud-flowkørsler, der er udført eller er planlagt til at blive udført.

Elementer er farvekodet som følger:

- Grøn angiver vellykket løb

- Rød angiver mislykket kørsel

- Blå angiver en planlagt fremtidig kørsel.

Status- og kørselsoplysningerne er tilgængelige med lang berøring eller svævemus på begivenheden.

### Køreplan

{{<border>}}
![Planlægger - Kør nu](/images/scheduler-schedule-view.png)
{{</border>}}

Tidsplanvisningen indeholder et sæt cloudflow baseret på tid fra det aktuelle tidspunkt og fremtidige planlagte flow i løbet af de næste dage.

## Kør nu

{{<border>}}
![Planlægger - Kør nu](/images/scheduler-run-now.png)
{{</border>}}

Den aktuelle version af Kør nu udfører Power Automate-skrivebordet. Det antages, at der ikke kræves nogen parametre for at udføre skrivebordsflowet. De yderligere kørselsoplysninger er tilgængelige i oplysningerne om seneste kørsel på skrivebordet.

### Planlagte ændringer

I fremtidige udgivelser betragtes følgende som nye funktioner:

1. Udfør cloudflowet i stedet for skrivebordsflowet. Dette omfatter derefter historik for kørsel af cloudflow og udførelse af eventuelle yderligere cloudflowhandlinger og parametre, der overføres til skrivebordsflowet.

2. Åbn desktop- og cloudflow-kørselssider.

### Skrivebeskyttet funktionsmåde for planlagte flows

Når et flow er planlagt til fremtidig udførelse, er det som standard indstillet til skrivebeskyttet tilstand og deaktiveret til øjeblikkelig udførelse. Det betyder, at brugerne ikke kan ændre eller udføre flowet, før den planlagte dato og det planlagte klokkeslæt er overskredet. Denne funktionsmåde er designet til at give en bedre brugeroplevelse og forhindre utilsigtet udførelse af flows, før de er beregnet til at køre.
Der er flere fordele ved denne tilgang, herunder:

- Forebyggelse af utilsigtet udførelse: Ved at deaktivere øjeblikkelig udførelse af flows, der er planlagt til fremtidig udførelse, er det mindre sandsynligt, at brugerne kører et flow ved et uheld, før det er beregnet til at køre.

- Forbedret forudsigelighed: Ved at indstille flows til skrivebeskyttet tilstand, når de er planlagt til fremtidig udførelse, kan brugerne lettere forudsige, hvornår flows kører, og sikre, at de har de nødvendige input og ressourcer klar.

- Ensartet brugeroplevelse: Ved at standardisere funktionsmåden for planlagte flows kan den give en ensartet og forudsigelig brugeroplevelse på tværs af alle forekomster af Flow.

- Hvis du vil ændre eller udføre et planlagt flow, kan brugerne redigere flowet og opdatere den planlagte dato og det planlagte klokkeslæt. Når den nye tidsplan er indstillet, deaktiveres flowet igen til øjeblikkelig udførelse og indstilles til skrivebeskyttet tilstand, indtil den nye tidsplan er gået.

## Fejlmeddelelser

Mulige fejlmeddelelser, der kan opstå under udførelse af kørselsflow.

### Fejlmeddelelse: "InvalidArgument - Kan ikke finde en gyldig forbindelse, der er knyttet til den angivne forbindelsesreference."

#### Beskrivelse: __________

Denne fejlmeddelelse angiver typisk, at der er et problem med forbindelsesreferencen i koden eller konfigurationen. Systemet kan ikke finde en gyldig forbindelse, der er knyttet til referencen, hvilket forhindrer det i at udføre den ønskede handling.

#### Årsager

Der er flere mulige årsager til denne fejlmeddelelse, herunder:

- Forkert eller ugyldig forbindelsesreference: Den angivne forbindelsesreference kan være ugyldig eller forkert, hvilket kan medføre, at systemet ikke kan finde en gyldig forbindelse, der er knyttet til det.

- Forbindelse slettet eller ændret: Hvis den forbindelse, der bruges i koden eller konfigurationen, er blevet slettet eller ændret, kan det medføre, at systemet ikke kan finde en gyldig forbindelse, der er knyttet til referencen.

- Problem med tilladelser: Den brugerkonto, der udfører koden eller konfigurationen, har muligvis ikke de nødvendige tilladelser til at få adgang til forbindelsen eller de ressourcer, der er knyttet til den.

#### Opløsning

Du kan løse dette problem ved at udføre følgende fremgangsmåde:

- Bekræft forbindelsesreferencen: Kontroller forbindelsesreferencen i koden eller konfigurationen, og sørg for, at den er gyldig og korrekt.

- Slet eksisterende forbindelser, og genskab: Hvis flowkontrollen advarer om, at der ikke er brugt en forbindelsesreference, kan du bruge flowkontrollen til at slette eksisterende forbindelser. Når forbindelserne er slettet, kan du genskabe forbindelsesreferencer til gruppen Maskine eller Maskine for at gøre det muligt at køre flowet.

## Noter

For den aktuelle version gælder følgende bemærkninger

1. Kun Power Automate Desktop- og Power Automate-løsninger, der er indeholdt i en løsning, vises
1. Mindst ét Power Automate Desktop er blevet registreret og udført

## Installere

For at installere planlægningsløsningen kan du gøre følgende:

1. Sørg for, at Power Apps component framework er aktiveret <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Læs mere</a>
1. Du har installeret Creator Kit i destinationsmiljøet. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installer fra App Source</a>
1. Du har downloadet AutomationKit.zip-filen fra afsnittet Aktiver i det seneste <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub-udgivelse</a>
1. Du har importeret den nyeste AutomationKitScheduler_*_administreret.zip fil ved hjælp af. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Læs mere</a>

## Køreplan

Du kan besøge vores <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-problemer</a> for at se foreslåede nye funktioner.

Du kan tilføje en ny <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Anmodning om planlægningsfunktion</a>

## Feedback

{{<questions name="/content/da/features/scheduler.json" completed="Tak, fordi du gav feedback" showNavigationButtons="false" locale="da">}}
