---
title: "Scheduler"
description: "Automatiseringskit - Planner"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B97833AB30777C813B3E62592D32D7E5B882ACEE
---

{{<toc>}}

## Introductie

Met de Automation Kit Scheduler kunt u de planning van terugkerende Power Automate Cloud-stromen in oplossingen bekijken die aanroepen naar Power Automate Desktop-stromen bevatten.

Deze functie is bijgewerkt als onderdeel van de [maart 2023](/nl/releases/march-2023), Zullen latere releases de functionaliteit van de planner blijven verbeteren en uitbreiden.

{{<border>}}
![Scheduler](/images/schedule.png)
{{</border>}}

De belangrijkste kenmerken van de planner zijn:

- De mogelijkheid om het schema van terugkerende cloudstromen te bekijken
- Filterschema op machine- en machinegroepen
- Een Power Automate-bureaubladstroom uitvoeren
- Bekijk het schema op dag, week, maand en planningsweergave
- De status van geplande stromen weergeven (geslaagd, mislukt of gepland)
- De duur van een Cloud Flow-run weergeven
- Bekijk de details van eventuele fouten.

## Flow uitvoeren

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

## Notities

Voor de huidige release zijn de volgende opmerkingen van toepassing

1. Alleen Power Automate Desktop- en Power Automate-oplossingen in een oplossing worden weergegeven
1. Ten minste één Power Automate Desktop is geregistreerd en uitgevoerd

## Installeren

Om de scheduler-oplossing te installeren, kunt u het volgende doen:

1. Zorg voor een Power Apps-onderdeelframework <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Lees meer</a>
1. U hebt de Creator Kit in de doelomgeving geïnstalleerd. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installeren vanuit app-bron</a>
1. U hebt het AutomationKit.zip-bestand gedownload van het gedeelte Activa van de nieuwste <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub-versie</a>
1. U hebt de nieuwste AutomationKitScheduler geïmporteerd_*_beheerd.zip bestand gebruiken. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Lees meer</a>

## Routekaart

U kunt onze <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-problemen</a> om voorgestelde nieuwe functies te bekijken.

U kunt een nieuwe toevoegen <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Scheduler Feature aanvraag</a>

## Terugkoppeling

{{<questions name="/content/nl/features/scheduler.json" completed="Bedankt voor het geven van feedback" showNavigationButtons="false" locale="nl">}}
