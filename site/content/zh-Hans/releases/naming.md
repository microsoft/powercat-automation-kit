---
title: 命名
description: 自动化套件 - 命名
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---
除了月份和版本号外，{{<product-name>}} 在每个版本使用代号标记。

## 生成过程

1.安装节点依赖项

```bash
npm install @criblinc/docker-names
```

1.将以下节点示例添加为名为 index.mjs 的文件

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1.运行示例

```bash
node index.mjs
```
