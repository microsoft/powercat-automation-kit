---
title: "Satellite - Erste Schritte"
description: "Automation Kit - Satellit - Erste Schritte"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Get Started', 'Satellite']
generated: 425608BE149AA6D640338A5F34EB704ADDAAAEF5
---

# Überblick

Willkommen auf der Startseite für die Satellite-Lösung. In diesem Abschnitt werden wichtige Änderungen behandelt, die im April 2023 und in späteren Versionen vorgenommen wurden. Nach April 2023 ist es nicht mehr erforderlich, dass Azure Key Vault Informationen zum Azure-Anwendungsmandanten, zur Anwendungs-ID und zum geheimen Schlüssel der Azure-Anwendung speichert.

## Konzeptentwurf

Auf unserer Lernseite finden Sie die [Konzeptentwurf](https://learn.microsoft.com/power-automate/guidance/automation-kit/overview/introduction#conceptual-design) der {{<product-name>}}. Das Schlüsselelement der Lösung ist die Power Platform Hauptumgebung.

In der Regel gibt es mehrere Satellitenproduktionsumgebungen, in denen Ihre Automatisierungsprojekte ausgeführt werden. Abhängig von Ihrer Umgebungsstrategie können dies auch Entwicklungs- oder Testumgebungen sein.

Zwischen diesen Umgebungen gibt es einen Synchronisierungsprozess nahezu in Echtzeit, der Cloud- oder Desktop-Flow-Telemetrie, die Nutzung von Computern und Maschinengruppen sowie Audit-Protokolle umfasst. Das Power BI-Dashboard für das Automation Kit zeigt diese Informationen an.

## Was hat sich geändert?

Im Rahmen der Problemlösung [[Automation Kit – Feature]: Azure Key Vault-Alternative für Satellitenumgebungen](https://github.com/microsoft/powercat-automation-kit/issues/84) Azure Key Vault ist nicht mehr erforderlich. Dies ist wichtig, da es die Komplexität der Installation und die Art und Weise, wie die Sicherheit verwaltet wird, um Lösungsartefakte zu erhalten, erheblich reduziert, wenn der Automation Solution Manager verwendet wird.

## Was ist dasselbe?

Sobald die Schlüsselelemente die gleichen sind wie die älteren Versionen vor April 2023 und April 2023, ist die Notwendigkeit einer Azure Active Directory-Anwendung.

Ein [Applikationsbenutzer](https://learn.microsoft.com/power-platform/admin/manage-application-users) ist ein Benutzertyp in der Power Platform, der durch das Vorhandensein des ApplicationId-Attributs im Systembenutzerdatensatz identifiziert wird. Anwendungsbenutzer werden in Azure Active Directory (Azure AD) erstellt und zum Authentifizieren und Autorisieren des Zugriffs auf die Power Platform verwendet. Sie werden in der Regel verwendet, um eine Anwendung oder einen Dienst darzustellen, die auf Daten zugreifen oder Vorgänge im Power Platform im Auftrag von Benutzern oder anderen Anwendungen ausführen müssen.

Insbesondere wird der Anwendungsbenutzer vom Automation Solution Manager verwendet, um Ihnen das Abfragen der Lösungskomponenten in einer Umgebung zu ermöglichen, sodass Sie einem Benutzer das Messen einer bereitgestellten Power Platform Lösung ermöglichen können.

## Installieren

Das [Installation über die Befehlszeile](/de/get-started/install) Für Satellitenlösungen werden Sie zur Eingabe des Azure Active Directory-Anwendungsnamens und der Azure Active Directory-Anwendungs-ID aufgefordert. Anhand dieser Informationen werden folgende Schritte ausgeführt:

1. Hinzufügen der Azure Active Directory-Anwendung als Anwendungsbenutzer
1. Hinzufügen des Anwendungsbenutzers zur Rolle "Systemadministrator"
1. Hinzufügen der Benutzer-ID des Anwendungsbenutzers zur Umgebungsvariablen **Solution-Manager-Artefakte Benutzer-ID lesen**

Die neue Rolle Dataverse-Rolle **Automation Solution Manager-Benutzer** wurde hinzugefügt, die es Benutzern ermöglicht, die neue benutzerdefinierte Dataverse-API GetDataverseSolutionArtifacts aufzurufen, die Lösungsartefakte mithilfe der bereitgestellten Umgebungsvariablen abfragt **Solution-Manager-Artefakte Benutzer-ID lesen**.

Wenn Sie die Satelitte-Lösung manuell installieren möchten, müssen die folgenden Änderungen an der [Satelliten einrichten](https://learn.microsoft.com/power-automate/guidance/automation-kit/setup/satellite) Anweisungen.

1. Überspringen Sie den Schritt "Neuen geheimen Clientschlüssel hinzufügen", da dieser für April 2023 oder neuer nicht mehr benötigt wird.
1. Überspringen Sie den Schritt zum Erstellen von geheimen Schlüsseln im Azure-Schlüsseltresor.
1. Fügen Sie die Benutzer-ID des Anwendungsbenutzers zum Feld **Solution-Manager-Artefakte Benutzer-ID lesen** Umgebungsvariable.

## Nach der Installation

Stellen Sie sicher, dass Benutzer, die die Automation Solution Manager-Anwendung ausführen, die **Automation Solution Manager-Benutzer** Dataverse-Sicherheitsrolle.

## Frühere Versionen

Vor der Veröffentlichung im April 2023 erforderten Installationen der Satellitenlösung Umgebungsvariablen vom Typ geheim. Dies erforderte eine [Azure-Schlüsseltresor](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#use-azure-key-vault-secrets-preview) , um die Werte für Mandanten-ID, Anwendungs-ID und Anwendungsschlüssel zu speichern. Um diese Funktion nutzen zu können, benötigen Sie auch die [Voraussetzungen](https://learn.microsoft.com/power-apps/maker/data-platform/environmentvariables#prerequisites) Da der Azure-Schlüsseltresor im selben Mandanten ist, richten Sie Microsoft.PowerPlatform als Ressourcenanbieter ein.

In den Versionen vom März 2023 oder älter wurde der Azure-Schlüsseltresor verwendet, um eine Mandanten-ID, eine Appplikations-ID und einen geheimen Anwendungsschlüssel zu speichern. Mit diesen Werten wurde ein Zugriffstoken angefordert, um Dataverse abzufragen, damit es die Liste der Lösungskomponenten zurückgeben konnte.

## Empfehlungen

Für vorhandene Benutzer wird empfohlen, die laufende Verwaltung zu vereinfachen und die Abhängigkeit von Azure Key Vault zu beseitigen, indem Sie die vorhandene Satelliteninstallation auf April 2023 oder höher aktualisieren, um die neuen Funktionen nutzen zu können.
