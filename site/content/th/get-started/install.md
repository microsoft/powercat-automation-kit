---
title: "ติดตั้ง"
description: "ชุดระบบอัตโนมัติ - ติดตั้ง"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 2251306D3FA73DEF67131846C92EDEB6BECC84B8
---

ในการติดตั้ง Automation Kit เวอร์ชันล่าสุดให้ใช้ขั้นตอนต่อไปนี้ด้านล่าง หากคุณไม่สามารถใช้เครื่องมือบรรทัดคําสั่งคุณสามารถใช้ขั้นตอนด้วยตนเองที่ระบุไว้ใน [คําแนะนําในการตั้งค่า](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. เปิดรุ่นล่าสุดจาก <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">การเผยแพร่ชุดระบบอัตโนมัติ GitHub</a>

1. ดาวน์โหลด **ชุดอัตโนมัติติดตั้ง.zip**

1. ในวินโดวส์เอ็กซ์พลอเรอร์ให้เลือกดาวน์โหลดมา **ชุดอัตโนมัติติดตั้ง.zip** และเปิดกล่องโต้ตอบคุณสมบัติ

1. เลือกปุ่ม **ปลด ล็อค** กระดุม

1. เลือก **ชุดอัตโนมัติติดตั้ง.zip** และใช้เมนูบริบทเพื่อ **แยกทั้งหมด**

1. ตรวจสอบให้แน่ใจว่าคุณมีปุ่ม <a href="https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> ติด ตั้ง

1. รันสคริปต์ powershell โดยใช้บรรทัดคําสั่งต่อไปนี้

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

หมายเหตุ: ขึ้นอยู่กับนโยบายการดําเนินการ PowerShell ของคุณคุณอาจต้องเรียกใช้คําสั่งต่อไปนี้

```cmd
powershell.exe -ExecutionPolicy Bypass -File Install_AutomationKit.ps1
```

1. สคริปต์ PowerShell จะพร้อมท์ให้คุณสร้างไฟล์การกําหนดค่าการติดตั้งโดยใช้ [ติดตั้งการตั้งค่า](/th/get-started/setup). หน้าการกําหนดค่าการตั้งค่าจะให้สิ่งต่อไปนี้แก่คุณ

    - เลือกการกําหนดค่าสําหรับโซลูชันหลักหรือดาวเทียม
   
    - เลือกผู้ใช้ที่จะกําหนดให้กับกลุ่มความปลอดภัย
   
    - สร้างการเชื่อมต่อที่จําเป็นในการติดตั้งโซลูชัน
    
    - กําหนดตัวแปรสภาพแวดล้อม
    
    - เลือกกําหนดว่าควรนําเข้าข้อมูลตัวอย่างหรือไม่
    
    - ควรเปิดใช้งานโฟลว์ Power Automate ที่มีอยู่ในโซลูชันหรือไม่

1. หลังจากที่คุณเสร็จสิ้นการคัดลอกการตั้งค่าการ **อัตโนมัติ- ชุดหลัก- install.json** หรือ **อัตโนมัติชุดดาวเทียมติดตั้ง.json** ไฟล์ไปยัง **ระบบอัตโนมัติKitติดตั้ง** โฟลเดอร์ด้านบน

1. เมื่อดาวน์โหลดไฟล์สคริปต์จะแจ้งให้ **y** เพื่อติดตั้งโซลูชันหลัก **n** เพื่อติดตั้งโซลูชันดาวเทียม

1. การติดตั้งจะอัปโหลดเริ่มต้นการติดตั้งด้วยการตั้งค่าที่กําหนด

## การตอบสนอง

ต้องการแสดงความคิดเห็นเกี่ยวกับ [ขั้นตอนการตั้งค่า](/th/get-started/setup)? คําถามด้านล่างช่วยให้เราปรับปรุงกระบวนการ

{{<questions name="/content/th/get-started/setup-feedback.json" completed="ขอขอบคุณที่ให้ข้อเสนอแนะ" showNavigationButtons=true locale="th">}}
