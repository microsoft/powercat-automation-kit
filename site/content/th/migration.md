---
title: "การย้ายข้อมูล RPA"
description: "ชุดระบบอัตโนมัติ - การย้ายข้อมูล RPA"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: CCB317C8E5382C83C9C53583C89346A7B6D052F5
---

{{<toc>}}

<br/>

{{<product-name>}} **โมดูลการย้ายข้อมูล** มอบชุดเครื่องมือและคําแนะนําที่ได้รับการพิสูจน์แล้วตามการมีส่วนร่วมกับลูกค้าเพื่อเร่งเส้นทางการโยกย้ายของคุณ ด้วยการใช้ประโยชน์จากความแข็งแกร่งของ Microsoft Power Platform, Microsoft Azure และบริการคลาวด์ของ Microsoft ที่กว้างขึ้น คุณจะสามารถ:

- ตระหนักถึงเป้าหมายของคุณในการประหยัดต้นทุน

- จัดหารั้วเพื่อวางแผนโยกย้ายตรวจสอบและตั้งค่ารูปแบบการดําเนินงานสําหรับการใช้งานอย่างต่อเนื่อง

- ใช้ประโยชน์จากตัวอย่างการแปลงที่คุณสามารถปรับแต่งให้เข้ากับกระบวนการของคุณเพื่อตอบสนองความต้องการในการย้ายข้อมูลของคุณ

## เริ่มต้นการย้ายข้อมูล RPA

