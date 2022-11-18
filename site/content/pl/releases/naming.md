---
title: "Nazewnictwa"
description: "Automation Kit - Nazewnictwo"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Releases', 'Guidance']
generated: 8E15314207C3D6B5AF4E7C6B20C26F8A788C66C1
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
