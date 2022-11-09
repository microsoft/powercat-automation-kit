---
title: アプリケーション ライフサイクル管理 (ALM)
description: オートメーションキット - ALM
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---
{{<slideStyles>}}

<div class="optional">

このページでは、に含まれる Power Automate デスクトップ ワークフローのオートメーション キットで ALM を使用する際に役立つコンポーネントの概要について説明します。[パワープラットフォームソリューション](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## 概要

Power Automate デスクトップ コンポーネントを含む Power Platform ソリューションの ALM を検討する場合

1.マネージド環境 Power Platform パイプラインの機能を確認して、エンタープライズ規模の製品内機能を利用して、環境内のソリューションを管理および制御します。

<br/>

2.必要に応じて、[Microsoft Power Platform Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools),[GitHub Actions for Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions)又は[パワープラットフォーム CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction)を使用して、ALM DevOps プロセスを統合および自動化します。

<br/>

3.の使用を検討してください[パワープラットフォーム用のALMアクセラレータ](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components).ALM アクセラレータは、統合されたソース管理ガバナンスを使用して Power Platform ALM タスクの多くを自動化する、事前に構築された Azure DevOps テンプレートのセットを提供します。

## パワーキャットから学ぶ

また、Power CAT チームが ALM アクセラレータを使用して[パワーキャットオートメーションキットALM](/ja/features/alm/powercat).

## リソース

[パワー プラットフォーム学習カタログの ALM アクセラレータ](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## ロードマップ

Automation Kit チームは、ALM アクセラレータ チームと協力して、以下をカバーする既存のテンプレートに Power Automate デスクトップ固有のタスクを追加しています。

-Power Automate デスクトップの定義を並べて比較します。

-Power Automate デスクトップの検証ルールがチェックされます。

-CI/CD パイプラインの一部としての単体テスト、統合テスト、およびシステム テストの実行。

私たちをレビューしてください[自動化キット ALM 関連のバックログ](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## フィードバック

{{<questions name="/features/alm.json" completed="Thank you for providing feedback" showNavigationButtons=false >}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

管理環境は、大規模なガバナンスを合理化および簡素化する機能を提供します。管理者は、数回クリックするだけでマネージド環境をアクティブ化し、すべてのローコード資産を管理するためのより少ない労力で、可視性と制御性を高める機能をすぐに点灯できます。

マネージド環境は、AI Builder が当社の製品にインテリジェンスを組み込み、Dataverse がデータ バックボーンを提供するのと同じ方法で、Power Platform ファミリの重要な部分です。管理された環境は、プラットフォームのガバナンスを大規模に合理化します。

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

管理環境は、次の機能を提供します。

-ホームページ、管理者ダイジェストメール、ライセンスレポート、データポリシービューでの使用状況の洞察による可視性の向上
-共有制限により、キャンバス アプリとソリューション フローを共有できる範囲と人数を制御できます。
-共有を制限されたセキュリティ グループに制限することもできます。
-ソリューションが管理環境にインポートされるたびにルールを自動的に実行するように、セキュリティまたは信頼性チェック用のソリューション チェッカーを構成する
-作成者のウェルカムと共有エクスペリエンスをカスタマイズして、ユーザーを正しいパスに導くようにします。
-少ない労力で、数回クリックするだけですぐにステップを合理化、簡素化、自動化できます。
-Power Platform パイプラインは、アプリケーション ライフサイクル管理 (ALM) プロセスを簡素化する機能を提供します。

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

これは私がメーカーポータルで作業している解決策です。

既に設定されているこのパイプラインを選択しました。パイプラインは基本的に、作業をある環境から別の環境に移動する一連の自動化されたステップです。このパイプラインは、左側の開発環境からテスト環境にソリューションを取り込みます。次に、テストから本番環境に移行するための別の段階があります。

テストにデプロイし、[次へ]を選択して、ここで接続を確認して環境をテストし、正しい資格情報を使用していることを確認します。次に、環境変数を構成して、たとえば、テストで適切な SharePoint サイトを指していることを確認します。これは、サイトが開発で使用していたサイトと異なる場合に重要です。

すべてを設定したら、「デプロイ」を選択するだけで、プリフライト検証が自動的に実行され、適切な依存関係があり、ソリューションがそのターゲット環境のDLPポリシーに違反しないようにします。パイプラインは、デプロイを実行する前に承認が必要になるように設定することもできます。

ここではすべてが成功したようです。

パイプラインを実行すると、すべてのソリューションをバックアップしてバージョン管理した組織全体のデプロイの完全な可視性と監査証跡を取得できます。

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

これらの機能は段階的に展開されます。管理ダイジェストや共有制限など、それらのいくつかは今日利用可能です。残りは年末までに展開される予定です。

今後数週間から数か月以内に、ホーム ページに使用状況の分析情報が表示されます。管理者ダイジェストの新しい傾向、およびライセンス使用状況のレポート。共有制限により、より多くの制御が可能になり、ソリューション フローがサポートされます。ソリューション チェッカーを使用して、安全でない展開をブロックできるようになります。顧客メーカーのオンボーディングとパイプライン機能も今年後半に提供される予定です。

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

Power Platform での ALM の選択について考慮すべきオプションがいくつかあります。マネージド環境 Power Platform パイプラインは、製品のアプリケーション ライフサイクル管理を提供します。

必要に応じて、マネージド環境 Power Platform パイプラインの拡張ポイントを[Power Platform Build Tools for Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)ザ[GitHub Actions for Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions)又は[パワープラットフォーム CLI](https://learn.microsoft.com/en-us/power-platform/developer/cli/introduction)を使用して、独自のカスタム ALM DevOps プロセスをロールします。

最後に、[パワープラットフォーム用のALMアクセラレータ](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)を CoE キットから提供し、Azure DevOps を使用したエンドツーエンド ALM 用のビルド済みのテンプレートとサンプルを提供します。ALM アクセラレータには、環境間でソリューションを構築および管理するための多くの一般的なシナリオが用意されています。

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

パワープラットフォーム用ALMアクセラレータとは何ですか?

Power Platform の ALM アクセラレータには、Azure DevOps Pipelines と Git ソース管理の最上位に位置する Power Apps が含まれています。このアプリは、作成者が Power Platform ソリューションのコンポーネントを定期的にエクスポートしてソース管理し、デプロイ要求を作成して、ターゲット環境にデプロイする前に作業を確認するための簡略化されたインターフェイスを提供します。

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

ALM アクセラレータのワークフローを見ると、開発環境から始まります。ALM プロセスとの対話は、ALM アクセラレータ キャンバス アプリまたはマネージド環境パイプラインを介して行われます。

作成者は、ソース管理からのソリューションのインポート、ソース管理への変更のエクスポート、変更をマージするためのプル要求の作成などの ALM タスクに ALM アクセラレータ キャンバス アプリを使用します。

Azure DevOps パイプライン用の ALM アクセラレータ テンプレートを使用すると、作成者と ALM アクセラレータ キャンバス アプリとの対話に基づいて ALM タスクの自動化が容易になります。

ALM アクセラレータには、運用環境への 3 段階のデプロイをサポートするパイプライン テンプレートが含まれています。
テンプレートは、特定のニーズやシナリオに合わせてカスタマイズできます

Power Platform の ALM アクセラレータは、Azure DevOps パイプラインの上にあるキャンバス アプリであり、作成者が Power Platform での開発作業のプル要求を定期的にコミットして作成するための簡略化されたインターフェイスを提供します。

Azure DevOps パイプラインとキャンバス アプリの組み合わせは、Power Platform ソリューションの完全な ALM アクセラレータを構成するものです。
パイプラインとアプリは参照実装です。これらは、CoE スターター キットの開発チームが内部で使用するために開発されましたが、Power プラットフォームで健全な ALM を実現する方法を示すためにオープンソース化およびリリースされています。これらは、そのまま使用することも、特定のビジネス シナリオに合わせてカスタマイズすることもできます。

{{</slide>}}
