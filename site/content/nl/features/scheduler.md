---
title: "Scheduler"
description: "Automatiseringskit - Planner"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 3191EC35273FDF75E031467EB6C5BF37F2883B67
---

{{<toc>}}

## Introductie

Op de pagina Automation Kit Automation Center Scheduler kunt u het schema bekijken van terugkerende Power Automate-cloudstromen binnen oplossingen die aanroepen naar Power Automate Desktop-stromen bevatten.

Deze functie is bijgewerkt als onderdeel van de [mei 2023](/nl/releases/june-2023)

{{<border>}}
![Scheduler](/images/schedule.png)
{{</border>}}

De belangrijkste kenmerken van de planner zijn:

- De mogelijkheid om het schema van terugkerende cloudstromen te bekijken
- Filterschema op machine- en machinegroepen en status
- Open Grid-weergave van bureaubladstroomuitvoeringen
- Een Power Automate-bureaubladstroom uitvoeren
- Bekijk het schema op dag, week, maand en planningsweergave
- De status van geplande stromen weergeven (geslaagd, mislukt of gepland)
- De duur van een Cloud Flow-run weergeven
- Bekijk de details van eventuele fouten.

## Cloudstromen

Zoals hierboven vermeld, alleen cloudstromen die zijn opgenomen als onderdeel van een oplossing. De recente [https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/) bevat informatie over het gebruik van de nieuwe preview van 'Dataverse-oplossingen standaard' om ervoor te zorgen dat cloudstromen worden opgenomen in oplossingen. Het gebruik van deze functie kan gebruikers helpen ervoor te zorgen dat de geplande cloudstromen die worden gemaakt, zichtbaar zijn in de planner.

## Agendaweergaven

## Dag, Week, Maand Weergaven

De dag-, week- en maandweergaven geven informatie weer over Desktop Cloud-stroomruns die zijn uitgevoerd of gepland zijn om te worden uitgevoerd.

Items hebben de volgende kleurcodes:

- Groen geeft een geslaagde run aan

- Rood geeft mislukte uitvoering aan

- Blauw geeft een geplande toekomstige run aan.

De status- en uitvoeringsinformatie is beschikbaar met een lange aanraak- of muisaanwijzer op de gebeurtenis.

### Rooster

{{<border>}}
![Planner - Planningsweergave](/images/scheduler-schedule-view.png)
{{</border>}}

De planningsweergave bevat een set cloudstromen op basis van de tijd van de huidige tijd en toekomstige geplande stromen in de komende dagen.

## Nu uitvoeren

{{<border>}}
![Scheduler - Nu uitvoeren](/images/scheduler-run-now.png?v=1)
{{</border>}}

De huidige versie van Nu uitvoeren voert het Power Automate-bureaublad uit. Er wordt van uitgegaan dat er geen parameters nodig zijn om de bureaubladstroom uit te voeren. De aanvullende uitvoeringsinformatie is beschikbaar in de informatie over de laatste uitvoering op het bureaublad.

## Rasterweergave openen

{{<border>}}
![Planner - Rasterweergave openen](/images/scheduler-open-grid-view.png)
{{</border>}}

Gebruikers kunnen navigeren naar de pagina bureaubladstromen die worden uitgevoerd in power automate vanuit onze startpagina van het Control Center
Schermafbeelding van de nieuwe knop "Open Grid View" op de startpagina om te navigeren naar de pagina Bureaubladstromen die worden uitgevoerd in de Power Automate-portal.

### Alleen-lezen gedrag van geplande stromen

Wanneer een stroom is gepland voor toekomstige uitvoering, wordt deze standaard ingesteld op de modus Alleen-lezen en uitgeschakeld voor onmiddellijke uitvoering. Dit betekent dat gebruikers de stroom niet kunnen wijzigen of uitvoeren totdat de geplande datum en tijd zijn verstreken. Dit gedrag is ontworpen om een betere gebruikerservaring te bieden en te voorkomen dat stromen per ongeluk worden uitgevoerd voordat ze moeten worden uitgevoerd.
Deze aanpak heeft verschillende voordelen, waaronder:

