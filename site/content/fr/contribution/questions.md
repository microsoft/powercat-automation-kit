---
title: "Questions de création"
description: "Kit d’automatisation - Questions de création"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 37D5A5E89FA4987CACF047AC5907F94874C4EA89
---

Cette page contient des informations sur le format utilisé pour créer des questions interactives incluses dans le {{<product-name>}} démarreur.

{{<toc>}}

## Commencer

Les questions utilisées dans les pages de démarrage du kit sont basées sur [Bibliothèque JS Open Source Survey](https://github.com/surveyjs/survey-library). L’utilisation de cette bibliothèque permet d’utiliser tous les contrôles prêts à l’emploi pris en charge.

Pour comprendre le cadre, vous pouvez consulter

- Le [Enquête JS Docs](https://surveyjs.io/form-library/documentation/overview)

- Types de questions simples comme [SMS](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [Groupes de radio](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [Case à cocher](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) ou [Classement](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- Utilisation de la visibilité conditionnelle [visibleSi](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- Passez en revue certaines des questions existantes qui sont utilisées dans le site. Par exemple, l' [Questions de surveillance](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- Découvrez comment inclure le code court dans votre démarque de contenu. Par exemple [Surveillance de la démarque](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## Intégration de questions dans votre contenu

Pour intégrer un ensemble de questions dans votre page, vous pouvez ajouter ce qui suit à votre démarque et changer le nom du fichier de questions que vous souhaitez lire

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

Le {{<product-name>}} inclut également des fonctions supplémentaires que vous pouvez utiliser à l’intérieur des expressions.

### Len

La fonction len renvoie la longueur d’une chaîne ou d’un tableau

#### Exemple len

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### Contient

La fonction contains renvoie true ou false si la chaîne ou le tableau de chaînes correspond à la valeur fournie

#### contient un exemple

Rendra l’élément visible si l’un des rôles sélectionnés est créateur

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

Rendra l’élément visible si l’un des rôles sélectionnés est créateur ou architecte

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## Widgets personnalisés

### Tâche d’image

Le {{<product-name>}} inclut également le **tâche_image** widget personnalisé. Ce widget peut être inclus dans vos éléments de question à l’aide de l’extrait json suivant.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### Propriétés

- **titre** - Le texte à afficher à l’utilisateur
- **type** - Doit être image-tâche
- **Le** - L’url du fichier SVG à rendre

#### Comment ça marche

Le fichier svg source prend en charge les liens hypertexte personnalisés suivants pour les éléments de votre fichier svg

- **template://item/selected** - Définira le format de l’objet pour définir le format sélectionné dans l’image
- **template://item/unselected** - Définira le format de l’objet pour définir le format non sélectionné des éléments de l’image
- **question://question-name/value** - Définira le format de l’objet pour définir le format non sélectionné des éléments de l’image

Des éléments visuels avec un lien hypertexte de question:// seront utilisés pour définir ou annuler le tableau de valeurs à l’intérieur de l’ensemble de questions. Cette capacité offre la possibilité de modifier de manière interactive la façon dont les autres questions sont affichées à l’utilisateur. Par exemple, si le fichier svg comportait deux objets avec les liens hypertexte suivants :

- **question://roles/maker**
- **question://roles/architect**

Si l’utilisateur sélectionne ces objets, d’autres éléments de la page peuvent être affichés, par exemple

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

## Questions et réponses

### **Question** Pourquoi cette approche a-t-elle été utilisée plutôt que Microsoft Forms ?

L’utilisation du shortcode des questions permet aux questions de faire partie de chaque page de contenu plutôt que d’un lien séparé.

### **Question** Quels sont les avantages de cette approche?

Les avantages suivants de cette approche sont les suivants :

- La possibilité d’utiliser des types de questions prêts à l’emploi

- La création de questions est basée sur la configuration et ne nécessite que la connaissance de JSon pour créer des questions

- Le cadre de questions est extensible permettant d’ajouter de nouvelles fonctions ou widgets

- L’utilisation de JSon pour les définitions de questions permet de stocker les questions dans le contrôle de code source, puis de les réviser et de les versionner au fil du temps.

### **Question** Cette approche pourrait-elle être utilisée dans une Power App ou une Power Page ?

Absolument, les mêmes définitions JavaScript et de questions pourraient être utilisées en créant un [Composant de code](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **Question** Comment puis-je créer les questions de tâche d’image SVG ?

Une option pour créer les fichiers svg est [Microsoft Visio](https://www.microsoft.com/microsoft-365/visio/) qui exporte des diagrammes vers un fichier SVG avec les liens hypertexte requis et compatible avec **tâche_image** questionne.

### **Question** Puis-je utiliser Microsoft PowerPoint pour exporter des fichiers SVG de questions de tâche d’image ?

Bien que Microsoft Power Point puisse exporter une diapositive vers une chaussure de test initiale de fichier SVG, il n’exporte pas les liens hypertexte requis pour créer un fichier interactif **tâche_image** Travaillez avec succès.

### **Question** Mes fichiers SVG exportés sont volumineux, puis-je les réduire ?

Une option pour les fichiers SVG pour les réduire avant de les valider dans le contrôle de code source. Il existe plusieurs outils qui peuvent être utilisés pour réduire la taille d’un SVG, une option à considérer est [SVGO](https://github.com/svg/svgo) un optimiseur SVG basé sur NodeJs.
