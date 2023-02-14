---
title: "กำหนดการ"
description: "ชุดระบบอัตโนมัติ - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B8DC4418FD2312850E01B5DB52344E2BB9B93C2F
---

{{<toc>}}

## แนะ นำ

Automation Kit Scheduler ช่วยให้สามารถดูกําหนดการของโฟลว์ระบบคลาวด์ Power Automate ที่เกิดซ้ําภายในโซลูชันที่มีการเรียกไปยังโฟลว์ Power Automate Desktop

คุณลักษณะนี้ได้รับการแนะนําให้เป็นส่วนหนึ่งของ [กุมภาพันธ์ 2023](/th/releases/february-2023)รุ่นต่อมาจะยังคงปรับปรุงและขยายฟังก์ชันการทํางานของตัวจัดกําหนดการ

{{<border>}}
![กำหนดการ](/images/schedule.png)
{{</border>}}

คุณสมบัติที่สําคัญของตัวจัดกําหนดการคือ:

- ความสามารถในการดูกําหนดการของโฟลว์ระบบคลาวด์ที่เกิดซ้ํา
- ดูกําหนดการตามมุมมองวัน สัปดาห์ เดือน และกําหนดการ
- ดูสถานะของโฟลว์ที่กําหนดเวลาไว้ (สําเร็จ ล้มเหลว หรือ กําหนดเวลา)
- ดูระยะเวลาของการเรียกใช้ Cloud Flow
- ดูรายละเอียดข้อผิดพลาดใด ๆ

## หมาย เหตุ

สําหรับรุ่นปัจจุบันจะใช้บันทึกย่อต่อไปนี้

1. เฉพาะโซลูชัน Power Automate Desktop และ Power Automate ที่อยู่ภายในโซลูชันเท่านั้นที่จะแสดง
1. มีการลงทะเบียนและดําเนินการ Power Automate Desktop อย่างน้อยหนึ่งรายการ

## ติดตั้ง

ในการติดตั้งโซลูชันตัวจัดกําหนดการคุณสามารถทําสิ่งต่อไปนี้:

1. ตรวจสอบให้แน่ใจว่า Power Apps component framework <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">ดูเพิ่มเติม</a>
1. คุณได้ติดตั้งชุดผู้สร้างลงในสภาพแวดล้อมเป้าหมายแล้ว <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">ติดตั้งจาก App Source</a>
1. คุณได้ดาวน์โหลดไฟล์ AutomationKit.zip จากส่วนเนื้อหาล่าสุด <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">ปล่อย GitHub</a>
1. คุณได้นําเข้า AutomationKitScheduler ล่าสุด_*_จัดการ.zip ไฟล์ที่ใช้ <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">ดูเพิ่มเติม</a>

## แผนงาน

คุณสามารถเยี่ยมชมของเรา <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">ปัญหา GitHub</a> เพื่อดูคุณลักษณะใหม่ที่เสนอ

คุณสามารถเพิ่มใหม่ได้ <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">คําขอคุณสมบัติตัวจัดกําหนดการ</a>

## การตอบสนอง

{{<questions name="/content/th/features/scheduler.json" completed="ขอขอบคุณที่ให้ข้อเสนอแนะ" showNavigationButtons="false" locale="th">}}
