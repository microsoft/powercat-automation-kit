---
title: "Lokalisierung"
description: "Automation Kit - Lokalisierung"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 2FF2232A3FA22363BFD644FE7880F83097A8BBBB
---

**Status:** {{<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon">}} Work In Progress - Experimentell

{{<toc>}}

## Förderung von Inklusion und Vielfalt im Automation Kit mithilfe von Lokalisierung

{{<border>}}

![Lokalisierung von Automation Kits](/images/automation-kit-localization.png)

{{</border>}}

Es wird geschätzt von der [Vereinte Nationen](https://hr.un.org/unhq/languages/english) dass 1,5 Milliarden Menschen Englisch sprechen. Angesichts der Tatsache, dass die Weltbevölkerung jedoch auf [8 Milliarden](https://www.un.org/en/desa/world-population-reach-8-billion-15-november-2022) bis November 2022 stellt dies eindeutig die Notwendigkeit dar, andere Sprachen zu unterstützen.

Das Power Platform Automation Kit-Team arbeitet standardmäßig mit US-Englisch für Inhalte, die nicht Teil der Microsoft Learn-Plattform sind. Um nicht englischsprachigen Benutzern gerecht zu werden, experimentieren wir mit einem automatisierten Prozess, der Inhalte konvertiert, die Teil unserer Automatisierungs-Startererfahrung sind. Mit diesem Ansatz wollen wir auf eine breitere Gemeinschaft skalieren.

Was uns als Team hilft, ist [Feedback](/de#provide-feedback) von unserer Benutzergemeinschaft über die Bedeutung der Lokalisierung für Sie. Obwohl dieser Ansatz einen professionellen Übersetzungsprozess nicht ersetzt, freuen wir uns über Ihr Feedback zu den Erfahrungen, die Ihnen die Lokalisierung bei den ersten Schritten und der Verwendung des Automation Kits bietet. Wir freuen uns darauf, zu sehen, wie wir eine breitere und vielfältigere Palette von Erfahrungen unterstützen können, während wir experimentieren und uns im Laufe der Zeit kontinuierlich verbessern.

Unser Ziel ist es, diese Erkenntnisse zu nutzen und sie auf die Dashboards und Anwendungen anzuwenden, die wir als Teil des Kits erstellen. Die Verwendung des automatisierten Übersetzungsprozesses ermöglicht es uns, Inhalte zu erstellen, die Sie in Ihr Unternehmen importieren können, damit Sie die mehrsprachige Einführung von Automatisierungsprojekten auf der ganzen Welt unterstützen und fördern können.

## Ziele

Eines der Kernziele der {{<product-name>}} soll die Inklusion durch die Lokalisierung von Inhalten unterstützen. Um dieses Ziel zu erreichen, gilt Folgendes:

- Inhalte, die auf [Starter-Seite](https://aka.ms/ak4pp/starter) bietet automatisierte Übersetzung über Azure Cognitive Services und benutzerdefinierte Zuordnungen.

- Das Kern-Content-Team für Starter-Site wird in en-us arbeiten und den Inhalt in die folgenden Sprachen umwandeln:

  - [Dänisch](https://microsoft.github.io/powercat-automation-kit/da/)
  - [Holländisch](https://microsoft.github.io/powercat-automation-kit/nl/)
  - [Französisch](https://microsoft.github.io/powercat-automation-kit/fr/)
  - [Deutsch](https://microsoft.github.io/powercat-automation-kit/de/) 
  - [Italienisch](https://microsoft.github.io/powercat-automation-kit/it/)
  - [Koreanisch](https://microsoft.github.io/powercat-automation-kit/ko/)
  - [Japanisch](https://microsoft.github.io/powercat-automation-kit/ja/)
  - [Norwegisch](https://microsoft.github.io/powercat-automation-kit/nb/)
  - [Polnisch](https://microsoft.github.io/powercat-automation-kit/pl/)
  - [Vereinfachtes Chinesisch](https://microsoft.github.io/powercat-automation-kit/zh-hans)
  - [Spanisch](https://microsoft.github.io/powercat-automation-kit/es/)
  - [Schwedisch](https://microsoft.github.io/powercat-automation-kit/sv/)

- Stellen Sie einen Feedback-Mechanismus bereit, damit die automatisch generierten Inhalte im Laufe der Zeit verbessert werden können.

- Frühzeitiges Beheben von Problemen bei der Lokalisierung, damit Inhalte [Lernen Sie Automatisierungs-CoE-Inhalte](https://aka.ms/AutomationCoE) Inhalte sind bereits in lokalisierten Formaten verfügbar.

- Verwenden Sie die Erkenntnisse aus dem Inhalt der Starterwebsite, um andere Kit-Assets wie Dashboard-Vorlagenberichte oder Anwendungen zu verbessern.

- Ermöglichen Sie ein "Crowd-Source"-Modell von Beiträgen, das eine verbesserte Sprachtransformation ermöglicht.

- Verwenden Sie die Erkenntnisse, um sprachspezifische "Communication Hub"-Inhalte für das Automation Kit zuzulassen, die in Ihre Organisation importiert werden können.

## Aktueller Zustand

- Unterstützung für amerikanisches Englisch zu britischem Englisch wurde noch nicht implementiert

- Standardmäßige standardmäßige Azure Cognitive Service-Textübersetzung des Kontexts für die oben genannten Testsprachen

## Fahrplan

Wir planen, diese Erkenntnisse auf die von uns verwendeten Power BI-Dashboards und Power Apps anzuwenden, damit wir als Team auf automatisierte Übersetzungen mit einer Feedbackschleife skalieren können, die es uns ermöglicht, im Laufe der Zeit eine breitere mehrsprachige Abdeckung bereitzustellen.

Unseren Lokalisierungsrückstand finden Sie auf unserer [GitHub-Website](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aopen+is%3Aissue+label%3Alocalization).

## Frage und Antwort

### **Frage:** Handelt es sich bei den lokalisierten Inhalten um professionell übersetzte Inhalte?

Nein, der Standardinhalt wird in US-Englisch erstellt und mithilfe von Azure Cognitive Services und Zuordnungsbegriffen automatisch in andere Sprachen übersetzt.

### **Frage:** Wie kann ich die Übersetzung für meine Sprache verbessern?

Erwägen Sie, Feedback oder einen Beitrag zu geben, um uns bei der Verbesserung Ihrer lokalisierten Sprachversion zu helfen.

### **Frage:** Welche Beziehung besteht zu den Microsoft Learn-Inhalten?

Der Inhalt der Startersite wird von {{<product-name>}} nur Team und Mitwirkende. Wenn Inhalte auf die Microsoft Learn-Plattform migriert werden, durchlaufen sie einen separaten Inhaltsüberprüfungs- und Lokalisierungsprozess.

### **Frage:** Können weitere Sprachen hinzugefügt werden?

Ja, wenn die Sprache von [Sprachunterstützung für Azure Cognitive Service](https://learn.microsoft.com/azure/cognitive-services/language-support) Dann könnte es hinzugefügt werden.

## Feedback geben

Was kann man Feedback zum Lokalisierungsprozess geben?

{{<questions name="/content/de/localization.json" completed="Vielen Dank für das Ausfüllen der Fragen" showNavigationButtons="false" locale="de">}}
