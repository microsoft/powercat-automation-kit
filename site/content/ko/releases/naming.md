---
title: 명명
description: 자동화 키트 - 이름 지정
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 9795E07C61E6C47431EB334171CBB72D03B773EF
---

월 및 버전 번호와 함께 {{<product-name>}}는 각 릴리스마다 코드 이름 태그를 사용합니다.

## 생성 프로세스

1. 노드 종속성 설치

```bash
npm install @criblinc/docker-names
```

1. 다음 노드 샘플을 index.mjs 파일로 추가합니다.

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. 샘플 실행

```bash
node index.mjs
```
