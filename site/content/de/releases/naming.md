---
title: Benennung
description: Automation Kit - Namensgebung
sidebar: false
sidebarlogo: fresh-white
include_footer: true
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
