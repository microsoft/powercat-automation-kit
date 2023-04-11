---
title: "Gestion du cycle de vie des applications Power CAT (ALM)"
description: "Kit d’automatisation - ALM Power CAT"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['ALM', 'Guidance', 'PowerCAT']
generated: 9EBA5424FE312098C68ECEF453107114F7F5EB5C
---

{{<slideStyles>}}

<div class="optional">

Le kit d’automatisation tire parti de la [Accélérateur ALM](https://aka.ms/aa4pp) pour fournir la fonctionnalité ALM pour les solutions qui incluent Power Automate Desktop

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## Processus de déploiement GitHub

Semblable au processus de publication utilisé pour d’autres kits gérés par Power CAT, le {{<product-name>}} utilise ALM Accelerator pour déployer des versions sur nos versions GitHub publiques.

Notre processus interne dispose d’un environnement Power Platform pour le développement, les tests et la production. Une fois que nous sommes prêts pour une version, nos actions GitHub intégrées empaquetent automatiquement les solutions de déploiement gérées et non gérées ainsi que les notes de version pour une version GitHub Draft.

Une fois que le brouillon est prêt, nous pouvons publier de nouvelles versions ou correctifs si nécessaire.

### Ce que cela signifie pour vous

Maintenant que nous avons mis en place cette automatisation, la version ALM automatisée présente les avantages suivants pour vous :

- Visibilité sur tout le code source à faible code qui compose le kit d’automatisation afin que vous puissiez étudier comment nous avons construit le kit.

- Processus d’automatisation rationalisé qui peut répondre rapidement aux bogues ou aux problèmes et fournir des correctifs si nécessaire.

- Compilation automatisée de tous les bogues et fonctionnalités inclus dans une version.

- Nous incluons Power Apps, Power Automate, Dataverse et Power Automate Desktop dans le cadre de notre processus ALM pour notre intégration continue / déploiement continu.

## Feuille de route

Vous pouvez consulter les éléments de notre arriéré ALM ouvert dans notre [Registre des problèmes GitHub](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

Dans l’ensemble, nous nous appuyons sur les fonctionnalités existantes du produit Power Platform et Microsoft DevOps pour combiner ALM Accelerator. Cette combinaison nous permet de nous concentrer sur des extensions spécifiques qui aident à l’hyperautomtion.

## Rétroaction

{{<questions name="/content/fr/features/alm/powercat.json" completed="Merci de nous avoir fait part de vos commentaires" showNavigationButtons="false" locale="fr">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

L’équipe Power CAT utilise l’accélérateur ALM pour créer et déployer chacun de nos [Versions](https://github.com/microsoft/powercat-automation-kit/releases).

Chaque version favorise les changements de notre développement dans les environnements de test et de production. Les solutions Power Platform contenues dans le kit utilisent un processus automatisé pour empaqueter les ressources à déployer dans des versions publiques de GitHub.

Dans les prochaines étapes, nous développerons la plate-forme existante [Caractéristiques ALM](/fr/features/alm) fournir des exemples d’inclusion de règles de validation et de comparaison visuelle d’échantillons RPA dans le cadre du processus DevOps.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

Voici les étapes clés du processus de publication du Kit d’automatisation :

1. Les modifications apportées à notre environnement Power Platform Dev sont enregistrées dans une branche du référentiel GitHub public

2. Lorsque les modifications sont prêtes à être incluses dans une version de test, elles sont fusionnées dans la branche principale à l’aide d’une demande d’extraction. Avant que la demande d’extraction puisse être terminée, le pipeline de validation Azure DevOps doit être terminé avec succès et la demande d’extraction doit être examinée.

3. Une fois que la demande d’extraction a passé les contrôles automatisés et reçu l’approbation de la révision, elle peut être fusionnée dans la branche principale. Cette fusion déclenche le pipeline de génération Azure DevOps de test qui publie la build managée dans l’environnement de Power Platform de test.

4. Après des tests internes, le pipeline de production Azure DevOps est déclenché manuellement pour générer un déploiement de Power Platform de production.

5. Une fois que la version est prête, le pipeline Azure DevOps de version crée un brouillon de version comprenant des notes de publication et des ressources de génération. La version finale fermera tous les problèmes ouverts et clôturera le jalon. Balise de build publiée dans le référentiel GitHub avec une étiquette Mois et année appliquée.

{{</slide>}}
