---
title: "パワー CAT アプリケーション ライフサイクル管理 (ALM)"
description: "オートメーションキット - ALMパワーキャット"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: EE6E212FD39B87D233249859750DDF2D7FC71E60
---

{{<slideStyles>}}

<div class="optional">

自動化キットは、[ALM アクセラレータ](https://aka.ms/aa4pp)Power Automate デスクトップを含むソリューションに ALM 機能を提供するため

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## GitHub のデプロイ プロセス

他の Power CAT 管理キットで使用されているリリース プロセスと同様に、{{<product-name>}} は、ALM アクセラレータを使用して、パブリック GitHub リリースにリリースをデプロイします。

当社の内部プロセスには、開発、テスト、および運用用の Power Platform 環境があります。リリースの準備ができたら、統合されたGitHub Actionsが、マネージドおよびアンマネージドのデプロイソリューションを、GitHubドラフトリリースのリリースノートとともに自動的にパッケージ化します。

ドラフトリリースの準備ができたら、必要に応じて新しいバージョンまたはホットフィックスを公開できます。

### お客様にとっての意味

この自動化が実施されたので、自動化されたALMリリースには次の利点があります。

-オートメーションキットを構成するすべてのローコードソースコードを可視化し、キットの構築方法を調査できます。

-バグや問題に迅速に対応し、必要に応じて修正プログラムを提供できる合理化された自動化プロセス。

-リリースに含まれるすべてのバグと機能の自動コンパイル。

-Power Apps、Power Automate、Dataverse、Power Automate Desktop は、継続的インテグレーション/継続的デプロイの ALM プロセスの一部として含まれています。

## ロードマップ

オープンALM関連のバックログ項目は、[GitHub の問題登録](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

全体として、既存のすぐに使用できる Power Platform と Microsoft DevOps 製品の機能を一緒に ALM アクセラレータに基づいて構築します。この組み合わせにより、ハイパーオートマクションに役立つ特定の拡張機能に集中できます。

## フィードバック

{{<questions name="/content/ja/features/alm/powercat.json" completed="フィードバックをお寄せいただきありがとうございます" showNavigationButtons="false" locale="ja">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Power CAT チームは、ALM アクセラレータを使用して、それぞれを構築およびデプロイします。[リリース](https://github.com/microsoft/powercat-automation-kit/releases).

各リリースでは、開発からテスト環境および運用環境への変更が促進されます。キット内の Power Platform ソリューションは、自動化されたプロセスを使用して、パブリック GitHub リリースにデプロイするアセットをパッケージ化します。

将来のマイルストーンでは、既存のプラットフォームを拡張します[ALM の機能](/ja/features/alm)を使用して、DevOps プロセスの一部として検証ルールと RPA サンプルの視覚的な比較を含める方法の例を提供します。

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

以下に、オートメーションキットのリリースプロセスの主な手順の概要を示します。

1.Power Platform 開発環境で行われた変更は、パブリック GitHub リポジトリのブランチに保存されます

2.変更をテストリリースに含める準備ができたら、プルリクエストを使用してメインブランチにマージされます。プル要求を完了する前に、Azure DevOps 検証パイプラインが正常に完了し、プル要求がレビューされている必要があります。

3.プル要求が自動チェックに合格し、レビューの承認を受け取ったら、メイン ブランチにマージできます。このマージにより、マネージド ビルドをテスト Power Platform 環境に発行するテスト Azure DevOps ビルド パイプラインがトリガーされます。

4.内部テストの後、Azure DevOps 運用パイプラインが手動でトリガーされ、運用 Power Platform デプロイが生成されます。

5.リリースの準備ができたら、リリース Azure DevOps パイプラインによって、リリース ノートとビルド資産を含むドラフト リリースが作成されます。最終リリースビルドは、すべての未解決の問題を閉じ、マイルストーンを閉じます。公開されたビルドは、月と年のラベルが適用された GitHub リポジトリにタグを付けます。

{{</slide>}}
