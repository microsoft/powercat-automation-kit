---
title: "スケジューラ"
description: "自動化キット - スケジューラ"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 00B15DA73732A60B73A09229CEF9B843E259A121
---

{{<toc>}}

## 紹介

Automation Kit スケジューラを使用すると、Power Automate デスクトップ フローへの呼び出しを含むソリューション内の定期的な Power Automate クラウド フローのスケジュールを表示できます。

この機能は、[2023年2月号](/ja/releases/february-2023)、今後のリリースでは、スケジューラの機能が改善され、拡張されます。

{{<border>}}
![スケジューラ](/images/schedule.png)
{{</border>}}

スケジューラの主な機能は次のとおりです。

-定期的なクラウドフローのスケジュールを表示する機能
-日、週、月、スケジュールビューでスケジュールを表示
-スケジュールされたフローの状態を表示する (成功、失敗、またはスケジュール済み)
-クラウド・フローの実行時間の表示
-エラーの詳細を表示します。

## 筆記

現在のリリースでは、次の注意事項が適用されます。

1.ソリューションに含まれる Power Automate デスクトップ ソリューションと Power Automate ソリューションのみが表示されます。
1.少なくとも 1 つの Power Automate デスクトップが登録され、実行されている

## 取り付ける

スケジューラ ソリューションをインストールするには、次の操作を行います。

1.Power Apps コンポーネント フレームワークを確認する<a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">続きを読む</a>
1.これで、クリエイターキットがターゲット環境にインストールされました。<a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">アプリソースからインストール</a>
1.最新のアセットセクションからAutomationKit.zipファイルをダウンロードしました<a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub リリース</a>
1.最新のオートメーションキットスケジューラをインポートしておきます。_*_管理.zipファイルを使用します。<a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">続きを読む</a>

## ロードマップ

あなたは私たちを訪問することができます<a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub の問題</a>をクリックして、提案された新機能を表示します。

新しい<a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">スケジューラ機能要求</a>

## フィードバック

{{<questions name="/content/ja/features/scheduler.json" completed="フィードバックをお寄せいただきありがとうございます" showNavigationButtons="false" locale="ja">}}
