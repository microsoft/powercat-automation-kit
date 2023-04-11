---
title: "Application Lifecycle Management (ALM)"
description: "Automatiseringskit - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['ALM', 'Guidance']
generated: CFA547EC584269A54557898046D235E91F77E46A
---

{{<slideStyles>}}

<div class="optional">

Op deze pagina vindt u een overzicht van onderdelen die u kunnen helpen bij het gebruik van ALM met de Automation Kit for Power Automate Desktop-workflows die zijn opgenomen in [Power Platform oplossingen](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## Samenvatting

Wanneer u ALM voor Power Platform oplossingen die Power Automate Desktop-onderdelen bevatten

1. Bekijk de functies van Managed Environment Power Platform Pipelines om te profiteren van in-productfuncties op bedrijfsschaal om oplossingen binnen omgevingen te beheren en te beheren.

<br/>

2. Onderzoek indien nodig de [Microsoft Power Platform Build Tools voor Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [GitHub-acties voor Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) of [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) om uw ALM DevOps-processen te integreren en te automatiseren.

<br/>

3. Overweeg het gebruik van de [ALM Accelerator voor Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). De ALM Accelerator biedt een vooraf gebouwde set Azure DevOps-sjablonen die veel van de Power Platform ALM-taken automatiseert met behulp van geïntegreerd bronbeheerbeheer.

## Leren van Power CAT

U kunt ook meer lezen hoe wij als Power CAT-team ALM Accelerator gebruiken om de [Power CAT Automatiseringskit ALM](/nl/features/alm/powercat).

## Weg

[ALM Accelerator voor Power Platform Learning Catalog](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## Routekaart

Het Automation Kit-team werkt samen met het ALM Accelerator-team om Power Automate Desktop-specifieke taken toe te voegen aan de bestaande sjablonen die betrekking hebben op:

- Vergelijk de definities van Power Automate Desktop naast elkaar.

- Validatieregelcontroles voor Power Automate Desktop.

- Uitvoering van unit-, integratie- en systeemtests als onderdeel van de CI/CD-pijplijn.

Bekijk onze [Automation Kit ALM gerelateerde backlog](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## Terugkoppeling

{{<questions name="/content/nl/features/alm.json" completed="Bedankt voor het geven van feedback" showNavigationButtons="false" locale="nl">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

Beheerde omgevingen bieden u de mogelijkheid om governance op schaal te stroomlijnen en te vereenvoudigen. Beheerders kunnen beheerde omgevingen met slechts een paar klikken activeren en onmiddellijk functies oplichten die meer zichtbaarheid, meer controle en minder moeite bieden om al uw low-code assets te beheren.

Beheerde omgevingen zijn een belangrijk onderdeel van de Power Platform-familie, op dezelfde manier waarop AI Builder intelligentie in onze producten heeft gestopt en Dataverse de data-backbone biedt. Beheerde omgevingen stroomlijnen het beheer van het platform op schaal.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

Beheerde omgevingen bieden u:

- Meer zichtbaarheid met gebruiksinzichten op de startpagina, e-mails met beheerderssamenvatting, licentierapporten en weergaven van gegevensbeleid
- Meer controle met limieten voor delen, zodat u kunt bepalen hoe breed en met hoeveel mensen canvas-app- en oplossingsstromen kunnen worden gedeeld.
- U kunt het delen ook beperken tot beperkte beveiligingsgroepen.
- Oplossingscontrole configureren voor beveiligings- of betrouwbaarheidscontroles om regels automatisch uit te voeren wanneer een oplossing wordt geïmporteerd in een beheerde omgeving
- Pas de welkomst- en deelervaring van de maker aan, zodat u gebruikers op het juiste pad leidt.
- Minder moeite stroomlijnen, vereenvoudigen en automatiseren stappen uit de doos met slechts een paar klikken. 
- De Power Platform Pipelines biedt de mogelijkheid om het APPLICATION LIFECYCLE MANAGEMENT (ALM)-proces te vereenvoudigen.

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

Dit is een oplossing waar ik mee werk in de Maker Portal.

Ik ben doorgegaan met het selecteren van deze pijplijn die al is ingesteld. Pijplijnen zijn in feite een reeks geautomatiseerde stappen die uw werk van de ene omgeving naar de andere verplaatsen. Deze pijplijn brengt mijn oplossing van de ontwikkelomgeving aan de linkerkant naar de testomgeving. Dan is er nog een fase om het van test naar productie te brengen.

Laten we implementeren om te testen, selecteer volgende en hier bevestig ik mijn verbindingen om de omgeving te testen om er zeker van te zijn dat ik de juiste referenties gebruik. Vervolgens configureer ik mijn omgevingsvariabelen om er bijvoorbeeld voor te zorgen dat ik in de test naar de juiste SharePoint-site wijs. Dit is belangrijk als de site anders was dan degene die ik in ontwikkeling gebruikte. 

Zodra ik alles heb ingesteld, kan ik gewoon "Implementeren" selecteren en preflight-validaties worden automatisch uitgevoerd om ervoor te zorgen dat ik de juiste afhankelijkheden heb en dat de oplossing het DLP-beleid in die doelomgeving niet schendt. De pijplijn kan ook zo worden ingesteld dat goedkeuring vereist is voordat de implementatie kan worden uitgevoerd. 

Het lijkt erop dat alles hier succesvol was.

Nadat ik mijn pijplijn heb uitgevoerd, krijg ik volledige zichtbaarheid en een audittrail van de implementaties in mijn organisatie met elke oplossing waarvan een back-up is gemaakt en een versie is gemaakt.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

De functies worden gefaseerd uitgerold. Sommigen van hen, zoals de beheerderssamenvattingen en deellimieten, zijn vandaag beschikbaar. De rest wordt tegen het einde van het jaar uitgerold.

In de komende weken en maanden ziet u gebruiksinzichten op de startpagina. Nieuwe trends in de beheerderssamenvattingen en rapporten voor gelicentieerd gebruik. Het delen van limieten krijgt meer controles en ondersteunt oplossingsstromen. U kunt onveilige implementaties blokkeren met Solution Checker. De onboarding- en pijplijnmogelijkheden van de klantmaker komen ook later dit jaar.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

U hebt een aantal opties om te overwegen voor uw ALM-keuzes in de Power Platform. De managed environment Power Platform pipelines bieden in product Application Lifecycle management.

Optioneel kunt u de uitbreidingspunten van de beheerde omgeving gebruiken Power Platform pijplijnen in combinatie met [Power Platform Build Tools voor Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)de [GitHub-acties voor Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) of [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) om uw eigen aangepaste ALM DevOps-processen te implementeren.

Eindelijk kunt u profiteren van de [ALM Accelerator voor Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) van de CoE Kit om vooraf gebouwde sjablonen en voorbeelden te bieden voor End-to-End ALM met behulp van Azure DevOps. De ALM Accelerator biedt vele veelvoorkomende scenario's om uw oplossingen in verschillende omgevingen te bouwen en te beheren.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

Wat is ALM Accelerator voor Power Platform?

De ALM Accelerator voor Power Platform bevat Power Apps die bovenop Azure DevOps Pipelines en Git-bronbeheer zit. De app biedt een vereenvoudigde interface voor makers om regelmatig de componenten in hun Power Platform Solutions te exporteren naar bronbeheer en implementatieverzoeken te maken om hun werk te laten beoordelen voordat ze in doelomgevingen worden geïmplementeerd.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

Kijkend naar de ALM Accelerator workflow begint het met Ontwikkelomgevingen. Hun interactie met het ALM-proces verloopt via de ALM Accelerator Canvas App of Managed Environment Pipelines

Makers gebruiken de ALM Accelerator Canvas-app voor hun ALM-taken, zoals het importeren van oplossingen vanuit bronbeheer, het exporteren van wijzigingen naar bronbeheer en het maken van een pull-verzoek om wijzigingen samen te voegen

ALM Accelerator-sjablonen voor Azure DevOps-pijplijnen vergemakkelijken de automatisering van ALM-taken op basis van de interactie van makers met de ALM Accelerator Canvas-app

ALM Accelerator bevat pijplijnsjablonen ter ondersteuning van een implementatie in 3 fasen naar productie.
Sjablonen kunnen worden aangepast aan specifieke behoeften en scenario's

De ALM Accelerator for Power Platform is een Canvas-app die bovenop Azure DevOps Pipelines zit om een vereenvoudigde interface te bieden voor makers om regelmatig pull-aanvragen voor hun ontwikkelingswerk in de Power Platform te committeren en te maken. 

De combinatie van de Azure DevOps Pipelines en de Canvas-app vormen de volledige ALM Accelerator voor Power Platform oplossing. 
De pipelines en de App zijn referentie-implementaties. Ze zijn ontwikkeld voor gebruik door het ontwikkelingsteam voor de CoE Starter Kit intern, maar zijn open source en vrijgegeven om aan te tonen hoe gezonde ALM kan worden bereikt in de Power Platform. Ze kunnen worden gebruikt zoals ze zijn of worden aangepast voor specifieke bedrijfsscenario's.

{{</slide>}}
