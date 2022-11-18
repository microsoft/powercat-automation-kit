---
title: "Process Advisor 통합"
description: "자동화 키트 - Process Advisor 통합"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Process Advisor', 'Integration', 'RPA']
generated: A51CC6A1EB6E9681ED2302F8F389D50BCC752BB6
---
--------------|---------------|-------------|
Duration Total (Total Processing Time in minutes)|Duration Total Per activity|Top-level metrics currently only median and average duration which can be transformed with some customization
Case frequency| (volume per process frequency)|Case count||
Resource count (Number of FTEs needed, Number of FTEs needed for Review/Rework)|Resource count
Rework percentage (AVG Error Rate %)|Rework percentage||
Currency||In Process Advisor data model

## Semi Automated Automation Project

Using the data collected in the Process Advisor in your Power BI custom workspace you can integrate the results using Power Automate or Power Apps.

![Automation Kit Process Advisor Integration](/images/illustrations/process-advisor-integration.svg)

Using the Process Advisor Import process simplifies the amount of information that needs to be entered and offers you a choice of options to integrate with you Automation Project.

Reviewers of the Automation Project and take into account the Process Advisor results when considering if they should Approve or Deny the Automation Project request.

NOTE:

1. We currently have items on the Automation Kit backlog to add additional templates and applications in upcoming milestones that enable you quickly get started with integrating your Processed Advisor data with the Automation Kit.

2. More information on configuring your Process Advisor analysis with a custom workspace can be found in [Load your process analytics in power bi](https://learn.microsoft.com/en-us/power-automate/process-mining-pbi-workspace#load-your-process-analytics-in-power-bi)

### Power Automate Templates

You could use out of the box Power BI connector actions and Power Automate cloud flows to create or update you Automation Kit projects.

## Questions

{{<questions name="/content/en-us/backlog/process-advisor-integration.json" completed="Thank you for completing Process Advisor questions" showNavigationButtons=false >}}

그 {{<product-name>}} 와 통합 [Process Advisor](https://learn.microsoft.com/en-us/power-automate/process-advisor-overview) 다음 시나리오를 지원합니다.

- **가공 마이닝** 비즈니스 프로세스 분석을 통해 비즈니스 사례를 식별하고 지원하여 데이터 분석으로 지원되는 자동화 프로젝트를 만듭니다.

- **데이터 기반 자동화 프로젝트 요청** 공정 해석 결과를 사용하여 Process Advisor 결과에서 자동화 프로젝트를 생성합니다.

- **반자동 자동화 프로젝트 생성** Process Advisor와 자동화 키트 간에 Dataverse 데이터를 통합하여 자동화 프로젝트를 만드는 작업량을 줄입니다.

- **파워 오토메이트 데스크톱 분석** RPA 프로세스 데이터를 분석하여 태스크 마이닝을 사용하여 현대화, 복원력 및 안정성을 개선하기 위한 개선 사항을 식별합니다.

## 가공 마이닝

Process Advisor와 함께 프로세스 마이닝을 사용하면 조직 전체 프로세스의 비효율성을 발견할 수 있습니다. 이러한 통찰력을 통해 기록 시스템(프로세스에서 사용하는 앱)에서 가져올 수 있는 이벤트 로그 파일을 사용하여 프로세스를 심층적으로 이해할 수 있습니다. 프로세스 마이닝은 성능 문제를 인식하기 위해 데이터 및 메트릭과 함께 프로세스의 맵을 표시합니다. 프로세스 마이닝에 적합한 프로세스의 예로는 미수금 및 주문 대 현금이 있습니다.

이 데이터를 사용하여 데이터 기반 자동화 프로젝트 요청을 생성할 수 있습니다.

## 자동화 프로젝트 생성

Process Advisor 프로세스 마이닝 및 보고 결과를 사용하면 다음 Process Advisor 정보를 사용하여 계산된 분석 결과를 사용하여 자동화 프로젝트를 지원할 Process Advisor 있습니다.

자동화 키트|Process Advisor|노트        |
