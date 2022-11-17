---
title: "Datenpakete"
description: "Automation Kit - Datenpakete"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 59DCC2AA961720CBEBCC57AD3C8C2B774F7B3FD1
---

{{<toc>}}

## Einleitung

Data Packs sind vorgefertigte Datensätze, die optional in Ihrem installierten Automation Kit installiert werden können, um Ihre Nutzung zu beschleunigen.

{{<border>}}
![Übersicht über Datenpakete](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks.svg)
{{</border>}}

<br/>

Eingeführt im Rahmen der [Oktober 2022](/de/releases/november-2022), Datapacks bieten Ihnen die Möglichkeit, optional Beispieldaten zu importieren.

Mit dem ROI-Datenpaket (Return on Investment) können Sie die Planung, Messung und Überwachung der Kapitalrendite über das Automation Kit Power BI-Dashboard schnell demonstrieren. Sie können Ihr erstes Datenpaket mit der [Erste Schritte](/de#getting-started) Abschnitt unten.

Im Laufe der Zeit fügen wir dem Backlog weitere Datenpakete zur Priorisierung hinzu und dokumentieren, wie Sie bei der Veröffentlichung von Datenpaketen für die Community zusammenarbeiten können.

## Fahrplan

{{<border>}}
![Roadmap für Datenpakete](https://powercat-automation-kit.azureedge.net/releases/november-2022/DataPacks-WhatsNext.svg?v=1)
{{</border>}}

<br/>

In zukünftigen Meilensteinen werden wir versuchen, die Datenpakete zu verbessern, indem wir sie als optionalen Teil des automatisierten Installationsprozesses des Automation Kits aufnehmen.

Die Möglichkeit, Data Packs als Teil der Installation einzuschließen, ermöglicht eine webbasierte Installation anstelle des Befehlszeileninstallationsprozesses für diese Version.

## Return On Investment Hauptlösung

Das Return on Investment (ROI)-Hauptlösungsdatenpaket enthält Automatisierungsprojekte, Maschinen und Beispiele für Power Automate Desktop-Telemetriedaten, damit Sie den End-to-End-Prozess in die Hand nehmen können.

### Erste Schritte

Erste Schritte mit diesem Datenpaket

- Installieren Sie das Creator Kit von [App-Quelle](https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1) oder über [Lerne zur Einrichtung](https://learn.microsoft.com/power-platform/guidance/creator-kit/setup)

- Installieren Sie die neueste Version des Automation Kit Main von [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases) benutzend [Lerne zur Einrichtung](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/main)

- Installieren Sie Power Platform Befehlszeilenschnittstelle mit [Lerne zur Einrichtung](https://learn.microsoft.com/power-platform/developer/cli/introduction)

- Erstellen der Authentifizierung für Ihre Umgebung

```pwsh
pac auth create --url https://contoso.crm.dynamics.com/
```

- Laden Sie die **AutomationKit.zip** Von [https://github.com/microsoft/powercat-automation-kit/releases](https://github.com/microsoft/powercat-automation-kit/releases)

- Extrahieren Sie die Datei **AutomationKit-SampleData.zip** Von **AutomationKit.zip**

- Importieren der Daten in Ihre Umgebung

```pwsh
pac data import -d AutomationKit-SampleData.zip --environment https://contoso.crm.dynamics.com/ 
```

- Verbinden Sie das von Ihnen heruntergeladene Power BI-Dashboard mit Ihrer Umgebung, um die importierten Daten zu untersuchen. Gebrauchen [Installieren des Power BI-Dashboards](/de/get-started/install-powerbi-dashboard) für weitere Informationen

## Feedback

{{<questions name="/content/de/features/datapacks.json" completed="Vielen Dank für Ihr Feedback" showNavigationButtons="false" locale="de">}}
