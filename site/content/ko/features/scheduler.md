---
title: "스케줄러"
description: "자동화 키트 - 스케줄러"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 74448AAD8893663688F10D12DCCC2009D386B0CE
---

{{<toc>}}

## 소개

자동화 키트 스케줄러를 사용하면 Power Automate 데스크톱 흐름에 대한 호출을 포함하는 솔루션 내에서 반복되는 Power Automate 클라우드 흐름의 일정을 볼 수 있습니다.

이 기능은 [2023년 3월](/ko/releases/march-2023)이후 릴리스에서는 스케줄러의 기능을 계속 개선하고 확장할 예정입니다.

{{<border>}}
![스케줄러](/images/schedule.png)
{{</border>}}

스케줄러의 주요 기능은 다음과 같습니다.

- 되풀이 클라우드 흐름의 일정을 볼 수 있는 기능
- 기계 및 기계 그룹별로 일정 필터링
- 전원 자동화 데스크톱 흐름 실행
- 일, 주, 월 및 일정 보기로 일정 보기
- 예약된 흐름의 상태 보기(성공, 실패 또는 예약됨)
- 클라우드 흐름 실행 기간 보기
- 오류의 세부 정보를 봅니다.

## 클라우드 흐름

위에서 언급했듯이 솔루션의 일부로 포함된 클라우드 흐름만 있습니다. 최근 [https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/) 에는 "기본적으로 Dataverse 솔루션"의 새 미리 보기를 사용하여 클라우드 흐름이 솔루션에 포함되도록 하는 방법에 대한 정보가 포함되어 있습니다. 이 기능을 사용하면 사용자가 생성된 예약된 클라우드 흐름이 스케줄러에 표시되도록 하는 데 도움이 될 수 있습니다.

## 달력 보기

## 일, 주, 월 보기

일, 주, 월 보기에는 실행되었거나 실행되도록 예약된 Desktop Cloud 흐름 실행에 대한 정보가 표시됩니다.

항목은 다음과 같이 색상으로 구분됩니다.

- 녹색은 성공적인 실행을 나타냅니다.

- 빨간색은 실행 실패를 나타냅니다.

- 파란색은 예정된 향후 실행을 나타냅니다.

상태 및 실행 정보는 이벤트를 길게 터치하거나 마우스로 가리키는 방법으로 사용할 수 있습니다.

### 일정

{{<border>}}
![스케줄러 - 지금 실행](/images/scheduler-schedule-view.png)
{{</border>}}

일정 보기에는 현재 시간의 시간과 다음 날의 향후 예약된 흐름을 기반으로 하는 클라우드 흐름 집합이 포함됩니다.

## 지금 실행

{{<border>}}
![스케줄러 - 지금 실행](/images/scheduler-run-now.png)
{{</border>}}

지금 실행의 현재 버전은 Power Automate 데스크톱을 실행합니다. 여기서는 데스크톱 흐름을 실행하는 데 필요한 매개 변수가 없다고 가정합니다. 추가 실행 정보는 Desktop 마지막 실행 정보에서 사용할 수 있습니다.

### 계획된 변경 사항

향후 릴리스에서는 다음이 새로운 기능으로 고려되고 있습니다.

1. 데스크톱 흐름이 아닌 클라우드 흐름을 실행합니다. 그런 다음 클라우드 흐름 실행 기록과 데스크톱 흐름에 전달되는 추가 클라우드 흐름 작업 및 매개 변수 실행이 포함됩니다.

2. 데스크톱 및 클라우드 흐름 실행 페이지를 엽니다.

### 예약된 흐름의 읽기 전용 동작

기본적으로 흐름이 향후 실행되도록 예약되면 읽기 전용 모드로 설정되고 즉시 실행할 수 없습니다. 즉, 사용자는 예약된 날짜 및 시간이 지날 때까지 흐름을 수정하거나 실행할 수 없습니다. 이 동작은 더 나은 사용자 환경을 제공하고 흐름이 실행되기 전에 실수로 실행되는 것을 방지하도록 설계되었습니다.
이 접근 방식에는 다음과 같은 몇 가지 이점이 있습니다.

