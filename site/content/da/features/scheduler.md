---
title: "Planlægger"
description: "Automatiseringssæt - Planlægger"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B8DC4418FD2312850E01B5DB52344E2BB9B93C2F
---

{{<toc>}}

## Indførelsen

Automatiseringspakken Scheduler giver mulighed for at få vist tidsplanen for tilbagevendende Power Automate Cloud-flows i løsninger, der omfatter opkald til Power Automate Desktop-flows.

Denne funktion blev introduceret som en del af [Marts 2023](/da/releases/february-2023), Senere udgivelser vil fortsætte med at forbedre og udvide funktionaliteten i planlæggeren.

{{<border>}}
![Planlægger](/images/schedule.png)
{{</border>}}

De vigtigste funktioner i planlæggeren er:

- Muligheden for at få vist tidsplanen for tilbagevendende cloudflows
- Se tidsplan efter dag, uge, måned og tidsplanvisning
- Få vist status for planlagte flow (Fuldført, Mislykket eller Planlagt)
- Se varigheden af en Cloud Flow-kørsel
- Se detaljerne eventuelle fejl.

## Noter

For den aktuelle version gælder følgende bemærkninger

1. Kun Power Automate Desktop- og Power Automate-løsninger, der er indeholdt i en løsning, vises
1. Mindst ét Power Automate Desktop er blevet registreret og udført

## Installere

For at installere planlægningsløsningen kan du gøre følgende:

1. Sørg for Power Apps-komponentstruktur <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Læs mere</a>
1. Du har installeret Creator Kit i destinationsmiljøet. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installer fra App Source</a>
1. Du har downloadet AutomationKit.zip-filen fra afsnittet Aktiver i det seneste <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub-udgivelse</a>
1. Du har importeret den nyeste AutomationKitScheduler_*_administreret.zip fil ved hjælp af. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Læs mere</a>

## Køreplan

Du kan besøge vores <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-problemer</a> for at se foreslåede nye funktioner.

Du kan tilføje en ny <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Anmodning om planlægningsfunktion</a>

## Feedback

{{<questions name="/content/da/features/scheduler.json" completed="Tak, fordi du gav feedback" showNavigationButtons="false" locale="da">}}
