---
title: "Satellite - Premiers pas"
description: "Kit d’automatisation - Satellite - Démarrer"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: 6883D16022FA80683F6DFF779929B1FC8B73E83F
---

# Aperçu

Bienvenue sur la page de démarrage de la solution Satellite. Cette section couvre les modifications importantes apportées en avril 2023 et les versions ultérieures. Après avril 2023, nous avons supprimé la nécessité pour Azure Key Vault de stocker les informations secrètes du locataire d’application Azure, de l’ID d’application et de l’application Azure.

## Conception

Notre page d’apprentissage décrit le [Conception](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) du {{<product-name>}}. L’élément clé de la solution est l’environnement principal Power Platform.

Il existe généralement plusieurs environnements de production de satellites qui exécutent vos projets d’automatisation. Selon votre stratégie d’environnement, il peut également s’agir d’environnements de développement ou de test.

Entre ces environnements, il existe un processus de synchronisation en temps quasi réel qui inclut la télémétrie de flux cloud ou de bureau, l’utilisation de machines et de groupes de machines et les journaux d’audit. Le tableau de bord Power BI pour le Kit d’automatisation affiche ces informations.

## Ce qui a changé

Dans le cadre de la résolution [[Kit d’automatisation - Fonctionnalité] : alternative Azure Key Vault pour les environnements satellites](https://github.com/microsoft/powercat-automation-kit/issues/84) Azure Key Vault n’est plus nécessaire. Ceci est important car cela réduit considérablement la complexité de l’installation et la façon dont la sécurité est gérée pour obtenir des artefacts de solution lors de l’utilisation d’Automation Solution Manager.

## Qu’est-ce qui est la même chose?

Une fois que les éléments clés sont les mêmes, les anciennes versions antérieures à avril 2023 et avril 2023 nécessitent une application Azure Active Directory.

Un [utilisateur de l’application](https://learn.microsoft.com/power-platform/admin/manage-application-users) est un type d’utilisateur dans le Power Platform identifié par la présence de l’attribut ApplicationId dans l’enregistrement d’utilisateur système. Les utilisateurs d’application sont créés dans Azure Active Directory (Azure AD) et sont utilisés pour authentifier et autoriser l’accès au Power Platform. Ils sont généralement utilisés pour représenter une application ou un service qui doit accéder aux données ou effectuer des opérations dans le Power Platform pour le compte d’utilisateurs ou d’autres applications.

Plus précisément, l’utilisateur d’application est utilisé par Automation Solution Manager pour vous permettre d’interroger les composants de solution dans un environnement afin que vous puissiez permettre à un utilisateur de mesurer une solution Power Platform déployée.

## Installer

Le [Installation par ligne de commande](/fr/get-started/install) pour les solutions satellites vous demandera le nom de l’application Azure Active Directory et l’ID d’application Azure Active Directory. À l’aide de ces informations, il :

1. Ajouter l’application Azure Active Directory en tant qu’utilisateur d’application
1. Ajouter l’utilisateur de l’application au rôle d’administrateur système
1. Ajouter l’ID utilisateur de l’utilisateur de l’application à la variable d’environnement **ID utilisateur lu par les artefacts de Solution Manager**

Le nouveau rôle dataverse **Utilisateur d’Automation Solution Manager** a été ajouté qui permet aux utilisateurs d’appeler la nouvelle API personnalisée Dataverse GetDataverseSolutionArtifacts qui interrogera les artefacts de solution à l’aide de la variable d’environnement fournie **ID utilisateur lu par les artefacts de Solution Manager**.

Si vous souhaitez installer la solution satelitte manuellement, les modifications suivantes doivent être apportées au [Configurer des satellites](https://learn.microsoft.com/en-us/power-automate/guidance/automation-kit/setup/satellite) instructions.

1. Ignorez l’étape « Ajouter une nouvelle clé secrète client » car elle n’est plus nécessaire pour avril 2023 ou plus récent.
1. Ignorez l’étape de création de secrets dans Azure Key Vault.
1. Ajoutez l’ID utilisateur de l’utilisateur de l’application au **ID utilisateur lu par les artefacts de Solution Manager** variable d’environnement.

## Après l’installation

Assurez-vous que le ou les utilisateurs qui exécuteront l’application Automation Solution Manager bénéficient de l' **Utilisateur d’Automation Solution Manager** Rôle de sécurité Dataverse.

## Versions précédentes

Avant la publication d’avril 2023, les installations de la solution Satellite nécessitaient des variables d’environnement de type secret. Cela nécessitait un [Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) pour stocker les valeurs de l’ID du client, de l’ID d’application et du secret d’application. Pour utiliser cette fonctionnalité, il fallait également que le [Conditions préalables](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/environmentvariables#prerequisites) du coffre de clés Azure étant le même locataire, configuration de Microsoft.PowerPlatform en tant que fournisseur de ressources.

Dans les versions de mars 2023 ou antérieures, Azure Key Vault était utilisé pour stocker un ID de locataire, un ID d’application et un secret d’application. À l’aide de ces valeurs, un jeton d’accès a été demandé pour interroger dataverse afin qu’il puisse renvoyer la liste des composants de solution.

## Recommandations

Pour les utilisateurs existants, il est recommandé de simplifier la gestion continue et de supprimer la nécessité d’une dépendance d’Azure Key Vault que vous mettez à niveau l’installation satellite existante vers avril 2023 ou version ultérieure pour tirer parti des nouvelles fonctionnalités.
