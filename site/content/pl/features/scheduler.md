---
title: "Harmonogram"
description: "Automation Kit - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: 3191EC35273FDF75E031467EB6C5BF37F2883B67
---

{{<toc>}}

## Wprowadzenie

Strona Harmonogram usługi Automation Kit Automation Center umożliwia wyświetlenie harmonogramu cyklicznych przepływów usługi Power Automate Cloud w ramach rozwiązań, które zawierają wywołania przepływów programu Power Automate Desktop.The Automation Kit Automation Center Scheduler page allows you to view schedule of recurring Power Automate Cloud flows inside Solutions that include calls to Power Automate Desktop flows.

Ta funkcja została zaktualizowana w ramach [czerwiec 2023 r.](/pl/releases/june-2023)

{{<border>}}
![Harmonogram](/images/schedule.png)
{{</border>}}

Kluczowe funkcje harmonogramu to:

- Możliwość przeglądania harmonogramu cyklicznych przepływów w chmurze
- Harmonogram filtrowania według maszyn i grup maszyn oraz stanu
- Otwórz widok siatki przebiegów przepływu pulpitu
- Uruchamianie przepływu programu Power Automate Desktop
- Wyświetlanie harmonogramu według widoku Dzień, Tydzień, Miesiąc i Harmonogram
- Wyświetlanie stanu zaplanowanych przepływów (Powodzenie, Niepowodzenie lub Zaplanowane)
- Wyświetlanie czasu trwania uruchomienia usługi Cloud Flow
- Wyświetl szczegóły wszelkich błędów.

## Przepływy w chmurze

