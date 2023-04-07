---
title: "Scheduler"
description: "Automation Kit - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 74448AAD8893663688F10D12DCCC2009D386B0CE
---

{{<toc>}}

## Einleitung

Der Automation Kit Scheduler ermöglicht es, den Zeitplan für wiederkehrende Power Automate Cloud-Flows innerhalb von Lösungen anzuzeigen, die Aufrufe von Power Automate Desktop-Flows enthalten.

Diese Funktion wurde im Rahmen der [März 2023](/de/releases/march-2023), Spätere Versionen werden die Funktionalität des Schedulers weiter verbessern und erweitern.

{{<border>}}
![Scheduler](/images/schedule.png)
{{</border>}}

Die wichtigsten Funktionen des Schedulers sind:

- Die Möglichkeit, den Zeitplan wiederkehrender Cloud-Flows anzuzeigen
- Filterplan nach Maschine und Maschinengruppen
- Ausführen eines Power Automate Desktop-Ablaufs
- Zeitplan nach Tag, Woche, Monat und Zeitplanansicht anzeigen
- Anzeigen des Status geplanter Flows (Erfolg, Fehler oder Geplant)
- Anzeigen der Dauer eines Cloud Flow-Laufs
- Zeigen Sie die Details aller Fehler an.

## Cloud-Flows

Wie oben erwähnt, nur Cloud-Flows, die als Teil einer Lösung enthalten sind. Die jüngste [https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/) enthält Informationen zur Verwendung der neuen Vorschau von "Dataverse-Lösungen standardmäßig", um sicherzustellen, dass Cloud-Flows in Lösungen enthalten sind. Mithilfe dieser Funktion können Benutzer sicherstellen, dass die geplanten Cloud-Flows, die erstellt werden, im Scheduler sichtbar sind.

## Kalenderansichten

## Tages-, Wochen-, Monatsansichten

Die Tages-, Wochen- und Monatsansichten zeigen Informationen zu Desktop Cloud-Flussläufen an, die ausgeführt wurden oder ausgeführt werden sollen.

Die Artikel sind wie folgt farbcodiert:

- Grün zeigt erfolgreichen Lauf an

- Rot zeigt fehlgeschlagene Ausführung an

- Blau zeigt eine geplante zukünftige Ausführung an.

Die Status- und Ausführungsinformationen sind durch langes Berühren oder Bewegen der Maus auf das Ereignis verfügbar.

### Zeitplan

{{<border>}}
![Scheduler - Jetzt ausführen](/images/scheduler-schedule-view.png)
{{</border>}}

Die Zeitplanansicht enthält eine Reihe von Cloud-Flows, die auf der Zeit aus der aktuellen Zeit und zukünftigen geplanten Flows in den nächsten Tagen basieren.

## Jetzt ausführen

{{<border>}}
![Scheduler - Jetzt ausführen](/images/scheduler-run-now.png)
{{</border>}}

Die aktuelle Version von Jetzt ausführen führt den Power Automate-Desktop aus. Es wird davon ausgegangen, dass zum Ausführen des Desktopflusses keine Parameter erforderlich sind. Die zusätzlichen Ausführungsinformationen finden Sie in den Informationen zur letzten Ausführung des Desktops.

### Geplante Änderungen

In zukünftigen Versionen werden die folgenden Funktionen als neue Funktionen betrachtet:

1. Führen Sie den Cloud-Flow anstelle des Desktop-Flows aus. Dies umfasst dann den Verlauf der Cloud-Flow-Ausführung und die Ausführung aller zusätzlichen Cloud-Flow-Aktionen und -Parameter, die an den Desktop-Flow übergeben werden.

2. Öffnen Sie Desktop- und Cloud-Flow-Ausführungsseiten.

### Schreibgeschütztes Verhalten geplanter Flows

Wenn ein Flow für die zukünftige Ausführung geplant ist, wird er standardmäßig auf den schreibgeschützten Modus festgelegt und für die sofortige Ausführung deaktiviert. Dies bedeutet, dass Benutzer den Flow erst ändern oder ausführen können, wenn das geplante Datum und die geplante Uhrzeit abgelaufen sind. Dieses Verhalten wurde entwickelt, um eine bessere Benutzererfahrung zu bieten und die versehentliche Ausführung von Flows zu verhindern, bevor sie ausgeführt werden sollen.
Dieser Ansatz bietet mehrere Vorteile, darunter:

- Verhindern einer versehentlichen Ausführung: Durch das Deaktivieren der sofortigen Ausführung von Flows, die für die zukünftige Ausführung geplant sind, ist es weniger wahrscheinlich, dass Benutzer versehentlich einen Flow ausführen, bevor er ausgeführt werden soll.

