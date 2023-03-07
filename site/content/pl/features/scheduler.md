---
title: "Harmonogram"
description: "Automation Kit - Scheduler"
sidebar: false
sidebarlogo: fresh-white
include_footer: true
author: Grant-Archibald-MS
tags: ['Schedule', 'Automation', 'Features']
generated: B97833AB30777C813B3E62592D32D7E5B882ACEE
---

{{<toc>}}

## Wprowadzenie

Harmonogram zestawu Automation Kit umożliwia wyświetlanie harmonogramu cyklicznych przepływów Power Automate Cloud wewnątrz rozwiązań, które obejmują wywołania przepływów programu Power Automate Desktop.

Ta funkcja została zaktualizowana w ramach [marzec 2023](/pl/releases/march-2023), Późniejsze wersje będą nadal ulepszać i rozwijać funkcjonalność harmonogramu.

{{<border>}}
![Harmonogram](/images/schedule.png)
{{</border>}}

Kluczowe funkcje harmonogramu to:

- Możliwość przeglądania harmonogramu cyklicznych przepływów w chmurze
- Harmonogram filtrowania według maszyny i grup maszyn
- Uruchamianie przepływu programu Power Automate Desktop
- Wyświetlanie harmonogramu według widoku Dzień, Tydzień, Miesiąc i Harmonogram
- Wyświetlanie stanu zaplanowanych przepływów (Powodzenie, Niepowodzenie lub Zaplanowane)
- Wyświetlanie czasu trwania uruchomienia usługi Cloud Flow
- Wyświetl szczegóły wszelkich błędów.

## Przebieg przepływu

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

## Notatki

W przypadku bieżącej wersji obowiązują następujące uwagi

1. Wyświetlane są tylko rozwiązania Power Automate Desktop i Power Automate zawarte w rozwiązaniu
1. Co najmniej jeden program Power Automate Desktop został zarejestrowany i wykonany

## Instalować

Aby zainstalować rozwiązanie harmonogramu, możesz wykonać następujące czynności:

1. Zapewnianie struktury składników Power Apps <a href="https://learn.microsoft.com/en-us/power-apps/developer/component-framework/component-framework-for-canvas-apps#enable-the-power-apps-component-framework-feature" target="_blank">Czytaj całość</a>
1. Zestaw twórców został zainstalowany w środowisku docelowym. <a href="https://appsource.microsoft.com/en-us/product/dynamics-365/microsoftpowercatarch.creatorkit1" target="_blank">Instalowanie ze źródła aplikacjiInstall from App Source</a>
1. Plik AutomationKit.zip został pobrany z sekcji Zasoby najnowszej wersji <a href="https://github.com/microsoft/powercat-automation-kit/releases" target="_blank">Wydanie usługi GitHub</a>
1. Zaimportowano najnowszą wersję AutomationKitScheduler_*_zarządzane.zip plik za pomocą. <a href='https://learn.microsoft.com/en-us/power-apps/maker/data-platform/import-update-export-solutions' target="_blank">Czytaj całość</a>

## Mapa drogowa

Możesz odwiedzić nasze <a href="https://github.com/microsoft/powercat-automation-kit/issues?q=is%3Aissue+is%3Aopen+label%3Ascheduler" target="_blank">Problemy z usługą GitHub</a> , aby wyświetlić proponowane nowe funkcje.

Możesz dodać nowy <a href="https://github.com/microsoft/powercat-automation-kit/issues/new?assignees=&labels=automation-kit%2Cenhancement%2Cscheduler&template=2-automation-kit-feature.yml&title=%5BAutomation+Kit+-+Feature%5D%3A+FEATURE+TITLE" target="_blank">Żądanie funkcji harmonogramu</a>

## Sprzężenie zwrotne

{{<questions name="/content/pl/features/scheduler.json" completed="Dziękujemy za przekazanie opinii" showNavigationButtons="false" locale="pl">}}
