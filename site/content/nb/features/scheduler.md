---
title: "Planlegger"
description: "Automatiseringssett - Planlegger"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 00B15DA73732A60B73A09229CEF9B843E259A121
---

{{<toc>}}

## Introduksjon

Automation Kit Scheduler gjør det mulig å vise tidsplanen for regelmessige Power Automate Cloud-flyter i løsninger som inkluderer kall til Power Automate Desktop-flyter.

Denne funksjonen ble introdusert som en del av [Februar 2023](/nb/releases/february-2023), Senere utgivelser vil fortsette å forbedre og utvide funksjonaliteten planleggeren.

{{<border>}}
![Planlegger](/images/schedule.png)
{{</border>}}

De viktigste funksjonene i planleggeren er:

- Muligheten til å vise tidsplanen for regelmessige skyflyter
- Vise tidsplan etter dag, uke, måned og tidsplanvisning
- Vise statusen for Planlagte flyter (Vellykket, Feil eller Planlagt)
- Vise varigheten av en Cloud Flow-kjøring
- Vis detaljer om eventuelle feil.

## Notater

For gjeldende versjon gjelder følgende merknader

1. Bare Power Automate Desktop- og Power Automate-løsninger i en løsning vises
1. Minst én Power Automate Desktop er registrert og utført

## Installere

For å installere planleggerløsningen kan du gjøre følgende:

1. Sikre rammeverket for Power Apps-komponenten <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Les også</a>
1. Du har installert Creator Kit i målmiljøet. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installer fra appkilde</a>
1. Du har lastet ned AutomationKit.zip-filen fra Aktiva-delen av den nyeste <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub-utgivelse</a>
1. Du har importert den nyeste AutomationKitScheduler_*_administrert.zip fil ved hjelp av. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Les også</a>

## Veikart

Du kan besøke vår <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-problemer</a> for å se foreslåtte nye funksjoner.

Du kan legge til en ny <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Forespørsel om planleggerfunksjon</a>

## Tilbakemelding

{{<questions name="/content/nb/features/scheduler.json" completed="Takk for at du gir tilbakemelding" showNavigationButtons="false" locale="nb">}}
