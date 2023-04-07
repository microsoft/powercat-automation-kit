---
title: "Process Advisor Integration"
description: "Automatiseringssæt - Process Advisor integration"
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

Den {{<product-name>}} integreres med [Process Advisor](https://learn.microsoft.com/power-automate/process-advisor-overview) for at understøtte følgende scenarier:

- **Forarbejdning af minedrift** Analyse af forretningsprocesser for at identificere og understøtte business casen for at oprette automatiseringsprojekter understøttet af dataanalyse.

- **Projektanmodninger om datadrevet automatisering** Brug resultaterne af din procesanalyse til at oprette et automatiseringsprojekt ud fra Process Advisor resultater.

- **Oprettelse af semiautomatiske automatiseringsprojekter** Integrer Dataverse-data mellem Process Advisor og Automation Kit for at reducere mængden af arbejde med at oprette automatiseringsprojekt.

- **Analyse af Power Automate Desktop** Analysér RPA-procesdata for at identificere forbedringer for at modernisere, forbedre robustheden og pålideligheden ved hjælp af Task mining.

## Forarbejdning af minedrift

Brug af Process mining med Process Advisor giver dig mulighed for at opdage ineffektivitet i processer i hele organisationen. Denne indsigt giver dig mulighed for at få en dyb forståelse af dine processer ved hjælp af hændelseslogfiler, som du kan få fra dit registreringssystem (apps, du bruger i dine processer). Process mining viser kort over dine processer med data og målepunkter for at genkende problemer med ydeevnen. Eksempler på processer, der er egnede til procesmining, omfatter debitorer og ordre-til-kontanter.

Disse data giver dig mulighed for at oprette datadrevne Automation Project-anmodninger.

## Oprettelse af automatiseringsprojekter

Ved hjælp af resultaterne af Process Advisor procesmining og rapportering kan du bruge følgende Process Advisor oplysninger til at understøtte dit automatiseringsprojekt ved hjælp af Process Advisor beregnede analyseresultater:

Automatisering kit|Process Advisor|Noter        |
