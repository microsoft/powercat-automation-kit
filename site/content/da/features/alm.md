---
title: "Administration af programlivscyklus (ALM)"
description: "Automatiseringssæt - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9879BCED5F4B223A5305D8514B67FB43AA12FDDD
---

{{<slideStyles>}}

<div class="optional">

Denne side indeholder en oversigt over komponenter, der kan hjælpe dig med at bruge ALM med Automation Kit til Power Automate Desktop-arbejdsprocesser, der er inkluderet i [Power Platform-løsninger](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## Resumé

Når du ser på ALM til Power Platform-løsninger, der omfatter Power Automate Desktop-komponenter

1. Gennemse funktionerne i Power Platform-pipelines i administreret miljø for at drage fordel af funktioner i virksomhedsskala i produktet til at administrere og styre løsninger i miljøer.

<br/>

2. Undersøg om nødvendigt [Microsoft Power Platform Build-værktøjer til Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [GitHub-handlinger til Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) eller [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) til at integrere og automatisere dine ALM DevOps-processer.

<br/>

3. Overvej at bruge [ALM Accelerator til Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). ALM Accelerator indeholder et færdigbygget sæt Azure DevOps-skabeloner, der automatiserer mange af Power Platform ALM-opgaverne ved hjælp af integreret styring af kildekontrol.

## Lær af Power CAT

Du kan også læse mere om, hvordan vi som Power CAT-team bruger ALM Accelerator til at sende [Power CAT-automatiseringssæt ALM](/da/features/alm/powercat).

## Ressourcer

[ALM Accelerator til Power Platform Learning Catalog](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## Køreplan

Automation Kit-teamet arbejder sammen med ALM Accelerator-teamet om at føje Power Automate Desktop-specifikke opgaver til de eksisterende skabeloner, der dækker:

- Sammenligning af Power Automate Desktop-definitioner side om side.

- Valideringsregel kontrollerer for Power Automate Desktop.

- Udførelse af enheds-, integrations- og systemtests som en del af CI/CD-pipelinen.

Gennemgå vores [Automation Kit ALM-relateret efterslæb](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## Feedback

{{<questions name="/content/da/features/alm.json" completed="Tak, fordi du gav feedback" shownavigationbuttons="false" locale="da">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

Administrerede miljøer giver dig mulighed for at strømline og forenkle styring i stor skala. Administratorer kan aktivere administrerede miljøer med blot et par klik og straks tænde funktioner, der giver mere synlighed, mere kontrol med mindre indsats for at administrere alle dine aktiver med lav kode.

Administrerede miljøer er en vigtig del af Power Platform-familien på samme måde, som AI Builder tilførte intelligens til vores produkter, og Dataverse leverer databackbonet. Administrerede miljøer strømliner styringen af platformen i stor skala.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

Administrerede miljøer giver dig:

- Mere synlighed med brugsindsigt på startsiden, administratoroversigtsmails, licensrapporter og datapolitikvisninger
- Mere kontrol med delingsgrænser, der giver dig kontrol over, hvor bredt og med hvor mange personer lærredapps og løsningsflows kan deles med.
- Du kan også begrænse deling til begrænsede sikkerhedsgrupper.
- Konfigurere løsningskontrol til sikkerheds- eller pålidelighedskontrol for at køre regler automatisk, når en løsning importeres til et administreret miljø
- Tilpas makerens velkomst og delingsoplevelse, så du guider brugerne ned ad den rigtige vej.
- Mindre indsats strømliner, forenkler og automatiserer trin ud af boksen med blot et par klik. 
- Power Platform Pipelines giver mulighed for at forenkle ALM-processen (Application Lifecycle Management).

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

Dette er en løsning, som jeg arbejder med i Maker Portal.

Jeg er gået videre med at vælge denne pipeline, der allerede er konfigureret. Pipelines er dybest set en række automatiserede trin, der flytter dit arbejde fra et miljø til et andet. Denne pipeline vil tage min løsning fra udviklingsmiljøet til venstre til testmiljøet. Så er der en anden fase til at tage det fra test til produktion.

Lad os implementere for at teste, vælge næste, og her bekræfter jeg mine forbindelser for at teste miljøet for at sikre, at jeg bruger de rigtige legitimationsoplysninger. Dernæst konfigurerer jeg mine miljøvariabler for at sikre, at jeg f.eks. peger på det rigtige SharePoint-websted i test. Dette er vigtigt, hvis webstedet var anderledes end det, jeg brugte i udviklingen. 

Når jeg har konfigureret det hele, kan jeg bare vælge "Deploy", og forhåndskontrolvalideringer køres automatisk for at gøre jeg har de rigtige afhængigheder, og løsningen overtræder ikke og DLP-politikker i det pågældende målmiljø. Pipelinen kan også konfigureres, så der kræves godkendelse, før installationen kan køres. 

Det ser ud til, at alt var vellykket her.

Når jeg har kørt min pipeline, får jeg fuld synlighed og et revisionsspor af implementeringerne på tværs af min organisation med hver løsning sikkerhedskopieret og versioneret.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

Funktionerne vil blive rullet ud i faser. Nogle af dem kan lide admin fordøjelser og delingsgrænser er tilgængelige i dag. Resten vil blive rullet ud inden årets udgang.

I de kommende uger og måneder vil du se brugsindsigt på startsiden. Nye tendenser i administratoroversigterne og rapporter til licenseret brug. Delingsgrænser får flere kontroller og understøtter løsningsflow. Du vil være i stand til at blokere usikre implementeringer med Solution Checker. Customer maker onboarding og pipeline kapaciteter vil også komme senere på året.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

Du har en række muligheder at overveje for dine ALM-valg i Power Platform. Power Platform-pipelines til administreret miljø leveres i administration af produktprogramlivscyklus.

Du kan også bruge udvidelsespunkterne i Power Platform-pipelines for administreret miljø kombineret med [Power Platform Build-værktøjer til Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)den [GitHub-handlinger til Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) eller [Power Platform CLI](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction) for at rulle dine egne brugerdefinerede ALM DevOps-processer.

Endelig kan du drage fordel af [ALM Accelerator til Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) fra CoE-sættet til at levere forudbyggede skabeloner og eksempler til End-to-End ALM ved hjælp af Azure DevOps. ALM Accelerator indeholder mange almindelige scenarier til opbygning og styring af dine løsninger på tværs af miljøer.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

Hvad er ALM Accelerator for Power Platform?

ALM Accelerator for Power Platform omfatter Power Apps, der er placeret oven på Azure DevOps Pipelines og Git-kildekontrol. Appen indeholder en forenklet grænseflade, hvor udviklere regelmæssigt kan eksportere komponenterne i deres Power Platform-løsninger for at kildestyre og oprette udrulningsanmodninger for at få deres arbejde gennemgået, før de installeres i destinationsmiljøer.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

Når man ser på ALM Accelerator-arbejdsgangen, starter den med udviklingsmiljøer. Deres interaktion med ALM-processen sker via ALM Accelerator Canvas-appen eller Managed Environment Pipelines

Udviklere bruger ALM Accelerator Canvas-appen til deres ALM-opgaver, f.eks. import af løsning fra kildekontrolelement, eksport af ændringer til kildekontrol og oprettelse af pullanmodninger for at flette ændringer

ALM Accelerator-skabeloner til Azure DevOps-pipelines letter automatiseringen af ALM-opgaver baseret på Makers-interaktionen med ALM Accelerator Canvas-appen

ALM Accelerator indeholder pipelineskabeloner, der understøtter en 3-trins implementering til produktion.
Skabeloner kan tilpasses, så de passer til specifikke behov og scenarier

ALM Accelerator for Power Platform er en lærredapp, der er placeret oven på Azure DevOps Pipelines for at give en forenklet grænseflade, så udviklere regelmæssigt kan forpligte og oprette pullanmodninger til deres udviklingsarbejde i Power Platform. 

Kombinationen af Azure DevOps Pipelines og Canvas-appen er det, der udgør den fulde ALM Accelerator for Power Platform-løsning. 
Pipelines og appen er referenceimplementeringer. De blev udviklet til brug af udviklingsteamet til CoE-startsættet internt, men er blevet open source og frigivet for at demonstrere, hvordan sund ALM kan opnås i Power Platform. De kan bruges som de er eller tilpasses til specifikke forretningsscenarier.

{{</slide>}}
