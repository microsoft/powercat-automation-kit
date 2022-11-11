---
title: "Pytania dotyczące tworzenia"
description: "Automation Kit — pytania dotyczące tworzenia"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
generated: 37D5A5E89FA4987CACF047AC5907F94874C4EA89
---

Ta strona zawiera informacje o formacie używanym do tworzenia interaktywnych pytań, które są zawarte jako część {{<product-name>}} rozrusznik.

{{<toc>}}

## Wprowadzenie

Pytania użyte na stronach startowych zestawu są oparte na [Biblioteka Open Source Survey JS](https://github.com/surveyjs/survey-library). Korzystanie z tej biblioteki umożliwia użycie wszystkich obsługiwanych formantów od razu po wyjęciu z pudełka.

Aby zrozumieć ramy, możesz spojrzeć na

- Ten [Dokumentacja Survey JS](https://surveyjs.io/form-library/documentation/overview)

- Proste typy pytań, takie jak [Tekst](https://surveyjs.io/form-library/examples/questiontype-text/reactjs), [Grupy radiowe](https://surveyjs.io/form-library/examples/questiontype-radiogroup/reactjs), [Pole wyboru](https://surveyjs.io/form-library/examples/questiontype-checkbox/reactjs) lub [Ranking](https://surveyjs.io/form-library/examples/questiontype-ranking/reactjs)

- Korzystanie z widoczności warunkowej [widocznyJeśli](https://surveyjs.io/form-library/examples/condition-kids/reactjs)

- Przejrzyj niektóre z istniejących pytań, które są używane w witrynie. Na przykład [Pytania dotyczące monitorowania](https://github.com/microsoft/powercat-automation-kit/blob/gh-pages/site/content/monitoring.json)

- Sprawdź, jak uwzględnić krótki kod w znaczniku zawartości. Na przykład [Monitorowanie przeceny](https://raw.githubusercontent.com/microsoft/powercat-automation-kit/gh-pages/site/content/monitoring-compare.md)

## Osadzanie pytań w treści

Aby osadzić zestaw pytań na stronie, możesz dodać następujące elementy do znacznika i zmienić nazwę pliku pytań, z którego chcesz czytać:

{{\<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false \>}}

## Custom Functions

Na {{<product-name>}} zawiera również kilka dodatkowych funkcji, których można używać w wyrażeniach wewnętrznych.

### Luksemburg

Funkcja len zwraca długość ciągu lub tablicy

#### Przykład Len

```json
{
    "type": "html",
    "html": "Thanks for selecting a role",
    "visibleIf": "len({roles}) > 0"
}
```

### Contains

Funkcja contains zwraca wartość true lub false, jeśli ciąg znaków lub tablica ciągów jest zgodna z podaną wartością

#### zawiera przykład

Sprawi, że element będzie widoczny, jeśli jedną z wybranych ról jest twórca

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},'maker')"
}
```

Sprawi, że element będzie widoczny, jeśli jedną z wybranych ról jest twórca lub architekt

```json
{
    "type": "html",
    "html": "Thanks for selecting a maker role",
    "visibleIf": "contains({roles},['maker', 'architect'])"
}
```

## Niestandardowe widżety

### Zadanie Obraz

Na {{<product-name>}} obejmuje również **image-task** Niestandardowy widżet. Ten widżet można dołączyć do elementów pytania za pomocą następującego fragmentu kodu json.

```json
{
    "title": "Please select the components of interest",
    "type": "image-task",
    "src": "/powercat-automation-kit/images/illustrations/sample.svg"
}
```

#### Właściwości

- **tytuł** - Tekst do wyświetlenia użytkownikowi
- **typ** - Musi być zadanie wizerunkowe
- **Src** - Adres URL pliku SVG do renderowania

#### Jak to działa

Źródłowy plik svg obsługuje następujące niestandardowe łącza hiperłączy dla elementów w pliku svg

- **template://item/selected** - Zdefiniuje format obiektu, aby ustawić wybrany format na obrazie
- **template://item/unselected** - Zdefiniuje format obiektu, aby ustawić niewybrany format elementów na obrazie
- **question://question-name/value** - Zdefiniuje format obiektu, aby ustawić niewybrany format elementów na obrazie

Elementy wizualne z hiperłączem question:// zostaną użyte do ustawienia lub wyłączenia tablicy wartości wewnątrz zestawu pytań. Ta zdolność zapewnia możliwość interaktywnej zmiany sposobu wyświetlania użytkownikowi innych pytań. Na przykład, jeśli plik svg miał dwa obiekty z następującymi hiperłączami:

- **question://roles/maker**
- **question://roles/architect**

Jeśli użytkownik wybierze te obiekty, mogą zostać wyświetlone inne elementy na stronie, na przykład

```json
{
    "type": "html",
    "html": "Makers build Automation Projects to solve business problems",
    "visibleIf": "contains({roles}, 'maker')"
}
```

## Pytanie i odpowiedź

### **Pytanie** Dlaczego zastosowano to podejście, a nie Microsoft Forms?

Użycie krótkiego kodu pytań pozwala pytaniom być częścią każdej strony treści, a nie oddzielnym linkiem.

### **Pytanie** Jakie są zalety takiego podejścia?

Następujące zalety tego podejścia obejmują:

- Możliwość korzystania z gotowych typów pytań

- Tworzenie pytań jest oparte na konfiguracji i wymaga tylko znajomości JSon do budowania pytań

- Struktura pytań jest rozszerzalna, umożliwiając dodawanie nowych funkcji lub widżetów

- Użycie JSon do definicji pytań umożliwia przechowywanie pytań w kontroli źródła oraz przeglądanie i wersjonowanie w czasie

### **Pytanie** Czy to podejście może być używane w aplikacji Power App lub Power Page?

Oczywiście, ten sam JavaScript i definicje pytań mogą być używane przez utworzenie [Składnik kodu](https://learn.microsoft.com/power-apps/developer/component-framework/custom-controls-overview)

### **Pytanie** Jak mogę utworzyć pytania dotyczące zadań obrazów SVG?

Jedną z opcji tworzenia plików svg jest [Microsoft Visio](https://www.microsoft.com/microsoft-365/visio/) które wll eksportują diagramy do pliku SVG z wymaganymi hiperłączami, który jest zgodny z **image-task** Pytania.

### **Pytanie** Czy za pomocą programu Microsoft PowerPoint można eksportować pliki SVG pytań dotyczących obrazów-zadań?

Podczas gdy Microsoft Power Point może wyeksportować slajd do pliku SVG, wstępny but testowy, nie eksportuje hiperłączy wymaganych do utworzenia interaktywnego **image-task** Pracuj pomyślnie.

### **Pytanie** Moje wyeksportowane pliki SVG są duże, czy mogę je zmniejszyć?

Jedna z opcji dla plików SVG, aby zmniejszyć je przed zatwierdzeniem ich do kontroli źródła. Istnieje wiele narzędzi, których można użyć do zmniejszenia rozmiaru pliku SVG, jedną z opcji do rozważenia jest [SVGO](https://github.com/svg/svgo) optymalizator SVG oparty na NodeJs.
