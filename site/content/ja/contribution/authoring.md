---
title: "作成ガイドライン"
description: "自動化キット - ドキュメント作成ガイドライン"
sidebar: false
sidebarlogo: fresh-white
include_footer: true

generated: 433D677DF77659E90DB96D781DBB7F15CEACA34E
---

以下のセクションでは、スターター ドキュメントを作成するためのガイドラインとメモの概要を説明します。

{{<toc>}}

## ガイドライン

以下のセクションでは、コントリビューションを作成するための技術、設計、および結果ベースのガイドラインの概要を説明します。

## 目標

ドキュメントを作成する際には、読者ができるようにする方法を検討することが重要です。**成功の穴に落ちる**.

ブラッドエイブラムスの定義[2003年の成功の穴](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/)として

> 成功の穴:多くの試練を通して勝利を見つけるために砂漠を横断する頂上、ピーク、または旅とはまったく対照的です
> そして驚き、私たちはお客様が単に勝利の実践に陥ることを望んでいます
> 私たちのプラットフォームとフレームワークを使用することによって。トラブルに巻き込まれやすい限り、失敗します。

この目標を考慮して、次の点を考慮してください。

-「崖のない体験」を提供する

  -管理者と中央ガバナンス チームが {{<product-name>}}

  -ユーザーが開発環境を利用して、中央環境が利用できず、テストまたは運用環境のデプロイの前に機能が必要な場合に、 {{<product-name>}}

  -簡単なセットアップでトライアル環境の使用法について話し合い、{{<product-name>}}

-フィードバック用のチャネルを提供します。お客様が改善できる点について意見を提供するオプションを提供する

### ソース管理

-完了しました[ドキュメンテーション](/ja/contribution/documentation)GitHub リポジトリに変更をダウンロードしてプッシュする手順
-新しい変更は新しいブランチにプッシュされ、変更を確認するためのプル要求があります
-すべてのドキュメントは、マークダウン、JSon、またはバージョン管理できる静的アセットのいずれかであり、標準のプルリクエストプロセスを使用してレビューする必要があります

## 設計ガイドライン

### ホームページ

-スターターエクスペリエンスの目的を概説する明確なタイトルとサブタイトルを用意する
-他の関連イベントを含めるための召喚状を提供します。たとえば、オフィスアワーに登録します。
-新規ユーザーのオンボーディングを支援するためのプライマリアクションとしての開始アクションへのリンク
-ユーザーのコミュニティを構築するのに役立つオフィスアワーに参加するための二次アクション
-一般的なアクションのタイルを含める
-ユーザーが超自動化プロジェクトを管理するのに役立つ機能の概要リスト
-共通リンクのフッター ナビゲーション。

読む[サイト構成](/ja/contribution/site-configuration)ホーム ページの構成の詳細については、を参照してください。

### 再使用

-hugo レイアウトを使用して、新しいテーマを指定したり、site\layouts フォルダーにコンテンツを配置して現在のテーマを上書きしたりできるようにします。
-レイアウトを変更すると、静的 HTML を多くのホスティング場所に含めることができます。例えば

  -GitHub Pages
  -パワーページ
  -共有ポイント
  -Azure Static Websites

-このアプローチは、パートナーまたはお客様がテンプレートとして使用して、{{の栄養フェーズを加速するための「ドキュメントパック」を構築できます。<product-name>}} ドキュメント
-ドキュメントの複数のユーザー (カスタマー センターやパートナー センター オブ エクセレンス チームなど) に機能を提供する
-ユーザーが提供したコンテンツを含めることを許可する
-新しい変更を {{<product-name>}} スタータードキュメント

## マークダウンページ

