---
title: "Process Advisor統合"
description: "オートメーションキット - Process Advisor統合"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Process Advisor', 'Integration', 'RPA']
generated: 1314509EA465891ED5914448D4EC119A8218FE57
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

2. More information on configuring your Process Advisor analysis with a custom workspace can be found in [Load your process analytics in power bi](https://learn.microsoft.com/power-automate/process-mining-pbi-workspace#load-your-process-analytics-in-power-bi)

### Power Automate Templates

You could use out of the box Power BI connector actions and Power Automate cloud flows to create or update you Automation Kit projects.

## Questions

{{<questions name="/content/en-us/backlog/process-advisor-integration.json" completed="Thank you for completing Process Advisor questions" showNavigationButtons=false />}}

{{<product-name>}} は[Process Advisor](https://learn.microsoft.com/power-automate/process-advisor-overview)次のシナリオをサポートします。

- **鉱業の処理**ビジネスケースを特定してサポートするためのビジネスプロセスの分析 データ分析によってサポートされる自動化プロジェクトを作成します。

- **データ駆動型自動化プロジェクト要求** プロセス分析の結果を使用して、Process Advisor結果から自動化プロジェクトを作成します。

- **半自動自動化プロジェクト作成** Process Advisor とオートメーション キットの間で Dataverse データを統合して、オートメーション プロジェクトを作成する作業量を削減します。

- **パワーオートメーションデスクトップの分析**RPAプロセスデータを分析して、タスクマイニングを使用してモダナイズ、回復力と信頼性を向上させるための改善点を特定します。

## 鉱業の処理

Process Advisorでプロセスマイニングを使用すると、組織全体のプロセスの非効率性を発見できます。これらの分析情報により、記録システム (プロセスで使用するアプリ) から取得できるイベント ログ ファイルを使用して、プロセスを深く理解できます。プロセスマイニングは、パフォーマンスの問題を認識するためのデータとメトリックを含むプロセスのマップを表示します。プロセスマイニングに適したプロセスの例としては、売掛金や受注から現金化などがあります。

このデータを使用すると、データ駆動型の自動化プロジェクト要求を作成できます。

## 自動化プロジェクトの作成

Process Advisorプロセスマイニングとレポート作成の結果を使用して、次のProcess Advisor情報を使用して、計算された分析結果を使用して自動化プロジェクトをサポートできますProcess Advisor。

オートメーションキット|Process Advisor|筆記|
