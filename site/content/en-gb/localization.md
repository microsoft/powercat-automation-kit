---
title: "Localization"
description: "Automation Kit - Localization"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 95F13FA4929A43C1DBF775B8119315DDEB91E0F5
---

**Status:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} Work In Progress - Experimental

{{<toc>}}

## Goals

One of the core goals of the {{<product-name>}} is to support being inclusive via localization of content. To meet this goal the following apply:

- Content hosted on [Starter Site](https://aka.ms/ak4pp/starter) provide automated translation via Azure Cognitive Services and custom mappings.

- The core starter site content team will work in en-us and transform the content to the following languages:

  - [Danish](https://microsoft.github.io/powercat-automation-kit/da/)
  - [Dutch](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [French](https://microsoft.github.io/powercat-automation-kit/fr/)
  - [Italian](https://microsoft.github.io/powercat-automation-kit/it/)
  - [Korean](https://microsoft.github.io/powercat-automation-kit/ko/)
  - [Japanese](https://microsoft.github.io/powercat-automation-kit/ja/)
  - [Norwegian](https://microsoft.github.io/powercat-automation-kit/nb/)
  - [Polish](https://microsoft.github.io/powercat-automation-kit/pl/)
  - [Simplified Chinese](https://microsoft.github.io/powercat-automation-kit/zh-hans)
  - [Spanish](https://microsoft.github.io/powercat-automation-kit/es/)
  - [Swedish](https://microsoft.github.io/powercat-automation-kit/sv/)

- Provide a feedback mechanism to allow the automated generated content to be improved over time.

- Address issues of localization early so that as content moves to [Learn Automation CoE content](https://aka.ms/AutomationCoE) content is available in localized formats already.

- Use the learnings from the starter site content to improve other Kit assets such as dashboard template reports or applications.

- Allow for a "crowd source" model of contributions that allow improved language transformation.

- Use the learnings to allow for language specific "Communication Hub" content for the Automation Kit.

## Promoting inclusion and diversity in the Automation Kit using localization

{{<border>}}

![Automation Kit Localization](/images/automation-kit-localization.png)

{{</border>}}

It is estimated by the [United Nations](https://hr.un.org/unhq/languages/english) that 1.5 billion people speak English. However given the world population is estimated to be [8 billion](https://www.un.org/en/desa/world-population-reach-8-billion-15-november-2022) by November 2022 this is clear a need to support other languages.

As a small team the Automation Kit works by default with US English for content that is not part of the Microsoft Lean platform. To help cater to non English speakers we have Automated the process of converting content that is part of this site.

What helps us at a team, is to get feedback from our user community on the importance of localization to you. We would welcome any feedback you have on the experience below and look forward to seeing how we can support a wider and more diverse set of localizations over time.

## Current State

- American English to British English support has not yet been implemented

- Default out of the box Azure Cognitive Service text translation of context for trial languages above

## Question and Answer

### **Question:** Is the localized content professionally translated content?

No, the default content is created in US English and automatically translated to other languages using Azure Cognitive Services and mapping terms.

### **Question:** How can I improve the translation for my language?

Consider providing feedback or a contribution to help us improve your localized language version.

### **Question:** What is the relationship to the Microsoft Learn content?

The starter side content is managed by the core {{<product-name>}} team only. When content migrates to the Microsoft Learn platform it goes through a separate content review and localization process.

### **Question:** Can other languages be added?

Yes, if the language is supported by [Azure Cognitive Service Language Support](https://learn.microsoft.com/azure/cognitive-services/language-support) then it could be added.

## Provide Feedback

What to provide feedback on the localization process?

{{<questions name="/content/en-gb/localization.json" completed="Thank you for completing questions" showNavigationButtons="false" locale="en-gb">}}