- Onbedoelde uitvoering voorkomen: door de onmiddellijke uitvoering van stromen die zijn gepland voor toekomstige uitvoering uit te schakelen, is de kans kleiner dat gebruikers per ongeluk een stroom uitvoeren voordat deze bedoeld is om te worden uitgevoerd.

- Verbeterde voorspelbaarheid: door stromen in te stellen op alleen-lezen modus wanneer ze zijn gepland voor toekomstige uitvoering, kunnen gebruikers gemakkelijker voorspellen wanneer stromen zullen worden uitgevoerd en ervoor zorgen dat ze de benodigde inputs en resources klaar hebben.

- Consistente gebruikerservaring: door het gedrag van geplande stromen te standaardiseren, kan het een consistente en voorspelbare gebruikerservaring bieden voor alle exemplaren van Flow.

- Als u een geplande stroom wilt wijzigen of uitvoeren, kunnen gebruikers de stroom bewerken en de geplande datum en tijd bijwerken. Zodra het nieuwe schema is ingesteld, wordt de stroom opnieuw uitgeschakeld voor onmiddellijke uitvoering en ingesteld op de alleen-lezenmodus totdat het nieuwe schema is verstreken.

## Foutberichten

Mogelijke foutmeldingen die kunnen optreden bij het uitvoeren van de runflow.

### Foutbericht: 'InvalidArgument - Kan geen geldige verbinding vinden die is gekoppeld aan de opgegeven verbindingsreferentie'.

#### Beschrijving

Dit foutbericht geeft meestal aan dat er een probleem is met de verbindingsverwijzing in de code of configuratie. Het systeem kan geen geldige verbinding vinden die aan de verwijzing is gekoppeld, waardoor het de gevraagde actie niet kan uitvoeren.

#### Oorzaken

Er zijn verschillende mogelijke oorzaken voor dit foutbericht, waaronder:

- Onjuiste of ongeldige verbindingsverwijzing: De opgegeven verbindingsreferentie kan ongeldig of onjuist zijn, waardoor het systeem een geldige verbinding die eraan is gekoppeld, niet kan vinden.

- Verbinding verwijderd of gewijzigd: Als de verbinding die in de code of configuratie wordt gebruikt, is verwijderd of gewijzigd, kan dit ertoe leiden dat het systeem geen geldige verbinding kan vinden die aan de verwijzing is gekoppeld.

- Probleem met machtigingen: het gebruikersaccount dat de code of configuratie uitvoert, heeft mogelijk niet de benodigde machtigingen om toegang te krijgen tot de verbinding of de bronnen die eraan zijn gekoppeld.

#### Resolutie

U kunt dit probleem oplossen door de volgende stappen uit te voeren:

- Controleer de verbindingsreferentie: Controleer de verbindingsreferentie in de code of configuratie en controleer of deze geldig en correct is.

- Bestaande verbindingen verwijderen en opnieuw maken: Als de stroomcontrole waarschuwt dat er geen verbindingsreferentie is gebruikt, kunt u de stroomcontrole gebruiken om bestaande verbindingen te verwijderen. Zodra de verbindingen zijn verwijderd, kunt u verbindingsverwijzingen naar de groep Machine of Machine opnieuw maken om de stroom uit te voeren.

## Notities

Voor de huidige release zijn de volgende opmerkingen van toepassing

1. Alleen Power Automate Desktop- en Power Automate-oplossingen in een oplossing worden weergegeven
1. Ten minste één Power Automate Desktop is geregistreerd en uitgevoerd

## Installeren

U kunt het bedieningspaneel als volgt installeren:

1. Ervoor zorgen dat power apps-onderdeelframework is ingeschakeld <a href="https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Lees meer</a>
1. U hebt de Creator Kit in de doelomgeving geïnstalleerd. <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installeren vanuit app-bron</a>
1. U hebt de nieuwste versie van AutomationKitControlCenter geïmporteerd_*_beheerd.zip bestand gebruiken. <a href='https://learn.microsoft.com/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Lees meer</a>

## Routekaart

U kunt onze <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-problemen</a> om voorgestelde nieuwe functies te bekijken.

U kunt een nieuwe toevoegen <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Scheduler Feature aanvraag</a>

## Terugkoppeling

{{<questions name="/content/nl/features/scheduler.json" completed="Bedankt voor het geven van feedback" showNavigationButtons="false" locale="nl">}}
