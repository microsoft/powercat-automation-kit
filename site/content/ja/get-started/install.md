---
title: "取り付ける"
description: "自動化キット - インストール"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: 2251306D3FA73DEF67131846C92EDEB6BECC84B8
---

最新バージョンのオートメーションキットをインストールするには、以下の手順を使用します。コマンドラインツールを使用できない場合は、「」に記載されている手動の手順を使用できます。[セットアップガイダンス](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1.から最新リリースを開きます。<a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Automation Kit GitHub リリース</a>

1.ダウンロード**オートメーションキットインストール.zip**

1.Windowsエクスプローラで、ダウンロードしたものを選択します**オートメーションキットインストール.zip**をクリックし、[プロパティ] ダイアログを開きます。

1.を選択します。**解除**ボタン

1.選ぶ**オートメーションキットインストール.zip**コンテキストメニューを使用して**すべて抽出**

1.次のものがあることを確認します。<a href="https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a>インストール

1.次のコマンド ラインを使用して PowerShell スクリプトを実行します。

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

注: PowerShell 実行ポリシーによっては、次のコマンドの実行が必要になる場合があります。

```cmd
powershell.exe -ExecutionPolicy Bypass -File Install_AutomationKit.ps1
```

1.PowerShell スクリプトでは、を使用してインストール構成ファイルを作成するように求められます。[インストール セットアップ](/ja/get-started/setup).セットアップ構成ページには、次の情報が表示されます。

    -メインソリューションまたはサテライトソリューションの構成を選択する
   
    -セキュリティ グループに割り当てるユーザーを選択する
   
    -ソリューションのインストールに必要な接続を作成する
    
    -環境変数の定義
    
    -必要に応じて、サンプル データをインポートするかどうかを定義します。
    
    -必要に応じて、ソリューションに含まれる Power Automate フローを有効にする必要があります

1.セットアップが完了したら、**Automation-kit-main-install.json**又は**Automation-kit-satellite-install.json**ファイルを**オートメーションキットインストール**上のフォルダ

1.ファイルがダウンロードされると、スクリプトは**y**メインソリューションをインストールするには、**n**サテライトソリューションをインストールするには

1.その後、インストールはアップロードされ、定義された設定でインストールを開始します

## フィードバック

に関するフィードバックを提供したい[セットアッププロセス](/ja/get-started/setup)?以下の質問は、プロセスの改善に役立ちます。

{{<questions name="/content/ja/get-started/setup-feedback.json" completed="フィードバックをお寄せいただきありがとうございます" showNavigationButtons=true locale="ja">}}
