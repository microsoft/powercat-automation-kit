---
title: 命名
description: 自動化キット - ネーミング
sidebar: false
sidebarlogo: fresh-white
include_footer: true
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
