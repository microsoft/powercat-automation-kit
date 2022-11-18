---
title: "전력 CAT 애플리케이션 라이프사이클 관리(ALM)"
description: "자동화 키트 - ALM 전원 고양이"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['ALM', 'Guidance', 'PowerCAT']
generated: A0E76BCFAC2095473353C3F9B49077A67DC58228
---

{{<slideStyles>}}

<div class="optional">

자동화 키트는 [ALM 가속기](https://aka.ms/aa4pp) 파워 오토메이트 데스크톱을 포함하는 솔루션에 ALM 기능을 제공하기 위해

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## 깃허브 배포 프로세스

다른 Power CAT 관리 키트에 사용되는 릴리스 프로세스와 유사하게 {{<product-name>}}는 ALM 액셀러레이터를 사용하여 공개 GitHub 릴리스에 릴리스를 배포합니다.

내부 프로세스에는 개발, 테스트 및 생산을위한 Power Platform 환경이 있습니다. 릴리스가 준비되면 통합된 GitHub 작업은 GitHub 초안 릴리스에 대한 릴리스 정보와 함께 관리되는 배포 솔루션과 관리되지 않는 배포 솔루션을 자동으로 패키지합니다.

초안 릴리스가 준비되면 필요에 따라 새 버전 또는 핫픽스를 게시할 수 있습니다.

### 이것이 의미하는 것

이제 이 자동화가 적용되었으므로 자동화된 ALM 릴리스는 다음과 같은 이점을 제공합니다.

- 자동화 키트를 구성하는 모든 로우 코드 소스 코드에 대한 가시성을 확보하여 키트를 구축한 방법을 조사할 수 있습니다.

- 버그 또는 문제에 신속하게 대응하고 필요한 경우 핫픽스를 제공할 수 있는 간소화된 자동화 프로세스입니다.

- 릴리스에 포함된 모든 버그 및 기능의 자동 컴파일.

- Power Apps, Power Automate, Dataverse 및 Power Automate 데스크톱을 지속적인 통합/지속적인 배포를 위한 ALM 프로세스의 일부로 포함합니다.

## 로드맵

다음에서 열려 있는 ALM 관련 백로그 항목을 조사할 수 있습니다. [GitHub 문제 등록](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

전반적으로 우리는 기존의 즉시 사용 가능한 Power Platform 및 Microsoft DevOps 제품 기능을 함께 ALM 가속기를 기반으로 합니다. 이 조합을 통해 우리는 초자동화에 도움이 되는 특정 확장에 집중할 수 있습니다.

## 피드백

{{<questions name="/content/ko/features/alm/powercat.json" completed="피드백을 제공해 주셔서 감사합니다." showNavigationButtons="false" locale="ko">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Power CAT 팀은 ALM 가속기를 사용하여 각 [릴리스](https://github.com/microsoft/powercat-automation-kit/releases).

각 릴리스는 개발에서 테스트 및 프로덕션 환경으로의 변경 사항을 촉진합니다. 키트 내의 Power Platform 솔루션은 자동화된 프로세스를 사용하여 공용 GitHub 릴리스에 배포할 자산을 패키징합니다.

향후 이정표에서 기존 플랫폼을 확장할 예정입니다. [ALM 기능](/ko/features/alm) DevOps 프로세스의 일부로 RPA 샘플의 유효성 검사 규칙 및 시각적 비교를 포함하는 방법의 예를 제공합니다.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

다음은 자동화 키트 릴리스 프로세스의 주요 단계를 간략하게 설명합니다.

1. Power Platform Dev 환경에서 변경한 내용은 공용 GitHub 리포지토리의 분기에 저장됩니다.

2. 변경 내용을 테스트 릴리스에 포함할 준비가 되면 끌어오기 요청을 사용하여 기본 분기에 병합됩니다. 끌어오기 요청을 완료하려면 먼저 Azure DevOps 유효성 검사 파이프라인을 성공적으로 완료하고 끌어오기 요청을 검토해야 합니다.

3. 끌어오기 요청이 자동화된 검사를 통과하고 검토 승인을 받으면 주 분기에 병합할 수 있습니다. 이 병합은 관리되는 빌드를 테스트 Power Platform 환경에 게시하는 테스트 Azure DevOps 빌드 파이프라인을 트리거합니다.

4. 내부 테스트 후 Azure DevOps 프로덕션 파이프라인이 수동으로 트리거되어 프로덕션 Power Platform 배포를 생성합니다.

5. 릴리스가 준비되면 릴리스 Azure DevOps 파이프라인은 릴리스 정보 및 빌드 자산을 포함한 초안 릴리스를 만듭니다. 최종 릴리스 빌드는 열려 있는 모든 문제를 닫고 마일스톤을 닫습니다. 게시된 빌드 태그는 월 및 연도 레이블이 적용된 GitHub 리포지토리에 태그입니다.

{{</slide>}}
