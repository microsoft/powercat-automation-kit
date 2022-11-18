---
title: "การตั้งชื่อ"
description: "ชุดระบบอัตโนมัติ - การตั้งชื่อ"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Releases', 'Guidance']
generated: 8E15314207C3D6B5AF4E7C6B20C26F8A788C66C1
---

ข้างเดือนและหมายเลขเวอร์ชัน {{<product-name>}} ใช้แท็กชื่อรหัสในแต่ละรุ่น

## กระบวนการสร้าง

1. ติดตั้งการขึ้นต่อกันของโหนด

```bash
npm install @criblinc/docker-names
```

1. เพิ่มตัวอย่างโหนต่อไปนี้เป็นแฟ้มชื่อ index.mjs

```nodejs
import {generateName} from '@criblinc/docker-names'

const dockerName = generateName();

console.log(dockerName);
```

1. เรียกใช้ตัวอย่าง

```bash
node index.mjs
```
