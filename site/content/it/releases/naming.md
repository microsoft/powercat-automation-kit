---
title: Denominazione
description: Kit di automazione - Denominazione
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9795E07C61E6C47431EB334171CBB72D03B773EF
---

Accanto ai numeri di mese e di versione il {{<product-name>}} utilizza un tag code name ogni versione.

## Processo di generazione

1. Installare le dipendenze dei nodi

```bash
npm install @criblinc/docker-names
```

1. Aggiungere il seguente esempio di nodo come file denominato index.mjs

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. Eseguire l'esempio

```bash
node index.mjs
```
