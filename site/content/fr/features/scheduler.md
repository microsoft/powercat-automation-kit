---
title: "Programmateur"
description: "Kit d’automatisation - Planificateur"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B97833AB30777C813B3E62592D32D7E5B882ACEE
---

{{<toc>}}

## Introduction

Le Planificateur du Kit d’automatisation permet d’afficher la planification des flux Power Automate Cloud récurrents dans les solutions qui incluent des appels aux flux Power Automate Desktop.

Cette fonctionnalité a été mise à jour dans le cadre de l' [Mars 2023](/fr/releases/march-2023), les versions ultérieures continueront d’améliorer et de développer les fonctionnalités du planificateur.

{{<border>}}
![Programmateur](/images/schedule.png)
{{</border>}}

Les principales caractéristiques du planificateur sont les suivantes :

- La possibilité de visualiser la planification des flux cloud récurrents
- Filtrer la planification par machine et groupes de machines
- Exécuter un flux Power Automate Desktop
- Voir le calendrier par jour, semaine, mois et affichage horaire
- Afficher l’état des flux planifiés (Succès, Échec ou Planifié)
- Afficher la durée d’une exécution de Cloud Flow
- Affichez les détails des erreurs.

## Flux d’exécution

### Comportement en lecture seule des flux planifiés

Par défaut, lorsqu’un flux est planifié pour une exécution future, il est défini en mode lecture seule et désactivé pour une exécution immédiate. Cela signifie que les utilisateurs ne peuvent pas modifier ou exécuter le flux tant que la date et l’heure planifiées ne sont pas écoulées. Ce comportement est conçu pour fournir une meilleure expérience utilisateur et empêcher l’exécution accidentelle des flux avant qu’ils ne soient destinés à s’exécuter.
Cette approche présente plusieurs avantages, notamment :

- Prévention de l’exécution accidentelle : en désactivant l’exécution immédiate des flux planifiés pour une exécution ultérieure, les utilisateurs sont moins susceptibles d’exécuter accidentellement un flux avant qu’il ne soit destiné à s’exécuter.

- Amélioration de la prévisibilité : en définissant les flux en mode lecture seule lorsqu’ils sont planifiés pour une exécution future, les utilisateurs peuvent plus facilement prédire quand les flux s’exécuteront et s’assurer qu’ils disposent des entrées et des ressources nécessaires.

- Expérience utilisateur cohérente : en standardisant le comportement des flux planifiés, il peut fournir une expérience utilisateur cohérente et prévisible sur toutes les instances de Flow.

- Pour modifier ou exécuter un flux planifié, les utilisateurs peuvent modifier le flux et mettre à jour la date et l’heure planifiées. Une fois la nouvelle planification définie, le flux sera à nouveau désactivé pour une exécution immédiate et défini en mode lecture seule jusqu’à ce que la nouvelle planification soit passée.

## Messages d’erreur

Messages d’erreur possibles pouvant se produire lors de l’exécution du flux d’exécution.

### Message d’erreur : « InvalidArgument - Impossible de trouver une connexion valide associée à la référence de connexion fournie. »

#### Description

Ce message d’erreur indique généralement qu’il existe un problème avec la référence de connexion fournie dans le code ou la configuration. Le système ne peut pas localiser une connexion valide associée à la référence, ce qui l’empêche d’exécuter l’action demandée.

#### Causes

Il existe plusieurs causes potentielles de ce message d’erreur, notamment :

- Référence de connexion incorrecte ou non valide : la référence de connexion fournie peut être non valide ou incorrecte, ce qui peut empêcher le système de localiser une connexion valide qui lui est associée.

- Connexion supprimée ou modifiée : si la connexion utilisée dans le code ou la configuration a été supprimée ou modifiée, le système peut ne pas localiser une connexion valide associée à la référence.

- Problème d’autorisations : le compte d’utilisateur exécutant le code ou la configuration peut ne pas disposer des autorisations nécessaires pour accéder à la connexion ou aux ressources qui lui sont associées.

#### Résolution

Pour résoudre ce problème, vous pouvez suivre les étapes suivantes :

- Vérifier la référence de connexion : vérifiez la référence de connexion fournie dans le code ou la configuration et assurez-vous qu’elle est valide et correcte.

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
