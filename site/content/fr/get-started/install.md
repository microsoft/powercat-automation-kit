---
title: "Installation par ligne de commande"
description: "Kit d’automatisation - Installer"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 10CE5DBCADF4F09FCAA4261FD8FBEBDE34B6FB2E
---

Pour installer la dernière version du Kit d’automatisation à l’aide de la ligne de commande, vous pouvez suivre les étapes ci-dessous. Si vous ne parvenez pas à utiliser les outils de ligne de commande, vous pouvez utiliser les étapes manuelles décrites dans [Guide de configuration](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. Assurez-vous d’avoir <a ref='https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">Activer la fonctionnalité d’infrastructure des composants Power Apps</a> dans les environnements dans lesquels vous souhaitez installer le Kit d’automatisation pour les environnements principal et satellite.

1. S’assurer que l' <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">Creator Kit installé</a> dans les environnements dans lesquels vous souhaitez installer

1. Ouvrez la dernière version à partir du <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Versions du kit d’automatisation GitHub</a>

1. Téléchargez le **AutomationKitInstall.zip** à partir de la section Actifs

1. Dans l’Explorateur Windows, sélectionnez le bouton téléchargé **AutomationKitInstall.zip** et ouvrez la boîte de dialogue Propriétés

1. Sélectionnez l’icône **Débloquer** bouton

1. Choisir **AutomationKitInstall.zip** et utilisez le menu contextuel pour **Extraire tout**

1. Assurez-vous d’avoir le <a href="https://learn.microsoft.com/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> Installé

1. Exécutez le script PowerShell à l’aide de la ligne de commande suivante

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

NOTE:
1. Selon votre stratégie d’exécution PowerShell, vous devrez peut-être exécuter la commande suivante

```cmd
Unblock-File Install_AutomationKit.ps1
```

1. Le script PowerShell vous invite à créer un fichier de configuration d’installation à l’aide de [Installer le programme d’installation](/fr/get-started/setup). Les pages de configuration de configuration vous fourniront les éléments suivants :

    - Sélectionner la configuration pour les solutions principales ou satellites
   
    - Sélectionner les utilisateurs à affecter aux groupes de sécurité
   
    - Créer les connexions requises pour installer la solution
    
    - Définir des variables d’environnement
    
    - Définir éventuellement si les exemples de données doivent être importés
    
    - Activer éventuellement Power Automate Les flux contenus dans les solutions doivent être activés

1. Après avoir terminé les étapes de configuration du site Web, vous pouvez copier téléchargé **automation-kit-main-install.json** ou **automation-kit-satellite-install.json** au dossier **AutomationKitInstall** dossier ci-dessus

1. Une fois le fichier téléchargé, le script vous demandera **y** pour installer la solution principale, **n** Pour installer la solution satellite

1. L’installation téléchargera ensuite démarrer l’installation avec les paramètres définis

## Rétroaction

Vous souhaitez fournir des commentaires sur le [Processus d’installation](/fr/get-started/setup)? Les questions ci-dessous nous aident à améliorer le processus.

{{<questions name="/content/fr/get-started/setup-feedback.json" completed="Merci de nous avoir fait part de vos commentaires" showNavigationButtons="false" locale="fr">}}
