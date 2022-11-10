---
title: Naming
description: Automation Kit - Naming
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9795E07C61E6C47431EB334171CBB72D03B773EF
---

Alongside the month and version numbers the {{<product-name>}} uses a code name tag each release.

## Generation Process

1. Install node dependencies

```bash
npm install @criblinc/docker-names
```

1. Add the following node sample as file named index.mjs

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. Run the sample

```bash
node index.mjs
```
