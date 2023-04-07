---
title: "サテライト - はじめに"
description: "自動化キット - サテライト - はじめに"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: 425608BE149AA6D640338A5F34EB704ADDAAAEF5
---

# 概要

サテライトソリューションのスターターページへようこそ。このセクションでは、2023 年 4 月以降のリリースで行われた重要な変更について説明します。2023 年 4 月以降、Azure アプリケーション テナント、アプリケーション ID、Azure アプリケーション シークレット情報を格納するための Azure Key Vault の必要性がなくなりました。

## 概念設計

私たちの学習ページの概要は[概念設計](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design)の {{<product-name>}}.ソリューションの重要な要素は、Power Platformメイン環境です。

通常、自動化プロジェクトを実行するサテライト実稼働環境は複数あります。環境戦略によっては、開発環境またはテスト環境になることもあります。

これらの環境の間には、クラウドまたはデスクトップのフローテレメトリ、マシンとマシングループの使用状況、監査ログを含むほぼリアルタイムの同期プロセスがあります。オートメーション キットの Power BI ダッシュボードには、この情報が表示されます。

## 変更点

解決の一環として[[Automation Kit - 機能]: サテライト環境向けの Azure Key Vault の代替手段](https://github.com/microsoft/powercat-automation-kit/issues/84)Azure Key Vault は不要になりました。これは、自動化ソリューション・マネージャーを使用するときに、インストールの複雑さと、ソリューション成果物を取得するためのセキュリティーの管理方法を大幅に軽減するため、重要です。

## 同じものは何ですか?

2023 年 4 月以前と 2023 年 4 月の古いリリースで重要な要素が同じになると、Azure Active Directory アプリケーションが必要になります。

ひとつの[アプリケーション ユーザー](https://learn.microsoft.com/power-platform/admin/manage-application-users) は、システム・ユーザー・レコード内の ApplicationId 属性の存在によって識別されるPower Platform内のユーザー・タイプです。アプリケーション ユーザーは Azure Active Directory (Azure AD) で作成され、Power Platformへのアクセスを認証および承認するために使用されます。これらは通常、ユーザーまたは他のアプリケーションに代わってデータにアクセスしたり、Power Platform内の操作を実行したりする必要があるアプリケーションまたはサービスを表すために使用されます。

具体的には、アプリケーション ユーザーはオートメーション ソリューション マネージャーによって使用され、環境内のソリューション コンポーネントを照会して、ユーザーが配置されたPower Platform ソリューションを測定できるようにします。

## 取り付ける

ザ[コマンドラインインストール](/ja/get-started/install)サテライト ソリューションの場合、Azure Active Directory アプリケーション名と Azure Active Directory アプリケーション ID の入力を求められます。 この情報を使用して、次のことを行います。

1.Azure Active Directory アプリケーションをアプリケーション ユーザーとして追加する
1.アプリケーションユーザをシステム管理者ロールに追加する
1.アプリケーション・ユーザーのユーザー ID を環境変数に追加する**ソリューション マネージャーの成果物の読み取りユーザー ID**

新しいロール データバース ロール**自動化ソリューションマネージャーユーザー**は、指定された環境変数を使用してソリューション成果物を照会する新しい Dataverse GetDataverseSolutionArtifacts カスタム API をユーザーが呼び出すことができることが追加されました。**ソリューション マネージャーの成果物の読み取りユーザー ID**.

サテリットソリューションを手動でインストールする場合は、次の変更を行う必要があります。[サテライトを設定する](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/satellite)指示。

1.「新しいクライアント シークレットを追加する」は、2023 年 4 月以降では不要になったため、スキップします。
1.Azure キー コンテナーにシークレットを作成する手順をスキップします。
1.アプリケーション・ユーザーのユーザー ID を**ソリューション マネージャーの成果物の読み取りユーザー ID**環境変数。

## インストール後

自動化ソリューション・マネージャー・アプリケーションを実行するユーザーに、**自動化ソリューションマネージャーユーザー**Dataverse セキュリティ ロール。

## 以前のリリース

2023 年 4 月のリリースより前のリリースでは、Satellite ソリューションのインストールには、シークレット型の環境変数が必要でした。これには、[Azure Key Vault](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview)を使用して、テナント ID、アプリケーション ID、およびアプリケーション シークレットの値を格納します。この機能を使用するには、[前提条件](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#prerequisites)Azure Key Vault が同じテナントであり、リソース プロバイダーとしての Microsoft.PowerPlatform のセットアップです。

2023 年 3 月以前のリリースでは、Azure Key Vault を使用してテナント ID、アプリケーション ID、アプリケーション シークレットが格納されていました。これらの値を使用して、ソリューション コンポーネントの一覧を返すことができるように、dataverse を照会するためのアクセス トークンが要求されました。

## 推奨 事項

既存のユーザーの場合は、継続的な管理を簡素化し、新機能を利用するために既存のサテライト インストールを 2023 年 4 月以降にアップグレードするという Azure Key Vault の依存関係の必要性を排除することをお勧めします。
