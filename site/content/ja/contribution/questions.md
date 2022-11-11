---
title: "オーサリングの質問"
description: "自動化キット - 質問の作成"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 37D5A5E89FA4987CACF047AC5907F94874C4EA89
---

このページには、{{<product-name>}} スターター。

{{<toc>}}

## はじめ

キットのスターターページで使用される質問は、[オープンソース調査JSライブラリ](https://github.com/surveyjs/survey-library).このライブラリを使用すると、サポートされているすべての標準コントロールを使用できます。

フレームワークを理解するには、

-ザ[調査JSドキュメント](https://surveyjs.io/form-library/documentation/overview)

-次のような単純な質問タイプ[テキスト](https://surveyjs.io/form-library/examples/questiontype-text/reactjs),[ラジオグループ](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs),[チェックボックス](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs)又は[ランキング](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

-条件付き表示の使用[可視の場合](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

-サイトで使用されている既存の質問のいくつかを確認します。例えば、[監視に関する質問](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

-コンテンツのマークダウンにショートコードを含める方法を確認します。例えば[マークダウンの監視](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## コンテンツに質問を埋め込む

ページに一連の質問を埋め込むには、マークダウンに以下を追加し、名前を読みたい質問ファイルに変更します

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

{{<product-name>}} には、式内で使用できるいくつかの追加関数も含まれています。

### レン

len 関数は、文字列または配列の長さを返します。

#### len の例

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### 含む

contains 関数は、文字列または文字列の配列が指定された値と一致する場合に true または false を返します。

#### 例が含まれています

選択したロールの 1 つが作成者である場合に要素を表示します。

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

選択したロールの 1 つが作成者またはアーキテクトである場合に要素を表示します。

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## カスタムウィジェット

### 画像タスク

{{<product-name>}} には、**画像タスク**カスタムウィジェット。このウィジェットは、次のjsonスニペットを使用して質問要素に含めることができます。

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### プロパティ

- **タイトル**- ユーザーに表示するテキスト
- **種類**- 画像タスクでなければなりません
- **ティッカー**- レンダリングする SVG ファイルの URL

#### 仕組み

ソース svg ファイルは、svg ファイル内の要素に対して次のカスタム ハイパーリンク リンクをサポートしています。

- **template://item/selected**- 画像で選択したフォーマットを設定するオブジェクトのフォーマットを定義します
- **template://item/unselected**- 画像内のアイテムの未選択のフォーマットを設定するためにオブジェクトのフォーマットを定義します
- **question://question-name/value**- 画像内のアイテムの未選択のフォーマットを設定するためにオブジェクトのフォーマットを定義します

ハイパーリンクが question:// のビジュアル要素は、一連の質問内の値の配列を設定または設定解除するために使用されます。この機能により、他の質問がユーザーに表示される方法を対話的に変更できます。たとえば、svg ファイルに次のハイパーリンクを持つ 2 つのオブジェクトがあるとします。

- **question://roles/maker**
- **question://roles/architect**

ユーザーがこれらのオブジェクトを選択すると、ページ上の他の要素が表示されます。

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

## 質問と回答

### **質問**なぜこのアプローチが Microsoft Forms ではなく使用されているのですか?

質問のショートコードを使用すると、質問を個別のリンクではなく、各コンテンツページの一部にすることができます。

### **質問**このアプローチにはどのような利点がありますか?

このアプローチの次の利点は次のとおりです。

-すぐに使用できる質問タイプを使用する機能

-質問の作成は構成駆動型であり、質問を作成するためにJSonの知識のみが必要です

-質問フレームワークは拡張可能で、新しい関数やウィジェットを追加できます

-質問定義にJSonを使用すると、質問をソース管理に保存し、時間の経過とともにレビューおよびバージョン管理できます。

### **質問**このアプローチは、Power App または Power Page 内で使用できますか?

絶対に、同じJavaScriptと質問の定義を使用して、[コード コンポーネント](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **質問**SVG画像タスクの質問を作成するにはどうすればよいですか?

svgファイルを作成する1つのオプションは、[マイクロソフトVisio](https://www.microsoft.com/microsoft-365/visio/)互換性のある必要なハイパーリンクを含むSVGファイルにダイアグラムをエクスポートする**画像タスク**問。

### **質問**Microsoft PowerPoint を使用して画像タスクの質問の SVG ファイルをエクスポートできますか?

Microsoft PowerPointはスライドをSVGファイルの初期テストシューズにエクスポートできますが、インタラクティブを作成するために必要なハイパーリンクはエクスポートされません**画像タスク**正常に機能します。

### **質問**エクスポートしたSVGファイルが大きいので、小さくできますか?

SVGファイルの1つのオプションは、ソース管理にコミットする前にそれらを小さくします。SVGのサイズを縮小するために使用できるツールは複数ありますが、考慮すべきオプションの1つは[スヴゴ](https://github.com/svg/svgo)NodeJsベースのSVGオプティマイザ。
