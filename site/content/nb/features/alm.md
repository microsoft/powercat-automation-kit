---
title: Administrasjon av programlivssyklus (ALM)
description: Automatiseringssett - ALM
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---
{{<slideStyles>}}

<div class="optional">

Denne siden gir en oversikt over komponenter som kan hjelpe deg med å bruke ALM med automatiseringssettet for Power Automate Desktop-arbeidsflyter som er inkludert i [Power Platform-løsninger](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## Sammendrag

Når du ser på ALM for Power Platform-løsninger som inkluderer Power Automate Desktop-komponenter

1. Se gjennom funksjonene i Power Platform-pipeliner for administrert miljø for å dra nytte av funksjoner i bedriftsskala i produktet for å administrere og styre løsninger i miljøer.

<br/>

2. Undersøk om nødvendig [Microsoft Power Platform Kompileringsverktøy for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [GitHub-handlinger for Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) eller [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) for å integrere og automatisere ALM DevOps-prosessene dine.

<br/>

3. Vurder å bruke [ALM-akselerator for Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). ALM Accelerator inneholder et forhåndsbygd sett med Azure DevOps-maler som automatiserer mange av Power Platform ALM-oppgavene ved hjelp av integrert kildekontrollstyring.

## Lære av Power CAT

Du kan også lese mer om hvordan vi som Power CAT-team bruker ALM Accelerator til å sende [Power CAT Automation Kit ALM](/nb/features/alm/powercat).

## Ressurser

[ALM Accelerator for Power Platform-læringskatalogen](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## Veikart

Automation Kit-teamet samarbeider med ALM Accelerator-teamet for å legge til Power Automate Desktop-spesifikke oppgaver i de eksisterende malene som dekker:

- Side ved side-sammenligning av Power Automate Desktop-definisjoner.

- Valideringsregel ser etter Power Automate Desktop.

- Utførelse av enhets-, integrasjons- og systemtester som en del av CI/CD-datasamlebåndet.

Se gjennom våre [Automation Kit ALM-relatert etterslep](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## Tilbakemelding

{{<questions name="/features/alm.json" completed="Thank you for providing feedback" showNavigationButtons=false >}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

Administrerte miljøer gir deg muligheten til å strømlinjeforme og forenkle styring i stor skala. Administratorer kan aktivere administrerte miljøer med bare noen få klikk og umiddelbart lyse opp funksjoner som gir mer synlighet, mer kontroll med mindre innsats for å administrere alle lavkoderessursene dine.

Administrerte miljøer er en viktig del av Power Platform-familien, på samme måte som AI Builder tilførte intelligens i produktene våre, og Dataverse gir dataryggraden. Administrerte miljøer effektiviserer styringen av plattformen i stor skala.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

Administrerte miljøer gir deg:

- Mer synlighet med bruksinnsikt på hjemmesiden, e-postmeldinger med administratorsammendrag, lisensrapporter og datapolicyvisninger
- Mer kontroll med delingsgrenser som gir deg kontroll over hvor vidt og hvor mange personer lerretsapp- og løsningsflyter kan deles med.
- Du kan også begrense deling til begrensede sikkerhetsgrupper.
- Konfigurere løsningskontroll for sikkerhets- eller pålitelighetskontroller for å kjøre regler automatisk når en løsning importeres til et administrert miljø
- Tilpass velkomst- og delingsopplevelsen for oppretteren slik at du veileder brukerne på riktig vei.
- Mindre innsats effektiviserer, forenkler og automatiserer trinn ut av esken bare noen få klikk. 
- Power Platform-pipelinene gir muligheten til å forenkle prosessen for administrasjon av programlivssyklus (ALM).

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

Dette er en løsning som jeg arbeider med i Maker Portal.

Jeg har gått foran for å velge denne rørledningen som allerede er konfigurert. Rørledninger er i utgangspunktet en serie automatiserte trinn som flytter arbeidet ditt fra ett miljø til et annet. Denne pipelinen tar løsningen min fra utviklingsmiljøet til venstre til testmiljøet. Så er det et annet stadium å ta det fra test til produksjon.

Lar distribuere for å teste, velg neste og her, vil jeg bekrefte tilkoblingene mine for å teste miljøet for å sikre at jeg bruker riktig legitimasjon. Deretter skal jeg konfigurere miljøvariablene mine for å sikre at jeg for eksempel peker til riktig SharePoint-område i test. Dette er viktig hvis nettstedet var annerledes enn det jeg brukte i utviklingen. 

Når jeg har konfigurert alt, kan jeg bare velge "Distribuer" og preflight-valideringer kjøres automatisk for å gjøre at jeg har de riktige avhengighetene, og løsningen bryter ikke og DLP-policyer i det målmiljøet. Pipelinen kan også konfigureres slik at godkjenning kreves før distribusjon kan kjøres. 

Ser ut som alt var vellykket her.

Når jeg har kjørt pipelinen, får jeg full oversikt og et revisjonsspor over distribusjonene i hele organisasjonen med hver løsning sikkerhetskopiert og versjonert.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

Funksjonene vil bli rullet ut i faser. Noen av dem som admin fordøyer og deling grenser er tilgjengelige i dag. Resten vil bli rullet ut innen utgangen av året.

I de kommende ukene og månedene vil du se bruksinnsikt på hjemmesiden. Nye trender i administratorsammendragene og rapporter for lisensiert bruk. Delingsgrenser vil få flere kontroller og støtteløsningsflyter. Du vil kunne blokkere usikre distribusjoner med Solution Checker. Funksjonene for kundeoppretter og pipeline kommer også senere i år.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

Du har en rekke alternativer du bør vurdere for ALM-valgene i Power Platform. Power Platform-datasamlebåndene for administrert miljø gir administrasjon av livssyklus for produktprogrammer.

Du kan eventuelt bruke utvidelsespunktene for Power Platform-pipeliner for administrert miljø kombinert med [Power Platform Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)den [GitHub-handlinger for Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) eller [Power Platform CLI](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction) for å rulle dine egne tilpassede ALM DevOps-prosesser.

Endelig kan du dra nytte av [ALM-akselerator for Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) fra CoE Kit for å levere forhåndsbygde maler og eksempler for ende-til-ende ALM ved hjelp av Azure DevOps. ALM Accelerator inneholder mange vanlige scenarier for å bygge og styre løsningene dine på tvers av miljøer.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

Hva er ALM Accelerator for Power Platform?

ALM Accelerator for Power Platform inkluderer Power Apps som sitter oppå Azure DevOps Pipelines og Git-kildekontroll. Appen gir et forenklet grensesnitt der utviklere regelmessig kan eksportere komponentene i Power Platform-løsningene sine for å kildekontrollere og opprette distribusjonsforespørsler for å få arbeidet gjennomgått før distribusjon til målmiljøer.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

Når du ser på ALM Accelerator-arbeidsflyten, starter den med utviklingsmiljøer. Deres samhandling med ALM-prosessen er via ALM Accelerator Canvas-appen eller Managed Environment Pipelines

Opprettere bruker lerretsappen ALM Accelerator til ALM-oppgavene sine, for eksempel importere løsning fra kildekontroll, eksportere endringer til kildekontroll og opprette henteforespørsel for å slå sammen endringer

ALM Accelerator-maler for Azure DevOps-datasamlebånd forenkler automatisering av ALM-oppgaver basert på Oppretter-samhandlingen med ALM Accelerator-lerretsappen

ALM Accelerator inkluderer pipelinemaler for å støtte en 3-trinns distribusjon til produksjon.
Maler kan tilpasses for å passe til spesifikke behov og scenarier

ALM Accelerator for Power Platform er en lerretsapp som sitter oppå Azure DevOps Pipelines for å gi et forenklet grensesnitt der opprettere regelmessig kan utføre og opprette pull-forespørsler for utviklingsarbeidet i Power Platform. 

Kombinasjonen av Azure DevOps Pipelines og lerretsappen er det som utgjør den fullstendige ALM Accelerator for Power Platform-løsningen. 
Pipelinene og appen er referanseimplementeringer. De ble utviklet for bruk av utviklingsteamet for CoE-startpakken internt, men har blitt åpen kildekode og utgitt for å demonstrere hvordan sunn ALM kan oppnås i Power Platform. De kan brukes som de er eller tilpasses for bestemte forretningsscenarier.

{{</slide>}}
