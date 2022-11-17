---
title: "Integracja Process Advisor"
description: "Automation Kit - integracja Process Advisor"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 4B988356292B6E69CAEB1E5D4AFB4A272A7131BE
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

2. More information on configuring your Process Advisor analysis with a custom workspace can be found in [Load your process analytics in power bi](https://learn.microsoft.com/en-us/power-automate/process-mining-pbi-workspace#load-your-process-analytics-in-power-bi)

### Power Automate Templates

You could use out of the box Power BI connector actions and Power Automate cloud flows to create or update you Automation Kit projects.

## Questions

{{<questions name="/content/en-us/backlog/process-advisor-integration.json" completed="Thank you for completing Process Advisor questions" showNavigationButtons=false >}}

Na {{<product-name>}} integruje się z [Process Advisor](https://learn.microsoft.com/en-us/power-automate/process-advisor-overview) , aby obsługiwać następujące scenariusze:

- **Przetwarzanie Górnictwo** Analiza procesów biznesowych w celu zidentyfikowania i wsparcia uzasadnienia biznesowego w celu stworzenia projektów automatyzacji wspieranych analizą danych.

- **Żądania projektów automatyzacji opartej na danych** Użyj wyników analizy procesu, aby utworzyć projekt automatyzacji na podstawie Process Advisor wyników.

- **Półautomatyczne tworzenie projektów automatyzacji** Zintegruj dane Dataverse między Process Advisor a Automation Kit, aby zmniejszyć ilość pracy związanej z tworzeniem projektu automatyzacji.

- **Analiza programu Power Automate Desktop** Analizuj dane procesów RPA, aby zidentyfikować ulepszenia w celu modernizacji, poprawy odporności i niezawodności przy użyciu eksploracji zadań.

## Przetwarzanie Górnictwo

Korzystanie z eksploracji procesów z Process Advisor umożliwia wykrycie nieefektywności procesów w całej organizacji. Te spostrzeżenia umożliwiają dogłębne zrozumienie procesów za pomocą plików dziennika zdarzeń, które można uzyskać z systemu rejestrowania (aplikacji używanych w procesach). Eksploracja procesów wyświetla mapy procesów z danymi i metrykami w celu rozpoznania problemów z wydajnością. Przykładowe procesy odpowiednie do eksploracji procesów obejmują należności i order-to-cash.

Te dane umożliwiają tworzenie żądań projektu automatyzacji opartych na danych.

## Tworzenie projektów automatyzacji

Korzystając z wyników Process Advisor procesu eksploracji i raportowania, można użyć następujących Process Advisor informacji do wsparcia projektu automatyzacji przy użyciu Process Advisor obliczonych wyników analizy:

Zestaw do automatyzacji|Process Advisor|Notatki        |
