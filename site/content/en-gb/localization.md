---
title: "Localization"
description: "Automation Kit - Localization"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Localization']
generated: 53AFF7C6E0B1889AF1A221C000C138D19F1390BA
---

**Status:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} Work In Progress - Experimental

{{<toc>}}

## Promoting inclusion and diversity in the Automation Kit using localization

{{<border>}}

![Automation Kit Localization](/images/automation-kit-localization.png)

{{</border>}}

It is estimated by the [United Nations](https://hr.un.org/unhq/languages/english) that 1.5 billion people speak English. However given the world population is estimated to be [8 billion](https://www.un.org/en/desa/world-population-reach-8-billion-15-november-2022) by November 2022, this presents a clear a need to support other languages.

The Power Platform Automation Kit team works by default with US English, for content that is not part of the Microsoft Learn platform. To help cater to non English speakers we are experimenting with an automated process that converts content that is part of our Automation starter experience. Using this approach we aim to scale to a wider community.

What helps us as a team, is to get [feedback](/en-gb#provide-feedback) from our user community on the importance of localization to you. While this approach does not replace a professional translation process, we would welcome any feedback you have on the experience that localization provides you getting started and using the Automation Kit. We look forward to seeing how we can support a wider and more diverse set of experiences as we experiment and continually improve over time.

We aim to use these learnings and apply them to the Dashboards and Applications we produce as part of the kit. Using the automated translation process will allow us to produce content that you will be able to import into your organization so that you can support and nurture multi lingual adoption of Automation projects across the world.

## Goals

One of the core goals of the {{<product-name>}} is to support being inclusive via localization of content. To meet this goal the following apply:

- Content hosted on [Starter Site](https://aka.ms/ak4pp/starter) provides automated translation via Azure Cognitive Services and custom mappings.

- The core starter site content team will work in en-us and transform the content to the following languages:

  - [Danish](https://microsoft.github.io/powercat-automation-kit/da/)
  - [Dutch](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [French](https://microsoft.github.io/powercat-automation-kit/fr/)
  - [German](https://microsoft.github.io/powercat-automation-kit/de/) 
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

- Use the learnings to allow for language specific "Communication Hub" content for the Automation Kit that can be imported into your organization.

## Current State

- American English to British English support has not yet been implemented

- Default out of the box Azure Cognitive Service text translation of context for trial languages above

## Roadmap

We plan to take these learnings and apply them to the Power BI dashboards and Power Apps we use so that we as a team can scale to automated translations with a feedback loop that allows us to provide broader multi lingual coverage over time.

You can view our localization backlog on our [GitHub Site](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aopen+is%3Aissue+label%3Alocalization).

## Question and Answer

### **Question:** Is the localized content professionally translated content?

No, the default content is created in US English and automatically translated to other languages using Azure Cognitive Services and mapping terms.

### **Question:** How can I improve the translation for my language?

Consider providing feedback or a contribution to help us improve your localized language version.

### **Question:** What is the relationship to the Microsoft Learn content?

The starter site content is managed by the {{<product-name>}} team and contributors only. When content migrates to the Microsoft Learn platform it goes through a separate content review and localization process.

### **Question:** Can other languages be added?

Yes, if the language is supported by [Azure Cognitive Service Language Support](https://learn.microsoft.com/azure/cognitive-services/language-support) then it could be added.

## Provide Feedback

What to provide feedback on the localization process?

{{<questions name="/content/en-gb/localization.json" completed="Thank you for completing questions" showNavigationButtons="false" locale="en-gb">}}
