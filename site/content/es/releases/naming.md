---
title: "Nombramiento"
description: "Kit de automatización - Nomenclatura"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Releases', 'Guidance']
generated: 8E15314207C3D6B5AF4E7C6B20C26F8A788C66C1
---

Junto con los números de mes y versión, el {{<product-name>}} utiliza una etiqueta de nombre de código en cada versión.

## Proceso de generación

1. Instalar dependencias de nodo

```bash
npm install @criblinc/docker-names
```

1. Agregue el siguiente ejemplo de nodo como archivo denominado index.mjs

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. Ejecutar el ejemplo

```bash
node index.mjs
```