Jak wspomniano powyżej, tylko przepływy chmury, które są uwzględnione jako część rozwiązania. Najnowsze [https://powerautomate.microsoft.com/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/](https://powerautomate.microsoft.com/vi-vn/blog/more-manageable-cloud-flows-with-dataverse-solutions-by-default/) zawiera informacje o tym, jak używać nowej wersji zapoznawczej "Domyślne rozwiązania Dataverse", aby upewnić się, że przepływy w chmurze są uwzględniane w rozwiązaniach. Korzystanie z tej funkcji może pomóc użytkownikom w zapewnieniu, że zaplanowane przepływy chmury, które są tworzone, są widoczne w harmonogramie.

## Widoki kalendarza

## Widoki dnia, tygodnia, miesiąca

Widoki dnia, tygodnia i miesiąca wyświetlają informacje o przebiegach przepływu Desktop Cloud, które zostały wykonane lub są zaplanowane do wykonania.

Elementy są oznaczone kolorami w następujący sposób:

- Zielony oznacza udany bieg

- Czerwony oznacza nieudane uruchomienie

- Kolor niebieski oznacza zaplanowany przyszły przebieg.

Informacje o stanie i przebiegu są dostępne po długim dotknięciu lub najechaniu myszą na wydarzenie.

### Harmonogram

{{<border>}}
![Harmonogram — widok harmonogramu](/images/scheduler-schedule-view.png)
{{</border>}}

Widok harmonogramu zawiera zestaw przepływów w chmurze opartych na czasie od bieżącego czasu i przyszłych zaplanowanych przepływach w ciągu następnych dni.

## Uruchom teraz

{{<border>}}
![Harmonogram — Uruchom teraz](/images/scheduler-run-now.png?v=1)
{{</border>}}

Bieżąca wersja polecenia Uruchom teraz spowoduje wykonanie pulpitu usługi Power Automate. Zakłada się, że nie ma żadnych parametrów wymaganych do wykonania przepływu pulpitu. Dodatkowe informacje o uruchomieniu są dostępne w informacjach o ostatnim uruchomieniu pulpitu.

## Otwórz widok siatki

{{<border>}}
![Harmonogram — widok otwartej siatki](/images/scheduler-open-grid-view.png)
{{</border>}}

Użytkownicy mogą przechodzić do strony uruchamiania przepływów pulpitu w usłudze Power Automate z naszej strony głównej Centrum sterowania
Zrzut ekranu przedstawiający nowy przycisk "Otwórz widok siatki" na stronie głównej, aby przejść do strony przepływów pulpitu w portalu Power Automate.

### Zachowanie zaplanowanych przepływów tylko do odczytu

Domyślnie, gdy przepływ jest zaplanowany do wykonania w przyszłości, jest on ustawiony na tryb tylko do odczytu i wyłączony do natychmiastowego wykonania. Oznacza to, że użytkownicy nie mogą modyfikować ani wykonywać przepływu, dopóki nie minie zaplanowana data i godzina. To zachowanie ma na celu zapewnienie lepszego środowiska użytkownika i zapobieganie przypadkowemu wykonaniu przepływów przed ich planowanym uruchomieniem.
Takie podejście ma kilka zalet, w tym:

- Zapobieganie przypadkowemu wykonaniu: Wyłączając natychmiastowe wykonywanie przepływów, które są zaplanowane do wykonania w przyszłości, użytkownicy są mniej narażeni na przypadkowe uruchomienie przepływu przed jego planowanym uruchomieniem.

- Zwiększona przewidywalność: Ustawiając przepływy na tryb tylko do odczytu, gdy są zaplanowane do wykonania w przyszłości, użytkownicy mogą łatwiej przewidzieć, kiedy przepływy zostaną uruchomione, i upewnić się, że mają przygotowane niezbędne dane wejściowe i zasoby.

- Spójne środowisko użytkownika: Standaryzacja zachowania zaplanowanych przepływów może zapewnić spójne i przewidywalne środowisko użytkownika we wszystkich wystąpieniach przepływu.

- Aby zmodyfikować lub wykonać zaplanowany przepływ, użytkownicy mogą edytować przepływ i aktualizować zaplanowaną datę i godzinę. Po ustawieniu nowego harmonogramu przepływ zostanie ponownie wyłączony do natychmiastowego wykonania i ustawiony w trybie tylko do odczytu do momentu przejścia nowego harmonogramu.

## Komunikaty o błędach

Możliwe komunikaty o błędach, które mogą wystąpić podczas wykonywania przepływu uruchamiania.

### Komunikat o błędzie: "InvalidArgument — nie można znaleźć prawidłowego połączenia skojarzonego z podanym odwołaniem do połączenia."

#### Opis

Ten komunikat o błędzie zazwyczaj wskazuje, że występuje problem z odwołaniem do połączenia podanym w kodzie lub konfiguracji. System nie może zlokalizować prawidłowego połączenia skojarzonego z odwołaniem, co uniemożliwia wykonanie żądanej akcji.

#### Powoduje

Istnieje kilka potencjalnych przyczyn tego komunikatu o błędzie, w tym:

- Nieprawidłowe lub nieprawidłowe odwołanie do połączenia: Podane odwołanie do połączenia może być nieprawidłowe lub niepoprawne, co może spowodować, że system nie zlokalizuje prawidłowego połączenia skojarzonego z nim.

- Połączenie usunięte lub zmienione: Jeśli połączenie użyte w kodzie lub konfiguracji zostało usunięte lub zmodyfikowane, może to spowodować, że system nie zlokalizuje prawidłowego połączenia skojarzonego z odwołaniem.

- Problem z uprawnieniami: konto użytkownika wykonujące kod lub konfigurację może nie mieć uprawnień niezbędnych do uzyskania dostępu do połączenia lub skojarzonych z nim zasobów.

#### Rezolucja

Aby rozwiązać ten problem, można wykonać następujące czynności:

- Sprawdź odwołanie do połączenia: Sprawdź odwołanie do połączenia podane w kodzie lub konfiguracji i upewnij się, że jest prawidłowe i poprawne.

- Usuń istniejące połączenia i odtwórz: Jeśli narzędzie Flow Checker ostrzega, że odwołanie do połączenia nie zostało użyte, możesz użyć narzędzia Flow Checker, aby usunąć istniejące połączenia. Po usunięciu połączeń można ponownie utworzyć odwołania do połączenia z komputerem lub grupą komputerów, aby umożliwić uruchomienie przepływu.

## Notatki

W przypadku bieżącej wersji obowiązują następujące uwagi

1. Wyświetlane są tylko rozwiązania Power Automate Desktop i Power Automate zawarte w rozwiązaniu
1. Co najmniej jeden program Power Automate Desktop został zarejestrowany i wykonany

## Instalować

Aby zainstalować Centrum sterowania, można wykonać następujące czynności:

1. Upewnij się, że struktura składników Power Apps jest włączona <a href="https://learn.microsoft.com/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Czytaj całość</a>
1. Zestaw twórców został zainstalowany w środowisku docelowym. <a href="https://appsource.microsoft.com/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Instalowanie ze źródła aplikacjiInstall from App Source</a>
1. Zaimportowano najnowszą wersję AutomationKitControlCenter_*_zarządzane.zip plik za pomocą. <a href='https://learn.microsoft.com/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Czytaj całość</a>

## Mapa drogowa

Możesz odwiedzić nasze <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">Problemy z usługą GitHub</a> , aby wyświetlić proponowane nowe funkcje.

Możesz dodać nowy <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Żądanie funkcji harmonogramu</a>

## Sprzężenie zwrotne

{{<questions name="/content/pl/features/scheduler.json" completed="Dziękujemy za przekazanie opinii" showNavigationButtons="false" locale="pl">}}
