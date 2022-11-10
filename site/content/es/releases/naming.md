---
title: Nombramiento
description: Kit de automatización - Nomenclatura
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9795E07C61E6C47431EB334171CBB72D03B773EF
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
