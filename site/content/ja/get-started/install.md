---
title: "コマンドラインインストール"
description: "自動化キット - インストール"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 10CE5DBCADF4F09FCAA4261FD8FBEBDE34B6FB2E
---

コマンドラインを使用して最新バージョンのオートメーションキットをインストールするには、以下の手順を使用できます。コマンドラインツールを使用できない場合は、「」に記載されている手動の手順を使用できます。[セットアップガイダンス](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1.あなたが持っていることを確認してください<a ref='https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">Power Apps コンポーネント フレームワーク機能を有効にする</a>メイン環境とサテライト環境の両方にオートメーションキットをインストールする環境で。

1.次のことを確認してください。<a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">クリエイターキットがインストールされている</a>インストールしたい環境に

1.から最新リリースを開きます。<a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Automation Kit GitHub リリース</a>

1.ダウンロード**オートメーションキットインストール.zip**[アセット] セクションから

1.Windowsエクスプローラで、ダウンロードしたものを選択します**オートメーションキットインストール.zip**をクリックし、[プロパティ] ダイアログを開きます。

1.を選択します。**解除**ボタン

1.選ぶ**オートメーションキットインストール.zip**コンテキストメニューを使用して**すべて抽出**

1.次のものがあることを確認します。<a href="https://learn.microsoft.com/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a>インストール

1.次のコマンド ラインを使用して PowerShell スクリプトを実行します。

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

手記：
1.PowerShell 実行ポリシーによっては、次のコマンドの実行が必要になる場合があります。

```cmd
Unblock-File Install_AutomationKit.ps1
```

1.PowerShell スクリプトでは、を使用してインストール構成ファイルを作成するように求められます。[インストール セットアップ](/ja/get-started/setup).セットアップ構成ページには、次の情報が表示されます。

    -メインソリューションまたはサテライトソリューションの構成を選択する
   
    -セキュリティ グループに割り当てるユーザーを選択する
   
    -ソリューションのインストールに必要な接続を作成する
    
    -環境変数の定義
    
    -必要に応じて、サンプル データをインポートするかどうかを定義します。
    
    -必要に応じて、ソリューションに含まれる Power Automate フローを有効にする必要があります

1.Webサイトのセットアップ手順が完了したら、ダウンロードしたものをコピーできます**Automation-kit-main-install.json**又は**Automation-kit-satellite-install.json**ファイルを**オートメーションキットインストール**上のフォルダ

1.ファイルがダウンロードされると、スクリプトは**y**メインソリューションをインストールするには、**n**サテライトソリューションをインストールするには

1.その後、インストールはアップロードされ、定義された設定でインストールを開始します

## フィードバック

に関するフィードバックを提供したい[セットアッププロセス](/ja/get-started/setup)?以下の質問は、プロセスの改善に役立ちます。

{{<questions name="/content/ja/get-started/setup-feedback.json" completed="フィードバックをお寄せいただきありがとうございます" showNavigationButtons="false" locale="ja">}}
