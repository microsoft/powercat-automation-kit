---
title: Power CAT Application Lifecycle Management (ALM)
description: Automatiseringskit - ALM Power CAT
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---
{{<slideStyles>}}

<div class="optional">

De Automation Kit maakt gebruik van de [ALM Versneller](https://aka.ms/aa4pp) om ALM-functionaliteit te bieden voor oplossingen die Power Automate Desktop bevatten

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## GitHub-implementatieproces

Vergelijkbaar met het releaseproces dat wordt gebruikt voor andere Power CAT beheerde kits, is de {{<product-name>}} gebruikt de ALM Accelerator om releases te implementeren in onze openbare GitHub-releases.

Ons interne proces heeft een Power Platform omgeving voor Ontwikkeling, Test en Productie. Zodra we klaar zijn voor een release, verpakken onze geïntegreerde GitHub Actions de beheerde en onbeheerde implementatieoplossingen samen met releaseopmerkingen automatisch voor een GitHub Draft-release.

Zodra de conceptrelease klaar is, kunnen we indien nodig nieuwe versies of hotfixes publiceren.

### Wat dit voor u betekent

Nu we deze automatisering hebben geïmplementeerd, heeft de geautomatiseerde ALM-release de volgende voordelen voor u:

- Inzicht in alle low-code broncode waaruit de Automation Kit bestaat, zodat u kunt onderzoeken hoe we de kit hebben gebouwd.

- Gestroomlijnd automatiseringsproces dat snel kan reageren op bugs of problemen en indien nodig hotfixes kan bieden.

- Geautomatiseerde compilatie van alle bugs en functies die zijn opgenomen in een release.

- We nemen Power Apps, Power Automate, Dataverse en Power Automate Desktop op als onderdeel van ons ALM-proces voor onze Continuous Integration / Continuous Deployment.

## Routekaart

U kunt onze openstaande ALM-gerelateerde backlog-items onderzoeken in onze [GitHub-problemen registreren](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

Over het algemeen bouwen we voort op de bestaande kant-en-klare Power Platform- en Microsoft DevOps-productfuncties samen ALM Accelerator. Deze combinatie stelt ons in staat om ons te concentreren op specifieke extensies die helpen bij hyperautomtion.

## Terugkoppeling

{{<questions name="/features/alm/powercat.json" completed="Thank you for providing feedback" showNavigationButtons=false >}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Het Power CAT-team gebruikt de ALM Accelerator om elk van onze [Releases](https://github.com/microsoft/powercat-automation-kit/releases).

Elke release bevordert veranderingen van onze ontwikkeling naar test- en productieomgevingen. De Power Platform-oplossingen in de kit gebruiken een geautomatiseerd proces om assets te verpakken voor implementatie in openbare GitHub-releases.

In toekomstige mijlpalen zullen we uitbreiden op bestaand platform [ALM-functies](/nl/features/alm) om voorbeelden te geven van het opnemen van validatieregels en visuele vergelijking van RPA-voorbeelden als onderdeel van het DevOps-proces.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

Hieronder worden de belangrijkste stappen in het releaseproces van de Automation Kit beschreven:

1. Wijzigingen in onze Power Platform Dev-omgeving worden opgeslagen in een branch in de openbare GitHub-opslagplaats

2. Wanneer wijzigingen klaar zijn voor opname in een testrelease, worden ze samengevoegd met de hoofdtak met behulp van een pull-aanvraag. Voordat de pull-aanvraag kan worden voltooid, moet de Azure DevOps-validatiepijplijn met succes worden voltooid en moet de pull-aanvraag worden beoordeeld.

3. Zodra de Pull Request de geautomatiseerde controles heeft doorstaan en goedkeuring heeft gekregen, kan deze worden samengevoegd met de hoofdtak. Deze samenvoeging activeert de test Azure DevOps-buildpijplijn die de beheerde build publiceert naar de test Power Platform-omgeving.

4. Na interne tests wordt de Azure DevOps-productiepijplijn handmatig geactiveerd om een Production Power Platform-implementatie te genereren.

5. Zodra de release klaar is, maakt de Release Azure DevOps-pijplijn een conceptrelease inclusief releaseopmerkingen en buildassets. De uiteindelijke release build sluit alle openstaande problemen en sluit de mijlpaal. Gepubliceerde buildtag de GitHub-opslagplaats met een maand- en jaarlabel toegepast.

{{</slide>}}
