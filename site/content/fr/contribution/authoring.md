---
title: Instructions de création
description: Instructions de création de documentation du Kit d’automatisation
sidebar: false
sidebarlogo: fresh-white
include_footer: true

---
Les sections suivantes présentent des instructions et des notes pour la création de documentation de démarrage.

{{<toc>}}

## Lignes directrices

Les sections suivantes décrivent les directives techniques, de conception et axées sur les résultats pour la rédaction de contributions

## Buts

Lorsque nous construisons notre documentation, il est important de réfléchir à la façon dont nous permettons à nos lecteurs de **Tomber dans le gouffre du succès**.

Brad Abrams défini [Le gouffre du succès en 2003](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) comme

> La fosse du succès : en contraste frappant avec un sommet, un pic ou un voyage à travers un désert pour trouver la victoire à travers de nombreuses épreuves
> et surprises, nous voulons que nos clients tombent simplement dans des pratiques gagnantes
> en utilisant notre plateforme et nos frameworks. Dans la mesure où nous facilitons les ennuis, nous échouons.

Compte tenu de cet objectif, envisagez ce qui suit :

- Offrez une expérience « sans falaises »

  - Aidez les administrateurs et les équipes de gouvernance centrale à créer un modèle en libre-service d’utilisation de {{<product-name>}}

  - Permettre aux utilisateurs d’utiliser des environnements de développement pour mettre la main sur si un environnement central n’est pas disponible et qu’ils souhaitent utiliser des fonctionnalités avant un déploiement de test ou de production du {{<product-name>}}

  - Discutez de l’utilisation des environnements d’essai avec une configuration facile pour vous familiariser avec le {{<product-name>}}

- Fournir un canal de rétroaction. Donner des options aux clients pour donner leur avis sur ce que nous pouvons améliorer

### Contrôle de code source

- Vous avez terminé [Documentation](/fr/contribution/documentation) étapes pour télécharger et transmettre les modifications au référentiel GitHub
- Les nouvelles modifications sont transmises à une nouvelle branche et disposent d’une demande d’extraction pour examiner les modifications
- Toute la documentation doit être démarquée, JSon ou statique qui peut être des contrôles de version et révisée à l’aide d’un processus de demande d’extraction standard.

## Directives de conception

### Page d’accueil

- Avoir un titre et un sous-titre clairs qui décrivent l’objectif de l’expérience de démarrage
- Fournir un appel à l’action pour inclure d’autres événements connexes. Par exemple, inscrivez-vous aux heures de bureau.
- Lien vers l’action de mise en route en tant qu’action principale pour aider les nouveaux utilisateurs à intégrer
- Action secondaire pour joindre les heures de bureau afin d’aider à créer une communauté d’utilisateurs
- Inclure des vignettes d’actions communes
- Liste récapitulative des fonctionnalités qui aident les utilisateurs à gérer les projets d’hyperautomatisation
- Navigation en pied de page pour les liens communs.

Lisez le [Site Configuration](/fr/contribution/site-configuration) pour plus d’informations sur la configuration de la page d’accueil.

### Réutiliser

- Utilisez les mises en page hugo pour pouvoir spécifier un nouveau thème ou remplacer le thème actuel en plaçant du contenu dans le dossier site\layouts
- La modification des mises en page devrait permettre d’inclure du HTML statique dans de nombreux emplacements d’hébergement. Par exemple

  - GitHub Pages
  - Pages d’alimentation
  - Point de partage
  - Sites web statiques Azure

- L’approche peut être utilisée comme modèle par les partenaires ou les clients pour créer des « packs de documentation » afin d’accélérer la phase de nuture de {{<product-name>}} documentation
- Fournir la possibilité à plusieurs utilisateurs de la documentation (par exemple, les équipes du Centre d’excellence des clients et des partenaires)
- Autoriser l’inclusion du contenu fourni par l’utilisateur
- Autoriser le processus de mise à niveau qui permet d’extraire de nouvelles modifications de {{<product-name>}} Documentation de démarrage

## Markdown Pages

