---
title: "スケジューラ"
description: "自動化キット - スケジューラ"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 74448AAD8893663688F10D12DCCC2009D386B0CE
---

{{<toc>}}

## 紹介

Automation Kit スケジューラを使用すると、Power Automate デスクトップ フローへの呼び出しを含むソリューション内の定期的な Power Automate クラウド フローのスケジュールを表示できます。

この機能は、[2023年3月号](/ja/releases/march-2023)、今後のリリースでは、スケジューラの機能が改善され、拡張されます。

{{<border>}}
![スケジューラ](/images/schedule.png)
{{</border>}}

スケジューラの主な機能は次のとおりです。

-定期的なクラウドフローのスケジュールを表示する機能
-コンピュータとコンピュータグループによるスケジュールのフィルタ
-Power Automate デスクトップ フローを実行する
-日、週、月、スケジュールビューでスケジュールを表示
-スケジュールされたフローの状態を表示する (成功、失敗、またはスケジュール済み)
-クラウド・フローの実行時間の表示
-エラーの詳細を表示します。

## クラウドフロー

前述のように、ソリューションの一部として含まれるクラウド フローのみ。最近の[https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/)クラウド フローがソリューションに含まれるようにするために、「既定の Dataverse ソリューション」の新しいプレビューを使用する方法に関する情報が含まれています。この機能を使用すると、ユーザーは、作成されたスケジュールされたクラウド フローがスケジューラに表示されるようにすることができます。

## カレンダービュー

## 日、週、月のビュー

日、週、月のビューには、実行された、または実行がスケジュールされているDesktop Cloudフローの実行に関する情報が表示されます。

アイテムは次のように色分けされています。

-緑は実行が成功したことを示します

-赤は実行の失敗を示します

-青は、スケジュールされた将来の実行を示します。

ステータスと実行情報は、イベントを長押しするか、マウスをホバーすることで確認できます。

### 計画

{{<border>}}
![スケジューラ - 今すぐ実行](/images/scheduler-schedule-view.png)
{{</border>}}

スケジュール ビューには、現在の時刻からの時間に基づく一連のクラウド フローと、今後数日間の将来のスケジュールされたフローが含まれます。

## 今すぐ実行

{{<border>}}
![スケジューラ - 今すぐ実行](/images/scheduler-run-now.png)
{{</border>}}

現在のバージョンの [今すぐ実行] では、Power Automate デスクトップが実行されます。デスクトップ フローの実行に必要なパラメーターがないことを前提としています。追加の実行情報は、デスクトップの最終実行情報で確認できます。

### 計画変更

今後のリリースでは、次の機能が新機能として検討されます。

1.デスクトップ フローではなくクラウド フローを実行します。これには、クラウド フローの実行履歴と実行、デスクトップ フローに渡される追加のクラウド フロー アクションとパラメーターが含まれます。

2.デスクトップとクラウドのフロー実行ページを開きます。

### スケジュールされたフローの読み取り専用動作

既定では、フローが将来の実行にスケジュールされると、フローは読み取り専用モードに設定され、すぐに実行できないように無効になります。つまり、ユーザーは、スケジュールされた日時が経過するまでフローを変更または実行できません。この動作は、ユーザー エクスペリエンスを向上させ、フローが実行される前に誤って実行されるのを防ぐように設計されています。
このアプローチには、次のようないくつかの利点があります。

-偶発的な実行の防止: 将来の実行がスケジュールされているフローの即時実行を無効にすることで、ユーザーがフローを実行する前に誤って実行する可能性が低くなります。

-予測可能性の向上: 将来の実行がスケジュールされているときにフローを読み取り専用モードに設定することで、ユーザーはフローがいつ実行されるかをより簡単に予測し、必要な入力とリソースの準備ができていることを確認できます。

-一貫したユーザーエクスペリエンス: スケジュールされたフローの動作を標準化することで、Flowのすべてのインスタンスで一貫性のある予測可能なユーザーエクスペリエンスを提供できます。

-スケジュールされたフローを変更または実行するために、ユーザーはフローを編集し、スケジュールされた日時を更新できます。新しいスケジュールが設定されると、フローは再び無効になり、すぐに実行され、新しいスケジュールが経過するまで読み取り専用モードに設定されます。

## エラー メッセージ

実行フローの実行時に発生する可能性のあるエラーメッセージ。

### エラー メッセージ: "無効な引数 - 指定された接続参照に関連付けられている有効な接続が見つかりません。

#### 形容

このエラー メッセージは、通常、コードまたは構成で提供される接続参照に問題があることを示します。システムは、参照に関連付けられた有効な接続を見つけることができないため、要求されたアクションを実行できません。

#### 原因

このエラー メッセージには、次のようないくつかの原因が考えられます。

-正しくない、または無効な接続参照: 指定された接続参照が無効または正しくない可能性があり、システムがそれに関連付けられている有効な接続を見つけることができない可能性があります。

-接続が削除または変更されました: コードまたは構成で使用されている接続が削除または変更された場合、参照に関連付けられている有効な接続が見つからない可能性があります。

-アクセス許可の問題: コードまたは構成を実行しているユーザー アカウントに、接続またはそれに関連付けられているリソースにアクセスするために必要なアクセス許可がない可能性があります。

#### 解決

この問題を解決するには、次の手順を実行します。

-接続参照を確認する: コードまたは構成で提供されている接続参照を確認し、有効で正しいことを確認します。

-既存の接続を削除して再作成する: フローチェッカーが、接続参照が使用されていないことを警告する場合は、フローチェッカーを使用して既存の接続を削除できます。接続が削除されたら、マシンまたはマシングループへの接続参照を再作成して、フローを実行できるようにすることができます。

## 筆記

現在のリリースでは、次の注意事項が適用されます。

1.ソリューションに含まれる Power Automate デスクトップ ソリューションと Power Automate ソリューションのみが表示されます。
1.少なくとも 1 つの Power Automate デスクトップが登録され、実行されている

## 取り付ける

スケジューラ ソリューションをインストールするには、次の操作を行います。

1.Power Apps コンポーネント フレームワークが有効になっていることを確認する<a href="https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">続きを読む</a>
1.これで、クリエイターキットがターゲット環境にインストールされました。<a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">アプリソースからインストール</a>
1.最新のアセットセクションからAutomationKit.zipファイルをダウンロードしました<a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub リリース</a>
1.最新のオートメーションキットスケジューラをインポートしておきます。_*_管理.zipファイルを使用します。<a href='https://learn.microsoft.com/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">続きを読む</a>

## ロードマップ

あなたは私たちを訪問することができます<a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub の問題</a>をクリックして、提案された新機能を表示します。

新しい<a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">スケジューラ機能要求</a>

## フィードバック

{{<questions name="/content/ja/features/scheduler.json" completed="フィードバックをお寄せいただきありがとうございます" showNavigationButtons="false" locale="ja">}}