---
title: "Installation über die Befehlszeile"
description: "Automation Kit - Installieren"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Install']
generated: BBA164EE25537E568BEC4EE4FC9CAA168C26E18B
---

Um die neueste Version des Automation Kits über die Befehlszeile zu installieren, können Sie die folgenden Schritte ausführen. Wenn Sie die Befehlszeilentools nicht verwenden können, können Sie die manuellen Schritte ausführen, die unter [Anleitung zur Einrichtung](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/prerequisites).

1. Stellen Sie sicher, dass Sie <a ref='https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature' target="_blank">Aktivieren des Power Apps-Komponentenframeworkfeatures</a> in den Umgebungen, in denen Sie das Automation Kit für Haupt- und Satellitenumgebungen installieren möchten.

1. Stellen Sie sicher, dass die <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1?tab=Reviews" target="_blank">Creator Kit installiert</a> in die Umgebungen, in denen Sie installieren möchten

1. Öffnen Sie die neueste Version aus dem <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Automation Kit GitHub-Versionen</a>

1. Laden Sie die **AutomationKitInstallieren.zip** aus dem Abschnitt "Assets"

1. Wählen Sie im Windows Explorer die heruntergeladene **AutomationKitInstallieren.zip** und öffnen Sie den Eigenschaftendialog

1. Wählen Sie die Schaltfläche **Entblocken** Knopf

1. Auswählen **AutomationKitInstallieren.zip** und verwenden Sie das Kontextmenü, um **Alle extrahieren**

1. Stellen Sie sicher, dass Sie über die <a href="https://learn.microsoft.com/power-platform/developer/cli/introduction" target="_blank">Power Platform CLI</a> installierte

1. Führen Sie das PowerShell-Skript über die folgende Befehlszeile aus

```cmd
cd AutomationKitInstall
powershell Install_AutomationKit.ps1
```

ANMERKUNG:
1. Abhängig von Ihrer PowerShell-Ausführungsrichtlinie müssen Sie möglicherweise den folgenden Befehl ausführen

```cmd
Unblock-File Install_AutomationKit.ps1
```

1. Das PowerShell-Skript fordert Sie auf, eine Installationskonfigurationsdatei mit [Installieren von Setup](/de/get-started/setup). Auf den Setup-Konfigurationsseiten finden Sie Folgendes:

    - Konfiguration für Haupt- oder Satellitenlösungen auswählen
   
    - Auswählen von Benutzern, die Sicherheitsgruppen zugewiesen werden sollen
   
    - Erstellen von Verbindungen, die für die Installation der Lösung erforderlich sind
    
    - Umgebungsvariablen definieren
    
    - Optional festlegen, ob Beispieldaten importiert werden sollen
    
    - Optional Power Automate Flows aktivieren, die in den Lösungen enthalten sind, sollten aktiviert sein

1. Nachdem Sie die Schritte zur Einrichtung der Website abgeschlossen haben, können Sie sie kopieren, herunterladen: **automation-kit-main-install.json** oder **automation-kit-satellite-install.json** Datei in die **AutomationKitInstallieren** Ordner oben

1. Sobald die Datei heruntergeladen wurde, fordert das Skript nach **y** , um die Hauptlösung zu installieren, **n** So installieren Sie die Satellitenlösung

1. Die Installation wird dann hochgeladen und startet die Installation mit den definierten Einstellungen

## Feedback

Möchten Sie Feedback zum [Setup-Prozess](/de/get-started/setup)? Die folgenden Fragen helfen uns, den Prozess zu verbessern.

{{<questions name="/content/de/get-started/setup-feedback.json" completed="Vielen Dank für Ihr Feedback" showNavigationButtons="false" locale="de">}}
