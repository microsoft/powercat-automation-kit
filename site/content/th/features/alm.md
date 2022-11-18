---
title: "การจัดการวงจรชีวิตของแอปพลิเคชัน (ALM)"
description: "ชุดระบบอัตโนมัติ - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 7A054C4EE36843CB023C64E2B26C68DDF722666D
---

{{<slideStyles>}}

<div class="optional">

หน้านี้แสดงภาพรวมของส่วนประกอบที่สามารถช่วยคุณในการใช้ ALM ด้วยชุดระบบอัตโนมัติสําหรับเวิร์กโฟลว์ Power Automate Desktop ที่รวมอยู่ใน [โซลูชั่นPower Platform](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## สรุป

เมื่อมองไปที่ ALM สําหรับโซลูชันPower Platformที่มีส่วนประกอบ Power Automate บนเดสก์ท็อป

1. ตรวจสอบคุณลักษณะของไปป์ไลน์Power Platformสภาพแวดล้อมที่มีการจัดการเพื่อใช้ประโยชน์จากฟีเจอร์ในผลิตภัณฑ์ระดับองค์กรเพื่อจัดการและควบคุมโซลูชันภายในสภาพแวดล้อม

<br/>

2. หากจําเป็นให้ตรวจสอบ [Microsoft Power Platform Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [การดําเนินการ GitHub สําหรับไมโครซอฟท์ Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) หรือ [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) เพื่อรวมและทําให้กระบวนการ ALM DevOps ของคุณเป็นไปโดยอัตโนมัติ

<br/>

3. พิจารณาใช้ปุ่ม [ตัวเร่ง ALM สําหรับ Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). ตัวเร่งความเร็ว ALM มีชุดเทมเพลต Azure DevOps ที่สร้างไว้ล่วงหน้าซึ่งทําให้งาน ALM Power Platform จํานวนมากเป็นแบบอัตโนมัติโดยใช้การกํากับดูแลการควบคุมแหล่งที่มาแบบรวม

## เรียนรู้จากพาวเวอร์แคท

นอกจากนี้คุณยังสามารถอ่านเพิ่มเติมว่าเราในฐานะทีม Power CAT ใช้ตัวเร่งความเร็ว ALM เพื่อจัดส่งได้อย่างไร [ชุดจ่ายไฟอัตโนมัติ CAT ALM](/th/features/alm/powercat).

## ทรัพยากร

[ตัวเร่ง ALM สําหรับแคตตาล็อกการเรียนรู้Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## แผนงาน

ทีม Automation Kit กําลังทํางานร่วมกับทีม ALM Accelerator เพื่อเพิ่มงานเฉพาะของ Power Automate Desktop ลงในเทมเพลตที่มีอยู่ซึ่งครอบคลุม:

- เปรียบเทียบแบบเคียงข้างกันของคําจํากัดความของ Power Automate บนเดสก์ท็อป

- กฎการตรวจสอบจะตรวจสอบสําหรับ Power Automate Desktop

- การดําเนินการทดสอบหน่วยการรวมและระบบซึ่งเป็นส่วนหนึ่งของไปป์ไลน์ CI / CD

ตรวจสอบของเรา [ชุดระบบอัตโนมัติ ALM ที่เกี่ยวข้องกับงานในมือ](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## การตอบสนอง

{{<questions name="/content/th/features/alm.json" completed="ขอขอบคุณที่ให้ข้อเสนอแนะ" showNavigationButtons="false" locale="th">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

สภาพแวดล้อมที่มีการจัดการช่วยให้คุณสามารถปรับปรุงและลดความซับซ้อนของการกํากับดูแลในวงกว้างได้ ผู้ดูแลระบบสามารถเปิดใช้งานสภาพแวดล้อมที่มีการจัดการได้ด้วยการคลิกเพียงไม่กี่ครั้งและจุดประกายคุณลักษณะต่างๆ ได้ทันที ซึ่งช่วยให้มองเห็นได้มากขึ้น ควบคุมได้มากขึ้นโดยใช้ความพยายามน้อยลงในการจัดการแอสเซทที่ใช้โค้ดน้อยทั้งหมดของคุณ

สภาพแวดล้อมที่มีการจัดการเป็นส่วนสําคัญของตระกูล Power Platform ในลักษณะเดียวกับที่ AI Builder ผสมผสานความชาญฉลาดเข้ากับผลิตภัณฑ์ของเรา และ Dataverse ให้แกนหลักของข้อมูล สภาพแวดล้อมที่มีการจัดการช่วยเพิ่มความคล่องตัวในการกํากับดูแลแพลตฟอร์มในวงกว้าง

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

สภาพแวดล้อมที่มีการจัดการช่วยให้คุณ:

- มองเห็นได้มากขึ้นด้วยข้อมูลเชิงลึกการใช้งานในหน้าแรกอีเมลสรุปของผู้ดูแลระบบรายงานใบอนุญาตและมุมมองนโยบายข้อมูล
- ควบคุมได้มากขึ้นด้วยขีดจํากัดการแชร์ ช่วยให้คุณควบคุมได้ว่าแอปพื้นที่ทํางานและโฟลว์โซลูชันสามารถแชร์กับผู้คนได้มากน้อยเพียงใดและด้วยจํานวนคน
- คุณยังสามารถจํากัดการแชร์เฉพาะกลุ่มความปลอดภัยที่จํากัดได้อีกด้วย
- กําหนดค่าตัวตรวจสอบโซลูชันสําหรับการตรวจสอบความปลอดภัยหรือความน่าเชื่อถือเพื่อเรียกใช้กฎโดยอัตโนมัติเมื่อใดก็ตามที่โซลูชันถูกนําเข้าไปยังสภาพแวดล้อมที่มีการจัดการ
- ปรับแต่งการต้อนรับและแบ่งปันประสบการณ์ของผู้ผลิตเพื่อให้คุณแนะนําผู้ใช้ตามเส้นทางที่ถูกต้อง
- ลดความพยายามลดความซับซ้อนและขั้นตอนอัตโนมัติออกจากกล่องเพียงไม่กี่คลิก 
- ไปป์ไลน์ Power Platform ให้ความสามารถในการลดความซับซ้อนของกระบวนการจัดการวงจรชีวิตของแอปพลิเคชัน (ALM)

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

นี่เป็นโซลูชันที่ฉันกําลังทํางานด้วยใน Maker Portal

ฉันได้ไปข้างหน้าเพื่อเลือกไปป์ไลน์นี้ที่ได้รับการตั้งค่าแล้ว ไปป์ไลน์เป็นชุดของขั้นตอนอัตโนมัติที่ย้ายงานของคุณจากสภาพแวดล้อมหนึ่งไปยังอีกสภาพแวดล้อมหนึ่ง ไปป์ไลน์นี้จะนําโซลูชันของฉันจากสภาพแวดล้อมการพัฒนาทางด้านซ้ายไปยังสภาพแวดล้อมการทดสอบ จากนั้นก็มีอีกขั้นตอนหนึ่งที่ต้องทําตั้งแต่การทดสอบจนถึงการผลิต

ให้ปรับใช้เพื่อทดสอบเลือกถัดไปและที่นี่ฉันจะยืนยันการเชื่อมต่อของฉันเพื่อทดสอบสภาพแวดล้อมเพื่อให้แน่ใจว่าฉันใช้ข้อมูลประจําตัวที่ถูกต้อง ต่อไปฉันจะกําหนดค่าตัวแปรสภาพแวดล้อมของฉันเพื่อให้แน่ใจว่าตัวอย่างเช่นฉันกําลังชี้ไปที่ไซต์ SharePoint ที่ถูกต้องในการทดสอบ นี่เป็นสิ่งสําคัญหากไซต์นั้นแตกต่างจากไซต์ที่ฉันใช้ในการพัฒนา 

เมื่อฉันตั้งค่าทั้งหมดแล้วฉันสามารถเลือก "ปรับใช้" และการตรวจสอบก่อนเที่ยวบินจะทํางานโดยอัตโนมัติเพื่อให้ฉันมีการอ้างอิงที่ถูกต้องและโซลูชันไม่ละเมิดและนโยบาย DLP ในสภาพแวดล้อมเป้าหมายนั้น นอกจากนี้ยังสามารถตั้งค่าไปป์ไลน์เพื่อให้จําเป็นต้องมีการอนุมัติก่อนที่จะสามารถรันการปรับใช้ได้ 

ดูเหมือนว่าทุกอย่างประสบความสําเร็จที่นี่

หลังจากที่ฉันเรียกใช้ไปป์ไลน์ของฉันฉันได้รับการมองเห็นเต็มรูปแบบและเส้นทางการตรวจสอบของการปรับใช้ทั่วทั้งองค์กรของฉันด้วยทุกโซลูชันที่สํารองและกําหนดเวอร์ชัน

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

คุณสมบัติจะเปิดตัวเป็นระยะ ๆ บางคนชอบสรุปของผู้ดูแลระบบและขีด จํากัด การแชร์มีให้บริการในวันนี้ ส่วนที่เหลือจะเปิดตัวภายในสิ้นปีนี้

ในอีกไม่กี่สัปดาห์และหลายเดือนข้างหน้า คุณจะเห็นข้อมูลเชิงลึกการใช้งานในหน้าแรก แนวโน้มใหม่ในสรุปของผู้ดูแลระบบและรายงานสําหรับการใช้งานที่ได้รับอนุญาต ขีดจํากัดการแชร์จะได้รับการควบคุมและโฟลว์โซลูชันการสนับสนุนมากขึ้น คุณจะสามารถบล็อกการปรับใช้ที่ไม่ปลอดภัยด้วยตัวตรวจสอบโซลูชัน ความสามารถในการเตรียมความพร้อมของผู้ผลิตลูกค้าและไปป์ไลน์จะมาในปลายปีนี้

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

คุณมีตัวเลือกมากมายที่ต้องพิจารณาสําหรับตัวเลือก ALM ของคุณในPower Platform ไปป์ไลน์Power Platformสภาพแวดล้อมที่มีการจัดการมีให้ในการจัดการวงจรชีวิตของแอปพลิเคชันผลิตภัณฑ์

อีกทางหนึ่งคือคุณสามารถใช้จุดส่วนขยายของไปป์ไลน์Power Platformสภาพแวดล้อมที่มีการจัดการรวมกับ [Power Platform สร้างเครื่องมือสําหรับ Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [การดําเนินการ GitHub สําหรับไมโครซอฟท์ Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) หรือ [Power Platform CLI](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction) เพื่อม้วนกระบวนการ ALM DevOps แบบกําหนดเองของคุณเอง

ในที่สุดคุณสามารถใช้ประโยชน์จาก [ตัวเร่ง ALM สําหรับ Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) จาก CoE Kit เพื่อจัดเตรียมเทมเพลตและตัวอย่างที่สร้างไว้ล่วงหน้าสําหรับ ALM แบบ End-to-End โดยใช้ Azure DevOps ส่วนช่วยดําเนินการ ALM มีสถานการณ์ทั่วไปมากมายเพื่อสร้างและควบคุมโซลูชันของคุณในสภาพแวดล้อมต่างๆ

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

ตัวเร่ง ALM สําหรับ Power Platform คืออะไร

ตัวเร่งความเร็ว ALM สําหรับ Power Platform ประกอบด้วย Power Apps ที่อยู่ด้านบนของไปป์ไลน์ Azure DevOps และการควบคุมแหล่งที่มา Git แอพนี้มีอินเทอร์เฟซที่เรียบง่ายสําหรับผู้ผลิตในการส่งออกส่วนประกอบใน Power Platform Solutions ของตนเป็นประจําเพื่อควบคุมแหล่งที่มาและสร้างคําขอการปรับใช้เพื่อให้มีการตรวจสอบงานของพวกเขาก่อนที่จะปรับใช้กับสภาพแวดล้อมเป้าหมาย

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

เมื่อมองไปที่เวิร์กโฟลว์ ALM Accelerator จะเริ่มต้นด้วยสภาพแวดล้อมการพัฒนา การโต้ตอบของพวกเขากับกระบวนการ ALM คือผ่านแอปพื้นที่ทํางานตัวเร่ง ALM หรือไปป์ไลน์สภาพแวดล้อมที่มีการจัดการ

ผู้สร้างใช้แอปพื้นที่ทํางานส่วนช่วยดําเนินการ ALM สําหรับงาน ALM ของพวกเขา เช่น โซลูชันการนําเข้าจากการควบคุมต้นทาง ส่งออกการเปลี่ยนแปลงไปยังตัวควบคุมต้นทาง และสร้างคําขอดึงข้อมูลเพื่อผสานการเปลี่ยนแปลง

เทมเพลตตัวเร่งความเร็ว ALM สําหรับไปป์ไลน์ Azure DevOps อํานวยความสะดวกในการทํางานอัตโนมัติของงาน ALM ตามการโต้ตอบของผู้สร้างกับแอปพื้นที่ทํางานตัวเร่งความเร็ว ALM

ALM Accelerator มีเทมเพลตไปป์ไลน์เพื่อรองรับการปรับใช้ 3 ขั้นตอนกับการผลิต
เทมเพลตสามารถปรับแต่งให้เหมาะกับความต้องการและสถานการณ์เฉพาะได้

ตัวเร่งความเร็ว ALM สําหรับ Power Platform เป็นแอปพื้นที่ทํางานที่อยู่ด้านบนของไปป์ไลน์ Azure DevOps เพื่อจัดเตรียมอินเทอร์เฟซที่เรียบง่ายสําหรับผู้สร้างเพื่อยอมรับและสร้างคําขอดึงข้อมูลสําหรับงานพัฒนาของพวกเขาใน Power Platform เป็นประจํา 

การรวมกันของไปป์ไลน์ Azure DevOps และแอปพื้นที่ทํางานคือสิ่งที่ประกอบขึ้นเป็นตัวเร่ง ALM เต็มรูปแบบสําหรับโซลูชัน Power Platform 
ไปป์ไลน์และแอพเป็นการใช้งานอ้างอิง พวกเขาได้รับการพัฒนาเพื่อใช้งานโดยทีมพัฒนาสําหรับ CoE Starter Kit ภายใน แต่ได้รับการโอเพ่นซอร์สและเผยแพร่เพื่อแสดงให้เห็นว่า ALM ที่ดีต่อสุขภาพสามารถทําได้ในPower Platformได้อย่างไร สามารถใช้ตามที่เป็นอยู่หรือปรับแต่งสําหรับสถานการณ์ทางธุรกิจเฉพาะ

{{</slide>}}