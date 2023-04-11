---
title: "Livscykelhantering för program (ALM)"
description: "Automation Kit - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['ALM', 'Guidance']
generated: CFA547EC584269A54557898046D235E91F77E46A
---

{{<slideStyles>}}

<div class="optional">

Den här sidan innehåller en översikt över komponenter som kan hjälpa dig att använda ALM med Automation Kit för Power Automate Desktop-arbetsflöden som ingår i [Power Platform lösningar](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## Sammanfattning

När du tittar på ALM för Power Platform lösningar som innehåller Power Automate Desktop-komponenter

1. Granska funktionerna i Managed Environment Power Platform Pipelines för att dra nytta av funktioner i företagsskala i produkten för att hantera och styra lösningar i miljöer.

<br/>

2. Om det behövs, undersök [Microsoft Power Platform Skapa verktyg för Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [GitHub-åtgärder för Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) eller [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) för att integrera och automatisera dina ALM DevOps-processer.

<br/>

3. Överväg att använda [ALM Accelerator för Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). ALM-acceleratorn innehåller en fördefinierad uppsättning Azure DevOps-mallar som automatiserar många av de Power Platform ALM-uppgifterna med hjälp av integrerad källkontrollstyrning.

## Lär dig av Power CAT

Du kan också läsa mer om hur vi som Power CAT-team använder ALM Accelerator för att leverera [Power CAT Automation Kit ALM](/sv/features/alm/powercat).

## Resurser

[ALM Accelerator för Power Platform Learning Catalog](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## Färdplan

Automation Kit-teamet arbetar med ALM Accelerator-teamet för att lägga till Power Automate Desktop-specifika uppgifter i de befintliga mallarna som omfattar:

- Sida vid sida jämför Power Automate Desktop-definitioner.

- Verifieringsuttryck söker efter Power Automate Desktop.

- Körning av enhets-, integrations- och systemtester som en del av CI/CD-pipelinen.

Granska vår [Automation Kit ALM-relaterad eftersläpning](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## Feedback

{{<questions name="/content/sv/features/alm.json" completed="Tack för att du ger feedback" showNavigationButtons="false" locale="sv">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

Hanterade miljöer ger dig möjlighet att effektivisera och förenkla styrningen i stor skala. Administratörer kan aktivera hanterade miljöer med bara några få klick och omedelbart tända funktioner som ger mer synlighet, mer kontroll med mindre ansträngning för att hantera alla dina tillgångar med lite kod.

Hanterade miljöer är en viktig del av Power Platform-familjen, på samma sätt som AI Builder införde intelligens i våra produkter och Dataverse tillhandahåller datastamnätet. Hanterade miljöer effektiviserar styrningen av plattformen i stor skala.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

Hanterade miljöer ger dig:

- Mer synlighet med användningsinsikter på startsidan, administratörssammanfattningar, licensrapporter och datapolicyvyer
- Mer kontroll med delningsgränser som ger dig kontroll över hur brett och med hur många personer arbetsyteappar och lösningsflöden kan delas med.
- Du kan också begränsa delningen till begränsade säkerhetsgrupper.
- Konfigurera lösningskontroll för säkerhets- eller tillförlitlighetskontroller för att köra regler automatiskt när en lösning importeras till en hanterad miljö
- Anpassa skaparens välkomst- och delningsupplevelse så att du guidar användarna på rätt väg.
- Mindre ansträngning effektiviserar, förenklar och automatiserar steg ur lådan bara några klick. 
- Power Platform Pipelines ger möjlighet att förenkla ALM-processen (Application Lifecycle Management).

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

Detta är en lösning som jag arbetar med i Maker Portal.

Jag har gått vidare för att välja den här pipelinen som redan har konfigurerats. Pipelines är i grunden en serie automatiserade steg som flyttar ditt arbete från en miljö till en annan. Den här pipelinen tar min lösning från utvecklingsmiljön till vänster till testmiljön. Sedan finns det ett annat steg för att ta det från test till produktion.

Låt oss distribuera för att testa, välj nästa och här bekräftar jag mina anslutningar för att testa miljön för att se till att jag använder rätt autentiseringsuppgifter. Därefter konfigurerar jag mina miljövariabler för att till exempel se till att jag pekar på rätt SharePoint-webbplats som testas. Detta är viktigt om webbplatsen var annorlunda än den jag använde under utveckling. 

När jag har konfigurerat allt kan jag bara välja "Distribuera" och preflight-valideringar körs automatiskt för att göra att jag har rätt beroenden och lösningen bryter inte mot och DLP-policyer i den målmiljön. Pipelinen kan också konfigureras så att godkännande krävs innan distributionen kan köras. 

Ser ut som att allt lyckades här.

När jag har kört min pipeline får jag full insyn och en granskningslogg över distributionerna i hela organisationen med varje lösning säkerhetskopierad och versionerad.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

Funktionerna kommer att rullas ut i faser. Vissa av dem som administratörssammanfattningar och delningsgränser är tillgängliga idag. Resten kommer att rullas ut i slutet av året.

Under de kommande veckorna och månaderna kommer du att se användningsinsikter på startsidan. Nya trender i administratörssammanfattningarna och rapporter för licensierad användning. Delningsgränser får fler kontroller och supportlösningsflöden. Du kommer att kunna blockera osäkra distributioner med Solution Checker. Kundtillverkarens onboarding- och pipelinefunktioner kommer också senare i år.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

Du har ett antal alternativ att överväga för dina ALM-val i Power Platform. Den hanterade miljön Power Platform pipelines tillhandahåller i produktlivscykelhantering för program.

Du kan också använda tilläggspunkterna för den hanterade miljön Power Platform pipelines i kombination med [Power Platform Skapa verktyg för Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)den [GitHub-åtgärder för Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) eller [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) för att rulla dina egna anpassade ALM DevOps-processer.

Äntligen kan du dra nytta av [ALM Accelerator för Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) från CoE Kit för att tillhandahålla förbyggda mallar och exempel för ALM från slutpunkt till slutpunkt med hjälp av Azure DevOps. ALM Accelerator tillhandahåller många vanliga scenarier för att skapa och styra dina lösningar i olika miljöer.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

Vad är ALM Accelerator för Power Platform?

ALM Accelerator for Power Platform innehåller Power Apps som finns ovanpå Azure DevOps Pipelines och Git-källkontroll. Appen tillhandahåller ett förenklat gränssnitt för tillverkare att regelbundet exportera komponenterna i sina Power Platform lösningar för källkontroll och skapa distributionsbegäranden för att få sitt arbete granskat innan de distribueras till målmiljöer.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

Om du tittar på arbetsflödet för ALM Accelerator börjar det med utvecklingsmiljöer. Deras interaktion med ALM-processen sker via ALM Accelerator Canvas App eller Managed Environment Pipelines

Utvecklare använder ALM Accelerator Canvas App för sina ALM-uppgifter som att importera lösning från källkontroll, exportera ändringar till källkontroll och skapa pull-begäran för att slå samman ändringar

ALM Accelerator-mallar för Azure DevOps-pipelines underlättar automatiseringen av ALM-uppgifter baserat på Makers-interaktionen med ALM Accelerator Canvas-appen

ALM Accelerator innehåller pipelinemallar för att stödja en 3-stegsdistribution till produktion.
Mallar kan anpassas för att passa specifika behov och scenarier

ALM Accelerator for Power Platform är en arbetsyteapp som finns ovanpå Azure DevOps Pipelines för att tillhandahålla ett förenklat gränssnitt där utvecklare regelbundet kan genomföra och skapa pull-begäranden för sitt utvecklingsarbete i Power Platform. 

Kombinationen av Azure DevOps Pipelines och arbetsyteappen är det som utgör den fullständiga ALM Accelerator för Power Platform lösningen. 
Pipelines och appen är referensimplementeringar. De utvecklades för användning av utvecklingsteamet för CoE-startpaketet internt men har varit öppen källkod och släppts för att visa hur hälsosam ALM kan uppnås i Power Platform. De kan användas som de är eller anpassas för specifika affärsscenarier.

{{</slide>}}
