---
title: "Naamgeving"
description: "Automatiseringskit - Naamgeving"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Releases', 'Guidance']
generated: 8E15314207C3D6B5AF4E7C6B20C26F8A788C66C1
---

Naast de maand- en versienummers de {{<product-name>}} gebruikt elke release een codenaamtag.

## Generatieproces

1. Knooppuntafhankelijkheden installeren

```bash
npm install @criblinc/docker-names
```

1. Het volgende knooppuntvoorbeeld toevoegen als bestand met de naam index.mjs

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. Het voorbeeld uitvoeren

```bash
node index.mjs
```
