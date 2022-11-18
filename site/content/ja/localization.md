---
title: "ローカライゼーション"
description: "自動化キット - ローカリゼーション"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Localization']
generated: 53AFF7C6E0B1889AF1A221C000C138D19F1390BA
---

**地位：**{{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} 進行中の作業 - 実験的

{{<toc>}}

## ローカリゼーションを使用したオートメーションキットのインクルージョンとダイバーシティの促進

{{<border>}}

![自動化キットのローカリゼーション](/images/automation-kit-localization.png)

{{</border>}}

それはによって推定されます[国際連合](https://hr.un.org/unhq/languages/english)その15億人が英語を話します。しかし、世界の人口を考えると、[80億](https://www.un.org/en/desa/world-population-reach-8-billion-15-november-2022)2022年11月までに、これは他の言語をサポートする必要性を明確に示しています。

Power Platform Automation Kit チームは、Microsoft Learn プラットフォームの一部ではないコンテンツに対して、既定で英語 (米国) で動作します。英語を話さない人にも対応できるように、自動化スターターエクスペリエンスの一部であるコンテンツを変換する自動プロセスを実験しています。このアプローチを使用して、より広いコミュニティに拡大することを目指しています。

チームとして私たちを助けるのは、[フィードバック](/ja#provide-feedback)お客様へのローカリゼーションの重要性に関するユーザーコミュニティから。このアプローチはプロの翻訳プロセスに取って代わるものではありませんが、ローカリゼーションによってオートメーションキットの使用開始と使用に関するフィードバックをお待ちしております。私たちは、実験を行い、時間の経過とともに継続的に改善しながら、より広く、より多様な一連のエクスペリエンスをどのようにサポートできるかを楽しみにしています。

これらの学習内容を使用し、キットの一部として作成するダッシュボードとアプリケーションに適用することを目指しています。自動翻訳プロセスを使用すると、組織にインポートできるコンテンツを作成できるため、世界中の自動化プロジェクトの多言語採用をサポートおよび育成できます。

## 目標

{{<product-name>}}は、コンテンツのローカリゼーションを通じてインクルーシブであることをサポートすることです。この目標を達成するには、以下が適用されます。

-でホストされているコンテンツ[スターターサイト](https://aka.ms/ak4pp/starter)Azure コグニティブ サービスとカスタム マッピングを介した自動翻訳を提供します。

-コア スターター サイト コンテンツ チームは en-us で作業し、コンテンツを次の言語に変換します。

  - [デンマーク語](https://microsoft.github.io/powercat-automation-kit/da/)
  - [オランダ語](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [フランス語](https://microsoft.github.io/powercat-automation-kit/fr/)
  - [ドイツ語](https://microsoft.github.io/powercat-automation-kit/de/) 
  - [イタリア語](https://microsoft.github.io/powercat-automation-kit/it/)
  - [韓国語](https://microsoft.github.io/powercat-automation-kit/ko/)
  - [日本語](https://microsoft.github.io/powercat-automation-kit/ja/)
  - [ノルウェー語](https://microsoft.github.io/powercat-automation-kit/nb/)
  - [ポーランド語](https://microsoft.github.io/powercat-automation-kit/pl/)
  - [簡体字中国語](https://microsoft.github.io/powercat-automation-kit/zh-hans)
  - [スペイン語](https://microsoft.github.io/powercat-automation-kit/es/)
  - [スウェーデン語](https://microsoft.github.io/powercat-automation-kit/sv/)

-フィードバック メカニズムを提供して、自動生成されたコンテンツを時間の経過と共に改善できるようにします。

-ローカリゼーションの問題に早期に対処し、コンテンツが[自動化 CoE コンテンツの学習](https://aka.ms/AutomationCoE)コンテンツは既にローカライズされた形式で提供されています。

-スターターサイトのコンテンツから学んだことを使用して、ダッシュボードテンプレートレポートやアプリケーションなどの他のKitアセットを改善します。

-改善された言語変換を可能にする貢献の「クラウドソース」モデルを許可します。

-学習内容を使用して、組織にインポートできるオートメーション キットの言語固有の "コミュニケーション ハブ" コンテンツを許可します。

## 現状

-アメリカ英語からイギリス英語へのサポートはまだ実装されていません

-既定の既定の Azure Cognitive Service は、上記の試用版言語のコンテキストのテキスト翻訳を行います。

## ロードマップ

これらの学習内容を、使用する Power BI ダッシュボードと Power Apps に適用して、チームとしてフィードバック ループを使用して自動翻訳に拡張できるようにし、時間の経過とともにより広範な多言語カバレッジを提供できるようにする予定です。

ローカリゼーションバックログは、[GitHub サイト](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aopen+is%3Aissue+label%3Alocalization).

## 質問と回答

### **質問：**ローカライズされたコンテンツは専門的に翻訳されたコンテンツですか?

いいえ、既定のコンテンツは英語 (米国) で作成され、Azure Cognitive Services とマッピング用語を使用して他の言語に自動的に翻訳されます。

### **質問：**自分の言語の翻訳を改善するにはどうすればよいですか?

ローカライズされた言語バージョンの改善に役立つフィードバックや貢献を提供することを検討してください。

### **質問：**Microsoft Learn コンテンツとの関係はどのようなものですか?

スターター サイトのコンテンツは、{{<product-name>}} チームとコントリビューターのみ。コンテンツが Microsoft Learn プラットフォームに移行すると、個別のコンテンツ レビューとローカリゼーション プロセスが経ます。

### **質問：**他の言語を追加できますか?

はい (言語が でサポートされている場合)[Azure Cognitive Service Language Support](https://learn.microsoft.com/azure/cognitive-services/language-support)その後、追加できます。

## フィードバックの提供

ローカリゼーションプロセスに関するフィードバックは何ですか?

{{<questions name="/content/ja/localization.json" completed="質問に回答していただきありがとうございます" showNavigationButtons="false" locale="ja">}}
