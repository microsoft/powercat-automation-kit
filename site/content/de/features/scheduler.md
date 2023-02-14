---
title: "Scheduler"
description: "Automation Kit - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B8DC4418FD2312850E01B5DB52344E2BB9B93C2F
---

{{<toc>}}

## Einleitung

Der Automation Kit Scheduler ermöglicht es, den Zeitplan für wiederkehrende Power Automate Cloud-Flows innerhalb von Lösungen anzuzeigen, die Aufrufe von Power Automate Desktop-Flows enthalten.

Diese Funktion wurde im Rahmen der [Februar 2023](/de/releases/february-2023), Spätere Versionen werden die Funktionalität des Schedulers weiter verbessern und erweitern.

{{<border>}}
![Scheduler](/images/schedule.png)
{{</border>}}

Die wichtigsten Funktionen des Schedulers sind:

- Die Möglichkeit, den Zeitplan wiederkehrender Cloud-Flows anzuzeigen
- Zeitplan nach Tag, Woche, Monat und Zeitplanansicht anzeigen
- Anzeigen des Status geplanter Flows (Erfolg, Fehler oder Geplant)
- Anzeigen der Dauer eines Cloud Flow-Laufs
- Zeigen Sie die Details aller Fehler an.

## Notizen

Für das aktuelle Release gelten folgende Hinweise

1. Es werden nur Power Automate Desktop- und Power Automate-Lösungen angezeigt, die in einer Lösung enthalten sind
1. Mindestens ein Power Automate Desktop wurde registriert und ausgeführt

## Installieren

Gehen Sie wie folgt vor, um die Scheduler-Lösung zu installieren:

1. Sicherstellen des Power Apps-Komponentenframeworks <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Lesen Sie mehr</a>
1. Sie haben das Creator Kit in der Zielumgebung installiert. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installieren von App-Quelle</a>
1. Sie haben die Datei AutomationKit.zip aus dem Abschnitt "Assets" der neuesten <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub-Version</a>
1. Sie haben den neuesten AutomationKitScheduler importiert_*_verwaltet.zip Datei mit. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Lesen Sie mehr</a>

## Fahrplan

Besuchen Sie unsere <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-Probleme</a> , um vorgeschlagene neue Funktionen anzuzeigen.

Sie können eine neue <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Scheduler Feature-Anfrage</a>

## Feedback

{{<questions name="/content/de/features/scheduler.json" completed="Vielen Dank für Ihr Feedback" showNavigationButtons="false" locale="de">}}
