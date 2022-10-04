---
title: Authoring Questions
description: Automation Kit authoring questions
sidebar: false
sidebarlogo: fresh-white
include_footer: true
---

This page contains information the format used to author interactive questions that are included as part of the {{<product-name>}} starter.

{{<toc>}}

## Getting Started

The questions used within the kit starter pages are based on [Open Source Survey JS Library](https://github.com/surveyjs/survey-library). Using this library allows all the out of the box controls supported to be used.

To understand the framework you can look at

- The [Survey JS Docs](https://surveyjs.io/form-library/documentation/overview)

- Simple question types like [Text](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [Radio Groups](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [Checkbox](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) or [Ranking](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- Using Conditional visibility [visibleIf](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- Review some of the existing questions that are used in the site. For example the [Monitoring Questions](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- Review how to include the short code in your content markdown. For example [Monitoring markdown](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## Embedding questions in you content

To embed a set of questions in your page your can add the following to your markdown and change the name to the question file you want to read from

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

The {{<product-name>}} also includes some additional functions you can use inside expressions.

### len

The len function returns the length of a string or array

#### len example

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### contains

The contains function returns true or false if the string or array of strings match the value provided

#### contains example

Will make element visible if one of the roles selected is maker

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

Will make element visible if one of the roles selected is maker or architect

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## Custom Widgets

### Image Task

The {{<product-name>}} also includes the **image-task** custom widget. This widget can be included in your question elements using the following json snippet.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### Properties

- **title** - The text to display to the user
- **type** - Must be image-task
- **src** - The url of the SVG file to render

#### How it works

The source svg file supports the following custom hyperlink links for elements in your svg file

- **template://item/selected** - Will define the format of the object to set the selected format in the image
- **template://item/unselected** - Will define the format of the object to set the unselected format of items in the image
- **question://question-name/value** - Will define the format of the object to set the unselected format of items in the image

Visual elements with a hyper link of question:// will be used to set or unset the array of values inside the set of questions. This ability provides the ability to interactively change how other questions are shown to the user. For example if the svg file had two objects with the following hyperlinks:

- **question://roles/maker**
- **question://roles/architect**

If the user selects these objects then other elements on the page could be shown for example

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

## Question and Answer

### **Question** Why has this approach been used rather than Microsoft Forms?

The use of the questions shortcode allows the questions to be part of each content page rather than a separate link.

### **Question** What advantages are there of this approach?

The following advantages of this approach includes

- The ability to use out of the box question types

- The creation of questions is configuration driven and only requires knowledge of JSon to build questions

- The question framework is extensible allowing new functions or widgets to be added

- Using JSon for the question definitions allows the questions to be stored in source control and reviewed and versioned over time

### **Question** Could this approach be used within a Power App or Power Page?

Absolutely, the same JavaScript and question definitions could be used by creating a [Code Component](https://learn.microsoft.com/en-us/power-apps/developer/component-framework/custom-controls-overview)

### **Question** How can I author the SVG image-task questions?

One option to create the svg files is [Microsoft Visio](https://www.microsoft.com/microsoft-365/visio/) which wll export diagrams to a svg file with the required hyperlinks that is compatible with **image-task** questions.

### **Question** Can I use Microsoft PowerPoint to export image-task questions SVG files?

While Microsoft Power Point can export a slide to a SVG file initial testing shoe it does not export the hyperlinks required to make an interactive **image-task** work successfully.

### **Question** My exported SVG files are large can I make them smaller?

One option for SVG files to make them smaller before committing them to source control. There are multiple tools that can be used to shrink the size of a SVG, one option to consider is [svgo](https://github.com/svg/svgo) a NodeJs based SVG optimizer.
