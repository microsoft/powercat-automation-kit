---
title: Naamgeving
description: Automatiseringskit - Naamgeving
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9795E07C61E6C47431EB334171CBB72D03B773EF
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
