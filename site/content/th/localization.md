---
title: "แปล"
description: "ชุดระบบอัตโนมัติ - การแปลเป็นภาษาท้องถิ่น"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: E807CB451AFD916D511FFBA8EAC5FA5C8C54BC47
---

**สถานะ:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} อยู่ระหว่างดําเนินการ - การทดลอง

{{<toc>}}

## เป้าหมาย

หนึ่งในเป้าหมายหลักของ {{<product-name>}} คือการสนับสนุนการรวมกลุ่มผ่านการแปลเนื้อหา เพื่อให้บรรลุเป้าหมายนี้ให้ใช้สิ่งต่อไปนี้:

- เนื้อหาที่โฮสต์บน [เว็บไซต์เริ่มต้น](https://aka.ms/ak4pp/starter) ให้การแปลอัตโนมัติผ่าน Azure Cognitive Services และการแม็ปแบบกําหนดเอง

- ทีมเนื้อหาไซต์เริ่มต้นหลักจะทํางานใน en-us และแปลงเนื้อหาเป็นภาษาต่อไปนี้:

  - [เดนมาร์ก](https://microsoft.github.io/powercat-automation-kit/da/)
  - [ดัทช์](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [ฝรั่งเศส](https://microsoft.github.io/powercat-automation-kit/fr/)
  - [อิตาลี](https://microsoft.github.io/powercat-automation-kit/it/)
  - [เกาหลี](https://microsoft.github.io/powercat-automation-kit/ko/)
  - [ญี่ปุ่น](https://microsoft.github.io/powercat-automation-kit/ja/)
  - [นอร์เวย์](https://microsoft.github.io/powercat-automation-kit/nb/)
  - [โปแลนด์](https://microsoft.github.io/powercat-automation-kit/pl/)
  - [จีนตัวย่อ](https://microsoft.github.io/powercat-automation-kit/zh-hans)
  - [สเปน](https://microsoft.github.io/powercat-automation-kit/es/)
  - [สวีเดน](https://microsoft.github.io/powercat-automation-kit/sv/)

- จัดเตรียมกลไกการตอบรับเพื่อให้เนื้อหาที่สร้างขึ้นโดยอัตโนมัติสามารถปรับปรุงได้ตลอดเวลา

- แก้ไขปัญหาของการแปลเป็นภาษาท้องถิ่นตั้งแต่เนิ่นๆ เพื่อให้เนื้อหาย้ายไปที่ [เรียนรู้เนื้อหาระบบอัตโนมัติ CoE](https://aka.ms/AutomationCoE) เนื้อหาพร้อมใช้งานในรูปแบบที่แปลเป็นภาษาท้องถิ่นแล้ว

- ใช้การเรียนรู้จากเนื้อหาของไซต์เริ่มต้นเพื่อปรับปรุงแอสเซท Kit อื่นๆ เช่น รายงานเทมเพลตแดชบอร์ดหรือแอปพลิเคชัน

- อนุญาตให้มีรูปแบบการมีส่วนร่วม "แหล่งที่มาของฝูงชน" ที่ช่วยให้การเปลี่ยนแปลงภาษาดีขึ้น

- ใช้การเรียนรู้เพื่ออนุญาตเนื้อหา "ฮับการสื่อสาร" เฉพาะภาษาสําหรับชุดการทํางานอัตโนมัติ

## สถานะปัจจุบัน

- การสนับสนุนภาษาอังกฤษแบบอเมริกันเป็นภาษาอังกฤษแบบอังกฤษยังไม่ได้ดําเนินการ

- ค่าเริ่มต้นจากกล่อง Azure Cognitive Service การแปลข้อความของบริบทสําหรับภาษาทดลองใช้ด้านบน

## คําถามและคําตอบ

### **ปัญหา:** เนื้อหาที่แปลเป็นภาษาท้องถิ่นเป็นเนื้อหาที่แปลอย่างมืออาชีพหรือไม่

ไม่มีการสร้างเนื้อหาเริ่มต้นเป็นภาษาอังกฤษแบบสหรัฐอเมริกาและแปลเป็นภาษาอื่นโดยอัตโนมัติโดยใช้ Azure Cognitive Services และข้อกําหนดการแมป

### **ปัญหา:** ฉันจะปรับปรุงการแปลสําหรับภาษาของฉันได้อย่างไร

ลองพิจารณาให้คําติชมหรือการสนับสนุนเพื่อช่วยเราปรับปรุงเวอร์ชันภาษาที่แปลเป็นภาษาท้องถิ่นของคุณ

### **ปัญหา:** ความสัมพันธ์กับเนื้อหา Microsoft Learn คืออะไร

เนื้อหาด้านเริ่มต้นได้รับการจัดการโดยแกนหลัก {{<product-name>}} ทีมเท่านั้น เมื่อเนื้อหาย้ายไปยังแพลตฟอร์ม Microsoft Learn เนื้อหานั้นจะต้องผ่านกระบวนการตรวจสอบเนื้อหาและการแปลเป็นภาษาท้องถิ่นแยกต่างหาก

### **ปัญหา:** สามารถเพิ่มภาษาอื่นได้หรือไม่?

ใช่ หากภาษานั้นได้รับการสนับสนุนโดย [การสนับสนุนภาษาบริการองค์ความรู้ของ Azure](https://learn.microsoft.com/azure/cognitive-services/language-support) จากนั้นก็สามารถเพิ่มได้

## ให้คําติชม

สิ่งที่จะให้ข้อเสนอแนะเกี่ยวกับกระบวนการแปล?

{{<questions name="/content/th/localization.json" completed="ขอบคุณสําหรับการกรอกคําถาม" showNavigationButtons="false" locale="th">}}
