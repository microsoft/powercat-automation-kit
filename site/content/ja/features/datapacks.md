---
title: "データパック"
description: "オートメーションキット - データパック"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 16D52F35701BF93D5BAB05162D94D9E9866918C6
---

{{<toc>}}

## 紹介

データパックは、インストール済みのオートメーションキットにオプションでインストールして使用を高速化できる、あらかじめパッケージ化されたデータのセットです。

{{<border>}}
![データ パックの概要](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

の一部として導入されました[2022年11月号](/ja/releases/november-2022)の場合、データパックでは、オプションでサンプル データをインポートすることができます。

投資収益率 (ROI) データ パックを使用すると、Automation Kit Power BI ダッシュボードを使用して、投資収益率の計画、測定、監視を迅速に実証できます。最初のデータパックは、[はじめ](/ja#getting-started)以下のセクション。

時間が経過と共に、優先順位付けのために他のデータ パックをバックログに追加し、データ パックをコミュニティに公開するために共同作業を行う方法を文書化します。

## ロードマップ

{{<border>}}
![データパックのロードマップ](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

今後のマイルストーンでは、Automation Kit の自動インストール プロセスのオプションの一部としてデータパックを含めることで、データパックを改善する予定です。

インストールの一部としてデータパックを含める機能により、このリリースのコマンドラインインストールプロセスではなく、Webベースのインストールが可能になります。

## 投資収益率の主なソリューション

投資収益率 (ROI) メイン ソリューション データ パックには、オートメーション プロジェクト、マシン、サンプルの Power Automate デスクトップ テレメトリが含まれているため、エンド ツー エンドのプロセスを体験できます。

### はじめ

このデータ パックの使用を開始するには

-からクリエイターキットをインストールする[アプリソース](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1)または経由[セットアップガイドを学ぶ](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

-から最新バージョンのオートメーションキットメインをインストールします[https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)使用[セットアップガイドを学ぶ](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

-を使用して Power Platform コマンド ライン インターフェイスをインストールします。[セットアップガイドを学ぶ](https://learn.microsoft.com/power-platform/developer/cli/introduction)

-環境への認証を作成する

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

-ダウンロード**オートメーションキット.zip**差出人[https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

-ファイルを抽出する**オートメーションキット-サンプルデータ.zip**差出人**オートメーションキット.zip**

-データを環境にインポートする

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

-ダウンロードした Power BI ダッシュボードを環境に接続して、インポートされたデータを探索します。使う[Power BI ダッシュボードをインストールする](/ja/get-started/install-powerbi-dashboard)詳細情報

## フィードバック

{{<questions name="/content/ja/features/datapacks.json" completed="フィードバックをお寄せいただきありがとうございます" showNavigationButtons="false" locale="ja">}}
