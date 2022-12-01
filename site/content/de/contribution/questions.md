---
title: "Fragen zum Verfassen"
description: "Automation Kit - Fragen zur Erstellung"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 2FDE38C6576920DE548EFE209151F9776EB47B41
---

Diese Seite enthält Informationen über das Format, das zum Erstellen interaktiver Fragen verwendet wird, die als Teil der {{<product-name>}} Starter.

{{<toc>}}

## Erste Schritte

Die Fragen, die auf den Kit-Starterseiten verwendet werden, basieren auf [Open Source Survey JS Bibliothek](https://github.com/surveyjs/survey-library). Durch die Verwendung dieser Bibliothek können alle standardmäßig unterstützten Steuerelemente verwendet werden.

Um das Framework zu verstehen, können Sie sich ansehen

- Das [Umfrage JS Docs](https://surveyjs.io/form-library/documentation/overview)

- Einfache Fragetypen wie [Text](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [Radiogruppen](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [Kontrollkästchen](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) oder [Rangordnung](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- Verwenden der bedingten Sichtbarkeit [visibleIf](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- Überprüfen Sie einige der vorhandenen Fragen, die auf der Website verwendet werden. Zum Beispiel die [Fragen zur Überwachung](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- Überprüfen Sie, wie Sie den Kurzcode in Ihren Inhaltsmarkdown aufnehmen. Zum Beispiel [Überwachen von Abschriften](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## Fragen in Ihre Inhalte einbetten

Um eine Reihe von Fragen in Ihre Seite einzubetten, können Sie Folgendes zu Ihrem Markdown hinzufügen und den Namen in die Fragedatei ändern, aus der Sie lesen möchten

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

Die {{<product-name>}} enthält auch einige zusätzliche Funktionen, die Sie innerhalb von Ausdrücken verwenden können.

### Len

Die len-Funktion gibt die Länge einer Zeichenfolge oder eines Arrays zurück

#### Len Beispiel

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### enthält

Die contains-Funktion gibt true oder false zurück, wenn die Zeichenfolge oder das Array von Zeichenfolgen mit dem angegebenen Wert übereinstimmt

#### enthält Beispiel

Wird das Element sichtbar machen, wenn eine der ausgewählten Rollen Maker ist

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

Wird das Element sichtbar machen, wenn eine der ausgewählten Rollen Hersteller oder Architekt ist

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## Benutzerdefinierte Widgets

### Image-Aufgabe

Die {{<product-name>}} enthält auch die **Bild-Aufgabe** Benutzerdefiniertes Widget. Dieses Widget kann mithilfe des folgenden JSON-Snippets in Ihre Frageelemente eingefügt werden.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### Eigenschaften

- **Titel** - Der Text, der dem Benutzer angezeigt werden soll
- **Art** - Muss Image-Task sein
- **Src** - Die URL der zu rendernden SVG-Datei

#### So funktioniert's

Die SVG-Quelldatei unterstützt die folgenden benutzerdefinierten Hyperlinklinks für Elemente in Ihrer SVG-Datei

- **template://item/selected** - Definiert das Format des Objekts, um das ausgewählte Format im Bild festzulegen
- **template://item/unselected** - Definiert das Format des Objekts, um das nicht ausgewählte Format der Elemente im Bild festzulegen

Visuelle Elemente mit einem Hyperlink von question:// werden verwendet, um das Wertearray innerhalb des Fragensatzes festzulegen oder aufzuheben. Diese Fähigkeit bietet die Möglichkeit, interaktiv zu ändern, wie dem Benutzer andere Fragen angezeigt werden. Beispiel: Die SVG-Datei enthält zwei Objekte mit den folgenden Hyperlinks:

- **question://roles/maker**
- **question://roles/architect**

Wenn der Benutzer diese Objekte auswählt, können z.B. andere Elemente auf der Seite angezeigt werden

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

Visuelle Elemente mit einem Hyperlink von option:// werden verwendet, um den Wert eines Optionssatzes oder einer Einzelwertfrage festzulegen. Beispiel: Die SVG-Datei enthält zwei Objekte mit den folgenden Hyperlinks:

- **option://type/A**
- **option://type/B**

```json
{
    "type": "html",
    "html": "Type A has been selected",
    "visibleIf": "{type} == 'A'"
}
```

## Frage und Antwort

### **Frage** Warum wurde dieser Ansatz anstelle von Microsoft Forms verwendet?

Die Verwendung des Fragen-Shortcodes ermöglicht es, dass die Fragen Teil jeder Inhaltsseite und nicht ein separater Link sind.

### **Frage** Welche Vorteile hat dieser Ansatz?

Zu den folgenden Vorteilen dieses Ansatzes gehören:

- Die Möglichkeit, sofort einsatzbereite Fragetypen zu verwenden

- Die Erstellung von Fragen ist konfigurationsgesteuert und erfordert nur Kenntnisse in JSon, um Fragen zu erstellen

- Das Frageframework ist erweiterbar, so dass neue Funktionen oder Widgets hinzugefügt werden können

- Durch die Verwendung von JSon für die Fragedefinitionen können die Fragen in der Quellcodeverwaltung gespeichert und im Laufe der Zeit überprüft und versioniert werden.

### **Frage** Könnte dieser Ansatz in einer Power App oder Power Page verwendet werden?

Absolut, die gleichen JavaScript- und Fragendefinitionen könnten verwendet werden, indem Sie eine [Code-Komponente](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **Frage** Wie kann ich die SVG-Bildaufgabenfragen erstellen?

Eine Option zum Erstellen der SVG-Dateien ist [Microsoft Visio](https://www.microsoft.com/microsoft-365/visio/) welche WLL Diagramme in eine SVG-Datei mit den erforderlichen Hyperlinks exportiert, die mit **Bild-Aufgabe** Fragen.

### **Frage** Kann ich Microsoft PowerPoint verwenden, um SVG-Dateien mit Bildaufgabenfragen zu exportieren?

Microsoft Power Point kann zwar eine Folie in einen SVG-Datei-Ersttestschuh exportieren, exportiert jedoch nicht die Hyperlinks, die zum Erstellen eines interaktiven **Bild-Aufgabe** erfolgreich arbeiten.

### **Frage** Meine exportierten SVG-Dateien sind groß, kann ich sie verkleinern?

Eine Option für SVG-Dateien, um sie zu verkleinern, bevor sie an die Quellcodeverwaltung übergeben werden. Es gibt mehrere Tools, die verwendet werden können, um die Größe eines SVG zu verkleinern, eine Option, die in Betracht gezogen werden sollte, ist [svgo](https://github.com/svg/svgo) ein NodeJs-basierter SVG-Optimierer.
