---
title: "Programmateur"
description: "Kit d’automatisation - Planificateur"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 3191EC35273FDF75E031467EB6C5BF37F2883B67
---

{{<toc>}}

## Introduction

La page Planificateur Automation Center du Kit d’automatisation vous permet d’afficher la planification des flux Power Automate Cloud récurrents dans les solutions qui incluent des appels aux flux Power Automate Desktop.

Cette fonctionnalité a été mise à jour dans le cadre de l' [Juin 2023](/fr/releases/june-2023)

{{<border>}}
![Programmateur](/images/schedule.png)
{{</border>}}

Les principales caractéristiques du planificateur sont les suivantes :

- La possibilité de visualiser la planification des flux cloud récurrents
- Filtrer la planification par machine et groupes de machines et par état
- Vue Grille ouverte des exécutions de flux Desktop
- Exécuter un flux Power Automate Desktop
- Voir le calendrier par jour, semaine, mois et affichage horaire
- Afficher l’état des flux planifiés (Succès, Échec ou Planifié)
- Afficher la durée d’une exécution de Cloud Flow
- Affichez les détails des erreurs.

## Flux de nuages

Comme indiqué ci-dessus, seuls les flux de nuages inclus dans une solution. Le récent [https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/) inclut des informations sur l’utilisation de la nouvelle version préliminaire des « solutions Dataverse par défaut » pour garantir que les flux cloud sont inclus dans les solutions. L’utilisation de cette fonctionnalité peut aider les utilisateurs à s’assurer que les flux cloud planifiés créés sont visibles dans le planificateur.

## Affichages du calendrier

## Vues jour, semaine, mois

Les vues jour, semaine, mois affichent des informations sur les exécutions de flux Desktop Cloud qui ont été exécutées ou planifiées.

Les articles sont codés par couleur comme suit :

- Le vert indique une exécution réussie

- Le rouge indique l’échec de l’exécution

- Le bleu indique une exécution future planifiée.

Les informations d’état et d’exécution sont disponibles avec une longue souris tactile ou survolée sur l’événement.

### Horaire

{{<border>}}
![Planificateur - Vue planifiée](/images/scheduler-schedule-view.png)
{{</border>}}

La vue de planification inclut un ensemble de flux de nuages basés sur l’heure actuelle et les flux planifiés futurs au cours des prochains jours.

## Exécuter maintenant

{{<border>}}
![Planificateur - Exécuter maintenant](/images/scheduler-run-now.png?v=1)
{{</border>}}

La version actuelle de l’Exécuter maintenant exécute le bureau Power Automate. Il est supposé qu’aucun paramètre n’est requis pour exécuter le flux de bureau. Les informations d’exécution supplémentaires sont disponibles dans les informations de dernière exécution du bureau.

## Vue Grille ouverte

{{<border>}}
![Planificateur - Vue Grille ouverte](/images/scheduler-open-grid-view.png)
{{</border>}}

Les utilisateurs peuvent accéder à la page des flux de bureau dans Power Automate de notre page d’accueil du centre de contrôle
Capture d’écran du nouveau bouton « Ouvrir la vue grille » sur la page d’accueil pour accéder à la page des flux de bureau s’exécute dans le portail Power Automate.

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

- Supprimer les connexions existantes et recréer : si le vérificateur de flux avertit qu’une référence de connexion n’a pas été utilisée, vous pouvez utiliser le vérificateur de flux pour supprimer les connexions existantes. Une fois les connexions supprimées, vous pouvez recréer des références de connexion au groupe Machine ou Machine pour permettre l’exécution du flux.

## Notes

Pour la version actuelle, les remarques suivantes s’appliquent

1. Seules les solutions Power Automate Desktop et Power Automate contenues dans une solution sont affichées
1. Au moins un Power Automate Desktop a été enregistré et exécuté

## Installer

Pour installer le centre de contrôle peut effectuer les opérations suivantes :

1. Vérifier que l’infrastructure des composants Power Apps est activée <a href="https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Lire la suite</a>
1. Vous avez installé le Creator Kit dans l’environnement cible. <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installer à partir de la source de l’application</a>
1. Vous avez importé la dernière version d’AutomationKitControlCenter_*_géré.zip fichier à l’aide. <a href='https://learn.microsoft.com/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Lire la suite</a>

## Feuille de route

Vous pouvez visiter notre <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">Problèmes GitHub</a> pour afficher les nouvelles fonctionnalités proposées.

Vous pouvez ajouter un nouveau <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Demande de fonctionnalité du planificateur</a>

## Rétroaction

{{<questions name="/content/fr/features/scheduler.json" completed="Merci de nous avoir fait part de vos commentaires" showNavigationButtons="false" locale="fr">}}
