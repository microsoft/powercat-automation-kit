---
title: "위성 - 시작하기"
description: "자동화 키트 - 위성 - 시작하기"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: D34A3BCCCE29730419418EAC4DDC091FAB118A83
---

# 개요

Satellite 솔루션의 시작 페이지에 오신 것을 환영합니다. 이 섹션에서는 2023년 4월 이후 릴리스의 중요한 변경 사항에 대해 설명합니다. 2023년 4월 이후에는 Azure 응용 프로그램 테넌트, 응용 프로그램 ID 및 Azure 응용 프로그램 비밀 정보를 저장하기 위해 Azure 키 자격 증명 모음이 필요하지 않습니다.

## 개념 설계

우리의 학습 페이지는 다음을 간략하게 설명합니다. [개념 설계](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) {{제품 이름}}의. 솔루션의 핵심 요소는 Power Platform 기본 환경입니다.

일반적으로 자동화 프로젝트를 실행하는 여러 위성 프로덕션 환경이 있습니다. 환경 전략에 따라 개발 또는 테스트 환경일 수도 있습니다.

이러한 환경 간에는 클라우드 또는 데스크톱 흐름 원격 분석, 컴퓨터 및 컴퓨터 그룹 사용, 감사 로그를 포함하는 거의 실시간 동기화 프로세스가 있습니다. 자동화 키트에 대한 Power BI 대시보드에 이 정보가 표시됩니다.

## 변경된 사항

해결의 일환으로 [[자동화 키트 - 기능]: 위성 환경에 대한 Azure 키 자격 증명 모음 대안](https://github.com/microsoft/powercat-automation-kit/issues/84) Azure 키 자격 증명 모음은 더 이상 필요하지 않습니다. 이는 설치의 복잡성을 크게 줄이고 자동화 솔루션 관리자를 사용할 때 솔루션 아티팩트를 얻기 위해 보안을 관리하는 방법을 크게 줄여주기 때문에 중요합니다.

## 같은 것은 무엇입니까?

핵심 요소가 이전 2023년 4월 이전 및 2023년 4월 릴리스와 동일하면 Azure Active Directory 애플리케이션이 필요합니다.

안 [응용 프로그램 사용자](https://learn.microsoft.com/power-platform/admin/manage-application-users) 는 시스템 사용자 레코드에 ApplicationId 특성이 있는 것으로 식별되는 Power Platform의 사용자 유형입니다. 응용 프로그램 사용자는 Azure AD(Azure Active Directory)에서 만들어지며 Power Platform 대한 액세스를 인증하고 권한을 부여하는 데 사용됩니다. 일반적으로 사용자 또는 다른 응용 프로그램을 대신하여 데이터에 액세스하거나 Power Platform에서 작업을 수행해야 하는 응용 프로그램 또는 서비스를 나타내는 데 사용됩니다.

특히 응용 프로그램 사용자는 자동화 솔루션 관리자에서 사용자가 배포된 Power Platform 솔루션을 계량할 수 있도록 환경에서 솔루션 구성 요소를 쿼리할 수 있도록 하는 데 사용됩니다.

## 설치하다

그 [명령줄 설치](/ko/get-started/install) 위성 솔루션의 경우 Azure Active Directory 응용 프로그램 이름 및 Azure Active Directory 응용 프로그램 ID를 묻는 메시지가 표시됩니다. 이 정보를 사용하면 다음이 수행됩니다.

1. Azure Active Directory 응용 프로그램을 응용 프로그램 사용자로 추가
1. 시스템 관리자 역할에 응용 프로그램 사용자 추가
1. 응용 프로그램 사용자의 사용자 ID를 환경 변수에 추가 **솔루션 관리자 아티팩트 읽기 사용자 ID**

새 역할 데이터버스 역할 **자동화 솔루션 관리자 사용자** 사용자가 제공된 환경 변수를 사용하여 솔루션 아티팩트를 쿼리하는 새로운 Dataverse GetDataverseSolutionArtifacts 사용자 지정 API를 호출할 수 있도록 추가되었습니다. **솔루션 관리자 아티팩트 읽기 사용자 ID**.

위성 솔루션을 수동으로 설치하려면 다음과 같이 변경해야 합니다. [위성 설정](https://learn.microsoft.com/en-us/power-automate/guidance/automation-kit/setup/satellite) 지시.

1. 2023년 4월 이상에는 더 이상 필요하지 않으므로 "새 클라이언트 암호 추가" 단계를 건너뜁니다.
1. Azure 키 자격 증명 모음에서 비밀을 만드는 단계를 건너뜁니다.
1. 애플리케이션 사용자의 사용자 ID를 **솔루션 관리자 아티팩트 읽기 사용자 ID** 환경 변수.

## 설치 후

자동화 솔루션 관리자 응용 프로그램을 실행할 사용자에게 **자동화 솔루션 관리자 사용자** 데이터버스 보안 역할.

## 이전 릴리스

2023년 4월 릴리스 이전에 Satellite 솔루션을 설치하려면 암호 유형의 환경 변수가 필요했습니다. 이를 위해서는 [Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) 테넌트 ID, 애플리케이션 ID 및 애플리케이션 비밀에 대한 값을 저장합니다. 이 기능을 사용하려면 [전제 조건](https://learn.microsoft.com/en-us/power-apps/maker/data-platform/environmentvariables#prerequisites) Azure Key Vault가 동일한 테넌트인 경우 Microsoft.PowerPlatform을 리소스 공급자로 설정합니다.

2023년 3월 또는 이전 릴리스에서는 Azure 키 자격 증명 모음을 사용하여 테넌트 ID, 앱 적용 ID 및 애플리케이션 비밀을 저장했습니다. 이러한 값을 사용하여 솔루션 구성 요소 목록을 반환할 수 있도록 dataverse를 쿼리하기 위해 액세스 토큰이 요청되었습니다.

## 권장 사항

기존 사용자의 경우 지속적인 관리를 간소화하고 새 기능을 활용하기 위해 기존 위성 설치를 2023년 4월 이상으로 업그레이드하는 Azure Key Vault의 종속성에 대한 필요성을 제거하는 것이 좋습니다.
