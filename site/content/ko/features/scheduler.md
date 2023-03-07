---
title: "스케줄러"
description: "자동화 키트 - 스케줄러"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 00B15DA73732A60B73A09229CEF9B843E259A121
---

{{<toc>}}

## 소개

자동화 키트 스케줄러를 사용하면 Power Automate 데스크톱 흐름에 대한 호출을 포함하는 솔루션 내에서 반복되는 Power Automate 클라우드 흐름의 일정을 볼 수 있습니다.

이 기능은 [2023년 2월](/ko/releases/february-2023)이후 릴리스에서는 스케줄러의 기능을 계속 개선하고 확장할 예정입니다.

{{<border>}}
![스케줄러](/images/schedule.png)
{{</border>}}

스케줄러의 주요 기능은 다음과 같습니다.

- 되풀이 클라우드 흐름의 일정을 볼 수 있는 기능
- 일, 주, 월 및 일정 보기로 일정 보기
- 예약된 흐름의 상태 보기(성공, 실패 또는 예약됨)
- 클라우드 흐름 실행 기간 보기
- 오류의 세부 정보를 봅니다.

## 노트

현재 릴리스의 경우 다음 참고 사항이 적용됩니다.

1. 솔루션 내에 포함된 Power Automate 데스크톱 및 Power Automate 솔루션만 표시됩니다.
1. 하나 이상의 Power Automate 데스크톱이 등록되고 실행되었습니다.

## 설치하다

스케줄러 솔루션을 설치하려면 다음을 수행할 수 있습니다.

1. Power Apps 구성 요소 프레임워크 확인 <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">더보기</a>
1. 크리에이터 키트를 대상 환경에 설치했습니다. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">앱 소스에서 설치</a>
1. 최신 자산의 섹션에서 AutomationKit.zip 파일을 다운로드했습니다. <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">깃허브 릴리스</a>
1. 최신 AutomationKitScheduler를 가져왔습니다._*_관리.zip 파일 사용. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">더보기</a>

## 로드맵

당신은 우리를 방문 할 수 있습니다 <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">깃허브 문제</a> 을 클릭하여 제안된 새 기능을 볼 수 있습니다.

새 항목을 추가할 수 있습니다. <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">스케줄러 기능 요청</a>

## 피드백

{{<questions name="/content/ko/features/scheduler.json" completed="피드백을 제공해 주셔서 감사합니다." showNavigationButtons="false" locale="ko">}}
