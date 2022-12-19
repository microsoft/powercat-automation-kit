---
title: "설치하다"
description: "자동화 키트 - 설치"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 458A6A6E57855817B73D18C0F0A5855DDAFC40DE
---

최신 버전의 자동화 키트를 설치하려면 아래 단계를 따르십시오. 명령줄 도구를 사용할 수 없는 경우 에 설명된 수동 단계를 사용할 수 있습니다. [설정 지침](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. 다음이 있는지 확인하십시오. <a ref='https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">Power Apps 구성 요소 프레임워크 기능 사용</a> 기본 및 위성 환경 모두에 대해 자동화 키트를 설치하려는 환경에서.

1. 다음을 확인합니다. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">크리에이터 키트 설치됨</a> 설치하려는 환경 모자로

1. 에서 최신 릴리스를 엽니다. <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">자동화 키트 GitHub 릴리스</a>

1. 다운로드 **자동화키트설치.zip** 자산 섹션에서

1. Windows 탐색기에서 다운로드 한 **자동화키트설치.zip** 을 클릭하고 속성 대화 상자를 엽니다.

1. 선택 **차단을 해제** 단추

1. 고르다 **자동화키트설치.zip** 상황에 맞는 메뉴를 사용하여 **모두 추출**

1. 당신이 가지고 있는지 확인하십시오 <a href="https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> 설치

1. 다음 명령줄을 사용하여 powershell 스크립트를 실행합니다.

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

메모:
1. PowerShell 실행 정책에 따라 다음 명령을 실행해야 할 수 있습니다.

```cmd
Unblock-File Install_AutomationKit.ps1
```

1. PowerShell 스크립트는 다음을 사용하여 설치 구성 파일을 만들라는 메시지를 표시합니다. [설치 프로그램 설치](/ko/get-started/setup). 설치 구성 페이지에서는 다음을 제공합니다.

    - 기본 또는 위성 솔루션에 대한 구성 선택
   
    - 보안 그룹에 할당할 사용자 선택
   
    - 솔루션을 설치하는 데 필요한 연결 만들기
    
    - 환경 변수 정의
    
    - 선택적으로 샘플 데이터를 가져와야 하는지 정의
    
    - 선택적으로 Power Automate 사용 솔루션에 포함된 흐름을 사용하도록 설정해야 합니다.

1. 설정을 완료한 후 **automation-kit-main-install.json** 또는 **automation-kit-satellite-install.json** 파일에 **자동화키트설치** 위의 폴더

1. 파일이 다운로드되면 스크립트는 **y** 기본 솔루션을 설치하려면 **n** 위성 솔루션을 설치하려면

1. 그러면 설치가 업로드되고 정의된 설정으로 설치가 시작됩니다.

## 피드백

에 대한 피드백을 제공하고 싶습니다. [설정 프로세스](/ko/get-started/setup)? 아래 질문은 프로세스를 개선하는 데 도움이 됩니다.

{{<questions name="/content/ko/get-started/setup-feedback.json" completed="피드백을 제공해 주셔서 감사합니다." showNavigationButtons=true locale="ko">}}