![คู่มือผู้นําธุรกิจเกี่ยวกับการโยกย้ายกระบวนการอัตโนมัติแบบหุ่นยนต์ (RPA)](https://msflowblogscdn.azureedge.net/wp-content/uploads/2022/01/RPAWhitepaper_Img-241x300.png)

คุณสามารถใช้การเชื่อมโยงต่อไปนี้เพื่อทําความเข้าใจกระบวนการโยกย้าย RPA สําหรับ Microsoft Power Platform:

- [วิธีการที่ได้รับการพิสูจน์แล้วในการปรับปรุงแนวทาง RPA ของคุณให้ทันสมัยด้วย Power Automate](https://powerautomate.microsoft.com/blog/proven-methods-to-modernize-your-rpa-approach-with-power-automate/)

- เอกสารไวท์เปเปอร์ที่ดาวน์โหลดได้ [คู่มือผู้นําธุรกิจเกี่ยวกับการโยกย้ายกระบวนการอัตโนมัติแบบหุ่นยนต์ (RPA)](https://aka.ms/PAD/RPAMigrationWhitepaper)

## พื้นที่โฟกัส

รายการต่อไปนี้แสดงภาพรวมของพื้นที่ที่เราจัดลําดับความสําคัญเพื่อรวมไว้ใน Automation Kit เพื่อให้เราสามารถปรับปรุงส่วนประกอบที่คุณสามารถใช้ในการโยกย้ายของคุณได้

> หมายเหตุ: พื้นที่โฟกัสเหล่านี้อาจมีการเปลี่ยนแปลงอย่างมาก การเปลี่ยนแปลงเหล่านี้จะเกิดขึ้นเราได้รับข้อเสนอแนะอย่างต่อเนื่องและจัดลําดับความสําคัญของคุณสมบัติเพื่อตอบสนองความต้องการของลูกค้า

### การวางแผน

- **การประเมิน** ส่วนประกอบที่ช่วยในขั้นตอนการวางแผนเพื่อช่วยในการระบุโซลูชันระบบอัตโนมัติใดจากสินค้าคงคลังอัตโนมัติของคุณที่จะย้ายเพื่อให้ผลกระทบเริ่มต้นที่ดีที่สุด

### การจัดการและธรรมาภิบาล

- **ผลตอบแทนจากการลงทุน** กรอบการทํางานสําหรับการรวบรวมและตรวจสอบผลตอบแทนจากการลงทุนของโปรแกรมการย้ายถิ่นของงานเพื่อให้ผู้มีส่วนได้ส่วนเสียมีส่วนร่วมกับกระบวนการโยกย้ายและสามารถวัดผลกระทบได้

- **กำกับ ดูแล** ชุดของส่วนประกอบและคําแนะนําที่ช่วยเกี่ยวกับวงจรชีวิตของแอปพลิเคชันการจัดทําเอกสารและการตรวจสอบการดําเนินงานอย่างต่อเนื่องของโซลูชันที่โยกย้าย

### การเปลี่ยนแปลง

- **การรวมระบบคลาวด์** ส่วนประกอบตัวอย่างที่สามารถใช้เพื่อเร่งกระบวนการแปลงเพื่อโยกย้ายโซลูชันไปยัง Microsoft Cloud ซึ่งเป็น Power Platform

- **ข้อกําหนดที่ไม่ใช่การทํางาน** ครอบคลุมวิธีการทดสอบคุณภาพ, การตรวจสอบ DevOps, เอกสารของโซลูชันที่โยกย้าย

### ศูนย์ความเป็นเลิศด้านระบบอัตโนมัติ

การเชื่อมต่อการโยกย้ายระบบอัตโนมัติกับศูนย์ความเป็นเลิศด้านระบบอัตโนมัติมีชุดทักษะสําหรับนักพัฒนาการโยกย้ายที่ทับซ้อนกับชุดระบบอัตโนมัติและตัวเร่งความเร็ว ALM

![ศูนย์ความเป็นเลิศด้านระบบอัตโนมัติ](/images/illustrations/automation-kit-migration.svg)

#### นักพัฒนาการโยกย้าย

ดูเฉพาะกระบวนการของนักพัฒนาการย้ายข้อมูล

{{<border>}}

![ศูนย์ความเป็นเลิศด้านระบบอัตโนมัติ - นักพัฒนาการโยกย้าย](/images/illustrations/automation-kit-migration-developer.svg)

{{</border>}}

##### ประเมินและวางแผน

การประเมินและแผนเริ่มต้นด้วยการสแกนการลงทุนระบบอัตโนมัติที่มีอยู่ของคุณฟรีโดยใช้ [ระบบพิมพ์เขียว](https://www.blueprintsys.com/) เพื่อกําหนดความซับซ้อนและขอบเขตในปัจจุบัน การใช้ข้อมูลนี้จะช่วยวางแผนสําหรับชุดเริ่มต้นของโซลูชันระบบอัตโนมัติที่สามารถโยกย้ายไปยัง Power Automate Desktop ได้

##### อพยพ

กระบวนการโยกย้ายจากระบบการโยกย้ายต้นทางของคุณไปยังการดําเนินการ Power Automate Desktop ที่เทียบเท่ากัน การดําเนินการใดๆ ที่กําหนดให้นักพัฒนาการโยกย้ายต้องตรวจสอบและอัปเดตจะถูกทําเครื่องหมายเป็นความคิดเห็น TODO เพื่อให้สามารถระบุงานที่เหลือได้อย่างง่ายดาย

##### สร้างสรุป

การใช้ความคิดเห็น TODO ที่ระบุนักพัฒนาการโยกย้ายจะดําเนินการตามขั้นตอนการโยกย้ายที่เหลือให้เสร็จสมบูรณ์เพื่อให้โซลูชันทํางานภายใน Power Automate Desktop

##### กระบวนการปรับใช้

การใช้โซลูชัน ALM Accelerator สามารถย้ายจากสภาพแวดล้อมการพัฒนาไปยังการผลิตที่มีการตรวจสอบความถูกต้องที่ใช้เพื่อให้แน่ใจว่ารายการ TODO ถูกลบออกและการตรวจสอบระบบเป้าหมายและการตรวจสอบ DLP ได้ถูกนําไปใช้

จากมุมมองการบํารุงรักษากฎการกํากับดูแล DLP และการตรวจสอบความถูกต้องอย่างต่อเนื่องสามารถนําไปใช้ต่อไปเพื่อปรับแต่งและอัปเดตโซลูชันที่ปรับใช้ล่วงเวลา

#### เลเยอร์อื่น ๆ

โมดูลการโยกย้ายสร้างขึ้นจากคําแนะนําและเครื่องมือที่มีอยู่เพื่อสนับสนุน ALM ส่วนประกอบโครงสร้างพื้นฐานพร้อมกับความปลอดภัยและการกํากับดูแลและการรายงานและการวิเคราะห์การดําเนินงาน