- 실수로 인한 실행 방지: 향후 실행이 예약된 흐름의 즉시 실행을 사용하지 않도록 설정하면 사용자가 의도하기 전에 실수로 흐름을 실행할 가능성이 줄어듭니다.

- 향상된 예측 가능성: 향후 실행이 예약될 때 흐름을 읽기 전용 모드로 설정하면 사용자는 흐름이 실행되는 시기를 보다 쉽게 예측하고 필요한 입력 및 리소스가 준비되어 있는지 확인할 수 있습니다.

- 일관된 사용자 환경: 예약된 흐름의 동작을 표준화하여 Flow의 모든 인스턴스에서 일관되고 예측 가능한 사용자 환경을 제공할 수 있습니다.

- 예약된 흐름을 수정하거나 실행하기 위해 사용자는 흐름을 편집하고 예약된 날짜 및 시간을 업데이트할 수 있습니다. 새 일정이 설정되면 즉시 실행을 위해 흐름이 다시 한 번 비활성화되고 새 일정이 지나갈 때까지 읽기 전용 모드로 설정됩니다.

## 오류 메시지

실행 흐름을 실행할 때 발생할 수 있는 오류 메시지일 수 있습니다.

### 오류 메시지: "InvalidArgument - 제공된 연결 참조와 연결된 유효한 연결을 찾을 수 없습니다."

#### 묘사

이 오류 메시지는 일반적으로 코드 또는 구성에 제공된 연결 참조에 문제가 있음을 나타냅니다. 시스템이 참조와 연관된 유효한 연결을 찾을 수 없으므로 요청된 조치를 실행할 수 없습니다.

#### 원인

이 오류 메시지의 원인은 다음과 같은 몇 가지가 있습니다.

- 올바르지 않거나 잘못된 연결 참조: 제공된 연결 참조가 잘못되었거나 잘못되어 시스템이 연결된 유효한 연결을 찾지 못할 수 있습니다.

- 연결 삭제 또는 변경: 코드 또는 구성에 사용된 연결이 삭제되거나 수정된 경우 시스템에서 참조와 연결된 유효한 연결을 찾지 못할 수 있습니다.

- 권한 문제: 코드 또는 구성을 실행하는 사용자 계정에 연결 또는 연결된 리소스에 액세스하는 데 필요한 권한이 없을 수 있습니다.

#### 해상도

이 문제를 해결하려면 다음 단계를 수행할 수 있습니다.

- 연결 참조 확인: 코드 또는 구성에 제공된 연결 참조를 확인하고 유효하고 올바른지 확인합니다.

- 기존 연결을 삭제하고 다시 만들기: 흐름 검사기에서 연결 참조가 사용되지 않았다는 경고가 표시되면 흐름 검사기를 사용하여 기존 연결을 삭제할 수 있습니다. 연결이 삭제되면 Machine 또는 Machine 그룹에 대한 연결 참조를 다시 만들어 흐름을 실행할 수 있습니다.

## 노트

현재 릴리스의 경우 다음 참고 사항이 적용됩니다.

1. 솔루션 내에 포함된 Power Automate 데스크톱 및 Power Automate 솔루션만 표시됩니다.
1. 하나 이상의 Power Automate 데스크톱이 등록되고 실행되었습니다.

## 설치하다

스케줄러 솔루션을 설치하려면 다음을 수행할 수 있습니다.

1. Power Apps 구성 요소 프레임워크가 사용하도록 설정되어 있는지 확인 <a href="https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">더보기</a>
1. 크리에이터 키트를 대상 환경에 설치했습니다. <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">앱 소스에서 설치</a>
1. 최신 자산의 섹션에서 AutomationKit.zip 파일을 다운로드했습니다. <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">깃허브 릴리스</a>
1. 최신 AutomationKitScheduler를 가져왔습니다._*_관리.zip 파일 사용. <a href='https://learn.microsoft.com/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">더보기</a>

## 로드맵

당신은 우리를 방문 할 수 있습니다 <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">깃허브 문제</a> 을 클릭하여 제안된 새 기능을 볼 수 있습니다.

새 항목을 추가할 수 있습니다. <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">스케줄러 기능 요청</a>

## 피드백

{{<questions name="/content/ko/features/scheduler.json" completed="피드백을 제공해 주셔서 감사합니다." showNavigationButtons="false" locale="ko">}}