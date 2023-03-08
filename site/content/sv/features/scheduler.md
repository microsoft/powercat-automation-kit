---
title: "Scheduler"
description: "Automation Kit - Schemaläggare"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: CB8CDD66959E9D2E4AE7FD54BE0C6D04AA2A02E3
---

{{<toc>}}

## Införandet

Med Automation Kit Scheduler kan du visa schemat för återkommande Power Automate Cloud-flöden i lösningar som innehåller anrop till Power Automate Desktop-flöden.

Den här funktionen uppdaterades som en del av [Mars 2023](/sv/releases/march-2023)kommer senare versioner att fortsätta att förbättra och utöka schemaläggarens funktionalitet.

{{<border>}}
![Scheduler](/images/schedule.png)
{{</border>}}

De viktigaste funktionerna i schemaläggaren är:

- Möjligheten att visa schemat för återkommande molnflöden
- Filtrera schema efter dator- och datorgrupper
- Köra ett Power Automate Desktop-flöde
- Visa schema efter dag-, vecko-, månads- och schemavy
- Visa status för Schemalagda flöden (Lyckades, Misslyckades eller Schemalagd)
- Visa varaktigheten för en Cloud Flow-körning
- Visa information om eventuella fel.

## Molnflöden

Som nämnts ovan endast molnflöden som ingår som en del av en lösning. Den senaste [https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/) innehåller information om hur du använder den nya förhandsversionen av "Dataverse-lösningar som standard" för att säkerställa att molnflöden ingår i lösningar. Med den här funktionen kan användarna se till att de schemalagda molnflöden som skapas visas i schemaläggaren.

## Kalendervyer

## Dag, vecka, månad visningar

Dag-, vecko- och månadsvyerna visar information om Desktop Cloud-flödeskörningar som har körts eller är schemalagda att köras.

Objekten är färgkodade enligt följande:

- Grönt indikerar lyckad körning

- Rött indikerar misslyckad körning

- Blå indikerar en schemalagd framtida körning.

Status- och körningsinformationen är tillgänglig med lång tryckning eller muspekare på händelsen.

### Schema

{{<border>}}
![Schemaläggare - Kör nu](/images/scheduler-schedule-view.png)
{{</border>}}

Schemavyn innehåller en uppsättning molnflöden baserat på tid från den aktuella tiden och framtida schemalagda flöden under de kommande dagarna.

## Kör nu

{{<border>}}
![Schemaläggare - Kör nu](/images/scheduler-run-now.png)
{{</border>}}

Den aktuella versionen av Kör nu kör Power Automate desktop. Det förutsätter att det inte krävs några parametrar för att köra datorflödet. Den ytterligare körningsinformationen finns i skrivbordsinformationen för senaste körning.

### Planerade förändringar

I framtida versioner betraktas följande som nya funktioner:

1. Kör molnflödet i stället för datorflödet. Detta inkluderar sedan körningshistorik för molnflöde och körning av eventuella ytterligare molnflödesåtgärder och parametrar som skickas till datorflödet.

2. Kör Power Automate Desktop med olika status.

3. Öppna körningssidorna för Desktop och Cloud flow.

### Skrivskyddat beteende för schemalagda flöden

När ett flöde schemaläggs för framtida körning är det som standard inställt på skrivskyddat läge och inaktiverat för omedelbar körning. Det innebär att användare inte kan ändra eller köra flödet förrän det schemalagda datumet och tiden har passerat. Det här beteendet är utformat för att ge en bättre användarupplevelse och förhindra oavsiktlig körning av flöden innan de är avsedda att köras.
Det finns flera fördelar med den här metoden, bland annat:

- Förhindra oavsiktlig körning: Genom att inaktivera omedelbar körning av flöden som är schemalagda för framtida körning är det mindre troligt att användare av misstag kör ett flöde innan det är avsett att köras.

- Förbättrad förutsägbarhet: Genom att ställa in flöden i skrivskyddat läge när de schemaläggs för framtida körning kan användarna enklare förutsäga när flöden kommer att köras och se till att de har nödvändiga indata och resurser redo.

- Konsekvent användarupplevelse: Genom att standardisera beteendet för schemalagda flöden kan det ge en konsekvent och förutsägbar användarupplevelse i alla instanser av Flow.

- Om du vill ändra eller köra ett schemalagt flöde kan användarna redigera flödet och uppdatera det schemalagda datumet och den schemalagda tiden. När det nya schemat har ställts in inaktiveras flödet återigen för omedelbar körning och ställs in i skrivskyddat läge tills det nya schemat har passerat.

## Felmeddelanden

Möjliga felmeddelanden som kan uppstå när du kör körningsflödet.

### Felmeddelande: "InvalidArgument – Det går inte att hitta en giltig anslutning som är associerad med den angivna anslutningsreferensen."

#### Beskrivning

Det här felmeddelandet indikerar vanligtvis att det finns ett problem med anslutningsreferensen som anges i koden eller konfigurationen. Systemet kan inte hitta en giltig anslutning som är associerad med referensen, vilket hindrar den från att utföra den begärda åtgärden.

#### Orsakar

Det finns flera möjliga orsaker till det här felmeddelandet, inklusive:

- Felaktig eller ogiltig anslutningsreferens: Den angivna anslutningsreferensen kan vara ogiltig eller felaktig, vilket kan leda till att systemet inte hittar en giltig anslutning som är associerad med den.

- Anslutningen har tagits bort eller ändrats: Om anslutningen som används i koden eller konfigurationen har tagits bort eller ändrats kan det leda till att systemet inte hittar en giltig anslutning som är associerad med referensen.

- Behörighetsproblem: Användarkontot som kör koden eller konfigurationen kanske inte har de behörigheter som krävs för att komma åt anslutningen eller de resurser som är associerade med den.

#### Resolution

Lös problemet genom att vidta följande steg:

- Verifiera anslutningsreferensen: Kontrollera anslutningsreferensen i koden eller konfigurationen och se till att den är giltig och korrekt.

- Ta bort befintliga anslutningar och återskapa: Om flödeskontrollen varnar för att en anslutningsreferens inte har använts kan du använda flödeskontrollen för att ta bort befintliga anslutningar. När anslutningarna har tagits bort kan du återskapa anslutningsreferenser till gruppen Dator eller Dator så att flödet kan köras.

## Anteckningar

För den aktuella versionen gäller följande information

1. Endast Power Automate Desktop- och Power Automate-lösningar som ingår i en lösning visas
1. Minst en Power Automate Desktop har registrerats och körts

## Installera

För att installera schemaläggningslösningen kan du göra följande:

1. Se till att Power Apps komponentramverk <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Läs mer</a>
1. Du har installerat Creator Kit i målmiljön. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installera från appkällan</a>
1. Du har laddat ned filen AutomationKit.zip från avsnittet Tillgångar i den senaste <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub-versionen</a>
1. Du har importerat den senaste AutomationKitScheduler_*_hanterad.zip fil med. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Läs mer</a>

## Färdplan

Du kan besöka vår <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-problem</a> för att visa föreslagna nya funktioner.

Du kan lägga till en ny <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Begäran om schemaläggningsfunktion</a>

## Feedback

{{<questions name="/content/sv/features/scheduler.json" completed="Tack för att du ger feedback" showNavigationButtons="false" locale="sv">}}
