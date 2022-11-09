---
title: 작성 질문
description: 자동화 키트 작성 질문
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---
이 페이지에는 {{<product-name>}} 스타터.

{{<toc>}}

## 시작

키트 시작 페이지에서 사용되는 질문은 다음을 기반으로 합니다. [오픈 소스 설문 조사 JS 라이브러리](https://github.com/surveyjs/survey-library). 이 라이브러리를 사용하면 지원되는 모든 기본 컨트롤을 사용할 수 있습니다.

프레임 워크를 이해하려면 다음을 볼 수 있습니다.

- 그 [설문 조사 JS 문서](https://surveyjs.io/form-library/documentation/overview)

- 다음과 같은 간단한 질문 유형 [문자 메시지](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [라디오 그룹](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [확인란](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) 또는 [순위](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- 조건부 가시성 사용 [보이는 경우](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- 사이트에서 사용되는 기존 질문 중 일부를 검토합니다. 예를 들면 다음과 같습니다. [모니터링 질문](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- 콘텐츠 마크다운에 단축 코드를 포함하는 방법을 검토합니다. 예를 들어 [마크다운 모니터링](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## 콘텐츠에 질문 포함

페이지에 질문 집합을 삽입하려면 마크다운에 다음을 추가하고 이름을 읽으려는 질문 파일로 변경할 수 있습니다.

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

그 {{<product-name>}}에는 표현식 내에서 사용할 수 있는 몇 가지 추가 함수도 포함되어 있습니다.

### 렌

len 함수는 문자열 또는 배열의 길이를 반환합니다.

#### 렌 예제

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### 포함

contains 함수는 문자열 또는 문자열 배열이 제공된 값과 일치하는 경우 true 또는 false를 반환합니다.

#### 포함 예제

선택한 역할 중 하나가 제작자 인 경우 요소가 표시됩니다.

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

선택한 역할 중 하나가 제작자 또는 설계자인 경우 요소를 표시합니다.

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## 사용자 지정 위젯

### 이미지 작업

그 {{<product-name>}}에는 **이미지 작업** 사용자 지정 위젯. 이 위젯은 다음 json 스니펫을 사용하여 질문 요소에 포함될 수 있습니다.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### 속성

- **타이틀** - 사용자에게 표시할 텍스트
- **형** - 이미지 작업이어야 합니다.
- **증권 시세 표시기** - 렌더링할 SVG 파일의 URL

#### 작동 방식

소스 svg 파일은 svg 파일의 요소에 대해 다음과 같은 사용자 지정 하이퍼링크 링크를 지원합니다.

- **template://item/selected** - 이미지에서 선택한 형식을 설정하기 위해 개체의 형식을 정의합니다.
- **template://item/unselected** - 이미지의 선택되지 않은 항목 형식을 설정하기 위해 개체의 형식을 정의합니다.
- **question://question-name/value** - 이미지의 선택되지 않은 항목 형식을 설정하기 위해 개체의 형식을 정의합니다.

하이퍼 링크가 question:// 있는 시각적 요소는 질문 집합 내에서 값 배열을 설정하거나 설정 해제하는 데 사용됩니다. 이 기능은 다른 질문이 사용자에게 표시되는 방식을 대화형으로 변경할 수 있는 기능을 제공합니다. 예를 들어 svg 파일에 다음 하이퍼링크가 있는 두 개의 개체가 있는 경우:

- **question://roles/maker**
- **question://roles/architect**

사용자가 이러한 개체를 선택하면 페이지의 다른 요소가 표시 될 수 있습니다.

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

## 질문과 답변

### **질문** Microsoft Forms 대신 이 접근 방식이 사용된 이유는 무엇입니까?

질문 단축 코드를 사용하면 질문이 별도의 링크가 아닌 각 콘텐츠 페이지의 일부가 될 수 있습니다.

### **질문** 이 접근 방식에는 어떤 이점이 있습니까?

이 방법의 장점은 다음과 같습니다.

- 즉시 사용 가능한 질문 유형을 사용하는 기능

- 질문 생성은 구성 기반이며 JSon에 대한 지식 만 있으면 질문을 작성할 수 있습니다.

- 질문 프레임워크는 확장 가능하여 새로운 기능이나 위젯을 추가할 수 있습니다.

- 질문 정의에 JSon을 사용하면 질문을 소스 제어에 저장하고 시간이 지남에 따라 검토 및 버전을 지정할 수 있습니다.

### **질문** 이 접근 방식을 파워 앱 또는 파워 페이지 내에서 사용할 수 있나요?

물론, 동일한 JavaScript 및 질문 정의를 사용하여 사용할 수 있습니다. [코드 구성 요소](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **질문** SVG 이미지 작업 질문을 작성하려면 어떻게 해야 합니까?

svg 파일을 만드는 한 가지 옵션은 다음과 같습니다. [마이크로소프트 비지오](https://www.microsoft.com/microsoft-365/visio/) WLL 내보내기 다이어그램을 호환되는 필수 하이퍼링크가 있는 SVG 파일로 내보냅니다. **이미지 작업** 질문.

### **질문** Microsoft PowerPoint를 사용하여 이미지 작업 질문 SVG 파일을 내보낼 수 있습니까?

Microsoft 파워 포인트는 슬라이드를 SVG 파일 초기 테스트 신발로 내보낼 수 있지만 대화형을 만드는 데 필요한 하이퍼 링크는 내보내지 않습니다. **이미지 작업** 성공적으로 작동합니다.

### **질문** 내 보낸 SVG 파일이 크면 더 작게 만들 수 있습니까?

SVG 파일을 소스 제어에 커밋하기 전에 더 작게 만드는 한 가지 옵션입니다. SVG의 크기를 줄이는 데 사용할 수 있는 여러 도구가 있으며 고려해야 할 한 가지 옵션은 다음과 같습니다. [스브고](https://github.com/svg/svgo) NodeJs 기반 SVG 최적화 프로그램입니다.
