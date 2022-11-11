---
title: "Power CAT Application Lifecycle Management (ALM)"
description: "Automation Kit - ALM Power CAT"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 0087DF5B505764347AC2AF0B6C170474826A5D65
---

{{<slideStyles>}}

<div class="optional">

Das Automation Kit nutzt die [ALM-Beschleuniger](https://aka.ms/aa4pp) um ALM-Funktionalität für Lösungen bereitzustellen, die Power Automate Desktop enthalten

</div>

{{<presentation slides="1,2">}}


<div class="optional">

{{<presentationStyles>}}

## GitHub-Bereitstellungsprozess

Ähnlich wie bei anderen Power CAT Managed Kits wird der {{<product-name>}} verwendet den ALM Accelerator, um Releases für unsere öffentlichen GitHub-Releases bereitzustellen.

Unser interner Prozess verfügt über eine Power-Plattform-Umgebung für Entwicklung, Test und Produktion. Sobald wir für eine Veröffentlichung bereit sind, packen unsere integrierten GitHub Actions die verwalteten und nicht verwalteten Bereitstellungslösungen zusammen mit den Versionshinweisen automatisch für ein GitHub Draft Release.

Sobald der Release-Entwurf fertig ist, können wir bei Bedarf neue Versionen oder Hotfixes veröffentlichen.

### Was das für Sie bedeutet

Jetzt, da wir diese Automatisierung eingerichtet haben, hat das automatisierte ALM-Release die folgenden Vorteile für Sie:

- Einblick in den gesamten Low-Code-Quellcode, aus dem das Automation Kit besteht, damit Sie untersuchen können, wie wir das Kit erstellt haben.

- Optimierter Automatisierungsprozess, der schnell auf Fehler oder Probleme reagieren und bei Bedarf Hotfixes bereitstellen kann.

- Automatische Kompilierung aller Bugs und Features, die in einem Release enthalten sind.

- Wir beziehen Power Apps, Power Automate, Dataverse und Power Automate Desktop als Teil unseres ALM-Prozesses für unsere kontinuierliche Integration / kontinuierliche Bereitstellung ein.

## Fahrplan

Sie können unsere offenen ALM-bezogenen Backlog-Elemente in unserem [GitHub-Probleme registrieren](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Aalm)

Insgesamt bauen wir auf den vorhandenen Out-of-the-Box-Power-Plattform- und Microsoft DevOps-Produktfunktionen zusammen mit ALM Accelerator auf. Diese Kombination ermöglicht es uns, uns auf spezifische Erweiterungen zu konzentrieren, die bei der Hyperautomatisierung helfen.

## Feedback

{{<questions name="/content/de/features/alm/powercat.json" completed="Vielen Dank für Ihr Feedback" shownavigationbuttons="false" locale="de">}}

</div>

{{<slide  id="slide1" audio="features/alm/powercat/overview.mp3" description="Power CAT ALM Overview" localImage="/images/illustrations/alm-roadmap-2022-11.svg" >}}

Das Power CAT-Team verwendet den ALM Accelerator, um jeden unserer [Auslösungen](https://github.com/microsoft/powercat-automation-kit/releases).

Jede Version fördert Änderungen von unserer Entwicklung in Test- und Produktionsumgebungen. Die Power Platform-Lösungen innerhalb des Kits verwenden einen automatisierten Prozess, um Assets für die Bereitstellung in öffentlichen GitHub-Versionen zu packen.

In zukünftigen Meilensteinen werden wir die bestehende Plattform ausbauen [ALM-Funktionen](/de/features/alm) , um Beispiele für das Einbinden von Validierungsregeln und den visuellen Vergleich von RPA-Beispielen als Teil des DevOps-Prozesses bereitzustellen.  

{{</slide>}}

{{<slide  id="slide2" audio="features/alm/powercat/release-process.mp3" description="Power CAT Automation Kit Release Checker" localImage="/images/illustrations/alm-powercat-process.svg" >}}

Im Folgenden werden die wichtigsten Schritte im Release-Prozess des Automation Kits beschrieben:

1. Änderungen, die in unserer Power Platform Dev-Umgebung vorgenommen werden, werden in einer Zweigstelle im öffentlichen GitHub-Repository gespeichert

2. Wenn Änderungen für die Aufnahme in ein Testrelease bereit sind, werden sie mithilfe eines Pull Requests mit dem Hauptzweig zusammengeführt. Bevor die Pullanforderung abgeschlossen werden kann, muss die Azure DevOps-Validierungspipeline erfolgreich abgeschlossen und die Pullanforderung überprüft werden.

3. Sobald der Pull Request die automatisierten Prüfungen bestanden und die Überprüfungsgenehmigung erhalten hat, kann er mit dem Hauptzweig zusammengeführt werden. Diese Zusammenführung löst die Azure DevOps-Testbuildpipeline aus, die den verwalteten Build in der Power Platform-Testumgebung veröffentlicht.

4. Nach internen Tests wird die Azure DevOps-Produktionspipeline manuell ausgelöst, um eine Production Power Platform-Bereitstellung zu generieren.

5. Sobald die Version fertig ist, erstellt die Azure DevOps-Pipeline einen Releaseentwurf, der Versionshinweise und Buildressourcen enthält. Der endgültige Release-Build schließt alle offenen Probleme und schließt den Meilenstein. Veröffentlichtes Build-Tag für das GitHub-Repository mit der Bezeichnung Monat und Jahr.

{{</slide>}}
