---
title: Navngi
description: Automatiseringssett - Navngiving
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9795E07C61E6C47431EB334171CBB72D03B773EF
---

Ved siden av måneds- og versjonsnumrene er {{<product-name>}} bruker en kodenavnkode hver utgivelse.

## Generasjon prosess

1. Installere nodeavhengigheter

```bash
npm install @criblinc/docker-names
```

1. Legg til følgende nodeeksempel som fil med navnet index.mjs

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. Kjøre eksemplet

```bash
node index.mjs
```
