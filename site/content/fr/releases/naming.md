---
title: "Nommage"
description: "Kit d’automatisation - Dénomination"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Releases', 'Guidance']
generated: 8E15314207C3D6B5AF4E7C6B20C26F8A788C66C1
---

À côté des numéros de mois et de version, le {{<product-name>}} utilise une balise de nom de code pour chaque version.

## Processus de génération

1. Installer les dépendances de nœud

```bash
npm install @criblinc/docker-names
```

1. Ajouter l’exemple de nœud suivant en tant que fichier nommé index.mjs

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. Exécuter l’exemple

```bash
node index.mjs
```
