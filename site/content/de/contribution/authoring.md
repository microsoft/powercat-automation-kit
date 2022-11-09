---
title: Authoring-Richtlinien
description: Richtlinien für die Erstellung von Automation Kit-Dokumentationen
sidebar: false
sidebarlogo: fresh-white
include_footer: true

---
In den folgenden Abschnitten werden Richtlinien und Hinweise zum Erstellen von Startdokumentation beschrieben.

{{<toc>}}

## Leitlinien

In den folgenden Abschnitten werden technische, design- und ergebnisorientierte Richtlinien für das Verfassen von Beiträgen beschrieben.

## Ziele

Bei der Erstellung unserer Dokumentation ist es wichtig zu überlegen, wie wir es unseren Lesern ermöglichen, **Fallen Sie in die Grube des Erfolgs**.

Brad Abrams definiert [Die Grube des Erfolgs 2003](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) wie

> Die Grube des Erfolgs: im krassen Gegensatz zu einem Gipfel, einem Gipfel oder einer Reise durch eine Wüste, um den Sieg durch viele Prüfungen zu finden
> und Überraschungen, wir wollen, dass unsere Kunden einfach in erfolgreiche Praktiken verfallen
> durch die Nutzung unserer Plattform und Frameworks. In dem Maße, in dem wir es leicht machen, in Schwierigkeiten zu geraten, scheitern wir.

Berücksichtigen Sie angesichts dieses Ziels Folgendes:

- Bieten Sie ein "Erlebnis ohne Klippen"

  - Unterstützen Sie Administratoren und zentrale Governanceteams bei der Erstellung eines Self-Service-Modells mit {{<product-name>}}

  - Ermöglichen Sie es Benutzern, Entwicklungsumgebungen zu nutzen, um praktische Übungen zu erhalten, wenn keine zentrale Umgebung verfügbar ist und sie Funktionen vor einem Test oder einer Produktionsbereitstellung der {{<product-name>}}

  - Besprechen Sie die Verwendung von Testumgebungen mit einfacher Einrichtung, um die {{<product-name>}}

- Stellen Sie einen Kanal für Feedback bereit. Geben Sie unseren Kunden Optionen, um Input zu geben, was wir verbessern können

### Quellcodeverwaltung

- Sie haben abgeschlossen [Dokumentation](/de/contribution/documentation) Schritte zum Herunterladen und Übertragen von Änderungen in das GitHub-Repository
- Neue Änderungen werden per Push an eine neue Verzweigung übertragen und verfügen über eine Pull Request, um Änderungen zu überprüfen
- Die gesamte Dokumentation sollte entweder Markdown, JSon oder statische Assets sein, die Versionskontrollen sein und mit dem Standard-Pull-Request-Prozess überprüft werden können.

## Design-Richtlinien

### Homepage

- Haben Sie einen klaren Titel und Untertitel, der das Ziel des Startererlebnisses umreißt
- Stellen Sie einen Aufruf zum Handeln bereit, um andere verwandte Ereignisse einzubeziehen. Registrieren Sie sich beispielsweise für die Bürozeiten.
- Link zur Aktion "Erste Schritte" als primäre Aktion zur Unterstützung neuer Benutzer an Bord
- Sekundäre Aktion zum Teilnehmen an Bürozeiten, um den Aufbau einer Benutzergemeinschaft zu unterstützen
- Kacheln allgemeiner Aktionen einschließen
- Zusammenfassung der Funktionen, die die Benutzer bei der Verwaltung von Hyperautomatisierungsprojekten unterstützen
- Fußzeilennavigation für allgemeine Links.

Lesen Sie die [Standortkonfiguration](/de/contribution/site-configuration) , um weitere Informationen zum Konfigurieren der Homepage zu erhalten.

### Wiederverwendung

- Verwenden Sie hugo layouts, um ein neues Design anzugeben oder das aktuelle Design zu überschreiben, indem Sie Inhalte im Ordner site\layouts ablegen
- Das Ändern von Layouts sollte es ermöglichen, statisches HTML in vielen Hosting-Speicherorten einzubinden. Zum Beispiel

  - GitHub-Seiten
  - Power-Seiten
  - Freigabepunkt
  - Statische Azure-Websites

- Der Ansatz kann von Partnern oder Kunden als Vorlage verwendet werden, um "Dokumentationspakete" zu erstellen, um die Nuture-Phase von {{<product-name>}} Dokumentation
- Bereitstellung der Möglichkeit für mehrere Benutzer der Dokumentation (z. B. Kunden- und Partner-Center of Excellence-Teams)
- Einbinden von vom Benutzer bereitgestellten Inhalten zulassen
- Upgrade-Prozess zulassen, der das Abrufen neuer Änderungen aus {{<product-name>}} Starter-Dokumentation

## Markdown-Seiten

