---
title: "RPA 마이그레이션"
description: "자동화 키트 - RPA 마이그레이션"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Migration', 'Guidance']
generated: 42940454F8C75C0160E5E7D94767DD18DFFC13C6
---

{{<toc>}}

<br/>

그 {{<product-name>}} **마이그레이션 모듈** 마이그레이션 여정을 가속화하기 위해 고객과의 계약을 기반으로 입증된 도구 및 지침 집합을 제공합니다. Microsoft Power Platform, Microsoft Azure 및 광범위한 Microsoft Cloud 서비스의 강점을 활용하여 다음을 수행할 수 있습니다.

- 비용 절감을 제공한다는 목표를 실현하십시오.

- 지속적인 사용을 위한 작업 모델을 계획, 마이그레이션, 모니터링 및 설정하기 위한 가드레일을 제공합니다.

- 마이그레이션 요구 사항을 충족하기 위해 프로세스에 맞게 사용자 지정할 수 있는 변환 샘플을 활용합니다.

## RPA 마이그레이션 시작하기

![비즈니스 리더를 위한 로봇 프로세스 자동화(RPA) 마이그레이션 가이드.](https://msflowblogscdn.azureedge.net/wp-content/uploads/2022/01/RPAWhitepaper_Img-241x300.png)

다음 링크를 사용하여 Microsoft Power Platform의 RPA 마이그레이션 프로세스를 이해할 수 있습니다.

- [파워 오토메이트로 RPA 접근 방식을 현대화하는 입증된 방법](https://powerautomate.microsoft.com/blog/proven-methods-to-modernize-your-rpa-approach-with-power-automate/)

- 다운로드 가능한 백서 [비즈니스 리더를 위한 로봇 프로세스 자동화(RPA) 마이그레이션 가이드.](https://aka.ms/PAD/RPAMigrationWhitepaper)

## 초점 분야

다음 목록에서는 마이그레이션에 사용할 수 있는 구성 요소를 개선할 수 있도록 Automation Kit에 포함하기 위해 우선 순위를 지정하는 영역에 대한 개요를 제공합니다.

> 참고: 이러한 초점 영역은 크게 변경될 수 있습니다. 이러한 변경 사항이 발생합니다. 지속적으로 피드백을 받고 고객의 요구를 충족하기 위해 기능의 우선 순위를 지정합니다.

### 계획

- **평가** 계획 단계에서 자동화 인벤토리에서 마이그레이션하여 최상의 초기 효과를 제공할 자동화 솔루션을 식별하는 데 도움이 되는 구성 요소입니다.

### 관리 및 거버넌스

- **투자 수익** 이해 관계자가 마이그레이션 프로세스에 참여하고 그 영향을 측정할 수 있도록 작업 마이그레이션 프로그램의 투자 수익을 수집하고 모니터링하기 위한 프레임워크입니다.

- **거버넌스** 응용 프로그램 수명 주기, 문서화 및 마이그레이션된 솔루션의 지속적인 운영 모니터링을 지원하는 구성 요소 및 지침 집합입니다.

### 변환

- **클라우드 통합** 솔루션을 Power Platform Microsoft 클라우드로 마이그레이션하기 위해 변환 프로세스를 가속화하는 데 사용할 수 있는 샘플 구성 요소입니다.

- **비 기능 요구 사항** 품질 테스트 접근 방식, DevOps 모니터링, 마이그레이션된 솔루션 문서화

### 자동화 우수 센터

Power Automation 마이그레이션을 자동화 우수 센터에 연결하면 자동화 키트 및 ALM 가속기와 겹치는 마이그레이션 개발자 기술 집합이 있습니다.

![자동화 우수 센터](/images/illustrations/automation-kit-migration.svg)

#### 마이그레이션 개발자

마이그레이션 개발자 프로세스를 구체적으로 살펴보기

{{<border>}}

![자동화 우수 센터 - 마이그레이션 개발자](/images/illustrations/automation-kit-migration-developer.svg)

{{</border>}}

##### 평가 및 계획

평가 및 계획은 다음을 사용하여 기존 자동화 투자에 대한 무료 스캔으로 시작됩니다. [블루프린트 시스템](https://www.blueprintsys.com/) 현재의 복잡성과 범위를 결정합니다. 이 정보를 사용하면 Power Automate 데스크톱으로 마이그레이션할 수 있는 초기 자동화 솔루션 집합을 계획하는 데 도움이 됩니다.

##### 이주하다

원본 마이그레이션 시스템에서 동등한 Power Automate 데스크톱 작업으로 마이그레이션하는 프로세스입니다. 마이그레이션 개발자가 검토하고 업데이트해야 하는 모든 작업은 남은 작업을 쉽게 식별할 수 있도록 TODO 주석으로 표시됩니다.

##### 빌드 완료

식별된 TODO 주석을 사용하여 마이그레이션 개발자는 나머지 마이그레이션 단계를 완료하여 솔루션이 Power Automate 데스크톱 내에서 작동하도록 합니다.

##### 배포 프로세스

ALM Accelerator 솔루션을 사용하여 유효성 검사가 적용된 개발 환경에서 프로덕션 환경으로 이동하여 TODO 항목이 제거되고 대상 시스템 검사 및 DLP 검사가 적용되었는지 확인할 수 있습니다.

유지 관리 관점에서 지속적인 DLP 거버넌스 및 유효성 검사 규칙을 계속 적용하여 배포된 솔루션을 미세 조정하고 업데이트할 수 있습니다.

#### 다른 레이어

마이그레이션 모듈은 ALM, 인프라 구성 요소, 보안 및 거버넌스, 운영 보고 및 분석을 지원하는 기존 지침 및 도구를 기반으로 합니다.