---
title: "Intégration Process Advisor"
description: "Kit d’automatisation - Intégration Process Advisor"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Process Advisor', 'Integration', 'RPA']
generated: A51CC6A1EB6E9681ED2302F8F389D50BCC752BB6
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

Le {{<product-name>}} s’intègre à [Process Advisor](https://learn.microsoft.com/en-us/power-automate/process-advisor-overview) pour prendre en charge les scénarios suivants :

- **Traitement de l’exploitation minière** Analyse des processus d’affaires pour identifier et soutenir l’analyse de rentabilisation pour créer des projets d’automatisation soutenus par l’analyse des données.

- **Demandes de projets d’automatisation pilotée par les données** Utilisez les résultats de votre analyse de processus pour créer un projet d’automatisation à partir de Process Advisor résultats.

- **Création de projets d’automatisation semi-automatisés** Intégrez les données Dataverse entre Process Advisor et Automation Kit pour réduire la quantité de travail nécessaire à la création d’un projet d’automatisation.

- **Analyse de Power Automate Desktop** Analysez les données de processus RPA pour identifier les améliorations à améliorer, améliorer la résilience et la fiabilité à l’aide de l’exploration de tâches.

## Traitement de l’exploitation minière

L’utilisation de Process Mining avec Process Advisor vous permet de découvrir les inefficacités dans les processus à l’échelle de l’organisation. Ces informations vous permettent d’acquérir une compréhension approfondie de vos processus à l’aide des fichiers journaux des événements que vous pouvez obtenir à partir de votre système d’enregistrement (applications que vous utilisez dans vos processus). L’exploration de processus affiche des cartes de vos processus avec des données et des mesures pour identifier les problèmes de performances. Des exemples de processus adaptés à l’exploration de processus incluent les comptes clients et la commande à l’encaissement.

Ces données vous permettent de créer des demandes de projet d’automatisation pilotées par les données.

## Création de projets d’automatisation

À l’aide des résultats de Process Advisor exploration de processus et de création de rapports, vous pouvez utiliser les informations Process Advisor suivantes pour soutenir votre projet d’automatisation à l’aide de résultats d’analyse Process Advisor calculés :

Kit d’automatisation|Process Advisor|Notes        |