- Sie können verwenden [Visual Studio-Code](https://code.visualstudio.com/) So bearbeiten Sie die Markdown-Dateien

- Markdown-Dateien sollten sich im Ordner /site/content befinden.

- Jede Markdown-Datei sollte auf jeder Seite eine gemeinsame Kopfzeile enthalten

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- Markdown-Dateien sollten Shortcodes verwenden, um JavaScript einzubetten

## Shortcodes

Kurzwahlnummern bieten die Möglichkeit, dynamische Inhalte in eine Markdown-Seite aufzunehmen. Weitere Informationen zu Shortcodes finden Sie im [Hugo Shortcode-Dokumentation](https://gohugo.io/content-management/shortcodes/)

Dieses Projekt enthält auch zusätzliche Shortcodes

### Inhaltsverzeichnis

Fügen Sie die **Toc** Folgen Sie dem Shortcode zu Ihrem Markdown, um ein Inhaltsverzeichnis mit Markdown-Headern in die Seite aufzunehmen, die von \{\{ und \}\}

```html
<toc/>
```

### Frage

Fügen Sie eine Reihe von Fragen in Ihre Seite ein, umgeben von \{\{ und \}\}

```html
<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

Parameter:

- **Name** Der Name der JSon-Datei, die die zu importierenden Fragen enthält. Lesen [Fragen](/de/contribution/questions) Weitere Informationen zum Question File Format
- **abgeschlossen** Der Text, der angezeigt werden soll, wenn die Fragen abgeschlossen sind
- **showNavigationButtons** true/false-Wert für den Schuh Navigationsschaltflächen Weiter/Zurück/Abgeschlossen

### Externes Bild

Fügen Sie ein Bild aus einer externen Quelle in Ihre Seite ein, umgeben von \{\{ und \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

Parameter:

- **Src** Der Quellpfad zum zu importierenden Bild
- **Größe** Die Größe in Pixeln, auf die die Größe des Quellbilds geändert werden soll
- **Text** Der alternative Text, der in das Bild eingefügt werden soll

## Notizen

### GitHub-Seiten einrichten

Die folgenden Schritte wurden verwendet, um die GitHub-Seiten für die Website einzurichten

1. Neuer verwaister Zweig in git erstellt

    ```bash
    git checkout --orphan gh-pages
    ```

1. Löschen des vorhandenen Inhalts (Dateien und Ordner)

    ```bash
    git clean -d -f
    ```

1. Hugo ist installiert

    - Sie können auch mit chocolatey unter Windows installieren
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. Hugo-Ausgabe für Ausgabe in den Ordner /docs konfiguriert

1. Testen Sie Ihre Änderungen

    ```bash
    hugo serve
    ```

1. Führen Sie den folgenden Befehl aus, um die statische HTML-Site im Site-Ordner zu erstellen

    ```bash  
    hugo
    ```
 
1. Pushen Sie Ihren gh-pages-Zweig auf GitHub

1. Einrichten des GitHub-Projekts zum Aktivieren von Pages

    - Siehe Konfigurieren einer Veröffentlichungsquelle für Ihre GitHub Pages-Website - GitHub Docs
    - Ausgewählter gh-pages-Zweig und Ordner /docs

### Image-Badge für die Startseite aktualisieren

Um das Startseitenbild an ein Status: Public Preview-Badge anzupassen, gehe ich wie folgt vor:

1. Klonen Sie das svg-badges Repo

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. Module installieren

    ```bash
    npm install
    ```

1. Starten des Webservers zum Generieren von Badges

    ```bash
    npm run start
    ```

1. Badge generieren

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. Laden Sie das SVG-Badge herunter

1. Verwenden Sie Inkscape, um vorhandenes SVG zu bearbeiten und Ergebnisse zu speichern

1. Neues Bild in den Ordner static\images\illustrations hochladen

1. Ändern des config.yaml-Heldenbilds

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## Frage und Antwort

### **Frage** Warum wurde Hugo ausgewählt?

[Hugo](https://gohugo.io/) ist ein beliebter statischer Site-Generator, der den Inhalt der {{<product-name>}} Startdokumentation, die in statisches HTML umgewandelt werden soll, das in GitHub-Seiten gehostet werden kann

### **Frage** Warum haben Sie nicht einen anderen statischen Site-Generator ausgewählt?

Das Power CAT-Kernteam hatte bereits Erfahrung mit Hugo

### **Frage** Warum wurde Microsoft Forms nicht für Fragen verwendet?

Ein gestalterisches Ziel war es, den Frageprozess direkt in den Inhalt zu integrieren.

### **Frage** Warum GitHub-Seiten zum Hosten von Inhalten?

Der Quellcode für {{<product-name>}} existiert bereits auf GitHub, und die native Unterstützung von GitHub-Seiten war eine Wahl, wo der Inhalt gehostet werden sollte.

### **Frage** Warum ist dieser Inhalt nicht aktiviert? [http://learn.microsoft.com]()?

- Wenn Inhalte zu allgemein wiederverwendbaren Anleitungen gereift sind, können sie zu [https://learn.microsoft.com]()

- Ein wichtiges Designziel wird durch GitHub-Hosting ermöglicht

   - Aktive Community-Beiträge zulassen
   
   - Förderung des Nuture Prozesses des Center of Excellence, damit die Dokumentation von Kunden und Partnern wiederverwendet werden kann

### **Frage** Warum wird der Ansatz nicht auf andere Power CAT-Projekte angewendet?

Die {{<product-name>}} experimentiert mit diesem Kanal der Dokumentation, um unsere bestehenden [Lerninhalte](https://aka.ms/automation-kit-learn). Basierend auf dem Feedback und den Ergebnissen dieses Experiments werden wir bewerten, ob andere von Power CAT verwaltete Projekte einen ähnlichen Ansatz verfolgen werden.

### **Frage** Wie sehe ich Probleme mit offener Dokumentation?

Besuchen Sie unsere [Probleme mit offener Dokumentation](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) Seite

### **Frage** Wie kann ich eine neue Dokumentationsfunktionsanfrage stellen?

Erstellen Sie eine neue [Feature-Anfrage](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
