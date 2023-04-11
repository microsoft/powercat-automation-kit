---
title: "การรวม Process Advisor"
description: "ชุดระบบอัตโนมัติ - การรวม Process Advisor"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Process Advisor', 'Integration', 'RPA']
generated: 1314509EA465891ED5914448D4EC119A8218FE57
---
--------------|---------------|-------------|
Duration Total (Total Processing Time in minutes)|Duration Total Per activity|Top-level metrics currently only median and average duration which can be transformed with some customization
Case frequency| (volume per process frequency)|Case count||
Resource count (Number of FTEs needed, Number of FTEs needed for Review/Rework)|Resource count
Rework percentage (AVG Error Rate %)|Rework percentage||
Currency||In Process Advisor data model

## Semi Automated Automation Project

Using the data collected in the Process Advisor in your Power BI custom workspace you can integrate the results using Power Automate or Power Apps.

![Automation Kit Process Advisor Integration](/images/illustrations/process-advisor-integration.svg)

Using the Process Advisor Import process simplifies the amount of information that needs to be entered and offers you a choice of options to integrate with you Automation Project.

Reviewers of the Automation Project and take into account the Process Advisor results when considering if they should Approve or Deny the Automation Project request.

NOTE:

1. We currently have items on the Automation Kit backlog to add additional templates and applications in upcoming milestones that enable you quickly get started with integrating your Processed Advisor data with the Automation Kit.

2. More information on configuring your Process Advisor analysis with a custom workspace can be found in [Load your process analytics in power bi](https://learn.microsoft.com/power-automate/process-mining-pbi-workspace#load-your-process-analytics-in-power-bi)

### Power Automate Templates

You could use out of the box Power BI connector actions and Power Automate cloud flows to create or update you Automation Kit projects.

## Questions

{{<questions name="/content/en-us/backlog/process-advisor-integration.json" completed="Thank you for completing Process Advisor questions" showNavigationButtons=false />}}

{{<product-name>}} ผสานรวมกับ [Process Advisor](https://learn.microsoft.com/power-automate/process-advisor-overview) เพื่อสนับสนุนสถานการณ์ต่อไปนี้:

- **การทําเหมืองแร่แปรรูป** การวิเคราะห์กระบวนการทางธุรกิจเพื่อระบุและสนับสนุนกรณีธุรกิจเพื่อสร้างโครงการอัตโนมัติที่สนับสนุนโดยการวิเคราะห์ข้อมูล

- **คําขอโครงการระบบอัตโนมัติที่ขับเคลื่อนด้วยข้อมูล** ใช้ผลลัพธ์ของการวิเคราะห์กระบวนการของคุณเพื่อสร้างโครงการอัตโนมัติจากผลลัพธ์ Process Advisor

- **การสร้างโครงการอัตโนมัติกึ่งอัตโนมัติ** รวมข้อมูล Dataverse ระหว่าง Process Advisor และ Automation Kit เพื่อลดปริมาณงานเพื่อสร้าง Automation Project

- **การวิเคราะห์ Power Automate บนเดสก์ท็อป** วิเคราะห์ข้อมูลกระบวนการ RPA เพื่อระบุการปรับปรุงเพื่อปรับปรุงความยืดหยุ่นและความน่าเชื่อถือให้ทันสมัยโดยใช้การทําเหมืองงาน

## การทําเหมืองแร่แปรรูป

การใช้การทําเหมืองกระบวนการกับ Process Advisor ช่วยให้คุณค้นพบความไร้ประสิทธิภาพในกระบวนการทั่วทั้งองค์กร ข้อมูลเชิงลึกเหล่านี้ช่วยให้คุณเข้าใจกระบวนการของคุณอย่างลึกซึ้งโดยใช้ไฟล์บันทึกเหตุการณ์ที่คุณจะได้รับจากระบบการบันทึกของคุณ (แอปที่คุณใช้ในกระบวนการของคุณ) การทําเหมืองกระบวนการแสดงแผนที่ของกระบวนการของคุณด้วยข้อมูลและเมตริกเพื่อรับรู้ปัญหาด้านประสิทธิภาพ ตัวอย่างกระบวนการที่เหมาะสมสําหรับการทําเหมืองกระบวนการ ได้แก่ ลูกหนี้และการสั่งซื้อเป็นเงินสด

ข้อมูลนี้ช่วยให้คุณสร้างคําขอโครงการระบบอัตโนมัติที่ขับเคลื่อนด้วยข้อมูล

## การสร้างโครงการอัตโนมัติ

การใช้ผลลัพธ์ของการทําเหมืองกระบวนการ Process Advisor และการรายงานคุณสามารถใช้ข้อมูล Process Advisor ต่อไปนี้เพื่อสนับสนุนโครงการระบบอัตโนมัติของคุณโดยใช้ผลการวิเคราะห์ Process Advisor คํานวณ:

ชุดระบบอัตโนมัติ|Process Advisor|หมาย เหตุ        |