- Vous pouvez utiliser [Visual Studio Code](https://code.visualstudio.com/) Pour modifier les fichiers Markdown

- Les fichiers Markdown doivent se trouver dans le dossier /site/content

- Chaque fichier de démarque doit inclure un en-tête commun sur chaque page

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- Les fichiers Markdown doivent utiliser des codes courts pour intégrer n’importe quel JavaScript

## Codes courts

Les codes courts permettent d’inclure du contenu dynamique dans une page de démarque. Vous pouvez en savoir plus sur les shortcodes à partir du [Documentation du shortcode Hugo](https://gohugo.io/content-management/shortcodes/)

Ce projet comprend également des codes courts supplémentaires

### Table des matières

Ajoutez le **Toc** Suivre le shortcode de votre Markdown pour inclure une table des matières des en-têtes Markdown dans la page entourée de \{\{ et \}\}

```html
<toc/>
```

### Question

Incluez un ensemble de questions dans votre page entourée de \{\{ et \}\}

```html
<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

Paramètres:

- **nom** Nom du fichier JSon qui inclut les questions à importer. Lire [Questionne](/fr/contribution/questions) Pour plus d’informations sur le format de fichier QUESTION
- **terminé** Le texte à afficher lorsque les questions sont remplies
- **showNavigationButtons** Valeur true/false pour chausser les boutons de navigation Suivant/Retour/Terminé

### Image externe

Inclure une image de taille provenant d’une source externe dans votre page entourée de \{\{ et \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

Paramètres:

- **Le** Le chemin source de l’image à importer
- **taille** Taille en pixels à redimensionner l’image source
- **SMS** Texte alternatif à inclure avec l’image

## Notes

### Configuration des pages GitHub

Les étapes suivantes ont été utilisées pour configurer les pages GitHub pour le site

1. Création d’une nouvelle branche orpheline dans git

    ```bash
    git checkout --orphan gh-pages
    ```

1. Effacer le contenu existant (fichiers et dossiers)

    ```bash
    git clean -d -f
    ```

1. Hugo est installé

    - Vous pouvez également installer avec chocolaté sur les fenêtres
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. Sortie Hugo configurée pour sortir dans le dossier /docs

1. Testez vos modifications

    ```bash
    hugo serve
    ```

1. Pour créer le site html statique à l’intérieur du dossier du site, exécutez la commande suivante

    ```bash  
    hugo
    ```
 
1. Poussez votre branche gh-pages vers GitHub

1. Configurer le projet GitHub pour activer Pages

    - Consultez Configuration d’une source de publication pour votre site GitHub Pages - GitHub Docs
    - Sélection de la branche gh-pages et du dossier /docs

### Mettre à jour le badge d’image de la page d’accueil

Pour personnaliser l’image de la page d’accueil en fonction d’un badge État : Aperçu public, procédez comme suit :

1. Cloner le référentiel svg-badges

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. Installer des modules

    ```bash
    npm install
    ```

1. Démarrer le serveur Web pour générer des badges

    ```bash
    npm run start
    ```

1. Générer un badge

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. Télécharger le badge svg

1. Utiliser inkscape pour éditer des svg existants et enregistrer les résultats

1. Télécharger une nouvelle image dans le dossier static\images\illustrations

1. Modifier l’image du héros config.yaml

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## Questions et réponses

### **Question** Pourquoi Hugo a-t-il été choisi ?

[Hugo](https://gohugo.io/) est un générateur de site statique populaire qui permet le contenu de {{<product-name>}} documentation de démarrage à transformer en HTML statique pouvant être hébergé dans GitHub Pages

### **Question** Pourquoi n’avez-vous pas choisi un autre générateur de site statique ?

L’équipe principale de Power CAT avait déjà utilisé Hugo

### **Question** Pourquoi Microsoft Forms n’a-t-il pas été utilisé pour les questions ?

L’un des objectifs de conception était d’intégrer le processus de questions directement dans le contenu.

### **Question** Pourquoi des pages GitHub pour héberger du contenu ?

Le code source de {{<product-name>}} existe déjà sur GitHub et la prise en charge des pages GitHub natives était un choix d’emplacement pour héberger le contenu.

### **Question** Pourquoi ce contenu n’est-il pas activé [http://learn.microsoft.com]()?

- Au fur et à mesure que le contenu évolue vers des conseils couramment réutilisables, il peut migrer vers [https://learn.microsoft.com]()

- Un objectif de conception clé est rendu possible par l’hébergement GitHub

   - Permettre une contribution active de la communauté
   
   - Favoriser le processus Nuture du Centre d’Excellence afin que la documentation puisse être réutilisée par les Clients et la communauté des Partenaires

### **Question** Pourquoi l’approche n’est-elle pas appliquée à d’autres projets Power CAT ?

Le {{<product-name>}} expérimente ce canal de documentation pour compléter et lier à notre [Contenu d’apprentissage](https://aka.ms/automation-kit-learn). Sur la base des commentaires et des résultats de cette expérience, nous évaluerons si d’autres projets gérés par Power CAT adopteront une approche similaire.

### **Question** Comment puis-je voir les problèmes de documentation ouverte ?

Vous pouvez visiter notre [Problèmes liés à la documentation ouverte](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) page

### **Question** Comment puis-je déclencher une nouvelle demande de fonctionnalité de documentation ?

Créer un nouveau [Demande de fonctionnalité](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
