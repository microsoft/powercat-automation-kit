---
title: "애플리케이션 수명 주기 관리(ALM)"
description: "자동화 키트 - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 7A054C4EE36843CB023C64E2B26C68DDF722666D
---

{{<slideStyles>}}

<div class="optional">

이 페이지에서는 에 포함된 Power Automate 데스크톱 워크플로용 자동화 키트와 함께 ALM을 사용하는 데 도움이 될 수 있는 구성 요소에 대한 개요를 제공합니다. [전력 플랫폼 솔루션](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## 요약

Power Automate 데스크톱 구성 요소를 포함하는 Power Platform 솔루션용 ALM을 살펴보면

1. 관리되는 환경 Power Platform Pipelines의 기능을 검토하여 엔터프라이즈 규모의 제품 내 기능을 활용하여 환경 내에서 솔루션을 관리하고 관리합니다.

<br/>

2. 필요한 경우 [Microsoft Power Platform Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [GitHub Actions for Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) 또는 [파워 플랫폼 CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) ALM DevOps 프로세스를 통합하고 자동화합니다.

<br/>

3. 사용을 고려하십시오 [전력 플랫폼용 ALM 가속기](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). ALM 가속기는 통합 소스 제어 거버넌스를 사용하여 많은 Power Platform ALM 작업을 자동화하는 미리 빌드된 Azure DevOps 템플릿 집합을 제공합니다.

## 파워 캣에서 배우기

또한 Power CAT 팀이 ALM 가속기를 사용하여 배송하는 방법에 대해 자세히 알아볼 수 있습니다. [전원 고양이 자동화 키트 ALM](/ko/features/alm/powercat).

## 리소스

[전력 플랫폼 학습 카탈로그를 위한 ALM 가속기](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## 로드맵

자동화 키트 팀은 ALM 가속기 팀과 협력하여 다음을 다루는 기존 템플릿에 Power Automate 데스크톱 관련 작업을 추가하고 있습니다.

- 파워 오토메이트 데스크톱 정의를 나란히 비교합니다.

- 유효성 검사 규칙은 Power Automate 데스크톱을 확인합니다.

- CI/CD 파이프라인의 일부로 단위, 통합 및 시스템 테스트 실행.

우리의 검토 [자동화 키트 ALM 관련 백로그](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## 피드백

{{<questions name="/content/ko/features/alm.json" completed="피드백을 제공해 주셔서 감사합니다." showNavigationButtons="false" locale="ko">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

관리되는 환경은 규모에 맞게 거버넌스를 간소화하고 간소화할 수 있는 기능을 제공합니다. 관리자는 몇 번의 클릭만으로 관리형 환경을 활성화하고 모든 로우 코드 자산을 관리하는 데 드는 노력을 줄이면서 더 많은 가시성과 더 많은 제어를 제공하는 기능을 즉시 밝힐 수 있습니다.

관리되는 환경은 AI Builder가 제품에 인텔리전스를 주입하고 Dataverse가 데이터 백본을 제공하는 것과 같은 방식으로 Power Platform 제품군의 핵심 부분입니다. 관리되는 환경은 플랫폼의 거버넌스를 대규모로 간소화합니다.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

관리되는 환경은 다음을 제공합니다.

- 홈 페이지의 사용 통찰력, 관리자 다이제스트 이메일, 라이선스 보고서 및 데이터 정책 보기를 통한 가시성 향상
- 공유 제한을 통해 더 많은 제어를 통해 캔버스 앱 및 솔루션 흐름을 공유할 수 있는 범위와 수를 제어할 수 있습니다.
- 제한된 보안 그룹으로 공유를 제한할 수도 있습니다.
- 보안 또는 안정성 검사를 위한 솔루션 검사기를 구성하여 솔루션을 관리되는 환경으로 가져올 때마다 규칙을 자동으로 실행합니다.
- 사용자를 올바른 경로로 안내할 수 있도록 제작자 환영 및 공유 환경을 사용자 지정합니다.
- 몇 번의 클릭만으로 즉시 사용 가능한 단계를 간소화하고 단순화하며 자동화하는 노력이 줄어듭니다. 
- Power 플랫폼 파이프라인은 ALM(애플리케이션 수명 주기 관리) 프로세스를 간소화하는 기능을 제공합니다.

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

이것은 내가 메이커 포털에서 작업하고있는 솔루션입니다.

이미 설정된이 파이프 라인을 선택했습니다. 파이프라인은 기본적으로 한 환경에서 다른 환경으로 작업을 이동하는 일련의 자동화된 단계입니다. 이 파이프 라인은 왼쪽의 개발 환경에서 테스트 환경으로 내 솔루션을 가져옵니다. 그런 다음 테스트에서 프로덕션으로 가져가는 또 다른 단계가 있습니다.

테스트를 위해 배포하고 다음을 선택하고 여기에서 연결을 확인하여 환경을 테스트하여 올바른 자격 증명을 사용하고 있는지 확인합니다. 다음에는 예를 들어 테스트에서 올바른 SharePoint 사이트를 가리키고 있는지 확인하기 위해 환경 변수를 구성하겠습니다. 사이트가 개발에서 사용했던 사이트와 다른 경우 중요합니다. 

모든 것을 설정하면 "배포"를 선택하면 실행 전 유효성 검사가 자동으로 실행되어 올바른 종속성이 있고 솔루션이 해당 대상 환경의 DLP 정책을 위반하지 않습니다. 배포를 실행하기 전에 승인이 필요하도록 파이프라인을 설정할 수도 있습니다. 

여기서 모든 것이 성공한 것 같습니다.

파이프라인을 실행한 후에는 모든 솔루션을 백업하고 버전을 지정한 조직 전체의 배포에 대한 완전한 가시성과 감사 추적을 얻을 수 있습니다.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

기능은 단계적으로 출시될 예정입니다. 관리자 다이제스트 및 공유 제한과 같은 일부는 현재 사용할 수 있습니다. 나머지는 연말까지 출시될 예정입니다.

앞으로 몇 주 또는 몇 달 안에 홈 페이지에서 사용 인사이트를 볼 수 있습니다. 관리자 다이제스트의 새로운 추세 및 사용이 허가된 사용에 대한 보고서입니다. 제한을 공유하면 더 많은 제어가 가능하고 솔루션 흐름을 지원할 수 있습니다. 솔루션 검사기를 사용하여 안전하지 않은 배포를 차단할 수 있습니다. 고객 제작자 온보딩 및 파이프라인 기능도 올해 말에 제공될 예정입니다.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

Power 플랫폼에서 ALM을 선택할 때 고려해야 할 여러 가지 옵션이 있습니다. 관리되는 환경 Power Platform 파이프라인은 제품 응용 프로그램 수명 주기 관리를 제공합니다.

필요에 따라 다음과 결합된 관리되는 환경 Power Platform 파이프라인의 확장 지점을 사용할 수 있습니다. [Azure DevOps를 위한 Power Platform Build Tools](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [GitHub Actions for Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) 또는 [파워 플랫폼 CLI](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction) 을 사용하여 사용자 지정 ALM DevOps 프로세스를 롤링할 수 있습니다.

마지막으로 당신은 활용할 수 있습니다 [전력 플랫폼용 ALM 가속기](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) CoE 키트에서 Azure DevOps를 사용하여 엔드투엔드 ALM에 대한 미리 빌드된 템플릿 및 샘플을 제공합니다. ALM 가속기는 여러 환경에서 솔루션을 빌드하고 제어할 수 있는 많은 일반적인 시나리오를 제공합니다.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

파워 플랫폼용 ALM 가속기란 무엇입니까?

Power Platform용 ALM 가속기에는 Azure DevOps 파이프라인 및 Git 원본 제어 위에 있는 Power Apps가 포함되어 있습니다. 이 앱은 제조업체가 Power Platform 솔루션의 구성 요소를 소스 제어로 정기적으로 내보내고 배포 요청을 생성하여 대상 환경에 배포하기 전에 작업을 검토할 수 있는 간소화된 인터페이스를 제공합니다.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

ALM 액셀러레이터 워크플로를 살펴보면 개발 환경에서 시작합니다. ALM 프로세스와의 상호 작용은 ALM 가속기 캔버스 앱 또는 관리되는 환경 파이프라인을 통해 이루어집니다.

제작자는 ALM 액셀러레이터 캔버스 앱을 사용하여 소스 제어에서 솔루션 가져오기, 소스 제어로 변경 사항 내보내기, 변경 내용 병합을 위한 풀 요청 만들기와 같은 ALM 작업을 수행합니다.

Azure DevOps 파이프라인용 ALM 가속기 템플릿은 ALM 가속기 캔버스 앱과의 제작자 상호 작용을 기반으로 ALM 작업의 자동화를 용이하게 합니다.

ALM Accelerator에는 프로덕션에 대한 3단계 배포를 지원하는 파이프라인 템플릿이 포함되어 있습니다.
템플릿은 특정 요구 사항과 시나리오에 맞게 사용자 지정할 수 있습니다.

Power 플랫폼용 ALM 가속기는 Azure DevOps 파이프라인 위에 위치하여 제조업체가 Power 플랫폼에서 개발 작업에 대한 끌어오기 요청을 정기적으로 커밋하고 만들 수 있는 간소화된 인터페이스를 제공하는 캔버스 앱입니다. 

Azure DevOps 파이프라인과 캔버스 앱의 조합은 Power Platform 솔루션용 전체 ALM 가속기를 구성합니다. 
파이프라인과 앱은 참조 구현입니다. 내부적으로 CoE 스타터 키트용 개발 팀에서 사용하기 위해 개발되었지만 Power 플랫폼에서 ALM을 얼마나 건강하게 달성할 수 있는지 보여주기 위해 오픈 소스 및 릴리스되었습니다. 있는 그대로 사용하거나 특정 비즈니스 시나리오에 맞게 사용자 지정할 수 있습니다.

{{</slide>}}
