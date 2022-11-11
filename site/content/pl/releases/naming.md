---
title: "Nazewnictwa"
description: "Automation Kit - Nazewnictwo"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9795E07C61E6C47431EB334171CBB72D03B773EF
---

Oprócz numeru miesiąca i wersji {{<product-name>}} używa znacznika nazwy kodowej w każdym wydaniu.

## Proces generowania

1. Instalowanie zależności węzłów

```bash
npm install @criblinc/docker-names
```

1. Dodaj następujący przykład węzła jako plik o nazwie index.mjs

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. Uruchamianie przykładu

```bash
node index.mjs
```
