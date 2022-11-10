---
title: Wskazówki dotyczące tworzenia
description: Wskazówki dotyczące tworzenia dokumentacji pakietu Automation Kit
sidebar: false
sidebarlogo: fresh-white
include_footer: true

generated: BA10815D9FEC78E27624D30D5760900841FA742C
---

W poniższych sekcjach przedstawiono wskazówki i uwagi dotyczące tworzenia dokumentacji początkowej.

{{<toc>}}

## Wytyczne

W poniższych sekcjach przedstawiono techniczne, projektowe i oparte na wynikach wytyczne dotyczące tworzenia wkładów

## Cele

Podczas tworzenia naszej dokumentacji ważne jest, aby zastanowić się, w jaki sposób umożliwiamy naszym czytelnikom **Wpadnij w otchłań sukcesu**.

Brad Abrams zdefiniowany [Otchłań sukcesu w 2003 roku](https://web.archive.org/web/20160705182659/https://blogs.msdn.microsoft.com/brada/2003/10/02/the-pit-of-success/) gdy

> Otchłań sukcesu: w jaskrawym kontraście do szczytu, szczytu lub podróży przez pustynię, aby znaleźć zwycięstwo w wielu próbach
> i niespodzianki, chcemy, aby nasi klienci po prostu wpadli w zwycięskie praktyki
> korzystając z naszej platformy i frameworków. W takim stopniu, w jakim ułatwiamy wpadnięcie w kłopoty, ponosimy porażkę.

Biorąc pod uwagę ten cel, rozważ następujące kwestie:

- Zapewnij "doświadczenie bez klifów"

  - Pomóż administratorom i zespołom centralnego zarządzania utworzyć samoobsługowy model korzystania z {{<product-name>}}

  - Zezwalaj użytkownikom na korzystanie ze środowisk programistycznych, aby uzyskać dostęp do nich, jeśli środowisko centralne nie jest dostępne i chcą korzystać z funkcji przed testem lub wdrożeniem produkcyjnym {{<product-name>}}

  - Omów użycie środowisk próbnych z łatwą konfiguracją, aby uzyskać praktyczne informacje z {{<product-name>}}

- Podaj kanał opinii. Daj klientom możliwość wniesienia wkładu w to, co możemy poprawić

### Kontrola źródła

- Ukończono [Dokumentacja](/pl/contribution/documentation) kroki, aby pobrać i wypchnąć zmiany do repozytorium GitHub
- Nowe zmiany są wypychane do nowej gałęzi i mają żądanie ściągnięcia w celu przejrzenia zmian
- Cała dokumentacja powinna być albo markdown, JSon, albo statycznymi zasobami, które mogą być kontrolowane wersją i przeglądane przy użyciu standardowego procesu pull request

## Wytyczne projektowe

### Strona główna

- Miej jasny tytuł i podtytuł, który określa cel doświadczenia początkowego
- Podaj wezwanie do działania, aby uwzględnić inne powiązane wydarzenia. Na przykład zarejestruj się na godziny pracy.
- Link do akcji Wprowadzenie, która jest podstawową akcją pomagającą nowym użytkownikom na pokładzie
- Akcja dodatkowa, aby dołączyć do godzin pracy, aby pomóc w budowaniu społeczności użytkowników
- Dołączanie kafelków typowych akcji
- Zbiorcza lista funkcji ułatwiających użytkownikom zarządzanie projektami hiperautomatyzacji
- Nawigacja w stopce dla typowych łączy.

Przeczytaj [Konfiguracja witryny](/pl/contribution/site-configuration) , aby uzyskać więcej informacji na temat konfigurowania strony głównej.

### Ponowne wykorzystanie

- Użyj układów hugo, aby móc określić nowy motyw lub zastąpić bieżący motyw, umieszczając zawartość w folderze site\layouts
- Zmiana układu powinna umożliwić dołączenie statycznego kodu HTML do wielu lokalizacji hostingu. Na przykład

  - Strony GitHub
  - Strony zasilania
  - Punkt udostępniania
  - Statyczne witryny sieci Web platformy Azure

- Podejście to może być używane jako szablon przez partnerów lub klientów do tworzenia "pakietów dokumentacji" w celu przyspieszenia fazy nuture {{<product-name>}} Dokumentacja
- Zapewnienie możliwości wielu użytkownikom dokumentacji (np. zespołom Customer Center of Excellence)
- Zezwalaj na dołączanie treści dostarczanych przez użytkownika
- Zezwalaj na proces uaktualniania, który umożliwia pobieranie nowych zmian z {{<product-name>}} Dokumentacja startowa

## Strony Markdown

- Możesz użyć [Visual Studio Code](https://code.visualstudio.com/) Aby edytować pliki Markdown

- Pliki Markdown powinny znajdować się w folderze /site/content

- Każdy plik przeceny powinien zawierać wspólny nagłówek na każdej stronie

```toml
title: Sample page
description: Automation Kit sample page
sidebar: false
sidebarlogo: fresh-white
include_footer: true
```

- Pliki Markdown powinny używać skrótów do osadzania dowolnego kodu JavaScript

## Skróty

Krótkie kody umożliwiają dołączanie dynamicznej zawartości do strony znaczników. Możesz przeczytać więcej o skrótach z [Dokumentacja skrótu Hugo](https://gohugo.io/content-management/shortcodes/)

Ten projekt zawiera również dodatkowe skróty

### Spis treści

Dodaj **Toc** podążanie za krótkim kodem do znacznika, aby dołączyć spis treści nagłówków Markdown na stronie otoczonej \{\{ oraz \}\}

```html
<toc/>
```

### Pytanie

Dołącz zestaw pytań do swojej strony otoczony \{\{ oraz \}\}

```html
<questions name="foo.json" completed="Thank you for completing foo" showNavigationButtons=false />
```

Parametry:

- **nazwa** Nazwa pliku JSon, który zawiera pytania do zaimportowania. Czytać [Pytania](/pl/contribution/questions) Aby uzyskać więcej informacji na temat formatu pliku pytania
- **Zakończone** Tekst wyświetlany po zakończeniu pytań
- **showNavigationButtons** wartość true/false do przycisku nawigacyjnego Następny/Wstecz/Zakończony

### Obraz zewnętrzny

Dołącz do strony obraz o rozmiarze ze źródła zewnętrznego otoczony \{\{ oraz \}\}

```html
<externalImage src="https://github.githubassets.com/images/icons/emoji/unicode/1f6a7.png" size="16x16" text="Construction Icon"/>
```

Parametry:

- **Src** Ścieżka źródłowa do obrazu do zaimportowania
- **rozmiar** Rozmiar w pikselach, na który ma zostać zmieniony rozmiar obrazu źródłowego
- **Tekst** Tekst alternatywny do dołączenia do obrazu

## Notatki

### Konfiguracja stron GitHub

Poniższe kroki, gdzie użyto do skonfigurowania stron GitHub dla witryny

1. Utworzono nową osieroconą gałąź w git

    ```bash
    git checkout --orphan gh-pages
    ```

1. Czyszczenie istniejącej zawartości (plików i folderów)

    ```bash
    git clean -d -f
    ```

1. Hugo jest zainstalowany

    - Możesz także zainstalować z chocolatey w systemie Windows
 
    ```bash
    choco install hugo-extended -confirm
    ```

1. Wyjście Hugo skonfigurowane do wyprowadzania do folderu / docs

1. Testowanie zmian

    ```bash
    hugo serve
    ```

1. Aby zbudować statyczną witrynę HTML wewnątrz folderu witryny, uruchom następujące polecenie:

    ```bash  
    hugo
    ```
 
1. Wypychaj gałąź gh-pages do GitHubPush your gh-pages branch to GitHub

1. Konfigurowanie projektu usługi GitHub, aby włączyć aplikację PagesSetup GitHub project to enable Pages

    - Zobacz Konfigurowanie źródła publikowania dla witryny GitHub Pages - GitHub Docs
    - Wybrana gałąź gh-pages i folder /docs

### Plakietka Aktualizuj obraz strony głównej

Aby dostosować obraz strony głównej do plakietki Stan: Podgląd publiczny Wykonuję następujące czynności:

1. Sklonuj repozytorium svg-badges

    ```bash
    git clone https://github.com/anouarhassine/svg-badges.git
    cd svg-badges   
    ```

1. Instalowanie modułów

    ```bash
    npm install
    ```

1. Uruchom serwer WWW, aby wygenerować odznaki

    ```bash
    npm run start
    ```

1. Wygeneruj plakietkę

    ```link
    http://localhost:9000/static/Status-Public%20Preview-Green
    ```

1. Pobierz plakietkę svg

1. Użyj inkscape do edycji istniejącego svg i zapisywania wyników

1. Prześlij nowy obraz do folderu static\images\illustrations

1. Zmienianie obrazu elementu głównego config.yaml

    ```yml
    params:
        hero:
            image: illustrations/worker-public-preview.svg 
    ```

## Pytanie i odpowiedź

### **Pytanie** Dlaczego wybrano Hugo?

[Hugo](https://gohugo.io/) to popularny generator stron statycznych, który umożliwia zawartość {{<product-name>}} dokumentacja startowa do przekształcenia na statyczny kod HTML, który może być hostowany w GitHub Pages

### **Pytanie** Dlaczego nie wybrałeś innego statycznego generatora witryn?

Główny zespół Power CAT miał wcześniejsze doświadczenie w korzystaniu z Hugo

### **Pytanie** Dlaczego Microsoft Forms nie został użyty do obsługi pytań?

Jednym z celów projektowych było zintegrowanie procesu zadawania pytań bezpośrednio z treścią.

### **Pytanie** Dlaczego strony GitHub hostują zawartość?

Kod źródłowy {{<product-name>}} już istnieje na GitHub, a natywna obsługa stron GitHub była jednym z wyborów miejsca hostowania zawartości.

### **Pytanie** Dlaczego ta treść nie jest włączona [http://learn.microsoft.com]()?

- W miarę dojrzewania treści do wskazówek wielokrotnego użytku może zostać przeniesiona do [https://learn.microsoft.com]()

- Kluczowy cel projektowy jest możliwy dzięki hostingowi GitHubA key design goal are enabled by GitHub hosting

   - Zezwalaj na aktywny wkład społeczności
   
   - Wspieranie procesu Nuture w Centrum Doskonałości, aby dokumentacja mogła być ponownie wykorzystywana przez Klientów i społeczność Partnerów

### **Pytanie** Dlaczego podejście to nie jest stosowane w innych projektach Power CAT?

Na {{<product-name>}} eksperymentuje z tym kanałem dokumentacji, aby uzupełnić i połączyć się z naszym istniejącym [Treści szkoleniowe](https://aka.ms/automation-kit-learn). Na podstawie informacji zwrotnych i wyników tego eksperymentu ocenimy, czy inne projekty zarządzane przez Power CAT przyjmą podobne podejście.

### **Pytanie** Jak wyświetlić problemy z otwartą dokumentacją?

Możesz odwiedzić nasze [Problemy z otwartą dokumentacją](https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Adocumentation) strona

### **Pytanie** Jak zgłosić prośbę o nową funkcję dokumentacji?

Utwórz nowy [Prośba o funkcję](https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement,automation-kit%2Cdocumentation&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE)