- Verbesserte Vorhersagbarkeit: Indem Flows bei der geplanten zukünftigen Ausführung in den schreibgeschützten Modus versetzt werden, können Benutzer leichter vorhersagen, wann Flows ausgeführt werden, und sicherstellen, dass sie über die erforderlichen Eingaben und Ressourcen verfügen.

- Konsistente Benutzererfahrung: Durch die Standardisierung des Verhaltens geplanter Flows kann eine konsistente und vorhersagbare Benutzererfahrung über alle Instanzen von Flow hinweg bereitgestellt werden.

- Um einen geplanten Flow zu ändern oder auszuführen, können Benutzer den Flow bearbeiten und das geplante Datum und die geplante Uhrzeit aktualisieren. Sobald der neue Zeitplan festgelegt wurde, wird der Ablauf für die sofortige Ausführung wieder deaktiviert und in den schreibgeschützten Modus versetzt, bis der neue Zeitplan abgelaufen ist.

## Fehlermeldungen

Mögliche Fehlermeldungen, die beim Ausführen des Ausführungsflusses auftreten können.

### Fehlermeldung: "InvalidArgument - Kann keine gültige Verbindung finden, die dem angegebenen Verbindungsverweis zugeordnet ist."

#### Beschreibung

Diese Fehlermeldung weist in der Regel darauf hin, dass ein Problem mit dem im Code oder in der Konfiguration angegebenen Verbindungsverweis vorliegt. Das System kann keine gültige Verbindung finden, die dem Verweis zugeordnet ist, wodurch es die angeforderte Aktion nicht ausführen kann.

#### Bewirkt

Es gibt mehrere mögliche Ursachen für diese Fehlermeldung, einschließlich:

- Falsche oder ungültige Verbindungsreferenz: Die angegebene Verbindungsreferenz kann ungültig oder falsch sein, was dazu führen kann, dass das System eine gültige Verbindung, die ihr zugeordnet ist, nicht finden kann.

- Verbindung gelöscht oder geändert: Wenn die im Code oder in der Konfiguration verwendete Verbindung gelöscht oder geändert wurde, kann dies dazu führen, dass das System keine gültige Verbindung findet, die der Referenz zugeordnet ist.

- Berechtigungsproblem: Das Benutzerkonto, das den Code oder die Konfiguration ausführt, verfügt möglicherweise nicht über die erforderlichen Berechtigungen für den Zugriff auf die Verbindung oder die ihr zugeordneten Ressourcen.

#### Auflösung

Um dieses Problem zu beheben, können Sie die folgenden Schritte ausführen:

- Überprüfen der Verbindungsreferenz: Überprüfen Sie die im Code oder in der Konfiguration angegebene Verbindungsreferenz, und stellen Sie sicher, dass sie gültig und korrekt ist.

- Vorhandene Verbindungen löschen und neu erstellen: Wenn der Flow Checker warnt, dass keine Verbindungsreferenz verwendet wurde, können Sie den Flow Checker verwenden, um vorhandene Verbindungen zu löschen. Nachdem die Verbindungen gelöscht wurden, können Sie Verbindungsverweise auf die Computer- oder Computergruppe neu erstellen, damit der Flow ausgeführt werden kann.

## Notizen

Für das aktuelle Release gelten folgende Hinweise

1. Es werden nur Power Automate Desktop- und Power Automate-Lösungen angezeigt, die in einer Lösung enthalten sind
1. Mindestens ein Power Automate Desktop wurde registriert und ausgeführt

## Installieren

Gehen Sie wie folgt vor, um die Scheduler-Lösung zu installieren:

1. Stellen Sie sicher, dass das Power Apps-Komponentenframework aktiviert ist <a href="https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Lesen Sie mehr</a>
1. Sie haben das Creator Kit in der Zielumgebung installiert. <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Installieren von App-Quelle</a>
1. Sie haben die Datei AutomationKit.zip aus dem Abschnitt "Assets" der neuesten <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">GitHub-Version</a>
1. Sie haben den aktuellen AutomationKitScheduler importiert_*_verwaltet.zip Datei mit. <a href='https://learn.microsoft.com/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Lesen Sie mehr</a>

## Fahrplan

Besuchen Sie unsere <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">GitHub-Probleme</a> , um vorgeschlagene neue Funktionen anzuzeigen.

Sie können eine neue <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Scheduler Feature-Anfrage</a>

## Feedback

{{<questions name="/content/de/features/scheduler.json" completed="Vielen Dank für Ihr Feedback" showNavigationButtons="false" locale="de">}}
