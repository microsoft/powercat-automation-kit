---
title: "ชุดข้อมูล"
description: "ชุดระบบอัตโนมัติ - ชุดข้อมูล"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Data', 'Integration']
generated: 5695D0411A1BD909454FF04F1BDDAA7D64578032
---

{{<toc>}}

## แนะ นำ

ชุดข้อมูลคือชุดข้อมูลที่บรรจุไว้ล่วงหน้าซึ่งสามารถติดตั้งลงใน Automation Kit ที่ติดตั้งไว้เพื่อเร่งการใช้งานของคุณ

{{<border>}}
![ภาพรวมของชุดข้อมูล](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

แนะนําเป็นส่วนหนึ่งของ [พฤศจิกายน 2022](/th/releases/november-2022)Datapacks ช่วยให้คุณสามารถเลือกนําเข้าข้อมูลตัวอย่างได้

ชุดข้อมูลผลตอบแทนจากการลงทุน (ROI) ช่วยให้คุณสามารถแสดงให้เห็นถึงการวางแผนการวัดแสงและการตรวจสอบผลตอบแทนจากการลงทุนอย่างรวดเร็วผ่านแดชบอร์ด Power BI ของ Automation Kit คุณสามารถโหลดชุดข้อมูลแรกของคุณโดยใช้ปุ่ม [เริ่มต้นใช้งาน](/th#getting-started) ส่วนด้านล่าง

การทํางานล่วงเวลาเราจะเพิ่มชุดข้อมูลอื่น ๆ ลงในงานในมือเพื่อจัดลําดับความสําคัญและจัดทําเอกสารวิธีที่คุณสามารถทํางานร่วมกันในการเผยแพร่ชุดข้อมูลไปยังชุมชน

## แผนงาน

{{<border>}}
![แผนงานชุดข้อมูล](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

ในเหตุการณ์สําคัญในอนาคตเราจะพยายามปรับปรุง datapacks โดยการรวมไว้เป็นส่วนหนึ่งของกระบวนการติดตั้งอัตโนมัติของ Automation Kit

ความสามารถในการรวม Data Packs เป็นส่วนหนึ่งของการติดตั้งจะช่วยให้สามารถติดตั้งบนเว็บแทนกระบวนการติดตั้งบรรทัดคําสั่งสําหรับรุ่นนี้

## ผลตอบแทนจากการลงทุน ทางออกหลัก

ชุดข้อมูลโซลูชันหลัก Return on Investment (ROI) ประกอบด้วยโครงการระบบอัตโนมัติ เครื่องจักร และตัวอย่างการวัดและส่งข้อมูลทางไกลของ Power Automate Desktop เพื่อให้คุณสามารถรับมือกับกระบวนการตั้งแต่ต้นจนจบ

### เริ่มต้นใช้งาน

เมื่อต้องการเริ่มต้นใช้งานชุดข้อมูลนี้

- ติดตั้งชุดครีเอเตอร์จาก [แหล่งที่มาของแอป](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) หรือผ่านทาง [เรียนรู้คู่มือการตั้งค่า](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- ติดตั้งเวอร์ชันล่าสุดของ Automation Kit Main จาก [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) ใช้ [เรียนรู้คู่มือการตั้งค่า](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- ติดตั้ง Power Platform Command Line Interface โดยใช้ [เรียนรู้คู่มือการตั้งค่า](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- สร้างการรับรองความถูกต้องกับสภาพแวดล้อมของคุณ

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- ดาวน์โหลด **ชุดระบบอัตโนมัติ.zip** จาก [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- แตกไฟล์ **ระบบอัตโนมัติชุด-ตัวอย่างข้อมูล.zip** จาก **ชุดระบบอัตโนมัติ.zip**

- นําเข้าข้อมูลไปยังสภาพแวดล้อมของคุณ

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- เชื่อมต่อแดชบอร์ด Power BI ที่ดาวน์โหลดจากสภาพแวดล้อมของคุณเพื่อสํารวจข้อมูลที่นําเข้า ใช้ [ติดตั้งแดชบอร์ด Power BI](/th/get-started/install-powerbi-dashboard) สําหรับข้อมูลเพิ่มเติม

## การตอบสนอง

{{<questions name="/content/th/features/datapacks.json" completed="ขอขอบคุณที่ให้ข้อเสนอแนะ" showNavigationButtons="false" locale="th">}}
