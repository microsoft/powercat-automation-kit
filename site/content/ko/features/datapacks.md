---
title: "데이터 팩"
description: "자동화 키트 - 데이터 팩"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Data', 'Integration']
generated: 5695D0411A1BD909454FF04F1BDDAA7D64578032
---

{{<toc>}}

## 소개

데이터 팩은 사용 속도를 높이기 위해 설치된 Automation Kit에 선택적으로 설치할 수 있는 사전 패키지된 데이터 세트입니다.

{{<border>}}
![데이터 팩 개요](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

의 일부로 도입 [2022년 11월](/ko/releases/november-2022)에서 데이터 팩은 선택적으로 샘플 데이터를 가져올 수 있는 기능을 제공합니다.

ROI(투자 수익률) 데이터 팩을 사용하면 자동화 키트 Power BI 대시보드를 통해 투자 수익의 계획, 계량 및 모니터링을 신속하게 시연할 수 있습니다. 다음을 사용하여 첫 번째 데이터 팩을 로드할 수 있습니다. [시작](/ko#getting-started) 섹션을 참조하십시오.

시간이 지남에 따라 우선 순위 지정을 위해 백로그에 다른 데이터 팩을 추가하고 커뮤니티에 데이터 팩을 게시하기 위해 공동 작업할 수 있는 방법을 문서화합니다.

## 로드맵

{{<border>}}
![데이터 팩 로드맵](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

향후 이정표에서는 자동화 키트 자동 설치 프로세스의 선택적 부분으로 데이터 팩을 포함하여 데이터 팩을 개선할 것입니다.

데이터 팩을 설치의 일부로 포함하는 기능은 이 릴리스의 명령줄 설치 프로세스 대신 웹 기반 설치를 허용합니다.

## 투자 수익 주요 솔루션

ROI(투자 수익률) 기본 솔루션 데이터 팩에는 자동화 프로젝트, 기계 및 샘플 Power Automate 데스크톱 원격 분석이 포함되어 있으므로 엔드투엔드 프로세스를 직접 수행할 수 있습니다.

### 시작

이 데이터 팩을 시작하려면

- 크리에이터 키트 설치 위치 [앱 소스](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) 또는 다음을 통해 [설정 가이드 알아보기](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- 다음에서 최신 버전의 자동화 키트 기본 설치 [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) 사용 [설정 가이드 알아보기](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- 다음을 사용하여 명령줄 인터페이스 Power Platform 설치 [설정 가이드 알아보기](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- 환경에 대한 인증 만들기

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- 다운로드 **오토메이션키트.zip** 보낸 사람 [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- 파일 압축 풀기 **오토메이션킷-샘플데이터.zip** 보낸 사람 **오토메이션키트.zip**

- 사용자 환경으로 데이터 가져오기

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- 다운로드한 Power BI 대시보드를 사용자 환경과 연결하여 가져온 데이터를 탐색합니다. 쓰다 [Power BI 대시보드 설치](/ko/get-started/install-powerbi-dashboard) 추가 정보

## 피드백

{{<questions name="/content/ko/features/datapacks.json" completed="피드백을 제공해 주셔서 감사합니다." showNavigationButtons="false" locale="ko">}}
