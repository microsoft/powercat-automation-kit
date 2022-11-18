---
title: "Benennung"
description: "Automation Kit - Namensgebung"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Releases', 'Guidance']
generated: 8E15314207C3D6B5AF4E7C6B20C26F8A788C66C1
---

Neben den Monats- und Versionsnummern wird {{<product-name>}} verwendet bei jeder Version ein Codenamen-Tag.

## Generierungsprozess

1. Installieren von Knotenabhängigkeiten

```bash
npm install @criblinc/docker-names
```

1. Fügen Sie das folgende Knotenbeispiel als Datei mit dem Namen index.mjs hinzu

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. Ausführen des Beispiels

```bash
node index.mjs
```
