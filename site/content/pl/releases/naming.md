---
title: Nazewnictwa
description: Automation Kit - Nazewnictwo
sidebar: false
sidebarlogo: fresh-white
include_footer: true
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
