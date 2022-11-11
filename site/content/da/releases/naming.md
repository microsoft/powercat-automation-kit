---
title: "Navngivning"
description: "Automatiseringssæt - navngivning"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9795E07C61E6C47431EB334171CBB72D03B773EF
---

Ved siden af måneds- og versionsnumrene {{<product-name>}} bruger et kodenavnsmærke for hver udgivelse.

## Generering proces

1. Installer nodeafhængigheder

```bash
npm install @criblinc/docker-names
```

1. Tilføj følgende nodeeksempel som fil med navnet index.mjs

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. Køre eksemplet

```bash
node index.mjs
```
