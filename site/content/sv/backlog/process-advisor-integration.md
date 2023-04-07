---
title: "Process Advisor Integration"
description: "Automation Kit - Process Advisor Integration"
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

Den {{<product-name>}} integreras med [Process Advisor](https://learn.microsoft.com/power-automate/process-advisor-overview) för att stödja följande scenarier:

- **Bearbetning av gruvdrift** Analys av affärsprocesser för att identifiera och stödja affärsfallet för att skapa automatiseringsprojekt som stöds av dataanalys.

- **Projektförfrågningar för datadriven automatisering** Använd resultaten av din processanalys för att skapa ett automatiseringsprojekt från Process Advisor resultat.

- **Halvautomatiserat skapande av automatiseringsprojekt** Integrera Dataverse-data mellan Process Advisor och Automation Kit för att minska mängden arbete för att skapa Automation-projekt.

- **Analys av Power Automate Desktop** Analysera RPA-processdata för att identifiera förbättringar för att modernisera, förbättra återhämtning och tillförlitlighet med hjälp av uppgiftsutvinning.

## Bearbetning av gruvdrift

Genom att använda processutvinning med Process Advisor kan du upptäcka ineffektivitet i organisationsomfattande processer. Med dessa insikter kan du få en djup förståelse för dina processer med hjälp av händelseloggfiler som du kan hämta från ditt inspelningssystem (appar som du använder i dina processer). Process mining visar kartor över dina processer med data och mått för att identifiera prestandaproblem. Exempel på processer som är lämpliga för processutvinning inkluderar kundfordringar och order-to-cash.

Med dessa data kan du skapa datadrivna Automation Project-begäranden.

## Skapa automatiseringsprojekt

Med hjälp av resultaten från Process Advisor processutvinning och rapportering kan du använda följande Process Advisor information för att stödja ditt automatiseringsprojekt med hjälp av Process Advisor beräknade analysresultat:

Automation Kit|Process Advisor|Anteckningar        |
