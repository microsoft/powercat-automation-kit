---
title: "กำหนดการ"
description: "ชุดระบบอัตโนมัติ - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 5DA3F1C4E1D121AFDA7A19B1E888CF88538487F4
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

## แผนงาน

คุณสามารถเยี่ยมชมของเรา <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">ปัญหา GitHub</a> เพื่อดูคุณลักษณะใหม่ที่เสนอ

คุณสามารถเพิ่มใหม่ได้ <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">คําขอคุณสมบัติตัวจัดกําหนดการ</a>

## การตอบสนอง

{{<questions name="/content/th/features/scheduler.json" completed="ขอขอบคุณที่ให้ข้อเสนอแนะ" showNavigationButtons="false" locale="th">}}
