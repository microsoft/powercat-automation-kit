---
title: "命名"
description: "自動化キット - ネーミング"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Releases', 'Guidance']
generated: 8E15314207C3D6B5AF4E7C6B20C26F8A788C66C1
---

月とバージョン番号の横に{{<product-name>}} は、リリースごとにコード名タグを使用します。

## 生成プロセス

1.ノードの依存関係のインストール

```bash
npm install @criblinc/docker-names
```

1.次のノードサンプルをindex.mjsという名前のファイルとして追加します

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1.サンプルを実行する

```bash
node index.mjs
```
