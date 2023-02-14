---
title: "Programmateur"
description: "Kit d’automatisation - Planificateur"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B8DC4418FD2312850E01B5DB52344E2BB9B93C2F
---

{{<toc>}}

## Introduction

Le Planificateur du Kit d’automatisation permet d’afficher la planification des flux Power Automate Cloud récurrents dans les solutions qui incluent des appels aux flux Power Automate Desktop.

Cette fonctionnalité a été introduite dans le cadre de l' [Février 2023](/fr/releases/february-2023), les versions ultérieures continueront d’améliorer et de développer les fonctionnalités du planificateur.

{{<border>}}
![Programmateur](/images/schedule.png)
{{</border>}}

Les principales caractéristiques du planificateur sont les suivantes :

- La possibilité de visualiser la planification des flux cloud récurrents
- Voir le calendrier par jour, semaine, mois et affichage horaire
- Afficher l’état des flux planifiés (Succès, Échec ou Planifié)
- Afficher la durée d’une exécution de Cloud Flow
- Affichez les détails des éventuelles erreurs.

## Notes

Pour la version actuelle, les remarques suivantes s’appliquent

1. Seules les solutions Power Automate Desktop et Power Automate contenues dans une solution sont affichées
1. Au moins un Power Automate Desktop a été enregistré et exécuté

## Installer

Pour installer la solution de planificateur, vous pouvez effectuer les opérations suivantes :

1. Garantir l’infrastructure des composants Power Apps <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Lire la suite</a>
1. Vous avez installé le Creator Kit dans l’environnement cible. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installer à partir de la source de l’application</a>
1. Vous avez téléchargé le fichier AutomationKit.zip à partir de la section Actifs de la dernière version <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Version de GitHub</a>
1. Vous avez importé la dernière version d’AutomationKitScheduler_*_géré.zip fichier à l’aide. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Lire la suite</a>

## Feuille de route

Vous pouvez visiter notre <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">Problèmes GitHub</a> pour afficher les nouvelles fonctionnalités proposées.

Vous pouvez ajouter un nouveau <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Demande de fonctionnalité du planificateur</a>

## Rétroaction

{{<questions name="/content/fr/features/scheduler.json" completed="Merci de nous avoir fait part de vos commentaires" showNavigationButtons="false" locale="fr">}}
