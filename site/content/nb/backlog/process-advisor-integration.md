---
title: "Process Advisor Integrasjon"
description: "Automatiseringssett – Process Advisor-integrasjon"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Process Advisor', 'Integration', 'RPA']
generated: 43CC06A24918E86A3EF2FB210C196D0296D46B26
---
--------------|---------------|-------------|
Duration Total (Total Processing Time in minutes)|Duration Total Per activity|Top-level metrics currently only median and average duration which can be transformed with some customization
Case frequency| (volume per process frequency)|Case count||
Resource count (Number of FTEs needed, Number of FTEs needed for Review/Rework)|Resource count
Rework percentage (AVG Error Rate %)|Rework percentage||
Currency||In Process Advisor data model

## Semi Automated Automation Project

Using the data collected in the Process Advisor in your Power BI custom workspace you can integrate the results using Power Automate or Power Apps.

![Automation Kit Process Advisor Integration](/images/illustrations/process-advisor-integration.svg)

Using the Process Advisor Import process simplifies the amount of information that needs to be entered and offers you a choice of options to integrate with you Automation Project.

Reviewers of the Automation Project and take into account the Process Advisor results when considering if they should Approve or Deny the Automation Project request.

NOTE:

1. We currently have items on the Automation Kit backlog to add additional templates and applications in upcoming milestones that enable you quickly get started with integrating your Processed Advisor data with the Automation Kit.

2. More information on configuring your Process Advisor analysis with a custom workspace can be found in [Load your process analytics in power bi](https://learn.microsoft.com/power-automate/process-mining-pbi-workspace#load-your-process-analytics-in-power-bi)

### Power Automate Templates

You could use out of the box Power BI connector actions and Power Automate cloud flows to create or update you Automation Kit projects.

## Questions

{{<questions name="/content/en-us/backlog/process-advisor-integration.json" completed="Thank you for completing Process Advisor questions" showNavigationButtons=false >}}

Den {{<product-name>}} integreres med [Process Advisor](https://learn.microsoft.com/power-automate/process-advisor-overview) for å støtte følgende scenarier:

- **Prosessering av gruvedrift** Analyse av forretningsprosesser for å identifisere og støtte forretningssaken for å opprette automatiseringsprosjekter som støttes av dataanalyse.

- **Datadrevet automatisering Prosjektforespørsler** Bruk resultatene fra prosessanalysen til å opprette et automatiseringsprosjekt fra Process Advisor resultatene.

- **Semi-automatisert automatisering Prosjektopprettelse** Integrer Dataverse-data mellom Process Advisor og automatiseringssett for å redusere arbeidsmengden for å opprette automatiseringsprosjekt.

- **Analyse av Power Automate Desktop** Analyser RPA-prosessdata for å identifisere forbedringer for å modernisere, forbedre robusthet og pålitelighet ved hjelp av oppgaveutvinning.

## Prosessering av gruvedrift

Ved å bruke prosessutvinning med Process Advisor kan du oppdage ineffektivitet i prosesser for hele organisasjonen. Denne innsikten gjør at du kan få en dyp forståelse av prosessene dine ved hjelp av hendelsesloggfiler som du kan få fra opptakssystemet ditt (apper du bruker i prosessene dine). Prosessutvinning viser kart over prosessene dine med data og beregninger for å gjenkjenne ytelsesproblemer. Eksempler på prosesser som egner seg for prosessutvinning inkluderer kundefordringer og ordre-til-kontanter.

Med disse dataene kan du opprette datadrevne prosjektforespørsler for automatisering.

## Opprettelse av automatiseringsprosjekter

Ved hjelp av resultatene av Process Advisor prosessutvinning og rapportering kan du bruke følgende Process Advisor informasjon til å støtte automatiseringsprosjektet ved hjelp av Process Advisor beregnede analyseresultatene:

Automatisering Kit|Process Advisor|Notater        |