-あなたは使うことができます[Visual Studio Code](https://code.visualstudio.com/)マークダウン ファイルを編集するには

-マークダウンファイルは/site/contentフォルダに配置する必要があります

-各マークダウンファイルには、各ページに共通のヘッダーを含める必要があります

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

-マークダウンファイルはショートコードを使用してJavaScriptを埋め込む必要があります

## ショートコード

ショートコードは、マークダウンページに動的コンテンツを含める機能を提供します。ショートコードの詳細については、[ヒューゴーショートコードドキュメント](https://gohugo.io/content-management/shortcodes/)

このプロジェクトには追加のショートコードも含まれています

### 目次

を追加します。**目次**マークダウンのショートコードに従って、で囲まれたページにマークダウンヘッダーの目次を含めます\{\{ および\}\}

```html
<toc/>
```

### 質問

で囲まれたページに一連の質問を含めます\{\{ および\}\}

```html
<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

パラメーター：

- **名前**インポートする質問を含む JSon ファイルの名前。読む[問](/ja/contribution/questions)質問ファイル形式の詳細については、こちらをご覧ください。
- **完了**質問の完了時に表示するテキスト
- **表示ナビゲーションボタン**靴の真/偽の値 次/戻る/完了したナビゲーションボタン

### 外部画像

で囲まれたページに外部ソースからのサイズ画像を含める\{\{ および\}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

パラメーター：

- **ティッカー**インポートするイメージへのソースパス
- **大きさ**ソース画像のサイズを変更するピクセル単位のサイズ
- **テキスト**画像に含める代替テキスト

## 筆記

### GitHub Pages のセットアップ

サイトの GitHub ページを設定するために使用される次の手順

1.gitで新しい孤立したブランチを作成しました

    ```bash
    git checkout --orphan gh-pages
    ```

1.既存のコンテンツ(ファイルとフォルダ)をクリアする

    ```bash
    git clean -d -f
    ```

1.ヒューゴがインストールされています

    -窓にチョコレートと一緒にインストールすることもできます
 
    ```bash
    choco install hugo-extended -confirm
    ```

1./docs フォルダーに出力するように構成された Hugo 出力

1.変更をテストする

    ```bash
    hugo serve
    ```

1.サイトフォルダ内に静的htmlサイトを構築するには、次のコマンドを実行します

    ```bash  
    hugo
    ```
 
1.gh-pagesブランチをGitHubにプッシュする

1.ページを有効にするための GitHub プロジェクトのセットアップ

    -を参照してください GitHub Pages サイトの公開ソースを設定する - GitHub ドキュメント
    -選択した gh-pages ブランチと /docs フォルダ

### ホームページの画像バッジを更新

ホーム ページの画像を [状態: パブリック プレビュー] バッジにカスタマイズするには、次の操作を行います。

1.svgバッジリポジトリを複製する

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1.モジュールのインストール

    ```bash
    npm install
    ```

1.Web サーバーを起動してバッジを生成する

    ```bash
    npm run start
    ```

1.バッジの生成

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1.svgバッジをダウンロードする

1.inkscapeを使用して既存のsvgを編集し、結果を保存する

1.新しい画像を静的\画像\イラストフォルダにアップロードする

1.config.yaml ヒーロー イメージを変更する

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## 質問と回答

### **質問**なぜヒューゴが選ばれたのですか?

[ヒューゴ](https://gohugo.io/){{<product-name>}} スタータードキュメントを GitHub Pages でホストできる静的 HTML に変換

### **質問**なぜ他の静的サイトジェネレーターを選択しなかったのですか?

コアパワーCATチームは、Hugoを使用した経験がありました

### **質問**Microsoft フォームが質問に使用されなかったのはなぜですか?

設計目的の1つは、質問プロセスをコンテンツに直接統合することでした。

### **質問**コンテンツをホストする GitHub ページを使用する理由

{{<product-name>}} はすでに GitHub に存在しており、ネイティブの GitHub ページのサポートは、コンテンツをホストする場所の 1 つの選択肢でした。

### **質問**このコンテンツがオンになっていないのはなぜですか[http://learn.microsoft.com]()?

-コンテンツが一般的に再利用可能なガイダンスに成熟するにつれて、[https://learn.microsoft.com]()

-重要な設計目標は GitHub ホスティングによって実現されます

   -コミュニティへの積極的な貢献を許可する
   
   -センターオブエクセレンスのNutureプロセスを促進して、顧客やパートナーコミュニティがドキュメントを再利用できるようにします

### **質問**アプローチが他のPower CATプロジェクトに適用されないのはなぜですか?

{{<product-name>}}は、既存のドキュメントを補完してリンクするために、このドキュメントのチャネルを実験しています[学習内容](https://aka.ms/automation-kit-learn).この実験のフィードバックと結果に基づいて、他の Power CAT 管理プロジェクトが同様のアプローチを採用するかどうかを評価します。

### **質問**オープンドキュメントの問題を確認するにはどうすればよいですか?

あなたは私たちを訪問することができます[オープンドキュメントの問題](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation)ページ

### **質問**新しいドキュメント機能要求を提出するにはどうすればよいですか?

新規作成[機能要求](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
