---
title: Gestion du cycle de vie des applications (ALM)
description: Kit d’automatisation - ALM
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9879BCED5F4B223A5305D8514B67FB43AA12FDDD
---

{{<slideStyles>}}

<div class="optional">

Cette page fournit une vue d’ensemble des composants qui peuvent vous aider à utiliser ALM avec le Kit d’automatisation pour les flux de travail Power Automate Desktop inclus dans [Solutions de plate-forme d’alimentation](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## Résumé

Lorsque vous examinez les solutions ALM for Power Platform qui incluent des composants Power Automate Desktop

1. Passez en revue les fonctionnalités de Managed Environment Power Platform Pipelines pour tirer parti des fonctionnalités intégrées au produit à l’échelle de l’entreprise afin de gérer et de gouverner les solutions au sein des environnements.

<br/>

2. Au besoin, examinez le [Outils de génération Microsoft Power Platform pour Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [Actions GitHub pour Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) ou [CLI de la plate-forme d’alimentation](https://learn.microsoft.com/power-platform/developer/cli/introduction) pour intégrer et automatiser vos processus ALM DevOps.

<br/>

3. Envisagez d’utiliser le [ALM Accelerator for Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). ALM Accelerator fournit un ensemble prédéfini de modèles Azure DevOps qui automatise de nombreuses tâches ALM Power Platform à l’aide de la gouvernance de contrôle de code source intégrée.

## Apprendre de Power CAT

Vous pouvez également en savoir plus sur la façon dont nous, en tant qu’équipe Power CAT, utilisons ALM Accelerator pour expédier le [Kit d’automatisation Power CAT ALM](/fr/features/alm/powercat).

## Ressources

[Catalogue d’apprentissage ALM Accelerator for Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## Feuille de route

L’équipe du kit d’automatisation travaille avec l’équipe ALM Accelerator pour ajouter des tâches spécifiques à Power Automate Desktop aux modèles existants qui couvrent :

- Comparaison côte à côte des définitions de Power Automate Desktop.

- Vérifications de règle de validation pour Power Automate Desktop.

- Exécution de tests unitaires, d’intégration et de systèmes dans le cadre du pipeline CI/CD.

Consultez notre [Backlog lié à Automation Kit ALM](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## Rétroaction

{{<questions name="/features/alm.json" completed="Thank you for providing feedback" showNavigationButtons=false >}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

Les environnements gérés vous permettent de rationaliser et de simplifier la gouvernance à grande échelle. Les administrateurs peuvent activer les environnements gérés en quelques clics et activer immédiatement les fonctionnalités qui offrent plus de visibilité, plus de contrôle avec moins d’efforts pour gérer toutes vos ressources low code.

Les environnements gérés sont un élément clé de la famille Power Platform, de la même manière qu’AI Builder a insufflé de l’intelligence dans nos produits et Dataverse fournit l’épine dorsale des données. Les environnements gérés rationalisent la gouvernance de la plate-forme à grande échelle.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

Les environnements gérés vous offrent :

- Plus de visibilité grâce à des informations sur l’utilisation sur la page d’accueil, des e-mails de résumé de l’administrateur, des rapports de licence et des vues de stratégie de données
- Plus de contrôle avec des limites de partage vous permettant de contrôler l’étendue et le nombre de personnes avec lesquelles les flux d’applications et de solutions canevas peuvent être partagés.
- Vous pouvez également limiter le partage à des groupes de sécurité limités.
- Configurer le vérificateur de solution pour les contrôles de sécurité ou de fiabilité afin d’exécuter automatiquement des règles chaque fois qu’une solution est importée dans un environnement géré
- Personnalisez l’expérience d’accueil et de partage du créateur afin de guider les utilisateurs sur le bon chemin.
- Moins d’efforts rationalisez, simplifiez et automatisez les étapes prêtes à l’emploi en quelques clics. 
- Power Platform Pipelines permet de simplifier le processus de gestion du cycle de vie des applications (ALM).

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

C’est une solution avec laquelle je travaille dans le portail Maker.

Je suis allé de l’avant pour sélectionner ce pipeline qui a déjà été configuré. Les pipelines sont essentiellement une série d’étapes automatisées qui déplacent votre travail d’un environnement à un autre. Ce pipeline fera passer ma solution de l’environnement de développement de gauche à l’environnement de test. Ensuite, il y a une autre étape pour passer du test à la production.

Déployons pour tester, sélectionnez suivant et ici, je vais confirmer mes connexions pour tester l’environnement pour m’assurer que j’utilise les bonnes informations d’identification. Ensuite, je vais configurer mes variables d’environnement pour m’assurer, par exemple, que je pointe vers le bon site SharePoint en test. Ceci est important si le site était différent de celui que j’utilisais en développement. 

Une fois que j’ai tout configuré, je peux simplement sélectionner « Déployer » et les validations de contrôle en amont sont automatiquement exécutées pour s’assurer que j’ai les bonnes dépendances et que la solution ne viole pas les politiques DLP dans cet environnement cible. Le pipeline peut également être configuré de sorte qu’une approbation soit requise avant que le déploiement puisse être exécuté. 

On dirait que tout a réussi ici.

Après avoir exécuté mon pipeline, j’obtiens une visibilité complète et une piste d’audit des déploiements dans mon organisation avec chaque solution sauvegardée et versionnée.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

Les fonctionnalités seront déployées par étapes. Certains d’entre eux, comme les résumés d’administration et les limites de partage, sont disponibles aujourd’hui. Le reste sera déployé d’ici la fin de l’année.

Dans les semaines et les mois à venir, vous verrez des informations sur l’utilisation sur la page d’accueil. Nouvelles tendances dans les résumés d’administration et les rapports pour l’utilisation sous licence. Les limites de partage permettront d’obtenir plus de contrôles et de flux de solutions de support. Vous pourrez bloquer les déploiements non sécurisés avec Solution Checker. Les capacités d’intégration et de pipeline des créateurs de clients viendront également plus tard cette année.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

Vous disposez d’un certain nombre d’options à prendre en compte pour vos choix ALM dans Power Platform. Les pipelines Managed Environment Power Platform assurent la gestion du cycle de vie des applications.

Vous pouvez éventuellement utiliser les points d’extension des pipelines Managed Environment Power Platform combinés avec [Power Platform Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)le [Actions GitHub pour Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) ou [CLI de la plate-forme d’alimentation](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction) pour déployer vos propres processus ALM DevOps personnalisés.

Enfin, vous pourriez profiter de la [ALM Accelerator for Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) du Kit CoE pour fournir des modèles et des exemples prédéfinis pour la gestion de patrimoine ALM de bout en bout à l’aide d’Azure DevOps. ALM Accelerator fournit de nombreux scénarios courants pour créer et gérer vos solutions dans tous les environnements.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

Qu’est-ce qu’ALM Accelerator for Power Platform ?

ALM Accelerator for Power Platform inclut Power Apps qui se trouve au-dessus des pipelines Azure DevOps et du contrôle de code source Git. L’application fournit une interface simplifiée permettant aux fabricants d’exporter régulièrement les composants de leurs solutions Power Platform vers le contrôle de code source et de créer des demandes de déploiement pour que leur travail soit examiné avant de déployer dans des environnements cibles.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

En examinant le flux de travail ALM Accelerator, il commence par les environnements de développement. Leur interaction avec le processus ALM se fait via l’application ALM Accelerator Canvas App ou Managed Environment Pipelines

Les créateurs utilisent l’application ALM Accelerator Canvas pour leurs tâches ALM telles que l’importation de solutions à partir du contrôle de code source, l’exportation des modifications vers le contrôle de code source et la création d’une demande d’extraction pour fusionner les modifications

Les modèles ALM Accelerator pour les pipelines Azure DevOps facilitent l’automatisation des tâches ALM en fonction de l’interaction des créateurs avec l’application ALM Accelerator Canvas

ALM Accelerator inclut des modèles de pipeline pour prendre en charge un déploiement en 3 étapes en production.
Les modèles peuvent être personnalisés pour répondre à des besoins et des scénarios spécifiques

ALM Accelerator for Power Platform est une application canevas qui repose sur Azure DevOps Pipelines pour fournir une interface simplifiée permettant aux créateurs de valider et de créer régulièrement des demandes d’extraction pour leur travail de développement dans Power Platform. 

La combinaison des pipelines Azure DevOps et de l’application Canvas constitue la solution complète d’ALM Accelerator for Power Platform. 
Les pipelines et l’application sont des implémentations de référence. Ils ont été développés pour être utilisés par l’équipe de développement du kit de démarrage CoE en interne, mais ont été open source et publiés afin de démontrer comment une ALM saine peut être obtenue dans la Power Platform. Ils peuvent être utilisés tels quels ou personnalisés pour des scénarios d’entreprise spécifiques.

{{</slide>}}
