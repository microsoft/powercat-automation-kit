---
title: "Namnge"
description: "Automation Kit - Namngivning"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9795E07C61E6C47431EB334171CBB72D03B773EF
---

Vid sidan av månaden och versionsnumren {{<product-name>}} använder en kodnamnstagg varje version.

## Generering Process

1. Installera nodberoenden

```bash
npm install @criblinc/docker-names
```

1. Lägg till följande nodexempel som fil med namnet index.mjs

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. Kör exemplet

```bash
node index.mjs
```