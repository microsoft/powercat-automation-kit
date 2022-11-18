---
title: "작성 지침"
description: "자동화 키트 - 문서 작성 지침"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Documentation', 'Guidelines']
generated: ED14A36CD731A55AE5FC328528A10CB645825C47
---

다음 섹션에서는 시작 설명서 작성에 대한 지침과 참고 사항을 간략하게 설명합니다.

{{<toc>}}

## 지침

다음 섹션에서는 기여 작성을 위한 기술, 디자인 및 결과 기반 지침을 간략하게 설명합니다.

## 목표

문서를 작성할 때 독자가 다음을 수행할 수 있도록 하는 방법을 고려하는 것이 중요합니다. **성공의 구덩이에 빠지다**.

브래드 에이브람스 정의 [2003년 성공의 구덩이](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) 만큼

> 성공의 구덩이 : 정상, 봉우리 또는 많은 시련을 통해 승리를 찾기 위해 사막을 가로 지르는 여행과는 완전히 대조적입니다.
> 그리고 놀라움, 우리는 고객이 단순히 성공적인 관행에 빠지기를 원합니다.
> 우리의 플랫폼과 프레임 워크를 사용하여. 우리가 곤경에 빠지기 쉽게 만드는 정도까지 우리는 실패합니다.

이 목표를 감안할 때 다음을 고려하십시오.

- "절벽 없음 경험" 제공

  - 관리자 및 중앙 거버넌스 팀이 {{<product-name>}}

  - 사용자가 개발 환경을 사용하여 중앙 환경을 사용할 수 없고 {{<product-name>}}

  - 쉬운 설정으로 평가판 환경 사용에 대해 논의하여 {{<product-name>}}

- 피드백을 위한 채널을 제공합니다. 고객이 개선할 수 있는 사항에 대한 의견을 제공할 수 있는 옵션 제공

### 소스 제어

- 완료했습니다 [문서조사](/ko/contribution/documentation) 변경 사항을 다운로드하고 GitHub 리포지토리에 푸시하는 단계
- 새 변경 내용이 새 분기로 푸시되고 변경 내용을 검토하기 위한 끌어오기 요청이 있습니다.
- 모든 문서는 markdown, JSon 또는 버전 제어가 될 수 있고 표준 끌어오기 요청 프로세스를 사용하여 검토할 수 있는 정적 자산이어야 합니다.

## 디자인 지침

### 홈페이지

- 스타터 경험의 목적을 설명하는 명확한 제목과 부제목이 있어야 합니다.
- 다른 관련 이벤트를 포함하도록 클릭 유도문안을 제공합니다. 예를 들어 근무 시간에 등록하십시오.
- 새 사용자의 온보딩을 돕기 위한 기본 작업으로 시작하기 작업에 연결
- 사용자 커뮤니티를 구축하는 데 도움이 되는 근무 시간에 참여하는 보조 작업
- 일반적인 작업의 타일 포함
- 사용자가 하이퍼오토메이션 프로젝트를 관리하는 데 도움이 되는 기능 요약 목록
- 공통 링크에 대한 바닥글 탐색.

읽기 [사이트 구성](/ko/contribution/site-configuration) 홈 페이지 구성에 대한 자세한 내용은.

### 재이용

- hugo 레이아웃을 사용하여 새 테마를 지정하거나 사이트 \ 레이아웃 폴더에 콘텐츠를 배치하여 현재 테마를 재정의 할 수 있습니다.
- 레이아웃을 변경하면 정적 HTML을 여러 호스팅 위치에 포함할 수 있습니다. 예를 들어

  - 깃허브 페이지
  - 파워 페이지
  - 공유 포인트
  - Azure Static Websites

- 이 접근 방식은 파트너 또는 고객이 {{의 영양 단계를 가속화하기 위해 "문서 팩"을 빌드하는 템플릿으로 사용할 수 있습니다.<product-name>}} 문서
- 설명서의 여러 사용자에게 기능 제공(예: 고객 및 파트너 우수 센터 팀)
- 사용자 제공 콘텐츠를 포함하도록 허용
- {{에서 새 변경 내용을 가져올 수 있는 업그레이드 프로세스 허용<product-name>}} 시작 문서

## 마크다운 페이지

