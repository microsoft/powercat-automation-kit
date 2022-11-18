---
title: "Packs de données"
description: "Kit d’automatisation - Packs de données"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Data', 'Integration']
generated: 5695D0411A1BD909454FF04F1BDDAA7D64578032
---

{{<toc>}}

## Introduction

Les packs de données sont un ensemble de données préemballées qui peuvent être installées en option dans votre kit d’automatisation installé pour accélérer votre utilisation.

{{<border>}}
![Vue d’ensemble des packs de données](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

Introduit dans le cadre de l' [Novembre 2022](/fr/releases/november-2022), Datapacks vous permet d’importer éventuellement des exemples de données.

Le pack de données Retour sur investissement (ROI) vous permet de démontrer rapidement la planification, le comptage et le suivi du retour sur investissement via le tableau de bord Power BI du kit d’automatisation. Vous pouvez charger votre premier pack de données à l’aide de l’icône [Commencer](/fr#getting-started) ci-dessous.

Au fil du temps, nous ajouterons d’autres packs de données au backlog pour la hiérarchisation des priorités et documenterons comment vous pouvez collaborer à la publication de packs de données dans la communauté.

## Feuille de route

{{<border>}}
![Feuille de route des packs de données](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

Dans les prochaines étapes, nous chercherons à améliorer les packs de données en les incluant en tant que partie facultative du processus d’installation automatisée du kit d’automatisation.

La possibilité d’inclure des packs de données dans le cadre de l’installation permettra une installation basée sur le Web, plutôt que le processus d’installation en ligne de commande pour cette version.

## Solution principale de retour sur investissement

Le pack de données principal de la solution de retour sur investissement (ROI) comprend des projets d’automatisation, des machines et des exemples de télémétrie Power Automate Desktop afin que vous puissiez vous familiariser avec le processus de bout en bout.

### Commencer

Pour commencer à utiliser ce pack de données

- Installez le Creator Kit à partir de [Source de l’application](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) ou via [Guide d’installation](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Installez la dernière version d’Automation Kit Main à partir de [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) Utilisant [Guide d’installation](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Installez Power Platform interface de ligne de commande à l’aide de [Guide d’installation](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Créer une authentification dans votre environnement

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Téléchargez le **AutomationKit.zip** De [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Extraire le fichier **AutomationKit-SampleData.zip** De **AutomationKit.zip**

- Importer les données dans votre environnement

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- Connectez le tableau de bord Power BI téléchargé à partir de avec votre environnement pour explorer les données importées. Utiliser [Installer le tableau de bord Power BI](/fr/get-started/install-powerbi-dashboard) Pour plus d’informations

## Rétroaction

{{<questions name="/content/fr/features/datapacks.json" completed="Merci de nous avoir fait part de vos commentaires" showNavigationButtons="false" locale="fr">}}
