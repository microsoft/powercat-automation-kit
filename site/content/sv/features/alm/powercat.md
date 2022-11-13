---
title: "Power CAT Application Lifecycle Management (ALM)"
description: "Automationssats - ALM Power CAT"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: EE6E212FD39B87D233249859750DDF2D7FC71E60
---

{{<slideStyles>}}

<div class="optional">

Automation Kit utnyttjar [ALM-accelerator](https://aka.ms/aa4pp) för att tillhandahålla ALM-funktioner för lösningar som innehåller Power Automate Desktop

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## GitHub distributionsprocess

Liknar den lanseringsprocess som används för andra Power CAT-hanterade kit {{<product-name>}} använder ALM Accelerator för att distribuera versioner till våra offentliga GitHub-versioner.

Vår interna process har en Power Platform-miljö för utveckling, testning och produktion. När vi är redo för en version paketerar våra integrerade GitHub Actions de hanterade och ohanterade distributionslösningarna tillsammans med viktig information automatiskt för en GitHub Draft-version.

När utkastet till version är klart kan vi publicera nya versioner eller snabbkorrigeringar efter behov.

### Vad detta innebär för dig

Nu när vi har den här automatiseringen på plats har den automatiska ALM-versionen följande fördelar för dig:

- Insyn i all källkod med låg kod som utgör Automation Kit så att du kan undersöka hur vi har byggt paketet.

- Strömlinjeformad automatiseringsprocess som kan svara på buggar eller problem snabbt och tillhandahålla snabbkorrigeringar om det behövs.

- Automatiserad kompilering av alla buggar och funktioner som ingår i en utgåva.

- Vi inkluderar Power Apps, Power Automate, Dataverse och Power Automate Desktop som en del av vår ALM-process för vår kontinuerliga integrering/kontinuerliga distribution.

## Färdplan

Du kan undersöka våra öppna ALM-relaterade eftersläpningsobjekt i vår [GitHub problemregister](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

Sammantaget bygger vi vidare på de befintliga färdiga Power Platform- och Microsoft DevOps-produktfunktionerna tillsammans ALM Accelerator. Denna kombination gör att vi kan fokusera på specifika tillägg som hjälper till med hyperautomtion.

## Feedback

{{<questions name="/content/sv/features/alm/powercat.json" completed="Tack för att du ger feedback" showNavigationButtons="false" locale="sv">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Power CAT-teamet använder ALM Accelerator för att bygga och distribuera var och en av våra [Släpper](https://github.com/microsoft/powercat-automation-kit/releases).

Varje version främjar ändringar från vår utveckling till test- och produktionsmiljöer. Power Platform-lösningarna i paketet använder en automatiserad process för att paketera tillgångar för distribution till offentliga GitHub-versioner.

I framtida milstolpar kommer vi att expandera på befintlig plattform [ALM-funktioner](/sv/features/alm) för att ge exempel på hur du inkluderar valideringsregler och visuell jämförelse av RPA-exempel som en del av DevOps-processen.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

Följande beskriver viktiga steg i Automation Kit-lanseringsprocessen:

1. Ändringar som görs i vår Power Platform Dev-miljö sparas i en gren på den offentliga GitHub-lagringsplatsen

2. När ändringarna är redo att inkluderas i en testversion slås de samman i huvudgrenen med hjälp av en pull-begäran. Innan pull-begäran kan slutföras måste Azure DevOps-valideringspipelinen slutföras och pull-begäran granskas.

3. När pull-begäran har klarat de automatiska kontrollerna och fått granskningsgodkännande kan den slås samman med huvudgrenen. Den här sammanslagningen utlöser testpipelinen Azure DevOps som publicerar den hanterade versionen till testmiljön Power Platform.

4. Efter intern testning utlöses Azure DevOps-produktionspipelinen manuellt för att generera en Power Platform-distribution för produktion.

5. När en version är klar skapar Azure DevOps-pipelinen ett utkast till version, inklusive viktig information och byggtillgångar. Den slutliga versionen stänger alla öppna problem och stänger milstolpen. Publicerad build-tagg GitHub-lagringsplatsen med en månads- och årsetikett tillämpad.

{{</slide>}}