- 당신은 사용할 수 있습니다 [비주얼 스튜디오 코드](https://code.visualstudio.com/) 마크다운 파일을 편집하려면

- 마크다운 파일은 /site/content 폴더에 있어야 합니다.

- 각 마크다운 파일에는 각 페이지에 공통 헤더가 포함되어야 합니다.

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- 마크다운 파일은 단축 코드를 사용하여 자바스크립트를 포함해야 합니다.

## 단축 코드

단축 코드는 마크다운 페이지에 동적 콘텐츠를 포함할 수 있는 기능을 제공합니다. 단축 코드에 대한 자세한 내용은 [휴고 단축 코드 문서](https://gohugo.io/content-management/shortcodes/)

이 프로젝트에는 추가 단축 코드도 포함되어 있습니다.

### 목차

추가 **목차** Markdown에 대한 단축 코드를 따라 페이지에 Markdown 헤더의 목차를 포함합니다. \{\{ 및 \}\}

```html
<toc/>
```

### 질문

페이지에 다음과 같은 일련의 질문을 포함합니다. \{\{ 및 \}\}

```html
<questions name="/content/en-us/foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

매개 변수:

- **이름** 가져올 질문이 포함된 JSon 파일의 이름입니다. 읽다 [질문](/ko/contribution/questions) 질문 파일 형식에 대한 자세한 내용
- **완료** 질문이 완료될 때 표시할 텍스트
- **내비게이션 버튼 표시** 신발에 대한 참/거짓 값 다음/뒤로/완료된 탐색 단추

### 외부 이미지

외부 소스의 크기 이미지를 다음으로 둘러싸인 페이지에 포함합니다. \{\{ 및 \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

매개 변수:

- **증권 시세 표시기** 가져올 이미지의 원본 경로
- **크기** 소스 이미지의 크기를 조정할 크기(픽셀)입니다.
- **문자 메시지** 이미지에 포함할 대체 텍스트

## 노트

### 깃허브 페이지 설정

사이트의 GitHub 페이지를 설정하는 데 사용되는 다음 단계

1. git에서 새로운 고아 분기를 만들었습니다.

    ```bash
    git checkout --orphan gh-pages
    ```

1. 기존 콘텐츠(파일 및 폴더) 지우기

    ```bash
    git clean -d -f
    ```

1. 휴고가 설치되었습니다.

    - 창문에 초콜릿으로 설치할 수도 있습니다.
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. /docs 폴더로 출력하도록 구성된 Hugo 출력

1. 변경 내용 테스트

    ```bash
    hugo serve
    ```

1. 사이트 폴더 안에 정적 html 사이트를 구축하려면 다음 명령을 실행하십시오.

    ```bash  
    hugo
    ```
 
1. gh 페이지 브랜치를 GitHub로 푸시하십시오.

1. 페이지를 사용하도록 GitHub 프로젝트 설정

    - GitHub 페이지 사이트에 대한 게시 원본 구성 - GitHub 문서 참조
    - 선택한 gh-pages 분기 및 /docs 폴더

### 홈페이지 이미지 배지 업데이트

홈페이지 이미지를 상태로 사용자 지정하려면: 공개 미리 보기 배지 다음을 수행합니다.

1. svg 배지 저장소 복제

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. 모듈 설치

    ```bash
    npm install
    ```

1. 웹 서버를 시작하여 배지 생성

    ```bash
    npm run start
    ```

1. 배지 생성

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. SVG 배지 다운로드

1. 잉크스케이프를 사용하여 기존 svg 편집 및 결과 저장

1. 정적 \ 이미지 \ 일러스트레이션 폴더에 새 이미지 업로드

1. config.yaml 영웅 이미지 변경

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## 질문과 답변

### **질문** 휴고가 선택된 이유는 무엇입니까?

[휴고](https://gohugo.io/) 는 {{<product-name>}} GitHub 페이지에서 호스팅할 수 있는 정적 HTML로 변환할 시작 문서

### **질문** 다른 정적 사이트 생성기를 선택하지 않은 이유는 무엇입니까?

핵심 Power CAT 팀은 이전에 Hugo를 사용한 경험이 있었습니다.

### **질문** Microsoft Forms가 질문에 사용되지 않은 이유는 무엇입니까?

한 가지 디자인 목표는 질문 프로세스를 콘텐츠에 직접 통합하는 것이 었습니다.

### **질문** 콘텐츠를 호스팅하기 위해 GitHub 페이지를 사용하는 이유는 무엇인가요?

에 대한 소스 코드 {{<product-name>}} GitHub에 이미 있으며 기본 GitHub 페이지 지원은 콘텐츠를 호스팅할 위치의 한 가지 선택이었습니다.

### **질문** 이 콘텐츠가 켜져 있지 않은 이유 [http://learn.microsoft.com]()?

- 콘텐츠가 일반적으로 재사용 가능한 지침으로 성숙해짐에 따라 다음으로 마이그레이션될 수 있습니다. [https://learn.microsoft.com]()

- 주요 디자인 목표는 GitHub 호스팅을 통해 활성화됩니다.

   - 적극적인 커뮤니티 기여 허용
   
   - 고객 및 파트너 커뮤니티에서 문서를 재사용할 수 있도록 Center of Excellence의 Nuture 프로세스를 육성합니다.

### **질문** 접근 방식이 다른 Power CAT 프로젝트에 적용되지 않는 이유는 무엇입니까?

그 {{<product-name>}} 는 기존 문서를 보완하고 연결하기 위해 이 문서 채널을 실험하고 있습니다. [학습 내용](https://aka.ms/automation-kit-learn). 이 실험의 피드백과 결과에 따라 다른 Power CAT 관리 프로젝트에서 유사한 접근 방식을 채택할지 여부를 평가합니다.

### **질문** 미해결 문서 문제를 보려면 어떻게 해야 합니까?

당신은 우리를 방문 할 수 있습니다 [문서 열기 문제](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) 페이지

### **질문** 새로운 문서 기능 요청을 제기하려면 어떻게 해야 합니까?

새로 만들기 [기능 요청](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
