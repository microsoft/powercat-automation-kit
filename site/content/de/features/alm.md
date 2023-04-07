---
title: "Application Lifecycle Management (ALM)"
description: "Automation Kit - ALM"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['ALM', 'Guidance']
generated: D3A4F6D207C148D3C321363A90995BEBC9D6EDD2
---

{{<slideStyles>}}

<div class="optional">

Diese Seite bietet eine Übersicht über Komponenten, die Sie bei der Verwendung von ALM mit dem Automation Kit for Power Automate Desktop-Workflows unterstützen können, das in [Power Platform Lösungen](https://learn.microsoft.com/power-platform/alm/solution-concepts-alm).

</div>

{{<presentation slides="1,2,3,4,5,6,7">}}

<div class="optional">

{{<presentationStyles>}}

## Zusammenfassung

Wenn Sie sich ALM für Power Platform Lösungen ansehen, die Power Automate Desktop-Komponenten enthalten

1. Sehen Sie sich die Funktionen von Managed Environment Power Platform Pipelines an, um die unternehmensweiten In-Product-Features für die Verwaltung und Steuerung von Lösungen in Umgebungen zu nutzen.

<br/>

2. Untersuchen Sie bei Bedarf die [Microsoft Power Platform Buildtools für Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools), [GitHub-Aktionen für Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) oder [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) zur Integration und Automatisierung Ihrer ALM DevOps Prozesse.

<br/>

3. Erwägen Sie die Verwendung der [ALM Accelerator für Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-components). Der ALM Accelerator stellt einen vordefinierten Satz von Azure DevOps-Vorlagen bereit, mit denen viele der Power Platform ALM-Aufgaben mithilfe einer integrierten Quellcodeverwaltungssteuerung automatisiert werden.

## Lernen von Power CAT

Sie können auch mehr darüber lesen, wie wir als Power CAT-Team ALM Accelerator verwenden, um die [Power CAT Automation Kit ALM](/de/features/alm/powercat).

## Betriebsmittel

[ALM Accelerator für Power Platform Lernkatalog](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog)

## Fahrplan

Das Automation Kit-Team arbeitet mit dem ALM Accelerator-Team zusammen, um Power Automate Desktop-spezifische Aufgaben zu den vorhandenen Vorlagen hinzuzufügen, die Folgendes abdecken:

- Direkter Vergleich der Power Automate Desktop-Definitionen.

- Validierungsregelprüfungen für Power Automate Desktop.

- Durchführung von Unit-, Integrations- und Systemtests als Teil der CI/CD-Pipeline.

Überprüfen Sie unsere [Automation Kit ALM-bezogenes Backlog](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm).

## Feedback

{{<questions name="/content/de/features/alm.json" completed="Vielen Dank für Ihr Feedback" showNavigationButtons="false" locale="de">}}

</div>

{{<slide  id="slide1" audio="features/alm/managed-environments-overview.mp3" description="Managed Environments Overview" image="features/alm/managed-environments-overview.svg" >}}

Verwaltete Umgebungen bieten Ihnen die Möglichkeit, Governance in großem Maßstab zu rationalisieren und zu vereinfachen. Administratoren können Managed Environments mit nur wenigen Klicks aktivieren und sofort Funktionen aufleuchten, die mehr Transparenz und mehr Kontrolle bei geringerem Aufwand für die Verwaltung all Ihrer Low-Code-Assets bieten.

Verwaltete Umgebungen sind ein wichtiger Bestandteil der Power Platform-Familie, so wie AI Builder Intelligenz in unsere Produkte einfließen ließ und Dataverse das Daten-Backbone bereitstellt. Verwaltete Umgebungen optimieren die Governance der Plattform in großem Maßstab.

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/managed-environments-features.mp3" description="Managed Environments Features" image="features/alm/managed-environments-features.svg" >}}

Verwaltete Umgebungen bieten Ihnen:

- Mehr Transparenz mit Nutzungseinblicken auf der Startseite, Admin-Übersichts-E-Mails, Lizenzberichten und Datenrichtlinienansichten
- Mehr Kontrolle mit Freigabebeschränkungen, mit denen Sie steuern können, wie weit und mit wie vielen Personen App- und Lösungsflüsse freigegeben werden können.
- Sie können die Freigabe auch auf begrenzte Sicherheitsgruppen beschränken.
- Konfigurieren der Lösungsprüfung für Sicherheits- oder Zuverlässigkeitsprüfungen, um Regeln automatisch auszuführen, wenn eine Lösung in eine verwaltete Umgebung importiert wird
- Passen Sie die Begrüßungs- und Freigabeerfahrung des Herstellers an, damit Sie Benutzer auf den richtigen Pfad führen.
- Weniger Aufwand Rationalisieren, vereinfachen und automatisieren Sie sofort einsatzbereite Schritte mit wenigen Klicks. 
- Die Power Platform Pipelines bietet die Möglichkeit, den Application Lifecycle Management (ALM)-Prozess zu vereinfachen.

{{</slide>}}

{{<slide  id="slide3" cdnVideo="features/alm/managed-environments-power-platform-pipelines-demo.mp4" description="Power Platform Pipelines Demo" >}}

Dies ist eine Lösung, mit der ich im Maker Portal arbeite.

Ich habe diese Pipeline ausgewählt, die bereits eingerichtet wurde. Pipelines sind im Grunde eine Reihe automatisierter Schritte, die Ihre Arbeit von einer Umgebung in eine andere verschieben. Diese Pipeline führt meine Lösung von der Entwicklungsumgebung auf der linken Seite in die Testumgebung. Dann gibt es eine weitere Phase, um es vom Test zur Produktion zu bringen.

Lassen Sie uns zum Testen bereitstellen, wählen Sie Weiter und hier bestätige ich meine Verbindungen, um die Umgebung zu testen, um sicherzustellen, dass ich die richtigen Anmeldeinformationen verwende. Als Nächstes konfiguriere ich meine Umgebungsvariablen, um beispielsweise sicherzustellen, dass ich im Test auf die richtige SharePoint-Website zeige. Dies ist wichtig, wenn die Website anders war als die, die ich in der Entwicklung verwendet habe. 

Sobald ich alles eingerichtet habe, kann ich einfach "Bereitstellen" auswählen und Preflight-Validierungen werden automatisch ausgeführt, um sicherzustellen, dass ich die richtigen Abhängigkeiten habe und die Lösung nicht gegen DLP-Richtlinien in dieser Zielumgebung verstößt. Die Pipeline kann auch so eingerichtet werden, dass eine Genehmigung erforderlich ist, bevor die Bereitstellung ausgeführt werden kann. 

Sieht so aus, als ob hier alles gelungen ist.

Nachdem ich meine Pipeline ausgeführt habe, erhalte ich vollständige Transparenz und einen Prüfpfad der Bereitstellungen in meiner Organisation, wobei jede Lösung gesichert und versioniert wird.

{{</slide>}}

{{<slide  id="slide4" audio="features/alm/managed-environments-feature-availability.mp3?v=1" description="Managed Environments Availability" image="features/alm/managed-environments-feature-availability.svg?v=1" >}}

Die Features werden in Phasen ausgerollt. Einige von ihnen wie die Admin-Digests und Freigabelimits sind heute verfügbar. Der Rest wird bis Ende des Jahres eingeführt.

In den kommenden Wochen und Monaten werden Sie auf der Startseite Einblicke in die Nutzung sehen. Neue Trends in den Admin-Digests und Berichten für die lizenzierte Nutzung. Durch die gemeinsame Nutzung von Grenzwerten erhalten Sie mehr Kontrollen und unterstützen Lösungsflüsse. Sie können unsichere Bereitstellungen mit Solution Checker blockieren. Die Onboarding- und Pipeline-Funktionen für Kundenhersteller werden ebenfalls später in diesem Jahr verfügbar sein.

{{</slide>}}

{{<slide  id="slide5" audio="features/alm/pipeline-extensibility.mp3?v=1" description="Pipeline Extensibility" image="features/alm/pipeline-extensibility.svg?v=1" >}}

Sie haben eine Reihe von Optionen, die Sie für Ihre ALM-Auswahl in der Power Platform in Betracht ziehen sollten. Die verwaltete Umgebung Power Platform Pipelines im Produkt Application Lifecycle Management bereitstellen.

Optional können Sie die Erweiterungspunkte der verwalteten Umgebung Power Platform Pipelines in Kombination mit [Power Platform Erstellen von Tools für Azure DevOps](https://learn.microsoft.com/power-platform/alm/devops-build-tools)das [GitHub-Aktionen für Microsoft Power Platform](https://learn.microsoft.com/power-platform/alm/devops-github-actions) oder [Power Platform CLI](https://learn.microsoft.com/power-platform/developer/cli/introduction) , um Ihre eigenen benutzerdefinierten ALM-DevOps-Prozesse zu rollen.

Schließlich konnten Sie die Vorteile der [ALM Accelerator für Power Platform](https://learn.microsoft.com/power-platform/guidance/coe/almacceleratorpowerplatform-learningcatalog) aus dem CoE-Kit, um vorgefertigte Vorlagen und Beispiele für End-to-End-ALM mithilfe von Azure DevOps bereitzustellen. Der ALM Accelerator bietet viele gängige Szenarien, um Ihre Lösungen umgebungsübergreifend zu erstellen und zu steuern.

{{</slide>}}

{{<slide  id="slide6" audio="features/alm/alm-accelerator-for-power-platform-overview.mp3?v=1" description="ALM Accelerator for Power Platform Overview" image="features/alm/alm-accelerator-for-power-platform-overview.svg?v=1" >}}

Was ist ALM Accelerator for Power Platform?

Der ALM Accelerator für Power Platform umfasst Power Apps, die auf Azure DevOps Pipelines und der Git-Quellcodeverwaltung basieren. Die App bietet eine vereinfachte Benutzeroberfläche für Hersteller, um die Komponenten in ihren Power Platform-Lösungen regelmäßig zur Quellcodeverwaltung zu exportieren und Bereitstellungsanforderungen zu erstellen, damit ihre Arbeit vor der Bereitstellung in Zielumgebungen überprüft wird.

{{</slide>}}

{{<slide  id="slide7" audio="features/alm/alm-accelerator-for-power-platform-workflow.mp3?v=1" description="ALM Accelerator for Power Platform Workflow" image="features/alm/alm-accelerator-for-power-platform-workflow.svg?v=1" >}}

Wenn man sich den ALM Accelerator-Workflow ansieht, beginnt er mit Entwicklungsumgebungen. Ihre Interaktion mit dem ALM-Prozess erfolgt über die ALM Accelerator Canvas App oder Managed Environment Pipelines

Maker verwenden die ALM Accelerator Canvas App für ihre ALM-Aufgaben wie das Importieren von Lösungen aus der Quellcodeverwaltung, das Exportieren von Änderungen in die Quellcodeverwaltung und das Erstellen einer Pull-Anforderung zum Zusammenführen von Änderungen

ALM Accelerator-Vorlagen für Azure DevOps-Pipelines erleichtern die Automatisierung von ALM-Aufgaben basierend auf der Maker-Interaktion mit der ALM Accelerator Canvas-App

ALM Accelerator enthält Pipeline-Vorlagen, um eine 3-stufige Bereitstellung in der Produktion zu unterstützen.
Vorlagen können an spezifische Anforderungen und Szenarien angepasst werden

Der ALM Accelerator for Power Platform ist eine Canvas-App, die auf Azure DevOps Pipelines aufbaut, um eine vereinfachte Schnittstelle für Maker bereitzustellen, mit der sie regelmäßig Pull-Anforderungen für ihre Entwicklungsarbeit im Power Platform festlegen und erstellen können. 

Die Kombination aus den Azure DevOps Pipelines und der Canvas-App bildet den vollständigen ALM Accelerator für Power Platform Lösung. 
Die Pipelines und die App sind Referenzimplementierungen. Sie wurden für die interne Verwendung durch das Entwicklungsteam für das CoE Starter Kit entwickelt, sind jedoch Open Source und wurden veröffentlicht, um zu demonstrieren, wie gesundes ALM in der Power Platform erreicht werden kann. Sie können unverändert verwendet oder für bestimmte Geschäftsszenarien angepasst werden.

{{</slide>}}
