---
title: "Power CAT Application Lifecycle Management (ALM)"
description: "Automatiseringssæt - ALM Power CAT"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 0087DF5B505764347AC2AF0B6C170474826A5D65
---

{{<slideStyles>}}

<div class="optional">

Automatiseringssættet udnytter [ALM Accelerator](https://aka.ms/aa4pp) for at levere ALM-funktionalitet til løsninger, der omfatter Power Automate Desktop

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## GitHub-implementeringsproces

I lighed med den udgivelsesproces, der bruges til andre Power CAT-administrerede sæt, er {{<product-name>}} bruger ALM Accelerator til at implementere udgivelser i vores offentlige GitHub-udgivelser.

Vores interne proces har et Power Platform-miljø til udvikling, test og produktion. Når vi er klar til en udgivelse, pakker vores integrerede GitHub Actions de administrerede og ikke-administrerede implementeringsløsninger sammen med produktbemærkninger automatisk til en GitHub Draft-udgivelse.

Når kladdeudgivelsen er klar, kan vi udgive nye versioner eller hotfixes efter behov.

### Hvad det betyder for dig

Nu hvor vi har denne automatisering på plads, har den automatiserede ALM-udgivelse følgende fordele for dig:

- Synlighed i al den lave kodekildekode, der udgør automatiseringssættet, så du kan undersøge, hvordan vi har bygget sættet.

- Strømlinet automatiseringsproces, der kan reagere hurtigt på fejl eller problemer og levere hotfixes, hvis det er nødvendigt.

- Automatisk samling af alle fejl og funktioner, der er inkluderet i en udgivelse.

- Vi inkluderer Power Apps, Power Automate, Dataverse og Power Automate Desktop som en del af vores ALM-proces til vores kontinuerlige integration/kontinuerlige udrulning.

## Køreplan

Du kan undersøge vores åbne ALM-relaterede efterslæbsposter i vores [GitHub-problemer Register](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

Samlet set bygger vi videre på de eksisterende Power Platform- og Microsoft DevOps-produktfunktioner sammen ALM Accelerator. Denne kombination giver os mulighed for at fokusere på specifikke udvidelser, der hjælper med hyperautomtion.

## Feedback

{{<questions name="/content/da/features/alm/powercat.json" completed="Tak, fordi du gav feedback" showNavigationButtons="false" locale="da">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Power CAT-teamet bruger ALM Accelerator til at bygge og implementere hver af vores [Udgivelser](https://github.com/microsoft/powercat-automation-kit/releases).

Hver udgivelse fremmer ændringer fra vores udvikling til test- og produktionsmiljøer. Power Platform-løsningerne i sættet bruger en automatiseret proces til at pakke aktiver til implementering i offentlige GitHub-udgivelser.

I fremtidige milepæle vil vi udvide på eksisterende platform [ALM-funktioner](/da/features/alm) for at give eksempler på, hvordan valideringsregler og visuel sammenligning af RPA-prøver kan medtages som en del af DevOps-processen.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

Følgende skitserer de vigtigste trin i udgivelsesprocessen for automatiseringssæt:

1. Ændringer, der foretages i vores Power Platform Dev-miljø, gemmes i en filial i det offentlige GitHub-lager

2. Når ændringer er klar til optagelse i en testudgivelse, flettes de ind i hovedgrenen ved hjælp af en pullanmodning. Før pullanmodningen kan fuldføres, skal Azure DevOps-valideringspipelinen fuldføres, og pullanmodningen skal gennemgås.

3. Når pullanmodningen har bestået de automatiske kontroller og modtaget gennemgangsgodkendelse, kan den flettes ind i hovedgrenen. Denne fletning udløser testpipelinen til Azure DevOps-build, som publicerer det administrerede build til Power Platform-testmiljøet.

4. Efter intern test udløses Azure DevOps-produktionspipelinen manuelt for at generere en Production Power Platform-udrulning.

5. Når udgivelsen er klar, opretter Azure DevOps-pipelinen en kladdeudgivelse med produktbemærkninger og buildaktiver. Den endelige udgivelsesbuild lukker alle åbne problemer og lukker milepælen. Udgivet build-tag GitHub-lageret med en måneds- og årsetiket anvendt.

{{</slide>}}
